using DnDLibraly.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDProjectFrontEnd.Forms
{
    public partial class AdventurerForm : Form
    {
        public AdventurerForm()
        {
            InitializeComponent();
            PopulateTable();
        }

        public void PopulateTable()
        {
            Table.Rows.Clear();
            var response = MainForm.client.GetStringAsync("adventurers").Result;
            var data = JsonConvert.DeserializeObject<List<Adventurer>>(response);
            for (int i = 0; i < data.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)Table.Rows[0].Clone();
                row.Cells[0].Value = data.ElementAt(i).Name;
                row.Cells[1].Value = data.ElementAt(i).Level;
                row.Cells[2].Value = data.ElementAt(i).HealthPoints;
                row.Cells[3].Value = data.ElementAt(i).ManaPoints;
                row.Cells[4].Value = data.ElementAt(i).AttackPoints;
                row.Cells[5].Value = data.ElementAt(i).DefensePoints;
                row.Cells[6].Value = data.ElementAt(i).CreatedOn;
                row.Cells[7].Value = data.ElementAt(i).UpdatedOn;
                row.Cells[8].Value = data.ElementAt(i).AdventurerId;
                Table.Rows.Add(row);
            }
        }

        public void ClearTBoxes()
        {
            AdventurerNameTBox.Text = "";
            AdventurerLevelTBox.Text = "";
            AdventurerHPTBox.Text = "";
            AdventurerMPTBox.Text = "";
            AdventurerAPTBox.Text = "";
            AdventurerDPTBox.Text = "";
        }

        private void AdventurerTable_SelectionChanged(object sender, EventArgs e)
        {
            int rowId = Table.CurrentCell.RowIndex;
            if (rowId == Table.Rows.Count - 1)
            {
                return;
            }
            AdventurerNameTBox.Text = Table.Rows[rowId].Cells[0].Value.ToString();
            AdventurerLevelTBox.Text = Table.Rows[rowId].Cells[1].Value.ToString();
            AdventurerHPTBox.Text = Table.Rows[rowId].Cells[2].Value.ToString();
            AdventurerMPTBox.Text = Table.Rows[rowId].Cells[3].Value.ToString();
            AdventurerAPTBox.Text = Table.Rows[rowId].Cells[4].Value.ToString();
            AdventurerDPTBox.Text = Table.Rows[rowId].Cells[5].Value.ToString();
            IdTBox.Text = Table.Rows[rowId].Cells[8].Value.ToString();
        }

        private void FindAdventurerBtn_Click(object sender, EventArgs e)
        {
            var response = MainForm.client.GetStringAsync("adventurers?name=" + FindAdventurerTBox.Text).Result;
            var data = JsonConvert.DeserializeObject<List<Adventurer>>(response).FirstOrDefault();

            DataGridViewRow row = (DataGridViewRow)Table.Rows[0].Clone();
            Table.Rows.Clear();
            row.Cells[0].Value = data.Name;
            row.Cells[1].Value = data.Level;
            row.Cells[2].Value = data.HealthPoints;
            row.Cells[3].Value = data.ManaPoints;
            row.Cells[4].Value = data.AttackPoints;
            row.Cells[5].Value = data.DefensePoints;
            row.Cells[6].Value = data.CreatedOn;
            row.Cells[7].Value = data.UpdatedOn;
            row.Cells[8].Value = data.AdventurerId;
            Table.Rows.Add(row);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            PopulateTable();
            FindAdventurerTBox.Text = "";
        }

        public Adventurer GetAdventurerFromSpecs(bool flag)
        {
            Adventurer a = null;
            try
            {
                a = new Adventurer()
                { 
                    Name = AdventurerNameTBox.Text,
                    Level = int.Parse(AdventurerLevelTBox.Text),
                    HealthPoints = double.Parse(AdventurerHPTBox.Text),
                    ManaPoints = double.Parse(AdventurerMPTBox.Text),
                    AttackPoints = double.Parse(AdventurerAPTBox.Text),
                    DefensePoints = double.Parse(AdventurerDPTBox.Text),
                    CreatedOn = DateTime.UtcNow
                };
                if (flag)
                {
                    a.AdventurerId = int.Parse(IdTBox.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Valid Information :(");
            }
            return a;
        }

        private void AddAdventurerBtn_Click(object sender, EventArgs e)
        {
            Adventurer a = GetAdventurerFromSpecs(false);

            if (a != null && a.Name.Length <= 200)
            {
                MainForm.client.PostAsJsonAsync("https://localhost:5001/api/adventurers", a);
            }
            Thread.Sleep(80);
            PopulateTable();
        }


        private void DeleteAdventurerBtn_Click(object sender, EventArgs e)
        {
            Adventurer a = GetAdventurerFromSpecs(true);

            if (a != null)
            {
                MainForm.client.DeleteAsync("https://localhost:5001/api/adventurers/" + a.AdventurerId);
            }
            Thread.Sleep(80);
            PopulateTable();
        }

        private void UpdateAdventurerBtn_Click(object sender, EventArgs e)
        {
            Adventurer a = GetAdventurerFromSpecs(true);
            if (a != null && a.Name.Length <= 200)
            {
                a.UpdatedOn = DateTime.UtcNow;
                MainForm.client.PutAsJsonAsync("https://localhost:5001/api/adventurers/" + a.AdventurerId, a);
            }
            Thread.Sleep(80);
            PopulateTable();
        }
    }
}
