namespace VangaGUI
{
    partial class AddNewTournament
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
            this.Name = new System.Windows.Forms.Label();
            this.Size = new System.Windows.Forms.Label();
            this.TournamentName = new System.Windows.Forms.TextBox();
            this.TournamentSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Send = new System.Windows.Forms.Button();
            this.Cansel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(12, 9);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(29, 13);
            this.Name.TabIndex = 0;
            this.Name.Text = "Имя";
            // 
            // Size
            // 
            this.Size.AutoSize = true;
            this.Size.Location = new System.Drawing.Point(181, 9);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(129, 13);
            this.Size.TabIndex = 1;
            this.Size.Text = "Размер( охват турнира )";
            // 
            // TournamentName
            // 
            this.TournamentName.Location = new System.Drawing.Point(12, 25);
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.Size = new System.Drawing.Size(164, 20);
            this.TournamentName.TabIndex = 2;
            // 
            // TournamentSize
            // 
            this.TournamentSize.Location = new System.Drawing.Point(182, 25);
            this.TournamentSize.Name = "TournamentSize";
            this.TournamentSize.Size = new System.Drawing.Size(126, 20);
            this.TournamentSize.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "1 - Международный";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "5 - Локальный";
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(320, 99);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(110, 23);
            this.Send.TabIndex = 6;
            this.Send.Text = "Отправить";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Cansel
            // 
            this.Cansel.Location = new System.Drawing.Point(15, 99);
            this.Cansel.Name = "Cansel";
            this.Cansel.Size = new System.Drawing.Size(94, 23);
            this.Cansel.TabIndex = 7;
            this.Cansel.Text = "Отмена";
            this.Cansel.UseVisualStyleBackColor = true;
            this.Cansel.Click += new System.EventHandler(this.Cansel_Click);
            // 
            // AddNewTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 134);
            this.Controls.Add(this.Cansel);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TournamentSize);
            this.Controls.Add(this.TournamentName);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.Name);
            //this.Name = "AddNewTournament";
            this.Text = "Добавить Турнир";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Size;
        private System.Windows.Forms.TextBox TournamentName;
        private System.Windows.Forms.TextBox TournamentSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Cansel;
    }
}