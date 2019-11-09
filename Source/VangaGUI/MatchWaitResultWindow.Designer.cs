namespace VangaGUI
{
    partial class MatchWaitResultWindow
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
            this.Close = new System.Windows.Forms.Button();
            this.MyMatchWaitResult = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddResult = new System.Windows.Forms.Button();
            this.statisticPredictTexBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HardPredictTextBox = new System.Windows.Forms.TextBox();
            this.PredictTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SavePredictTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.LightGray;
            this.Close.Location = new System.Drawing.Point(435, 139);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(88, 27);
            this.Close.TabIndex = 24;
            this.Close.Text = "Закрыть окно";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.EndLerning_Click);
            // 
            // MyMatchWaitResult
            // 
            this.MyMatchWaitResult.FormattingEnabled = true;
            this.MyMatchWaitResult.Location = new System.Drawing.Point(12, 29);
            this.MyMatchWaitResult.Name = "MyMatchWaitResult";
            this.MyMatchWaitResult.Size = new System.Drawing.Size(372, 21);
            this.MyMatchWaitResult.TabIndex = 25;
            this.MyMatchWaitResult.SelectedIndexChanged += new System.EventHandler(this.MyMatchWaitResult_SelectedIndexChanged);
            this.MyMatchWaitResult.Click += new System.EventHandler(this.MyMatchWaitResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Выберите матч";
            // 
            // AddResult
            // 
            this.AddResult.Location = new System.Drawing.Point(390, 27);
            this.AddResult.Name = "AddResult";
            this.AddResult.Size = new System.Drawing.Size(133, 23);
            this.AddResult.TabIndex = 27;
            this.AddResult.Text = "Записать результат";
            this.AddResult.UseVisualStyleBackColor = true;
            this.AddResult.Click += new System.EventHandler(this.AddResult_Click);
            // 
            // statisticPredictTexBox
            // 
            this.statisticPredictTexBox.Enabled = false;
            this.statisticPredictTexBox.Location = new System.Drawing.Point(178, 56);
            this.statisticPredictTexBox.Name = "statisticPredictTexBox";
            this.statisticPredictTexBox.Size = new System.Drawing.Size(345, 20);
            this.statisticPredictTexBox.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ожидаемый результат матча";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Рисковый Прогноз";
            // 
            // HardPredictTextBox
            // 
            this.HardPredictTextBox.Enabled = false;
            this.HardPredictTextBox.Location = new System.Drawing.Point(178, 84);
            this.HardPredictTextBox.Name = "HardPredictTextBox";
            this.HardPredictTextBox.Size = new System.Drawing.Size(200, 20);
            this.HardPredictTextBox.TabIndex = 31;
            // 
            // PredictTextBox
            // 
            this.PredictTextBox.Enabled = false;
            this.PredictTextBox.Location = new System.Drawing.Point(178, 110);
            this.PredictTextBox.Name = "PredictTextBox";
            this.PredictTextBox.Size = new System.Drawing.Size(200, 20);
            this.PredictTextBox.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Прогноз";
            // 
            // SavePredictTextBox
            // 
            this.SavePredictTextBox.Enabled = false;
            this.SavePredictTextBox.Location = new System.Drawing.Point(178, 140);
            this.SavePredictTextBox.Name = "SavePredictTextBox";
            this.SavePredictTextBox.Size = new System.Drawing.Size(200, 20);
            this.SavePredictTextBox.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Сейвовый прогноз";
            // 
            // MatchWaitResultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(253)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(535, 179);
            this.Controls.Add(this.SavePredictTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PredictTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HardPredictTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statisticPredictTexBox);
            this.Controls.Add(this.AddResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyMatchWaitResult);
            this.Controls.Add(this.Close);
            this.Name = "MatchWaitResultWindow";
            this.Text = "MatchWaitResultWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.ComboBox MyMatchWaitResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddResult;
        private System.Windows.Forms.TextBox statisticPredictTexBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HardPredictTextBox;
        private System.Windows.Forms.TextBox PredictTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SavePredictTextBox;
        private System.Windows.Forms.Label label5;
    }
}