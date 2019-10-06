namespace VangaGUI
{
    partial class MainWindows
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FootBall_Radio = new System.Windows.Forms.RadioButton();
            this.CSGO_Radio = new System.Windows.Forms.RadioButton();
            this.RocketLeague_Radio = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ChangeDiscipline = new System.Windows.Forms.Button();
            this.Label_TeamA = new System.Windows.Forms.Label();
            this.Label_TeamB = new System.Windows.Forms.Label();
            this.VangaPanel = new System.Windows.Forms.Panel();
            this.LastFiveMatchesA = new System.Windows.Forms.Panel();
            this.FirstMatchPanelA = new System.Windows.Forms.Panel();
            this.AddMatch_TeamA = new System.Windows.Forms.Button();
            this.SecondMatchPanelA = new System.Windows.Forms.Panel();
            this.FifthMatchPanelA = new System.Windows.Forms.Panel();
            this.ThirdMatchPanelA = new System.Windows.Forms.Panel();
            this.FourthMatchPanelA = new System.Windows.Forms.Panel();
            this.LastFiveMatchesB = new System.Windows.Forms.Panel();
            this.FirstMatchPanelB = new System.Windows.Forms.Panel();
            this.AddMatch_TeamB = new System.Windows.Forms.Button();
            this.SecondMatchPanelB = new System.Windows.Forms.Panel();
            this.FifthMatchTotalB = new System.Windows.Forms.Panel();
            this.ThirdMatchPanelB = new System.Windows.Forms.Panel();
            this.FourthMatchPanelB = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.TeamB_Box = new System.Windows.Forms.ComboBox();
            this.TeamA_Box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenWaitResultMatches = new System.Windows.Forms.Button();
            this.DisciplinePanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LearningProgressPanel = new System.Windows.Forms.Panel();
            this.VangaPanel.SuspendLayout();
            this.LastFiveMatchesA.SuspendLayout();
            this.LastFiveMatchesB.SuspendLayout();
            this.DisciplinePanel.SuspendLayout();
            this.LearningProgressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FootBall_Radio
            // 
            this.FootBall_Radio.AutoSize = true;
            this.FootBall_Radio.Location = new System.Drawing.Point(19, 5);
            this.FootBall_Radio.Name = "FootBall_Radio";
            this.FootBall_Radio.Size = new System.Drawing.Size(64, 17);
            this.FootBall_Radio.TabIndex = 0;
            this.FootBall_Radio.TabStop = true;
            this.FootBall_Radio.Text = "Футбол";
            this.FootBall_Radio.UseVisualStyleBackColor = true;
            // 
            // CSGO_Radio
            // 
            this.CSGO_Radio.AutoSize = true;
            this.CSGO_Radio.Location = new System.Drawing.Point(19, 28);
            this.CSGO_Radio.Name = "CSGO_Radio";
            this.CSGO_Radio.Size = new System.Drawing.Size(58, 17);
            this.CSGO_Radio.TabIndex = 1;
            this.CSGO_Radio.TabStop = true;
            this.CSGO_Radio.Text = "CS:GO";
            this.CSGO_Radio.UseVisualStyleBackColor = true;
            // 
            // RocketLeague_Radio
            // 
            this.RocketLeague_Radio.AutoSize = true;
            this.RocketLeague_Radio.Location = new System.Drawing.Point(19, 51);
            this.RocketLeague_Radio.Name = "RocketLeague_Radio";
            this.RocketLeague_Radio.Size = new System.Drawing.Size(99, 17);
            this.RocketLeague_Radio.TabIndex = 2;
            this.RocketLeague_Radio.TabStop = true;
            this.RocketLeague_Radio.Text = "Rocket League";
            this.RocketLeague_Radio.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 34);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(448, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // ChangeDiscipline
            // 
            this.ChangeDiscipline.Location = new System.Drawing.Point(3, 73);
            this.ChangeDiscipline.Name = "ChangeDiscipline";
            this.ChangeDiscipline.Size = new System.Drawing.Size(130, 23);
            this.ChangeDiscipline.TabIndex = 4;
            this.ChangeDiscipline.Text = "Выбрать дисциплину";
            this.ChangeDiscipline.UseVisualStyleBackColor = true;
            this.ChangeDiscipline.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Label_TeamA
            // 
            this.Label_TeamA.AutoSize = true;
            this.Label_TeamA.Location = new System.Drawing.Point(3, 14);
            this.Label_TeamA.Name = "Label_TeamA";
            this.Label_TeamA.Size = new System.Drawing.Size(61, 13);
            this.Label_TeamA.TabIndex = 5;
            this.Label_TeamA.Text = "Команда 1";
            // 
            // Label_TeamB
            // 
            this.Label_TeamB.AutoSize = true;
            this.Label_TeamB.Location = new System.Drawing.Point(524, 14);
            this.Label_TeamB.Name = "Label_TeamB";
            this.Label_TeamB.Size = new System.Drawing.Size(61, 13);
            this.Label_TeamB.TabIndex = 6;
            this.Label_TeamB.Text = "Команда 2";
            // 
            // VangaPanel
            // 
            this.VangaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(254)))), ((int)(((byte)(193)))));
            this.VangaPanel.Controls.Add(this.LastFiveMatchesA);
            this.VangaPanel.Controls.Add(this.LastFiveMatchesB);
            this.VangaPanel.Controls.Add(this.label2);
            this.VangaPanel.Controls.Add(this.TeamB_Box);
            this.VangaPanel.Controls.Add(this.TeamA_Box);
            this.VangaPanel.Controls.Add(this.label1);
            this.VangaPanel.Controls.Add(this.Label_TeamA);
            this.VangaPanel.Controls.Add(this.Label_TeamB);
            this.VangaPanel.Location = new System.Drawing.Point(200, 13);
            this.VangaPanel.Name = "VangaPanel";
            this.VangaPanel.Size = new System.Drawing.Size(588, 369);
            this.VangaPanel.TabIndex = 7;
            // 
            // LastFiveMatchesA
            // 
            this.LastFiveMatchesA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.LastFiveMatchesA.Controls.Add(this.FirstMatchPanelA);
            this.LastFiveMatchesA.Controls.Add(this.AddMatch_TeamA);
            this.LastFiveMatchesA.Controls.Add(this.SecondMatchPanelA);
            this.LastFiveMatchesA.Controls.Add(this.FifthMatchPanelA);
            this.LastFiveMatchesA.Controls.Add(this.ThirdMatchPanelA);
            this.LastFiveMatchesA.Controls.Add(this.FourthMatchPanelA);
            this.LastFiveMatchesA.Location = new System.Drawing.Point(6, 70);
            this.LastFiveMatchesA.Name = "LastFiveMatchesA";
            this.LastFiveMatchesA.Size = new System.Drawing.Size(273, 296);
            this.LastFiveMatchesA.TabIndex = 17;
            // 
            // FirstMatchPanelA
            // 
            this.FirstMatchPanelA.Location = new System.Drawing.Point(3, 3);
            this.FirstMatchPanelA.Name = "FirstMatchPanelA";
            this.FirstMatchPanelA.Size = new System.Drawing.Size(267, 47);
            this.FirstMatchPanelA.TabIndex = 13;
            // 
            // AddMatch_TeamA
            // 
            this.AddMatch_TeamA.Location = new System.Drawing.Point(65, 268);
            this.AddMatch_TeamA.Name = "AddMatch_TeamA";
            this.AddMatch_TeamA.Size = new System.Drawing.Size(149, 23);
            this.AddMatch_TeamA.TabIndex = 15;
            this.AddMatch_TeamA.Text = "Добавить матч команды";
            this.AddMatch_TeamA.UseVisualStyleBackColor = true;
            // 
            // SecondMatchPanelA
            // 
            this.SecondMatchPanelA.Location = new System.Drawing.Point(3, 56);
            this.SecondMatchPanelA.Name = "SecondMatchPanelA";
            this.SecondMatchPanelA.Size = new System.Drawing.Size(267, 47);
            this.SecondMatchPanelA.TabIndex = 14;
            // 
            // FifthMatchPanelA
            // 
            this.FifthMatchPanelA.Location = new System.Drawing.Point(3, 215);
            this.FifthMatchPanelA.Name = "FifthMatchPanelA";
            this.FifthMatchPanelA.Size = new System.Drawing.Size(267, 47);
            this.FifthMatchPanelA.TabIndex = 14;
            // 
            // ThirdMatchPanelA
            // 
            this.ThirdMatchPanelA.Location = new System.Drawing.Point(3, 109);
            this.ThirdMatchPanelA.Name = "ThirdMatchPanelA";
            this.ThirdMatchPanelA.Size = new System.Drawing.Size(267, 47);
            this.ThirdMatchPanelA.TabIndex = 14;
            // 
            // FourthMatchPanelA
            // 
            this.FourthMatchPanelA.Location = new System.Drawing.Point(3, 162);
            this.FourthMatchPanelA.Name = "FourthMatchPanelA";
            this.FourthMatchPanelA.Size = new System.Drawing.Size(267, 47);
            this.FourthMatchPanelA.TabIndex = 14;
            // 
            // LastFiveMatchesB
            // 
            this.LastFiveMatchesB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.LastFiveMatchesB.Controls.Add(this.FirstMatchPanelB);
            this.LastFiveMatchesB.Controls.Add(this.AddMatch_TeamB);
            this.LastFiveMatchesB.Controls.Add(this.SecondMatchPanelB);
            this.LastFiveMatchesB.Controls.Add(this.FifthMatchTotalB);
            this.LastFiveMatchesB.Controls.Add(this.ThirdMatchPanelB);
            this.LastFiveMatchesB.Controls.Add(this.FourthMatchPanelB);
            this.LastFiveMatchesB.Location = new System.Drawing.Point(305, 70);
            this.LastFiveMatchesB.Name = "LastFiveMatchesB";
            this.LastFiveMatchesB.Size = new System.Drawing.Size(280, 296);
            this.LastFiveMatchesB.TabIndex = 16;
            // 
            // FirstMatchPanelB
            // 
            this.FirstMatchPanelB.Location = new System.Drawing.Point(3, 3);
            this.FirstMatchPanelB.Name = "FirstMatchPanelB";
            this.FirstMatchPanelB.Size = new System.Drawing.Size(271, 47);
            this.FirstMatchPanelB.TabIndex = 13;
            // 
            // AddMatch_TeamB
            // 
            this.AddMatch_TeamB.Location = new System.Drawing.Point(73, 268);
            this.AddMatch_TeamB.Name = "AddMatch_TeamB";
            this.AddMatch_TeamB.Size = new System.Drawing.Size(149, 23);
            this.AddMatch_TeamB.TabIndex = 15;
            this.AddMatch_TeamB.Text = "Добавить матч команды";
            this.AddMatch_TeamB.UseVisualStyleBackColor = true;
            // 
            // SecondMatchPanelB
            // 
            this.SecondMatchPanelB.Location = new System.Drawing.Point(3, 56);
            this.SecondMatchPanelB.Name = "SecondMatchPanelB";
            this.SecondMatchPanelB.Size = new System.Drawing.Size(271, 47);
            this.SecondMatchPanelB.TabIndex = 14;
            // 
            // FifthMatchTotalB
            // 
            this.FifthMatchTotalB.Location = new System.Drawing.Point(3, 215);
            this.FifthMatchTotalB.Name = "FifthMatchTotalB";
            this.FifthMatchTotalB.Size = new System.Drawing.Size(271, 47);
            this.FifthMatchTotalB.TabIndex = 14;
            // 
            // ThirdMatchPanelB
            // 
            this.ThirdMatchPanelB.Location = new System.Drawing.Point(3, 109);
            this.ThirdMatchPanelB.Name = "ThirdMatchPanelB";
            this.ThirdMatchPanelB.Size = new System.Drawing.Size(271, 47);
            this.ThirdMatchPanelB.TabIndex = 14;
            // 
            // FourthMatchPanelB
            // 
            this.FourthMatchPanelB.Location = new System.Drawing.Point(3, 162);
            this.FourthMatchPanelB.Name = "FourthMatchPanelB";
            this.FourthMatchPanelB.Size = new System.Drawing.Size(271, 47);
            this.FourthMatchPanelB.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "5 Последних матчей: ";
            // 
            // TeamB_Box
            // 
            this.TeamB_Box.FormattingEnabled = true;
            this.TeamB_Box.Location = new System.Drawing.Point(320, 14);
            this.TeamB_Box.Name = "TeamB_Box";
            this.TeamB_Box.Size = new System.Drawing.Size(198, 21);
            this.TeamB_Box.TabIndex = 11;
            this.TeamB_Box.SelectedIndexChanged += new System.EventHandler(this.TeamB_Box_SelectedIndexChanged);
            // 
            // TeamA_Box
            // 
            this.TeamA_Box.FormattingEnabled = true;
            this.TeamA_Box.Location = new System.Drawing.Point(71, 14);
            this.TeamA_Box.Name = "TeamA_Box";
            this.TeamA_Box.Size = new System.Drawing.Size(192, 21);
            this.TeamA_Box.TabIndex = 10;
            this.TeamA_Box.SelectedIndexChanged += new System.EventHandler(this.TeamA_Box_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Против";
            // 
            // OpenWaitResultMatches
            // 
            this.OpenWaitResultMatches.Location = new System.Drawing.Point(13, 335);
            this.OpenWaitResultMatches.Name = "OpenWaitResultMatches";
            this.OpenWaitResultMatches.Size = new System.Drawing.Size(171, 47);
            this.OpenWaitResultMatches.TabIndex = 8;
            this.OpenWaitResultMatches.Text = "Посмотреть матчи  ожидающие результата";
            this.OpenWaitResultMatches.UseVisualStyleBackColor = true;
            this.OpenWaitResultMatches.Click += new System.EventHandler(this.OpenWaitResultMatches_Click);
            // 
            // DisciplinePanel
            // 
            this.DisciplinePanel.Controls.Add(this.ChangeDiscipline);
            this.DisciplinePanel.Controls.Add(this.RocketLeague_Radio);
            this.DisciplinePanel.Controls.Add(this.CSGO_Radio);
            this.DisciplinePanel.Controls.Add(this.FootBall_Radio);
            this.DisciplinePanel.Location = new System.Drawing.Point(23, 12);
            this.DisciplinePanel.Name = "DisciplinePanel";
            this.DisciplinePanel.Size = new System.Drawing.Size(148, 100);
            this.DisciplinePanel.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Обучение Нейронной сети";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 49);
            this.button2.TabIndex = 11;
            this.button2.Text = "Тест Нейронной сети";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LearningProgressPanel
            // 
            this.LearningProgressPanel.Controls.Add(this.progressBar1);
            this.LearningProgressPanel.Location = new System.Drawing.Point(12, 388);
            this.LearningProgressPanel.Name = "LearningProgressPanel";
            this.LearningProgressPanel.Size = new System.Drawing.Size(773, 60);
            this.LearningProgressPanel.TabIndex = 12;
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LearningProgressPanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DisciplinePanel);
            this.Controls.Add(this.OpenWaitResultMatches);
            this.Controls.Add(this.VangaPanel);
            this.Name = "MainWindows";
            this.Text = "Vanga 0.73";
            this.VangaPanel.ResumeLayout(false);
            this.VangaPanel.PerformLayout();
            this.LastFiveMatchesA.ResumeLayout(false);
            this.LastFiveMatchesB.ResumeLayout(false);
            this.DisciplinePanel.ResumeLayout(false);
            this.DisciplinePanel.PerformLayout();
            this.LearningProgressPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton FootBall_Radio;
        private System.Windows.Forms.RadioButton CSGO_Radio;
        private System.Windows.Forms.RadioButton RocketLeague_Radio;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ChangeDiscipline;
        private System.Windows.Forms.Label Label_TeamA;
        private System.Windows.Forms.Label Label_TeamB;
        private System.Windows.Forms.Panel VangaPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TeamB_Box;
        private System.Windows.Forms.ComboBox TeamA_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel LastFiveMatchesA;
        private System.Windows.Forms.Panel FirstMatchPanelA;
        private System.Windows.Forms.Button AddMatch_TeamA;
        private System.Windows.Forms.Panel SecondMatchPanelA;
        private System.Windows.Forms.Panel FifthMatchPanelA;
        private System.Windows.Forms.Panel ThirdMatchPanelA;
        private System.Windows.Forms.Panel FourthMatchPanelA;
        private System.Windows.Forms.Panel LastFiveMatchesB;
        private System.Windows.Forms.Panel FirstMatchPanelB;
        private System.Windows.Forms.Button AddMatch_TeamB;
        private System.Windows.Forms.Panel SecondMatchPanelB;
        private System.Windows.Forms.Panel FifthMatchTotalB;
        private System.Windows.Forms.Panel ThirdMatchPanelB;
        private System.Windows.Forms.Panel FourthMatchPanelB;
        private System.Windows.Forms.Button OpenWaitResultMatches;
        private System.Windows.Forms.Panel DisciplinePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel LearningProgressPanel;
    }
}

