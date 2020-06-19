using DnDLibraly.Models;
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
    public partial class MonsterForm : Form
    {
        public MonsterForm()
        {
            InitializeComponent();
            PopulateTable();
        }

        public void PopulateTable()
        {
            Table.Rows.Clear();
            var response = MainForm.client.GetStringAsync("monsters").Result;
            var data = JsonConvert.DeserializeObject<List<Monster>>(response);
            for (int i = 0; i < data.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)Table.Rows[0].Clone();
                row.Cells[0].Value = data.ElementAt(i).Name;
                row.Cells[1].Value = data.ElementAt(i).HealthPoints;
                row.Cells[2].Value = data.ElementAt(i).AttackPoints;
                row.Cells[3].Value = data.ElementAt(i).DefensePoints;
                row.Cells[4].Value = data.ElementAt(i).ExPoints;
                row.Cells[5].Value = data.ElementAt(i).CreatedOn;
                row.Cells[6].Value = data.ElementAt(i).UpdatedOn;
                row.Cells[7].Value = data.ElementAt(i).MonsterId;
                Table.Rows.Add(row);
            }
        }

        public void ClearTBoxes()
        {
            MonsterNameTBox.Text = "";
            MonsterHPTBox.Text = "";
            MonsterAPTBox.Text = "";
            MonsterDPTBox.Text = "";
            ExPTBox.Text = "";
        }

        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowId = Table.CurrentCell.RowIndex;
            if (rowId == Table.Rows.Count - 1)
            {
                return;
            }
            MonsterNameTBox.Text = Table.Rows[rowId].Cells[0].Value.ToString();
            MonsterHPTBox.Text = Table.Rows[rowId].Cells[1].Value.ToString();
            MonsterAPTBox.Text = Table.Rows[rowId].Cells[2].Value.ToString();
            MonsterDPTBox.Text = Table.Rows[rowId].Cells[3].Value.ToString();
            ExPTBox.Text = Table.Rows[rowId].Cells[4].Value.ToString();
            IdTBox.Text = Table.Rows[rowId].Cells[7].Value.ToString();
        }

        private void FindMonsterBtn_Click(object sender, EventArgs e)
        {
            var response = MainForm.client.GetStringAsync("monsters?name=" + FindMonsterTBox.Text).Result;
            var data = JsonConvert.DeserializeObject<List<Monster>>(response).FirstOrDefault();

            DataGridViewRow row = (DataGridViewRow)Table.Rows[0].Clone();
            Table.Rows.Clear();
            row.Cells[0].Value = data.Name;
            row.Cells[1].Value = data.HealthPoints;
            row.Cells[2].Value = data.AttackPoints;
            row.Cells[3].Value = data.DefensePoints;
            row.Cells[4].Value = data.ExPoints;
            row.Cells[5].Value = data.CreatedOn;
            row.Cells[6].Value = data.UpdatedOn;
            row.Cells[7].Value = data.MonsterId;
            Table.Rows.Add(row);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            PopulateTable();
            FindMonsterTBox.Text = "";
        }

        public Monster GetMonsterFromSpecs(bool flag)
        {
            Monster m = null;
            try
            {
                m = new Monster()
                {
                    Name = MonsterNameTBox.Text,
                    HealthPoints = double.Parse(MonsterHPTBox.Text),
                    AttackPoints = double.Parse(MonsterAPTBox.Text),
                    DefensePoints = double.Parse(MonsterDPTBox.Text),
                    ExPoints = int.Parse(ExPTBox.Text),
                    CreatedOn = DateTime.UtcNow
                };
                if (flag)
                {
                    m.MonsterId = int.Parse(IdTBox.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Valid Information :(");
            }
            return m;
        }

        private void AddMonsterBtn_Click(object sender, EventArgs e)
        {
            Monster m = GetMonsterFromSpecs(false);

            if (m != null && m.Name.Length <= 200)
            {
                MainForm.client.PostAsJsonAsync("https://localhost:5001/api/monsters", m);
            }
            Thread.Sleep(80);
            PopulateTable();
        }

        private void DeleteMonsterBtn_Click(object sender, EventArgs e)
        {
            Monster m = GetMonsterFromSpecs(true);

            if (m != null)
            {
                MainForm.client.DeleteAsync("https://localhost:5001/api/monsters/" + m.MonsterId);
            }
            Thread.Sleep(80);
            PopulateTable();
        }

        private void UpdateMonsterBtn_Click(object sender, EventArgs e)
        {
            Monster m = GetMonsterFromSpecs(true);
            if (m != null && m.Name.Length <= 200)
            {
                m.UpdatedOn = DateTime.UtcNow;
                MainForm.client.PutAsJsonAsync("https://localhost:5001/api/monsters/" + m.MonsterId, m);
            }
            Thread.Sleep(80);
            PopulateTable();
        }
    }
}
