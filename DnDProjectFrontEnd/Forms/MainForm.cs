using DnDLibraly.Models;
using DnDProjectFrontEnd.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDProjectFrontEnd
{
    public partial class MainForm : Form
    {
        public static HttpClient client = new HttpClient();
        public AdventurerForm aform;
        public MonsterForm mform;
        public FightForm fform;
        public RegisterForm rform;
        public LoginForm lform;
        public AdventurerFightForm afform;
        public MonsterFightForm mfform;

        public static string LoggedUserToken;

        public void ShowHideBtns(bool flag)
        {
            LogInBtn.Visible = flag;
            RegisterBtn.Visible = flag;
            LogoutBtn.Visible = !flag;
        }

        public void CloseAllWindows()
        {
            if (lform != null)
            {
                lform.Dispose();
            }
            if (rform != null)
            {
                rform.Dispose();
            }
            if (mform != null)
            {
                mform.Dispose();
            }
            if (fform != null)
            {
                fform.Dispose();
            }
            if (aform != null)
            {
                aform.Dispose();
            }
            if (afform != null)
            {
                afform.Dispose();
            }
            if (mfform != null)
            {
                mfform.Dispose();
            }
        }


        public MainForm()
        {
            InitializeComponent(); 
            client.BaseAddress = new Uri("https://localhost:5001/api/");
        }
        private void LogInBtn_Click(object sender, EventArgs e)
        {
            CloseAllWindows();
            lform = new LoginForm(this);
            lform.Visible = true;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            CloseAllWindows();
            rform = new RegisterForm();
            rform.Visible = true;
        }

        private void AdventurersBtn_Click(object sender, EventArgs e)
        {
            CloseAllWindows();
            if (LoggedUserToken != null)
            {
                aform = new AdventurerForm();
                aform.Visible = true;
            } 
        }

        private void MonstersBtn_Click(object sender, EventArgs e)
        {
            CloseAllWindows();
            if (LoggedUserToken != null)
            {
                mform = new MonsterForm();
                mform.Visible = true;
            }
        }

        private void FightsBtn_Click(object sender, EventArgs e)
        {
            CloseAllWindows();
            if (LoggedUserToken != null)
            {
                fform = new FightForm();
                fform.Visible = true;
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            ShowHideBtns(true);
            LoggedUserToken = null;
            client.DefaultRequestHeaders.Clear();
        }

        private void AdventurerFightBtn_Click(object sender, EventArgs e)
        {
            CloseAllWindows();
            if (LoggedUserToken != null)
            {
                afform = new AdventurerFightForm();
                afform.Visible = true;
            }            
        }

        private void MonsterFightBtn_Click(object sender, EventArgs e)
        {
            CloseAllWindows();
            if (LoggedUserToken != null)
            {
                mfform = new MonsterFightForm();
                mfform.Visible = true;
            }
        }
    }
}
