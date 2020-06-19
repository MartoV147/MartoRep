namespace DnDProjectFrontEnd
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LogInBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.AdventurersBtn = new System.Windows.Forms.Button();
            this.MonstersBtn = new System.Windows.Forms.Button();
            this.FightsBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.AdventurerFightBtn = new System.Windows.Forms.Button();
            this.MonsterFightBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInBtn
            // 
            this.LogInBtn.Location = new System.Drawing.Point(13, 13);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.Size = new System.Drawing.Size(75, 23);
            this.LogInBtn.TabIndex = 0;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.UseVisualStyleBackColor = true;
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Location = new System.Drawing.Point(97, 13);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(75, 23);
            this.RegisterBtn.TabIndex = 1;
            this.RegisterBtn.Text = "Register";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // AdventurersBtn
            // 
            this.AdventurersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AdventurersBtn.Location = new System.Drawing.Point(12, 42);
            this.AdventurersBtn.Name = "AdventurersBtn";
            this.AdventurersBtn.Size = new System.Drawing.Size(160, 61);
            this.AdventurersBtn.TabIndex = 2;
            this.AdventurersBtn.Text = "Adventurers";
            this.AdventurersBtn.UseVisualStyleBackColor = true;
            this.AdventurersBtn.Click += new System.EventHandler(this.AdventurersBtn_Click);
            // 
            // MonstersBtn
            // 
            this.MonstersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MonstersBtn.Location = new System.Drawing.Point(12, 109);
            this.MonstersBtn.Name = "MonstersBtn";
            this.MonstersBtn.Size = new System.Drawing.Size(160, 61);
            this.MonstersBtn.TabIndex = 3;
            this.MonstersBtn.Text = "Monsters";
            this.MonstersBtn.UseVisualStyleBackColor = true;
            this.MonstersBtn.Click += new System.EventHandler(this.MonstersBtn_Click);
            // 
            // FightsBtn
            // 
            this.FightsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FightsBtn.Location = new System.Drawing.Point(12, 176);
            this.FightsBtn.Name = "FightsBtn";
            this.FightsBtn.Size = new System.Drawing.Size(160, 61);
            this.FightsBtn.TabIndex = 4;
            this.FightsBtn.Text = "Fights";
            this.FightsBtn.UseVisualStyleBackColor = true;
            this.FightsBtn.Click += new System.EventHandler(this.FightsBtn_Click);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(53, 13);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogoutBtn.TabIndex = 5;
            this.LogoutBtn.Text = "Log Out";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Visible = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // AdventurerFightBtn
            // 
            this.AdventurerFightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AdventurerFightBtn.Location = new System.Drawing.Point(12, 243);
            this.AdventurerFightBtn.Name = "AdventurerFightBtn";
            this.AdventurerFightBtn.Size = new System.Drawing.Size(160, 61);
            this.AdventurerFightBtn.TabIndex = 6;
            this.AdventurerFightBtn.Text = "Send Adventurers to Fight";
            this.AdventurerFightBtn.UseVisualStyleBackColor = true;
            this.AdventurerFightBtn.Click += new System.EventHandler(this.AdventurerFightBtn_Click);
            // 
            // MonsterFightBtn
            // 
            this.MonsterFightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MonsterFightBtn.Location = new System.Drawing.Point(12, 310);
            this.MonsterFightBtn.Name = "MonsterFightBtn";
            this.MonsterFightBtn.Size = new System.Drawing.Size(160, 61);
            this.MonsterFightBtn.TabIndex = 7;
            this.MonsterFightBtn.Text = "Send Monsters to Fight";
            this.MonsterFightBtn.UseVisualStyleBackColor = true;
            this.MonsterFightBtn.Click += new System.EventHandler(this.MonsterFightBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 383);
            this.Controls.Add(this.MonsterFightBtn);
            this.Controls.Add(this.AdventurerFightBtn);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.FightsBtn);
            this.Controls.Add(this.MonstersBtn);
            this.Controls.Add(this.AdventurersBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.LogInBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LogInBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button AdventurersBtn;
        private System.Windows.Forms.Button MonstersBtn;
        private System.Windows.Forms.Button FightsBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button AdventurerFightBtn;
        private System.Windows.Forms.Button MonsterFightBtn;
    }
}

