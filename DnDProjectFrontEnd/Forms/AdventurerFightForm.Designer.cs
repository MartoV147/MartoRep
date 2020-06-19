namespace DnDProjectFrontEnd.Forms
{
    partial class AdventurerFightForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdventurerFightForm));
            this.label1 = new System.Windows.Forms.Label();
            this.AdventurerCBox = new System.Windows.Forms.ComboBox();
            this.Table = new System.Windows.Forms.DataGridView();
            this.AdventurerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FightId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FightCBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteAdventurerBtn = new System.Windows.Forms.Button();
            this.AddAdventurerBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adventurer:";
            // 
            // AdventurerCBox
            // 
            this.AdventurerCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AdventurerCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AdventurerCBox.FormattingEnabled = true;
            this.AdventurerCBox.Location = new System.Drawing.Point(12, 33);
            this.AdventurerCBox.Name = "AdventurerCBox";
            this.AdventurerCBox.Size = new System.Drawing.Size(178, 24);
            this.AdventurerCBox.TabIndex = 1;
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdventurerId,
            this.FightId});
            this.Table.Location = new System.Drawing.Point(196, 12);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(238, 230);
            this.Table.TabIndex = 2;
            this.Table.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Table_CellMouseClick);
            // 
            // AdventurerId
            // 
            this.AdventurerId.HeaderText = "AdventurerId";
            this.AdventurerId.Name = "AdventurerId";
            // 
            // FightId
            // 
            this.FightId.HeaderText = "FightId";
            this.FightId.Name = "FightId";
            // 
            // FightCBox
            // 
            this.FightCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FightCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FightCBox.FormattingEnabled = true;
            this.FightCBox.Location = new System.Drawing.Point(12, 80);
            this.FightCBox.Name = "FightCBox";
            this.FightCBox.Size = new System.Drawing.Size(178, 24);
            this.FightCBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fight Id:";
            // 
            // DeleteAdventurerBtn
            // 
            this.DeleteAdventurerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteAdventurerBtn.Location = new System.Drawing.Point(12, 156);
            this.DeleteAdventurerBtn.Name = "DeleteAdventurerBtn";
            this.DeleteAdventurerBtn.Size = new System.Drawing.Size(178, 40);
            this.DeleteAdventurerBtn.TabIndex = 37;
            this.DeleteAdventurerBtn.Text = "Delete";
            this.DeleteAdventurerBtn.UseVisualStyleBackColor = true;
            this.DeleteAdventurerBtn.Click += new System.EventHandler(this.DeleteAdventurerBtn_Click);
            // 
            // AddAdventurerBtn
            // 
            this.AddAdventurerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddAdventurerBtn.Location = new System.Drawing.Point(12, 110);
            this.AddAdventurerBtn.Name = "AddAdventurerBtn";
            this.AddAdventurerBtn.Size = new System.Drawing.Size(178, 40);
            this.AddAdventurerBtn.TabIndex = 35;
            this.AddAdventurerBtn.Text = "Add";
            this.AddAdventurerBtn.UseVisualStyleBackColor = true;
            this.AddAdventurerBtn.Click += new System.EventHandler(this.AddAdventurerBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RefreshBtn.Location = new System.Drawing.Point(12, 202);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(178, 40);
            this.RefreshBtn.TabIndex = 38;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // AdventurerFightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 260);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DeleteAdventurerBtn);
            this.Controls.Add(this.AddAdventurerBtn);
            this.Controls.Add(this.FightCBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.AdventurerCBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdventurerFightForm";
            this.Text = "AdventurerFightForm";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox AdventurerCBox;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdventurerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FightId;
        private System.Windows.Forms.ComboBox FightCBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeleteAdventurerBtn;
        private System.Windows.Forms.Button AddAdventurerBtn;
        private System.Windows.Forms.Button RefreshBtn;
    }
}