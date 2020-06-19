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
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDProjectFrontEnd.Forms
{
    public partial class MonsterFightForm : Form
    {
        public void PopulateCBox1(ComboBox cBox)
        {
            var response = MainForm.client.GetStringAsync("monsters").Result;
            var data = JsonConvert.DeserializeObject<List<Monster>>(response);

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
            var response = MainForm.client.GetStringAsync("monsterfight").Result;
            var data = JsonConvert.DeserializeObject<List<MonsterFight>>(response);
            for (int i = 0; i < data.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)Table.Rows[0].Clone();
                row.Cells[0].Value = data.ElementAt(i).MonsterId;
                row.Cells[1].Value = data.ElementAt(i).FightId;
                Table.Rows.Add(row);
            }
        }

        public MonsterFight GetMonsterFightFromSpecs()
        {
            MonsterFight mf = null;

            var response = MainForm.client.GetStringAsync("monsters?name=" + MonsterCBox.Text).Result;
            var monster = JsonConvert.DeserializeObject<List<Monster>>(response).FirstOrDefault();

            mf = new MonsterFight()
            {
                FightId = int.Parse(FightCBox.Text),
                MonsterId = monster.MonsterId
            };
            return mf;

        }

        public MonsterFightForm()
        {
            InitializeComponent();
            PopulateCBox1(MonsterCBox);
            PopulateCBox2(FightCBox);
            PopulateTable();
        }

        private void AddMonsterBtn_Click(object sender, EventArgs e)
        {
            var response = MainForm.client.GetStringAsync("monsters?name=" + MonsterCBox.Text).Result;
            var monster = JsonConvert.DeserializeObject<List<Monster>>(response).FirstOrDefault();

            int test = int.Parse(FightCBox.Text);

            var response1 = MainForm.client.GetStringAsync("fights/" + test).Result;
            var fight = JsonConvert.DeserializeObject<Fight>(response1);

            MonsterFight m = new MonsterFight
            {
                MonsterId = monster.MonsterId,
                FightId = fight.FightId,
                Monster = monster,
                Fight = fight
            };

            MainForm.client.PostAsJsonAsync("https://localhost:5001/api/monsterfight", m);
            Thread.Sleep(80);
            PopulateTable();
        }

        private void DeleteMonsterBtn_Click(object sender, EventArgs e)
        {
            MonsterFight mf = GetMonsterFightFromSpecs();
            if (mf != null)
            {
                MainForm.client.DeleteAsync("https://localhost:5001/api/monsterfight/" + mf.MonsterId + "/" + mf.FightId);
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

            var response = MainForm.client.GetStringAsync("monsters/" + Table.Rows[rowId].Cells[0].Value.ToString()).Result;
            var data = JsonConvert.DeserializeObject<Monster>(response);

            MonsterCBox.Text = data.Name;
            FightCBox.Text = Table.Rows[rowId].Cells[1].Value.ToString();

        }
    }
}
