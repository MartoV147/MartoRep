namespace DnDProjectFrontEnd.Forms
{
    partial class MonsterFightForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonsterFightForm));
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.DeleteMonsterBtn = new System.Windows.Forms.Button();
            this.AddMonsterBtn = new System.Windows.Forms.Button();
            this.FightCBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridView();
            this.MonsterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FightId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonsterCBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RefreshBtn.Location = new System.Drawing.Point(12, 202);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(178, 40);
            this.RefreshBtn.TabIndex = 46;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // DeleteMonsterBtn
            // 
            this.DeleteMonsterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DeleteMonsterBtn.Location = new System.Drawing.Point(12, 156);
            this.DeleteMonsterBtn.Name = "DeleteMonsterBtn";
            this.DeleteMonsterBtn.Size = new System.Drawing.Size(178, 40);
            this.DeleteMonsterBtn.TabIndex = 45;
            this.DeleteMonsterBtn.Text = "Delete";
            this.DeleteMonsterBtn.UseVisualStyleBackColor = true;
            this.DeleteMonsterBtn.Click += new System.EventHandler(this.DeleteMonsterBtn_Click);
            // 
            // AddMonsterBtn
            // 
            this.AddMonsterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddMonsterBtn.Location = new System.Drawing.Point(12, 110);
            this.AddMonsterBtn.Name = "AddMonsterBtn";
            this.AddMonsterBtn.Size = new System.Drawing.Size(178, 40);
            this.AddMonsterBtn.TabIndex = 44;
            this.AddMonsterBtn.Text = "Add";
            this.AddMonsterBtn.UseVisualStyleBackColor = true;
            this.AddMonsterBtn.Click += new System.EventHandler(this.AddMonsterBtn_Click);
            // 
            // FightCBox
            // 
            this.FightCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FightCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FightCBox.FormattingEnabled = true;
            this.FightCBox.Location = new System.Drawing.Point(12, 80);
            this.FightCBox.Name = "FightCBox";
            this.FightCBox.Size = new System.Drawing.Size(178, 24);
            this.FightCBox.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 42;
            this.label2.Text = "Fight Id:";
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonsterId,
            this.FightId});
            this.Table.Location = new System.Drawing.Point(196, 12);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(238, 230);
            this.Table.TabIndex = 41;
            this.Table.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Table_CellMouseClick);
            // 
            // MonsterId
            // 
            this.MonsterId.HeaderText = "MonsterId";
            this.MonsterId.Name = "MonsterId";
            // 
            // FightId
            // 
            this.FightId.HeaderText = "FightId";
            this.FightId.Name = "FightId";
            // 
            // MonsterCBox
            // 
            this.MonsterCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MonsterCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MonsterCBox.FormattingEnabled = true;
            this.MonsterCBox.Location = new System.Drawing.Point(12, 33);
            this.MonsterCBox.Name = "MonsterCBox";
            this.MonsterCBox.Size = new System.Drawing.Size(178, 24);
            this.MonsterCBox.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Monster:";
            // 
            // MonsterFightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 260);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DeleteMonsterBtn);
            this.Controls.Add(this.AddMonsterBtn);
            this.Controls.Add(this.FightCBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.MonsterCBox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MonsterFightForm";
            this.Text = "MonsterFightForm";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button DeleteMonsterBtn;
        private System.Windows.Forms.Button AddMonsterBtn;
        private System.Windows.Forms.ComboBox FightCBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.ComboBox MonsterCBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonsterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FightId;
    }
}