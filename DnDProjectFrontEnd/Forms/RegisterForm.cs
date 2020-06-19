using DnDLibraly.Models;
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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        public void ClearTBoxes()
        {
            FNameTBox.Text = "";
            LNAmeTBox.Text = "";
            AgeTBox.Text = "";
            UsernameTBox.Text = "";
            PasswordTBox.Text = "";
            EmailTBox.Text = "";
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            int age = 0;
            try
            {
                age = int.Parse(AgeTBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Age Must be a Number");
                ClearTBoxes();
            }

            User user = new User()
            {   
                FName = FNameTBox.Text,
                LName = LNAmeTBox.Text,
                Age = age,
                Username = UsernameTBox.Text,
                Password = PasswordTBox.Text,
                Email = EmailTBox.Text
            };

            if (user != null)
            {
                MainForm.client.PostAsJsonAsync("https://localhost:5001/api/users", user);
            }
            ClearTBoxes();
            Dispose();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
