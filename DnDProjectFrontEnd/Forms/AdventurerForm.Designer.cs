namespace DnDProjectFrontEnd.Forms
{
    partial class AdventurerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdventurerForm));
            this.FindAdventurerBtn = new System.Windows.Forms.Button();
            this.FindAdventurerTBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteAdventurerBtn = new System.Windows.Forms.Button();
            this.UpdateAdventurerBtn = new System.Windows.Forms.Button();
            this.AddAdventurerBtn = new System.Windows.Forms.Button();
            this.AdventurerDPTBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AdventurerAPTBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AdventurerMPTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdventurerHPTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AdventurerLevelTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdventurerNameTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridView();
            this.AdventurerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HealthPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManaPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttackPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefensePoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.IdTBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // FindAdventurerBtn
            // 
            this.FindAdventurerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FindAdventurerBtn.Location = new System.Drawing.Point(8, 489);
            this.FindAdventurerBtn.Name = "FindAdventurerBtn";
            this.FindAdventurerBtn.Size = new System.Drawing.Size(178, 40);
            this.FindAdventurerBtn.TabIndex = 37;
            this.FindAdventurerBtn.Text = "Find";
            this.FindAdventurerBtn.UseVisualStyleBackColor = true;
            this.FindAdventurerBtn.Click += new System.EventHandler(this.FindAdventurerBtn_Click);
            // 
            // FindAdventurerTBox
            // 
            this.FindAdventurerTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FindAdventurerTBox.Location = new System.Drawing.Point(8, 460);
            this.FindAdventurerTBox.Name = "FindAdventurerTBox";
            this.FindAdventurerTBox.Size = new System.Drawing.Size(178, 23);
            this.FindAdventurerTBox.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(8, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Find Adventurer by Name:";
            // 
            // DeleteAdventurerBtn
            // 
            this.DeleteAdventurerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteAdventurerBtn.Location = new System.Drawing.Point(8, 384);
            this.DeleteAdventurerBtn.Name = "DeleteAdventurerBtn";
            this.DeleteAdventurerBtn.Size = new System.Drawing.Size(178, 40);
            this.DeleteAdventurerBtn.TabIndex = 34;
            this.DeleteAdventurerBtn.Text = "Delete";
            this.DeleteAdventurerBtn.UseVisualStyleBackColor = true;
            this.DeleteAdventurerBtn.Click += new System.EventHandler(this.DeleteAdventurerBtn_Click);
            // 
            // UpdateAdventurerBtn
            // 
            this.UpdateAdventurerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UpdateAdventurerBtn.Location = new System.Drawing.Point(8, 338);
            this.UpdateAdventurerBtn.Name = "UpdateAdventurerBtn";
            this.UpdateAdventurerBtn.Size = new System.Drawing.Size(178, 40);
            this.UpdateAdventurerBtn.TabIndex = 33;
            this.UpdateAdventurerBtn.Text = "Update";
            this.UpdateAdventurerBtn.UseVisualStyleBackColor = true;
            this.UpdateAdventurerBtn.Click += new System.EventHandler(this.UpdateAdventurerBtn_Click);
            // 
            // AddAdventurerBtn
            // 
            this.AddAdventurerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddAdventurerBtn.Location = new System.Drawing.Point(8, 292);
            this.AddAdventurerBtn.Name = "AddAdventurerBtn";
            this.AddAdventurerBtn.Size = new System.Drawing.Size(178, 40);
            this.AddAdventurerBtn.TabIndex = 32;
            this.AddAdventurerBtn.Text = "Add";
            this.AddAdventurerBtn.UseVisualStyleBackColor = true;
            this.AddAdventurerBtn.Click += new System.EventHandler(this.AddAdventurerBtn_Click);
            // 
            // AdventurerDPTBox
            // 
            this.AdventurerDPTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AdventurerDPTBox.Location = new System.Drawing.Point(8, 263);
            this.AdventurerDPTBox.Name = "AdventurerDPTBox";
            this.AdventurerDPTBox.Size = new System.Drawing.Size(178, 23);
            this.AdventurerDPTBox.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(8, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Adventurer DefensePoints:";
            // 
            // AdventurerAPTBox
            // 
            this.AdventurerAPTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AdventurerAPTBox.Location = new System.Drawing.Point(8, 217);
            this.AdventurerAPTBox.Name = "AdventurerAPTBox";
            this.AdventurerAPTBox.Size = new System.Drawing.Size(178, 23);
            this.AdventurerAPTBox.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(8, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Adventurer AttackPoints:";
            // 
            // AdventurerMPTBox
            // 
            this.AdventurerMPTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AdventurerMPTBox.Location = new System.Drawing.Point(8, 171);
            this.AdventurerMPTBox.Name = "AdventurerMPTBox";
            this.AdventurerMPTBox.Size = new System.Drawing.Size(178, 23);
            this.AdventurerMPTBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(8, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Adventurer ManaPoints:";
            // 
            // AdventurerHPTBox
            // 
            this.AdventurerHPTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AdventurerHPTBox.Location = new System.Drawing.Point(8, 125);
            this.AdventurerHPTBox.Name = "AdventurerHPTBox";
            this.AdventurerHPTBox.Size = new System.Drawing.Size(178, 23);
            this.AdventurerHPTBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Adventurer HealthPoints:";
            // 
            // AdventurerLevelTBox
            // 
            this.AdventurerLevelTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AdventurerLevelTBox.Location = new System.Drawing.Point(8, 79);
            this.AdventurerLevelTBox.Name = "AdventurerLevelTBox";
            this.AdventurerLevelTBox.Size = new System.Drawing.Size(178, 23);
            this.AdventurerLevelTBox.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Adventurer Level:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdventurerNameTBox
            // 
            this.AdventurerNameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AdventurerNameTBox.Location = new System.Drawing.Point(8, 33);
            this.AdventurerNameTBox.Name = "AdventurerNameTBox";
            this.AdventurerNameTBox.Size = new System.Drawing.Size(178, 23);
            this.AdventurerNameTBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Adventurer Name:";
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdventurerName,
            this.Level,
            this.HealthPoints,
            this.ManaPoints,
            this.AttackPoints,
            this.DefensePoints,
            this.CreatedOn,
            this.UpdatedOn,
            this.Id});
            this.Table.Location = new System.Drawing.Point(192, 12);
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.Size = new System.Drawing.Size(842, 563);
            this.Table.TabIndex = 19;
            this.Table.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AdventurerTable_SelectionChanged);
            // 
            // AdventurerName
            // 
            this.AdventurerName.HeaderText = "Name";
            this.AdventurerName.Name = "AdventurerName";
            this.AdventurerName.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // HealthPoints
            // 
            this.HealthPoints.HeaderText = "HealthPoints";
            this.HealthPoints.Name = "HealthPoints";
            this.HealthPoints.ReadOnly = true;
            // 
            // ManaPoints
            // 
            this.ManaPoints.HeaderText = "ManaPoints";
            this.ManaPoints.Name = "ManaPoints";
            this.ManaPoints.ReadOnly = true;
            // 
            // AttackPoints
            // 
            this.AttackPoints.HeaderText = "AttackPoints";
            this.AttackPoints.Name = "AttackPoints";
            this.AttackPoints.ReadOnly = true;
            // 
            // DefensePoints
            // 
            this.DefensePoints.HeaderText = "DefensePoints";
            this.DefensePoints.Name = "DefensePoints";
            this.DefensePoints.ReadOnly = true;
            // 
            // CreatedOn
            // 
            this.CreatedOn.HeaderText = "CreatedOn";
            this.CreatedOn.Name = "CreatedOn";
            this.CreatedOn.ReadOnly = true;
            // 
            // UpdatedOn
            // 
            this.UpdatedOn.HeaderText = "UpdatedOn";
            this.UpdatedOn.Name = "UpdatedOn";
            this.UpdatedOn.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RefreshBtn.Location = new System.Drawing.Point(8, 535);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(178, 40);
            this.RefreshBtn.TabIndex = 38;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // IdTBox
            // 
            this.IdTBox.Location = new System.Drawing.Point(156, 7);
            this.IdTBox.Name = "IdTBox";
            this.IdTBox.Size = new System.Drawing.Size(30, 20);
            this.IdTBox.TabIndex = 39;
            this.IdTBox.Visible = false;
            // 
            // AdventurerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 585);
            this.Controls.Add(this.IdTBox);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.FindAdventurerBtn);
            this.Controls.Add(this.FindAdventurerTBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeleteAdventurerBtn);
            this.Controls.Add(this.UpdateAdventurerBtn);
            this.Controls.Add(this.AddAdventurerBtn);
            this.Controls.Add(this.AdventurerDPTBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AdventurerAPTBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AdventurerMPTBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AdventurerHPTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AdventurerLevelTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdventurerNameTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdventurerForm";
            this.Text = "AdventurerForm";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FindAdventurerBtn;
        private System.Windows.Forms.TextBox FindAdventurerTBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DeleteAdventurerBtn;
        private System.Windows.Forms.Button UpdateAdventurerBtn;
        private System.Windows.Forms.Button AddAdventurerBtn;
        private System.Windows.Forms.TextBox AdventurerDPTBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AdventurerAPTBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AdventurerMPTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AdventurerHPTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdventurerLevelTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AdventurerNameTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.TextBox IdTBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdventurerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn HealthPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManaPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttackPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefensePoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}