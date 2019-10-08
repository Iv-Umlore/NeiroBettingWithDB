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
            this.NetworkLearning = new System.Windows.Forms.Button();
            this.TestNetwork = new System.Windows.Forms.Button();
            this.LearningProgressPanel = new System.Windows.Forms.Panel();
            this.MatchesCount = new System.Windows.Forms.Label();
            this.MatchesCountLabel = new System.Windows.Forms.Label();
            this.CountOfCircle = new System.Windows.Forms.Label();
            this.NumberOfCircleValue = new System.Windows.Forms.Label();
            this.CircleCountLabel = new System.Windows.Forms.Label();
            this.AverageResultValue = new System.Windows.Forms.Label();
            this.AverageResultLabel = new System.Windows.Forms.Label();
            this.PredictionPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HardRisk = new System.Windows.Forms.Label();
            this.HardPrediction = new System.Windows.Forms.Label();
            this.ResultHardLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MediumRisk = new System.Windows.Forms.Label();
            this.MediumPrediction = new System.Windows.Forms.Label();
            this.ResultMediumLabel = new System.Windows.Forms.Label();
            this.FirstPredictionPanel = new System.Windows.Forms.Panel();
            this.EasyRisk = new System.Windows.Forms.Label();
            this.EasyPrediction = new System.Windows.Forms.Label();
            this.ResultEasyLabel = new System.Windows.Forms.Label();
            this.AddTeam = new System.Windows.Forms.Button();
            this.GetPrediction = new System.Windows.Forms.Button();
            this.ReloadWeights = new System.Windows.Forms.Button();
            this.SaveWeights = new System.Windows.Forms.Button();
            this.VangaPanel.SuspendLayout();
            this.LastFiveMatchesA.SuspendLayout();
            this.LastFiveMatchesB.SuspendLayout();
            this.DisciplinePanel.SuspendLayout();
            this.LearningProgressPanel.SuspendLayout();
            this.PredictionPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.FirstPredictionPanel.SuspendLayout();
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
            this.progressBar1.Size = new System.Drawing.Size(770, 23);
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
            this.ChangeDiscipline.Click += new System.EventHandler(this.ChangeDiscipline_Click);
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
            this.AddMatch_TeamA.Click += new System.EventHandler(this.AddMatch_TeamA_Click);
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
            this.AddMatch_TeamB.Click += new System.EventHandler(this.AddMatch_TeamB_Click);
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
            this.OpenWaitResultMatches.Location = new System.Drawing.Point(15, 208);
            this.OpenWaitResultMatches.Name = "OpenWaitResultMatches";
            this.OpenWaitResultMatches.Size = new System.Drawing.Size(169, 47);
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
            // NetworkLearning
            // 
            this.NetworkLearning.Location = new System.Drawing.Point(15, 279);
            this.NetworkLearning.Name = "NetworkLearning";
            this.NetworkLearning.Size = new System.Drawing.Size(88, 47);
            this.NetworkLearning.TabIndex = 10;
            this.NetworkLearning.Text = "Обучение Нейронной сети";
            this.NetworkLearning.UseVisualStyleBackColor = true;
            this.NetworkLearning.Click += new System.EventHandler(this.NetworkLearning_Click);
            // 
            // TestNetwork
            // 
            this.TestNetwork.Location = new System.Drawing.Point(109, 279);
            this.TestNetwork.Name = "TestNetwork";
            this.TestNetwork.Size = new System.Drawing.Size(88, 47);
            this.TestNetwork.TabIndex = 11;
            this.TestNetwork.Text = "Тест Нейронной сети";
            this.TestNetwork.UseVisualStyleBackColor = true;
            this.TestNetwork.Click += new System.EventHandler(this.TestNetwork_Click);
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
            this.LearningProgressPanel.Location = new System.Drawing.Point(12, 388);
            this.LearningProgressPanel.Name = "LearningProgressPanel";
            this.LearningProgressPanel.Size = new System.Drawing.Size(776, 60);
            this.LearningProgressPanel.TabIndex = 12;
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
            this.MatchesCountLabel.Location = new System.Drawing.Point(343, 11);
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
            // PredictionPanel
            // 
            this.PredictionPanel.Controls.Add(this.panel2);
            this.PredictionPanel.Controls.Add(this.panel1);
            this.PredictionPanel.Controls.Add(this.FirstPredictionPanel);
            this.PredictionPanel.Location = new System.Drawing.Point(462, 385);
            this.PredictionPanel.Name = "PredictionPanel";
            this.PredictionPanel.Size = new System.Drawing.Size(326, 63);
            this.PredictionPanel.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HardRisk);
            this.panel2.Controls.Add(this.HardPrediction);
            this.panel2.Controls.Add(this.ResultHardLabel);
            this.panel2.Location = new System.Drawing.Point(216, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 57);
            this.panel2.TabIndex = 2;
            // 
            // HardRisk
            // 
            this.HardRisk.AutoSize = true;
            this.HardRisk.Location = new System.Drawing.Point(65, 34);
            this.HardRisk.Name = "HardRisk";
            this.HardRisk.Size = new System.Drawing.Size(28, 13);
            this.HardRisk.TabIndex = 2;
            this.HardRisk.Text = "0.83";
            // 
            // HardPrediction
            // 
            this.HardPrediction.AutoSize = true;
            this.HardPrediction.Location = new System.Drawing.Point(7, 34);
            this.HardPrediction.Name = "HardPrediction";
            this.HardPrediction.Size = new System.Drawing.Size(48, 13);
            this.HardPrediction.TabIndex = 1;
            this.HardPrediction.Text = "П1 + 1,5";
            // 
            // ResultHardLabel
            // 
            this.ResultHardLabel.AutoSize = true;
            this.ResultHardLabel.Location = new System.Drawing.Point(4, 10);
            this.ResultHardLabel.Name = "ResultHardLabel";
            this.ResultHardLabel.Size = new System.Drawing.Size(98, 13);
            this.ResultHardLabel.TabIndex = 0;
            this.ResultHardLabel.Text = "Результат + риск:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MediumRisk);
            this.panel1.Controls.Add(this.MediumPrediction);
            this.panel1.Controls.Add(this.ResultMediumLabel);
            this.panel1.Location = new System.Drawing.Point(107, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 57);
            this.panel1.TabIndex = 1;
            // 
            // MediumRisk
            // 
            this.MediumRisk.AutoSize = true;
            this.MediumRisk.Location = new System.Drawing.Point(65, 34);
            this.MediumRisk.Name = "MediumRisk";
            this.MediumRisk.Size = new System.Drawing.Size(28, 13);
            this.MediumRisk.TabIndex = 2;
            this.MediumRisk.Text = "0.83";
            // 
            // MediumPrediction
            // 
            this.MediumPrediction.AutoSize = true;
            this.MediumPrediction.Location = new System.Drawing.Point(2, 34);
            this.MediumPrediction.Name = "MediumPrediction";
            this.MediumPrediction.Size = new System.Drawing.Size(48, 13);
            this.MediumPrediction.TabIndex = 1;
            this.MediumPrediction.Text = "П1 + 1,5";
            // 
            // ResultMediumLabel
            // 
            this.ResultMediumLabel.AutoSize = true;
            this.ResultMediumLabel.Location = new System.Drawing.Point(2, 10);
            this.ResultMediumLabel.Name = "ResultMediumLabel";
            this.ResultMediumLabel.Size = new System.Drawing.Size(98, 13);
            this.ResultMediumLabel.TabIndex = 0;
            this.ResultMediumLabel.Text = "Результат + риск:";
            // 
            // FirstPredictionPanel
            // 
            this.FirstPredictionPanel.Controls.Add(this.EasyRisk);
            this.FirstPredictionPanel.Controls.Add(this.EasyPrediction);
            this.FirstPredictionPanel.Controls.Add(this.ResultEasyLabel);
            this.FirstPredictionPanel.Location = new System.Drawing.Point(3, 3);
            this.FirstPredictionPanel.Name = "FirstPredictionPanel";
            this.FirstPredictionPanel.Size = new System.Drawing.Size(101, 57);
            this.FirstPredictionPanel.TabIndex = 0;
            // 
            // EasyRisk
            // 
            this.EasyRisk.AutoSize = true;
            this.EasyRisk.Location = new System.Drawing.Point(67, 34);
            this.EasyRisk.Name = "EasyRisk";
            this.EasyRisk.Size = new System.Drawing.Size(28, 13);
            this.EasyRisk.TabIndex = 2;
            this.EasyRisk.Text = "0.83";
            // 
            // EasyPrediction
            // 
            this.EasyPrediction.AutoSize = true;
            this.EasyPrediction.Location = new System.Drawing.Point(3, 34);
            this.EasyPrediction.Name = "EasyPrediction";
            this.EasyPrediction.Size = new System.Drawing.Size(48, 13);
            this.EasyPrediction.TabIndex = 1;
            this.EasyPrediction.Text = "П1 + 1,5";
            // 
            // ResultEasyLabel
            // 
            this.ResultEasyLabel.AutoSize = true;
            this.ResultEasyLabel.Location = new System.Drawing.Point(0, 10);
            this.ResultEasyLabel.Name = "ResultEasyLabel";
            this.ResultEasyLabel.Size = new System.Drawing.Size(98, 13);
            this.ResultEasyLabel.TabIndex = 0;
            this.ResultEasyLabel.Text = "Результат + риск:";
            // 
            // AddTeam
            // 
            this.AddTeam.Location = new System.Drawing.Point(15, 118);
            this.AddTeam.Name = "AddTeam";
            this.AddTeam.Size = new System.Drawing.Size(169, 39);
            this.AddTeam.TabIndex = 14;
            this.AddTeam.Text = "Добавить команду";
            this.AddTeam.UseVisualStyleBackColor = true;
            this.AddTeam.Click += new System.EventHandler(this.AddTeam_Click);
            // 
            // GetPrediction
            // 
            this.GetPrediction.Location = new System.Drawing.Point(15, 163);
            this.GetPrediction.Name = "GetPrediction";
            this.GetPrediction.Size = new System.Drawing.Size(169, 39);
            this.GetPrediction.TabIndex = 15;
            this.GetPrediction.Text = "Предсказать исход";
            this.GetPrediction.UseVisualStyleBackColor = true;
            this.GetPrediction.Click += new System.EventHandler(this.GetPrediction_Click);
            // 
            // ReloadWeights
            // 
            this.ReloadWeights.Location = new System.Drawing.Point(109, 332);
            this.ReloadWeights.Name = "ReloadWeights";
            this.ReloadWeights.Size = new System.Drawing.Size(88, 47);
            this.ReloadWeights.TabIndex = 16;
            this.ReloadWeights.Text = "Сбросить значение весов";
            this.ReloadWeights.UseVisualStyleBackColor = true;
            this.ReloadWeights.Click += new System.EventHandler(this.ReloadWeights_Click);
            // 
            // SaveWeights
            // 
            this.SaveWeights.Location = new System.Drawing.Point(15, 332);
            this.SaveWeights.Name = "SaveWeights";
            this.SaveWeights.Size = new System.Drawing.Size(88, 47);
            this.SaveWeights.TabIndex = 17;
            this.SaveWeights.Text = "Сохранить текущие настройки";
            this.SaveWeights.UseVisualStyleBackColor = true;
            this.SaveWeights.Click += new System.EventHandler(this.SaveWeights_Click);
            // 
            // MainWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.SaveWeights);
            this.Controls.Add(this.ReloadWeights);
            this.Controls.Add(this.GetPrediction);
            this.Controls.Add(this.AddTeam);
            this.Controls.Add(this.PredictionPanel);
            this.Controls.Add(this.LearningProgressPanel);
            this.Controls.Add(this.TestNetwork);
            this.Controls.Add(this.NetworkLearning);
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
            this.LearningProgressPanel.PerformLayout();
            this.PredictionPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.FirstPredictionPanel.ResumeLayout(false);
            this.FirstPredictionPanel.PerformLayout();
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
        private System.Windows.Forms.Button NetworkLearning;
        private System.Windows.Forms.Button TestNetwork;
        private System.Windows.Forms.Panel LearningProgressPanel;
        private System.Windows.Forms.Label AverageResultLabel;
        private System.Windows.Forms.Label CountOfCircle;
        private System.Windows.Forms.Label NumberOfCircleValue;
        private System.Windows.Forms.Label CircleCountLabel;
        private System.Windows.Forms.Label AverageResultValue;
        private System.Windows.Forms.Panel PredictionPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label HardRisk;
        private System.Windows.Forms.Label HardPrediction;
        private System.Windows.Forms.Label ResultHardLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MediumRisk;
        private System.Windows.Forms.Label MediumPrediction;
        private System.Windows.Forms.Label ResultMediumLabel;
        private System.Windows.Forms.Panel FirstPredictionPanel;
        private System.Windows.Forms.Label EasyRisk;
        private System.Windows.Forms.Label EasyPrediction;
        private System.Windows.Forms.Label ResultEasyLabel;
        private System.Windows.Forms.Button AddTeam;
        private System.Windows.Forms.Button GetPrediction;
        private System.Windows.Forms.Label MatchesCount;
        private System.Windows.Forms.Label MatchesCountLabel;
        private System.Windows.Forms.Button ReloadWeights;
        private System.Windows.Forms.Button SaveWeights;
    }
}

