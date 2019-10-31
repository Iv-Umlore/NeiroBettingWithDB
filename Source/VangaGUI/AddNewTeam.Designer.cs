namespace VangaGUI
{
    partial class AddNewTeam
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
            this.SendButton = new System.Windows.Forms.Button();
            this.CanselButton = new System.Windows.Forms.Button();
            this.teamAbbr = new System.Windows.Forms.TextBox();
            this.TeamName = new System.Windows.Forms.TextBox();
            this.tier_team = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.abbr = new System.Windows.Forms.Label();
            this.Rank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(227, 119);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(93, 23);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // CanselButton
            // 
            this.CanselButton.Location = new System.Drawing.Point(13, 119);
            this.CanselButton.Name = "CanselButton";
            this.CanselButton.Size = new System.Drawing.Size(75, 23);
            this.CanselButton.TabIndex = 1;
            this.CanselButton.Text = "Отмена";
            this.CanselButton.UseVisualStyleBackColor = true;
            this.CanselButton.Click += new System.EventHandler(this.CanselButton_Click);
            // 
            // teamAbbr
            // 
            this.teamAbbr.Location = new System.Drawing.Point(167, 64);
            this.teamAbbr.Name = "teamAbbr";
            this.teamAbbr.Size = new System.Drawing.Size(93, 20);
            this.teamAbbr.TabIndex = 2;
            // 
            // TeamName
            // 
            this.TeamName.Location = new System.Drawing.Point(12, 64);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(149, 20);
            this.TeamName.TabIndex = 3;
            this.TeamName.TextChanged += new System.EventHandler(this.TeamName_TextChanged);
            // 
            // tier_team
            // 
            this.tier_team.Location = new System.Drawing.Point(278, 64);
            this.tier_team.Name = "tier_team";
            this.tier_team.Size = new System.Drawing.Size(54, 20);
            this.tier_team.TabIndex = 4;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 45);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(106, 13);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Название команды";
            // 
            // abbr
            // 
            this.abbr.AutoSize = true;
            this.abbr.Location = new System.Drawing.Point(167, 45);
            this.abbr.Name = "abbr";
            this.abbr.Size = new System.Drawing.Size(78, 13);
            this.abbr.TabIndex = 6;
            this.abbr.Text = "Аббревиатура";
            // 
            // Rank
            // 
            this.Rank.AutoSize = true;
            this.Rank.Location = new System.Drawing.Point(266, 45);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(85, 13);
            this.Rank.TabIndex = 7;
            this.Rank.Text = "Ранг (1 лучший)";
            // 
            // AddNewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(225)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(354, 154);
            this.Controls.Add(this.Rank);
            this.Controls.Add(this.abbr);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.tier_team);
            this.Controls.Add(this.TeamName);
            this.Controls.Add(this.teamAbbr);
            this.Controls.Add(this.CanselButton);
            this.Controls.Add(this.SendButton);
            this.Name = "AddNewTeam";
            this.Text = "AddNewTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button CanselButton;
        private System.Windows.Forms.TextBox teamAbbr;
        private System.Windows.Forms.TextBox TeamName;
        private System.Windows.Forms.TextBox tier_team;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label abbr;
        private System.Windows.Forms.Label Rank;
    }
}