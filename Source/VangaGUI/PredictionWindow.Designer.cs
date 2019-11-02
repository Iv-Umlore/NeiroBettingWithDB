namespace VangaGUI
{
    partial class PredictionWindow
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
            this.Tournament = new System.Windows.Forms.TextBox();
            this.Team_A = new System.Windows.Forms.TextBox();
            this.Team_B = new System.Windows.Forms.TextBox();
            this.Impotant_A_comboBox = new System.Windows.Forms.ComboBox();
            this.Impotant_B = new System.Windows.Forms.ComboBox();
            this.Replacement_A = new System.Windows.Forms.TextBox();
            this.Replacement_B = new System.Windows.Forms.TextBox();
            this.Cansel = new System.Windows.Forms.Button();
            this.GetPredict = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Tournament
            // 
            this.Tournament.Enabled = false;
            this.Tournament.Location = new System.Drawing.Point(13, 13);
            this.Tournament.Name = "Tournament";
            this.Tournament.Size = new System.Drawing.Size(214, 20);
            this.Tournament.TabIndex = 0;
            // 
            // Team_A
            // 
            this.Team_A.Enabled = false;
            this.Team_A.Location = new System.Drawing.Point(13, 49);
            this.Team_A.Name = "Team_A";
            this.Team_A.Size = new System.Drawing.Size(98, 20);
            this.Team_A.TabIndex = 1;
            // 
            // Team_B
            // 
            this.Team_B.Enabled = false;
            this.Team_B.Location = new System.Drawing.Point(129, 49);
            this.Team_B.Name = "Team_B";
            this.Team_B.Size = new System.Drawing.Size(98, 20);
            this.Team_B.TabIndex = 2;
            // 
            // Impotant_A_comboBox
            // 
            this.Impotant_A_comboBox.FormattingEnabled = true;
            this.Impotant_A_comboBox.Location = new System.Drawing.Point(12, 108);
            this.Impotant_A_comboBox.Name = "Impotant_A_comboBox";
            this.Impotant_A_comboBox.Size = new System.Drawing.Size(98, 21);
            this.Impotant_A_comboBox.TabIndex = 26;
            // 
            // Impotant_B
            // 
            this.Impotant_B.FormattingEnabled = true;
            this.Impotant_B.Location = new System.Drawing.Point(129, 108);
            this.Impotant_B.Name = "Impotant_B";
            this.Impotant_B.Size = new System.Drawing.Size(98, 21);
            this.Impotant_B.TabIndex = 27;
            // 
            // Replacement_A
            // 
            this.Replacement_A.Location = new System.Drawing.Point(12, 160);
            this.Replacement_A.Name = "Replacement_A";
            this.Replacement_A.Size = new System.Drawing.Size(97, 20);
            this.Replacement_A.TabIndex = 28;
            // 
            // Replacement_B
            // 
            this.Replacement_B.Location = new System.Drawing.Point(129, 160);
            this.Replacement_B.Name = "Replacement_B";
            this.Replacement_B.Size = new System.Drawing.Size(98, 20);
            this.Replacement_B.TabIndex = 29;
            // 
            // Cansel
            // 
            this.Cansel.Location = new System.Drawing.Point(12, 226);
            this.Cansel.Name = "Cansel";
            this.Cansel.Size = new System.Drawing.Size(97, 23);
            this.Cansel.TabIndex = 30;
            this.Cansel.Text = "Отмена";
            this.Cansel.UseVisualStyleBackColor = true;
            this.Cansel.Click += new System.EventHandler(this.Calsel_Click);
            // 
            // GetPredict
            // 
            this.GetPredict.Location = new System.Drawing.Point(129, 226);
            this.GetPredict.Name = "GetPredict";
            this.GetPredict.Size = new System.Drawing.Size(98, 23);
            this.GetPredict.TabIndex = 31;
            this.GetPredict.Text = "Предсказать";
            this.GetPredict.UseVisualStyleBackColor = true;
            this.GetPredict.Click += new System.EventHandler(this.GetPredict_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Важность матча для команд";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Количество замен";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(214, 20);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // PredictionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 271);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetPredict);
            this.Controls.Add(this.Cansel);
            this.Controls.Add(this.Replacement_B);
            this.Controls.Add(this.Replacement_A);
            this.Controls.Add(this.Impotant_B);
            this.Controls.Add(this.Impotant_A_comboBox);
            this.Controls.Add(this.Team_B);
            this.Controls.Add(this.Team_A);
            this.Controls.Add(this.Tournament);
            this.Name = "PredictionWindow";
            this.Text = "PredictionWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tournament;
        private System.Windows.Forms.TextBox Team_A;
        private System.Windows.Forms.TextBox Team_B;
        private System.Windows.Forms.ComboBox Impotant_A_comboBox;
        private System.Windows.Forms.ComboBox Impotant_B;
        private System.Windows.Forms.TextBox Replacement_A;
        private System.Windows.Forms.TextBox Replacement_B;
        private System.Windows.Forms.Button Cansel;
        private System.Windows.Forms.Button GetPredict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}