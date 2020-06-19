namespace DnDProjectFrontEnd.Forms
{
    partial class MonsterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonsterForm));
            this.IdTBox = new System.Windows.Forms.TextBox();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.FindMonsterBtn = new System.Windows.Forms.Button();
            this.FindMonsterTBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteMonsterBtn = new System.Windows.Forms.Button();
            this.UpdateMonsterBtn = new System.Windows.Forms.Button();
            this.AddMonsterBtn = new System.Windows.Forms.Button();
            this.MonsterDPTBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MonsterAPTBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MonsterHPTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MonsterNameTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridView();
            this.AdventurerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HealthPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttackPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DefensePoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExPTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // IdTBox
            // 
            this.IdTBox.Location = new System.Drawing.Point(160, 3);
            this.IdTBox.Name = "IdTBox";
            this.IdTBox.Size = new System.Drawing.Size(30, 20);
            this.IdTBox.TabIndex = 60;
            this.IdTBox.Visible = false;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RefreshBtn.Location = new System.Drawing.Point(12, 472);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(178, 40);
            this.RefreshBtn.TabIndex = 59;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // FindMonsterBtn
            // 
            this.FindMonsterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FindMonsterBtn.Location = new System.Drawing.Point(12, 426);
            this.FindMonsterBtn.Name = "FindMonsterBtn";
            this.FindMonsterBtn.Size = new System.Drawing.Size(178, 40);
            this.FindMonsterBtn.TabIndex = 58;
            this.FindMonsterBtn.Text = "Find";
            this.FindMonsterBtn.UseVisualStyleBackColor = true;
            this.FindMonsterBtn.Click += new System.EventHandler(this.FindMonsterBtn_Click);
            // 
            // FindMonsterTBox
            // 
            this.FindMonsterTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FindMonsterTBox.Location = new System.Drawing.Point(12, 397);
            this.FindMonsterTBox.Name = "FindMonsterTBox";
            this.FindMonsterTBox.Size = new System.Drawing.Size(178, 23);
            this.FindMonsterTBox.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(9, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 17);
            this.label7.TabIndex = 56;
            this.label7.Text = "Find Monster by Name:";
            // 
            // DeleteMonsterBtn
            // 
            this.DeleteMonsterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteMonsterBtn.Location = new System.Drawing.Point(12, 334);
            this.DeleteMonsterBtn.Name = "DeleteMonsterBtn";
            this.DeleteMonsterBtn.Size = new System.Drawing.Size(178, 40);
            this.DeleteMonsterBtn.TabIndex = 55;
            this.DeleteMonsterBtn.Text = "Delete";
            this.DeleteMonsterBtn.UseVisualStyleBackColor = true;
            this.DeleteMonsterBtn.Click += new System.EventHandler(this.DeleteMonsterBtn_Click);
            // 
            // UpdateMonsterBtn
            // 
            this.UpdateMonsterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UpdateMonsterBtn.Location = new System.Drawing.Point(12, 288);
            this.UpdateMonsterBtn.Name = "UpdateMonsterBtn";
            this.UpdateMonsterBtn.Size = new System.Drawing.Size(178, 40);
            this.UpdateMonsterBtn.TabIndex = 54;
            this.UpdateMonsterBtn.Text = "Update";
            this.UpdateMonsterBtn.UseVisualStyleBackColor = true;
            this.UpdateMonsterBtn.Click += new System.EventHandler(this.UpdateMonsterBtn_Click);
            // 
            // AddMonsterBtn
            // 
            this.AddMonsterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddMonsterBtn.Location = new System.Drawing.Point(12, 242);
            this.AddMonsterBtn.Name = "AddMonsterBtn";
            this.AddMonsterBtn.Size = new System.Drawing.Size(178, 40);
            this.AddMonsterBtn.TabIndex = 53;
            this.AddMonsterBtn.Text = "Add";
            this.AddMonsterBtn.UseVisualStyleBackColor = true;
            this.AddMonsterBtn.Click += new System.EventHandler(this.AddMonsterBtn_Click);
            // 
            // MonsterDPTBox
            // 
            this.MonsterDPTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MonsterDPTBox.Location = new System.Drawing.Point(12, 167);
            this.MonsterDPTBox.Name = "MonsterDPTBox";
            this.MonsterDPTBox.Size = new System.Drawing.Size(178, 23);
            this.MonsterDPTBox.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Monster DefensePoints:";
            // 
            // MonsterAPTBox
            // 
            this.MonsterAPTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MonsterAPTBox.Location = new System.Drawing.Point(12, 121);
            this.MonsterAPTBox.Name = "MonsterAPTBox";
            this.MonsterAPTBox.Size = new System.Drawing.Size(178, 23);
            this.MonsterAPTBox.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(9, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Monster AttackPoints:";
            // 
            // MonsterHPTBox
            // 
            this.MonsterHPTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MonsterHPTBox.Location = new System.Drawing.Point(12, 75);
            this.MonsterHPTBox.Name = "MonsterHPTBox";
            this.MonsterHPTBox.Size = new System.Drawing.Size(178, 23);
            this.MonsterHPTBox.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(9, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Monster HealthPoints:";
            // 
            // MonsterNameTBox
            // 
            this.MonsterNameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MonsterNameTBox.Location = new System.Drawing.Point(12, 29);
            this.MonsterNameTBox.Name = "MonsterNameTBox";
            this.MonsterNameTBox.Size = new System.Drawing.Size(178, 23);
            this.MonsterNameTBox.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Monster Name:";
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdventurerName,
            this.HealthPoints,
            this.AttackPoints,
            this.DefensePoints,
            this.ExpPoints,
            this.CreatedOn,
            this.UpdatedOn,
            this.Id});
            this.Table.Location = new System.Drawing.Point(196, 12);
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.Size = new System.Drawing.Size(743, 500);
            this.Table.TabIndex = 40;
            this.Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellClick);
            // 
            // AdventurerName
            // 
            this.AdventurerName.HeaderText = "Name";
            this.AdventurerName.Name = "AdventurerName";
            this.AdventurerName.ReadOnly = true;
            // 
            // HealthPoints
            // 
            this.HealthPoints.HeaderText = "HealthPoints";
            this.HealthPoints.Name = "HealthPoints";
            this.HealthPoints.ReadOnly = true;
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
            // ExpPoints
            // 
            this.ExpPoints.HeaderText = "ExpPoints";
            this.ExpPoints.Name = "ExpPoints";
            this.ExpPoints.ReadOnly = true;
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
            // ExPTBox
            // 
            this.ExPTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExPTBox.Location = new System.Drawing.Point(12, 213);
            this.ExPTBox.Name = "ExPTBox";
            this.ExPTBox.Size = new System.Drawing.Size(178, 23);
            this.ExPTBox.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(9, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Experience Points:";
            // 
            // MonsterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 526);
            this.Controls.Add(this.ExPTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdTBox);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.FindMonsterBtn);
            this.Controls.Add(this.FindMonsterTBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeleteMonsterBtn);
            this.Controls.Add(this.UpdateMonsterBtn);
            this.Controls.Add(this.AddMonsterBtn);
            this.Controls.Add(this.MonsterDPTBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MonsterAPTBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MonsterHPTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MonsterNameTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonsterForm";
            this.Text = "MonsterForm";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdTBox;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button FindMonsterBtn;
        private System.Windows.Forms.TextBox FindMonsterTBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DeleteMonsterBtn;
        private System.Windows.Forms.Button UpdateMonsterBtn;
        private System.Windows.Forms.Button AddMonsterBtn;
        private System.Windows.Forms.TextBox MonsterDPTBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox MonsterAPTBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MonsterHPTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MonsterNameTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.TextBox ExPTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdventurerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HealthPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttackPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn DefensePoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}