using DnDLibraly.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDProjectFrontEnd.Forms
{
    public partial class LoginForm : Form
    {
        MainForm mForm;
        public LoginForm(MainForm mForm)
        {
            InitializeComponent();
            this.mForm = mForm;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            MainForm.LoggedUserToken = null;

            var response1 = MainForm.client.GetStringAsync("users?username="+ UsernameTBox.Text + "&password=" + PasswordTBox.Text).Result;
            var data = JsonConvert.DeserializeObject<List<User>>(response1).FirstOrDefault();

            if (data == null)
            {
                MessageBox.Show("Invalid Username or Password");
                UsernameTBox.Text = "";
                PasswordTBox.Text = "";
                return;
            }
            else
            {
                var json = JsonConvert.SerializeObject(data);
                var dataRequest = new StringContent(json, Encoding.UTF8, "application/json");

                var response = MainForm.client.PostAsync("login", dataRequest);

                var stream = response.Result.Content;

                MainForm.LoggedUserToken = stream.ReadAsStringAsync().Result;

                if (!string.IsNullOrEmpty(MainForm.LoggedUserToken))
                {
                    MainForm.client.DefaultRequestHeaders.
                        Add("Authorization", String.Format("Bearer {0}", MainForm.LoggedUserToken));

                }

                Dispose();
                mForm.ShowHideBtns(false);
            }
        }
    }
}
