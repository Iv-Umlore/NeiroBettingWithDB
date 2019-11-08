namespace VangaGUI
{
    partial class LearningWindow
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
            this.SaveWeights = new System.Windows.Forms.Button();
            this.ReloadWeights = new System.Windows.Forms.Button();
            this.LearningProgressPanel = new System.Windows.Forms.Panel();
            this.MatchesCount = new System.Windows.Forms.Label();
            this.MatchesCountLabel = new System.Windows.Forms.Label();
            this.CountOfCircle = new System.Windows.Forms.Label();
            this.NumberOfCircleValue = new System.Windows.Forms.Label();
            this.CircleCountLabel = new System.Windows.Forms.Label();
            this.AverageResultValue = new System.Windows.Forms.Label();
            this.AverageResultLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.TestNetwork = new System.Windows.Forms.Button();
            this.NetworkLearning = new System.Windows.Forms.Button();
            this.EndLerning = new System.Windows.Forms.Button();
            this.LearningProgressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveWeights
            // 
            this.SaveWeights.Location = new System.Drawing.Point(397, 12);
            this.SaveWeights.Name = "SaveWeights";
            this.SaveWeights.Size = new System.Drawing.Size(88, 47);
            this.SaveWeights.TabIndex = 22;
            this.SaveWeights.Text = "Сохранить текущие настройки";
            this.SaveWeights.UseVisualStyleBackColor = true;
            this.SaveWeights.Click += new System.EventHandler(this.SaveWeights_Click);
            // 
            // ReloadWeights
            // 
            this.ReloadWeights.Location = new System.Drawing.Point(303, 12);
            this.ReloadWeights.Name = "ReloadWeights";
            this.ReloadWeights.Size = new System.Drawing.Size(88, 47);
            this.ReloadWeights.TabIndex = 21;
            this.ReloadWeights.Text = "Сбросить значение весов";
            this.ReloadWeights.UseVisualStyleBackColor = true;
            this.ReloadWeights.Click += new System.EventHandler(this.ReloadWeights_Click);
            // 
            // LearningProgressPanel
            // 
            this.LearningProgressPanel.Controls.Add(this.MatchesCount);
            this.LearningProgressPanel.Controls.Add(this.MatchesCountLabel);
            this.LearningProgressPanel.Controls.Add(this.CountOfCircle);
            this.LearningProgressPanel.Controls.Add(this.NumberOfCircleValue);
            this.LearningProgressPanel.Controls.Add(this.CircleCountLabel);
            this.LearningProgressPanel.Controls.Add(this.AverageResultValue);
            this.LearningProgressPanel.Controls.Add(this.AverageResultLabel);
            this.LearningProgressPanel.Controls.Add(this.progressBar1);
            this.LearningProgressPanel.Location = new System.Drawing.Point(18, 83);
            this.LearningProgressPanel.Name = "LearningProgressPanel";
            this.LearningProgressPanel.Size = new System.Drawing.Size(776, 60);
            this.LearningProgressPanel.TabIndex = 20;
            this.LearningProgressPanel.Visible = false;
            // 
            // MatchesCount
            // 
            this.MatchesCount.AutoSize = true;
            this.MatchesCount.Location = new System.Drawing.Point(460, 11);
            this.MatchesCount.Name = "MatchesCount";
            this.MatchesCount.Size = new System.Drawing.Size(25, 13);
            this.MatchesCount.TabIndex = 10;
            this.MatchesCount.Text = "150";
            // 
            // MatchesCountLabel
            // 
            this.MatchesCountLabel.AutoSize = true;
            this.MatchesCountLabel.Location = new System.Drawing.Point(334, 11);
            this.MatchesCountLabel.Name = "MatchesCountLabel";
            this.MatchesCountLabel.Size = new System.Drawing.Size(108, 13);
            this.MatchesCountLabel.TabIndex = 9;
            this.MatchesCountLabel.Text = "Количество матчей:";
            // 
            // CountOfCircle
            // 
            this.CountOfCircle.AutoSize = true;
            this.CountOfCircle.Location = new System.Drawing.Point(238, 11);
            this.CountOfCircle.Name = "CountOfCircle";
            this.CountOfCircle.Size = new System.Drawing.Size(46, 13);
            this.CountOfCircle.TabIndex = 8;
            this.CountOfCircle.Text = "из 1000";
            // 
            // NumberOfCircleValue
            // 
            this.NumberOfCircleValue.AutoSize = true;
            this.NumberOfCircleValue.Location = new System.Drawing.Point(216, 11);
            this.NumberOfCircleValue.Name = "NumberOfCircleValue";
            this.NumberOfCircleValue.Size = new System.Drawing.Size(16, 13);
            this.NumberOfCircleValue.TabIndex = 7;
            this.NumberOfCircleValue.Text = "...";
            // 
            // CircleCountLabel
            // 
            this.CircleCountLabel.AutoSize = true;
            this.CircleCountLabel.Location = new System.Drawing.Point(171, 11);
            this.CircleCountLabel.Name = "CircleCountLabel";
            this.CircleCountLabel.Size = new System.Drawing.Size(39, 13);
            this.CircleCountLabel.TabIndex = 6;
            this.CircleCountLabel.Text = "Цикл: ";
            // 
            // AverageResultValue
            // 
            this.AverageResultValue.AutoSize = true;
            this.AverageResultValue.Location = new System.Drawing.Point(109, 11);
            this.AverageResultValue.Name = "AverageResultValue";
            this.AverageResultValue.Size = new System.Drawing.Size(16, 13);
            this.AverageResultValue.TabIndex = 5;
            this.AverageResultValue.Text = "...";
            // 
            // AverageResultLabel
            // 
            this.AverageResultLabel.AutoSize = true;
            this.AverageResultLabel.Location = new System.Drawing.Point(11, 11);
            this.AverageResultLabel.Name = "AverageResultLabel";
            this.AverageResultLabel.Size = new System.Drawing.Size(96, 13);
            this.AverageResultLabel.TabIndex = 4;
            this.AverageResultLabel.Text = "Средняя Ошибка:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 34);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(770, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // TestNetwork
            // 
            this.TestNetwork.Location = new System.Drawing.Point(109, 12);
            this.TestNetwork.Name = "TestNetwork";
            this.TestNetwork.Size = new System.Drawing.Size(88, 47);
            this.TestNetwork.TabIndex = 19;
            this.TestNetwork.Text = "Тест Нейронной сети";
            this.TestNetwork.UseVisualStyleBackColor = true;
            this.TestNetwork.Click += new System.EventHandler(this.TestNetwork_Click);
            // 
            // NetworkLearning
            // 
            this.NetworkLearning.Location = new System.Drawing.Point(18, 12);
            this.NetworkLearning.Name = "NetworkLearning";
            this.NetworkLearning.Size = new System.Drawing.Size(88, 47);
            this.NetworkLearning.TabIndex = 18;
            this.NetworkLearning.Text = "Обучение Нейронной сети";
            this.NetworkLearning.UseVisualStyleBackColor = true;
            this.NetworkLearning.Click += new System.EventHandler(this.NetworkLearning_Click);
            // 
            // EndLerning
            // 
            this.EndLerning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.EndLerning.Location = new System.Drawing.Point(700, 12);
            this.EndLerning.Name = "EndLerning";
            this.EndLerning.Size = new System.Drawing.Size(88, 47);
            this.EndLerning.TabIndex = 23;
            this.EndLerning.Text = "Закончить обучение";
            this.EndLerning.UseVisualStyleBackColor = false;
            this.EndLerning.Click += new System.EventHandler(this.EndLerning_Click);
            // 
            // LearningWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 177);
            this.Controls.Add(this.EndLerning);
            this.Controls.Add(this.SaveWeights);
            this.Controls.Add(this.ReloadWeights);
            this.Controls.Add(this.LearningProgressPanel);
            this.Controls.Add(this.TestNetwork);
            this.Controls.Add(this.NetworkLearning);
            this.Name = "LearningWindow";
            this.Text = "LearningWindow";
            this.LearningProgressPanel.ResumeLayout(false);
            this.LearningProgressPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SaveWeights;
        private System.Windows.Forms.Button ReloadWeights;
        private System.Windows.Forms.Panel LearningProgressPanel;
        private System.Windows.Forms.Label MatchesCount;
        private System.Windows.Forms.Label MatchesCountLabel;
        private System.Windows.Forms.Label CountOfCircle;
        private System.Windows.Forms.Label NumberOfCircleValue;
        private System.Windows.Forms.Label CircleCountLabel;
        private System.Windows.Forms.Label AverageResultValue;
        private System.Windows.Forms.Label AverageResultLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button TestNetwork;
        private System.Windows.Forms.Button NetworkLearning;
        private System.Windows.Forms.Button EndLerning;
    }
}