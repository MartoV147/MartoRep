namespace DnDProjectFrontEnd.Forms
{
    partial class FightForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FightForm));
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.FindFightBtn = new System.Windows.Forms.Button();
            this.FindFightTBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DeleteFightBtn = new System.Windows.Forms.Button();
            this.UpdateFightBtn = new System.Windows.Forms.Button();
            this.AddFightBtn = new System.Windows.Forms.Button();
            this.ExpPointsTBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceWonTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FightTerrainTBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridView();
            this.FightId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Terrain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceWon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FightIdTBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RefreshBtn.Location = new System.Drawing.Point(12, 430);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(178, 40);
            this.RefreshBtn.TabIndex = 78;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // FindFightBtn
            // 
            this.FindFightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FindFightBtn.Location = new System.Drawing.Point(12, 384);
            this.FindFightBtn.Name = "FindFightBtn";
            this.FindFightBtn.Size = new System.Drawing.Size(178, 40);
            this.FindFightBtn.TabIndex = 77;
            this.FindFightBtn.Text = "Find";
            this.FindFightBtn.UseVisualStyleBackColor = true;
            this.FindFightBtn.Click += new System.EventHandler(this.FindFightBtn_Click);
            // 
            // FindFightTBox
            // 
            this.FindFightTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FindFightTBox.Location = new System.Drawing.Point(12, 355);
            this.FindFightTBox.Name = "FindFightTBox";
            this.FindFightTBox.Size = new System.Drawing.Size(178, 23);
            this.FindFightTBox.TabIndex = 76;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(9, 335);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 75;
            this.label7.Text = "Find Fight by ID:";
            // 
            // DeleteFightBtn
            // 
            this.DeleteFightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteFightBtn.Location = new System.Drawing.Point(12, 292);
            this.DeleteFightBtn.Name = "DeleteFightBtn";
            this.DeleteFightBtn.Size = new System.Drawing.Size(178, 40);
            this.DeleteFightBtn.TabIndex = 74;
            this.DeleteFightBtn.Text = "Delete";
            this.DeleteFightBtn.UseVisualStyleBackColor = true;
            this.DeleteFightBtn.Click += new System.EventHandler(this.DeleteFightBtn_Click);
            // 
            // UpdateFightBtn
            // 
            this.UpdateFightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UpdateFightBtn.Location = new System.Drawing.Point(12, 246);
            this.UpdateFightBtn.Name = "UpdateFightBtn";
            this.UpdateFightBtn.Size = new System.Drawing.Size(178, 40);
            this.UpdateFightBtn.TabIndex = 73;
            this.UpdateFightBtn.Text = "Update";
            this.UpdateFightBtn.UseVisualStyleBackColor = true;
            this.UpdateFightBtn.Click += new System.EventHandler(this.UpdateFightBtn_Click);
            // 
            // AddFightBtn
            // 
            this.AddFightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddFightBtn.Location = new System.Drawing.Point(12, 200);
            this.AddFightBtn.Name = "AddFightBtn";
            this.AddFightBtn.Size = new System.Drawing.Size(178, 40);
            this.AddFightBtn.TabIndex = 72;
            this.AddFightBtn.Text = "Add";
            this.AddFightBtn.UseVisualStyleBackColor = true;
            this.AddFightBtn.Click += new System.EventHandler(this.AddFightBtn_Click);
            // 
            // ExpPointsTBox
            // 
            this.ExpPointsTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExpPointsTBox.Location = new System.Drawing.Point(12, 171);
            this.ExpPointsTBox.Name = "ExpPointsTBox";
            this.ExpPointsTBox.Size = new System.Drawing.Size(178, 23);
            this.ExpPointsTBox.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Experience Points:";
            // 
            // PriceWonTBox
            // 
            this.PriceWonTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PriceWonTBox.Location = new System.Drawing.Point(12, 125);
            this.PriceWonTBox.Name = "PriceWonTBox";
            this.PriceWonTBox.Size = new System.Drawing.Size(178, 23);
            this.PriceWonTBox.TabIndex = 67;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "Price Reward:";
            // 
            // FightTerrainTBox
            // 
            this.FightTerrainTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FightTerrainTBox.Location = new System.Drawing.Point(12, 79);
            this.FightTerrainTBox.Name = "FightTerrainTBox";
            this.FightTerrainTBox.Size = new System.Drawing.Size(178, 23);
            this.FightTerrainTBox.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "Fight Terrain:";
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FightId,
            this.Terrain,
            this.PriceWon,
            this.ExpPoint,
            this.CreatedOn,
            this.UpdatedOn});
            this.Table.Location = new System.Drawing.Point(196, 12);
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.Size = new System.Drawing.Size(644, 458);
            this.Table.TabIndex = 63;
            this.Table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_CellClick);
            // 
            // FightId
            // 
            this.FightId.HeaderText = "FightId";
            this.FightId.Name = "FightId";
            this.FightId.ReadOnly = true;
            // 
            // Terrain
            // 
            this.Terrain.HeaderText = "Terrain";
            this.Terrain.Name = "Terrain";
            this.Terrain.ReadOnly = true;
            // 
            // PriceWon
            // 
            this.PriceWon.HeaderText = "PriceWon";
            this.PriceWon.Name = "PriceWon";
            this.PriceWon.ReadOnly = true;
            // 
            // ExpPoint
            // 
            this.ExpPoint.HeaderText = "ExpPoint";
            this.ExpPoint.Name = "ExpPoint";
            this.ExpPoint.ReadOnly = true;
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
            // FightIdTBox
            // 
            this.FightIdTBox.Enabled = false;
            this.FightIdTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FightIdTBox.Location = new System.Drawing.Point(12, 33);
            this.FightIdTBox.Name = "FightIdTBox";
            this.FightIdTBox.Size = new System.Drawing.Size(178, 23);
            this.FightIdTBox.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 80;
            this.label2.Text = "Fight ID:";
            // 
            // FightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 482);
            this.Controls.Add(this.FightIdTBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.FindFightBtn);
            this.Controls.Add(this.FindFightTBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeleteFightBtn);
            this.Controls.Add(this.UpdateFightBtn);
            this.Controls.Add(this.AddFightBtn);
            this.Controls.Add(this.ExpPointsTBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PriceWonTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FightTerrainTBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FightForm";
            this.Text = "FightForm";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button FindFightBtn;
        private System.Windows.Forms.TextBox FindFightTBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button DeleteFightBtn;
        private System.Windows.Forms.Button UpdateFightBtn;
        private System.Windows.Forms.Button AddFightBtn;
        private System.Windows.Forms.TextBox ExpPointsTBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PriceWonTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FightTerrainTBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.TextBox FightIdTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FightId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Terrain;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceWon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedOn;
    }
}