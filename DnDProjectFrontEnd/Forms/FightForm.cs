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
    public partial class FightForm : Form
    {
        public FightForm()
        {
            InitializeComponent();
            PopulateTable();
        }

        public void PopulateTable()
        {
            Table.Rows.Clear();
            var response = MainForm.client.GetStringAsync("fights").Result;
            var data = JsonConvert.DeserializeObject<List<Fight>>(response);
            for (int i = 0; i < data.Count(); i++)
            {
                DataGridViewRow row = (DataGridViewRow)Table.Rows[0].Clone();
                row.Cells[0].Value = data.ElementAt(i).FightId;
                row.Cells[1].Value = data.ElementAt(i).Terrain;
                row.Cells[2].Value = data.ElementAt(i).PriceWon;
                row.Cells[3].Value = data.ElementAt(i).ExpPoints;
                row.Cells[4].Value = data.ElementAt(i).CreatedOn;
                row.Cells[5].Value = data.ElementAt(i).UpdatedOn;
                Table.Rows.Add(row);
            }
        }

        public Fight GetFightFromSpecs(bool flag)
        {
            Fight f = null;
            try
            {
                f = new Fight()
                {
                    Terrain = FightTerrainTBox.Text,
                    PriceWon = double.Parse(PriceWonTBox.Text),
                    ExpPoints = int.Parse(ExpPointsTBox.Text),
                    CreatedOn = DateTime.UtcNow
                };
                if (flag)
                {
                    f.FightId = int.Parse(FightIdTBox.Text);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insert Valid Information :(");
            }
            return f;
        }


        private void Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowId = Table.CurrentCell.RowIndex;
            if (rowId == Table.Rows.Count - 1)
            {
                return;
            }
            FightIdTBox.Text = Table.Rows[rowId].Cells[0].Value.ToString();
            FightTerrainTBox.Text = Table.Rows[rowId].Cells[1].Value.ToString();
            PriceWonTBox.Text = Table.Rows[rowId].Cells[2].Value.ToString();
            ExpPointsTBox.Text = Table.Rows[rowId].Cells[3].Value.ToString();
        }

        private void AddFightBtn_Click(object sender, EventArgs e)
        {
            Fight f = GetFightFromSpecs(false);

            if (f != null && f.Terrain.Length <= 200)
            {
                MainForm.client.PostAsJsonAsync("https://localhost:5001/api/fights", f);
            }
            Thread.Sleep(80);
            PopulateTable();
        }

        private void UpdateFightBtn_Click(object sender, EventArgs e)
        {
            Fight f = GetFightFromSpecs(true);
            if (f != null && f.Terrain.Length <= 200)
            {
                f.UpdatedOn = DateTime.UtcNow;
                MainForm.client.PutAsJsonAsync("https://localhost:5001/api/fights/" + f.FightId, f);
            }
            Thread.Sleep(80);
            PopulateTable();
        }

        private void DeleteFightBtn_Click(object sender, EventArgs e)
        {
            Fight f = GetFightFromSpecs(true);

            if (f != null)
            {
                MainForm.client.DeleteAsync("https://localhost:5001/api/fights/" + f.FightId);
            }
            Thread.Sleep(80);
            PopulateTable();
        }

        private void FindFightBtn_Click(object sender, EventArgs e)
        {
            int fightId = int.Parse(FindFightTBox.Text);
            var response = MainForm.client.GetStringAsync("fights/" + fightId).Result;
            var data = JsonConvert.DeserializeObject<Fight>(response);

            DataGridViewRow row = (DataGridViewRow)Table.Rows[0].Clone();
            Table.Rows.Clear();
            row.Cells[0].Value = data.FightId;
            row.Cells[1].Value = data.Terrain;
            row.Cells[2].Value = data.PriceWon;
            row.Cells[3].Value = data.ExpPoints;
            row.Cells[4].Value = data.CreatedOn;
            row.Cells[5].Value = data.UpdatedOn;
            Table.Rows.Add(row);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            PopulateTable();
            FindFightTBox.Text = "";
        }
    }
}