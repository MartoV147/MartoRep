using DnDLibraly.Models;
using DnDLibraly.Models.MIdWareTables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDProjectFrontEnd.Forms
{
    public partial class AdventurerFightForm : Form
    {
        public void PopulateCBox1(ComboBox cBox)
        {
            var response = MainForm.client.GetStringAsync("adventurers").Result;
            var data = JsonConvert.DeserializeObject<List<Adventurer>>(response);

            cBox.BindingContext = new BindingContext();
            cBox.DataSource = data;
            cBox.DisplayMember = "Name";
            cBox.ValueMember = "Name";
        }

        public void PopulateCBox2(ComboBox cBox)
        {
            var response = MainForm.client.GetStringAsync("fights").Result;
            var data = JsonConvert.DeserializeObject<List<Fight>>(response);

            cBox.BindingContext = new BindingContext();
            cBox.DataSource = data;
            cBox.DisplayMember = "FightId";
            cBox.ValueMember = "FightId";
        }

        public void PopulateTable()
        {
            Table.Rows.Clear();
            var response = MainForm.client.GetStringAsync("adventurerfights").Result;
            var data = JsonConvert.DeserializeObject<List<AdventurerFight>>(response);
            for (int i = 0; i < data.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)Table.Rows[0].Clone();
                row.Cells[0].Value = data.ElementAt(i).AdventurerId;
                row.Cells[1].Value = data.ElementAt(i).FightId;
                Table.Rows.Add(row);
            }
        }

        public AdventurerFight GetAdventurerFightFromSpecs()
        {
            AdventurerFight af = null;

            var response = MainForm.client.GetStringAsync("adventurers?name=" + AdventurerCBox.Text).Result;
            var adventurer = JsonConvert.DeserializeObject<List<Adventurer>>(response).FirstOrDefault();

            af = new AdventurerFight()
            {
                FightId = int.Parse(FightCBox.Text),
                AdventurerId = adventurer.AdventurerId
            };
            return af;
        }

        public AdventurerFightForm()
        {
            InitializeComponent();
            PopulateCBox1(AdventurerCBox);
            PopulateCBox2(FightCBox);
            PopulateTable();

        }

        private void AddAdventurerBtn_Click(object sender, EventArgs e)
        {
            var response = MainForm.client.GetStringAsync("adventurers?name=" + AdventurerCBox.Text).Result;
            var adventurer = JsonConvert.DeserializeObject<List<Adventurer>>(response).FirstOrDefault();

            int test = int.Parse(FightCBox.Text);

            var response1 = MainForm.client.GetStringAsync("fights/" + test).Result;
            var fight = JsonConvert.DeserializeObject<Fight>(response1);

            AdventurerFight a = new AdventurerFight
            {
                AdventurerId = adventurer.AdventurerId,
                FightId = fight.FightId,
                Adventurer = adventurer,
                Fight = fight
            };


            MainForm.client.PostAsJsonAsync("https://localhost:5001/api/adventurerfights", a);

            Thread.Sleep(80);
            PopulateTable();
        }

        private void DeleteAdventurerBtn_Click(object sender, EventArgs e)
        {
            AdventurerFight af = GetAdventurerFightFromSpecs();
            if (af != null)
            {
                MainForm.client.DeleteAsync("https://localhost:5001/api/adventurerfights/" + af.AdventurerId + "/" + af.FightId);
            }
            Thread.Sleep(80);
            PopulateTable();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            PopulateTable();
        }

        private void Table_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowId = Table.CurrentCell.RowIndex;
            if (rowId == Table.Rows.Count - 1)
            {
                return;
            }

            var response = MainForm.client.GetStringAsync("adventurers/" + Table.Rows[rowId].Cells[0].Value.ToString()).Result;
            var data = JsonConvert.DeserializeObject<Adventurer>(response);

            AdventurerCBox.Text = data.Name;
            FightCBox.Text = Table.Rows[rowId].Cells[1].Value.ToString();
        }
    }
}
