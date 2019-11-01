using BridgeToInterface;
using ProjectHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VangaGUI
{
    public partial class MainWindows : Form
    {

        private BridgeToInterfaceController _mainController;

        public MainWindows()
        {
            InitializeComponent();
            FootBall_Radio.Select();
            ChangeController();
        }

        private void ChangeController(int type = 1)
        {
            _mainController = new BridgeToInterfaceController();
        }
        
        private void OpenWaitResultMatches_Click(object sender, EventArgs e)
        {
            MatchesCount.Text = "250";
        }

        private void GetPrediction_Click(object sender, EventArgs e)
        {
            PredictionPanel.Show();
            LearningProgressPanel.Hide();
        }

        private void AddTeam_Click(object sender, EventArgs e)
        {
            var wind = new AddNewTeam(_mainController);
            wind.Show();
        }

        private void AddMatch_TeamA_Click(object sender, EventArgs e)
        {
            // Открыть новое окно, вызвать оттуда SaveMatchResult с кодом 0
        }

        private void AddMatch_TeamB_Click(object sender, EventArgs e)
        {
            // Открыть новое окно, вызвать оттуда SaveLastMatchresult
        }

        private void TestNetwork_Click(object sender, EventArgs e)
        {
            var result = _mainController.TestNetwork();
            MatchesCount.Text = _mainController.MatchesCount.ToString();
            AverageResultValue.Text = result.ToString();
        }

        private void NetworkLearning_Click(object sender, EventArgs e)
        {
            PredictionPanel.Hide();
            LearningProgressPanel.Show();
            _mainController.LearningNetwork();
        }

        private void ChangeDiscipline_Click(object sender, EventArgs e)
        {
            _mainController.ChangeDiscipline(Discipline.Football);
        }

        private void SaveWeights_Click(object sender, EventArgs e)
        {
            _mainController.SaveCurrentWeights();
        }

        private void ReloadWeights_Click(object sender, EventArgs e)
        {
            _mainController.ReloadWeights();
        }

        private void AddTournament_Click(object sender, EventArgs e)
        {
            var wind = new AddNewTournament(_mainController);
            wind.Show();
        }
        
        private void TeamB_Box_Click(object sender, EventArgs e)
        {
            TeamB_Box.Items.Clear();
            var list = new List<string>();
            if (TeamA_Box.SelectedItem == null)
                list = _mainController.GetTeamList();
            else list = _mainController.GetTeamList(TeamA_Box.SelectedItem.ToString());
            foreach (var name in list)
                TeamB_Box.Items.Add(name);
        }

        private void TeamA_Box_Click(object sender, EventArgs e)
        {
            TeamA_Box.Items.Clear();
            var list = new List<string>();
            if (TeamB_Box.SelectedItem == null)
                list = _mainController.GetTeamList();
            else list = _mainController.GetTeamList(TeamB_Box.SelectedItem.ToString());
            foreach (var name in list)
                TeamA_Box.Items.Add(name);
        }

        private void TournamentBox_Click(object sender, EventArgs e)
        {
            TournamentBox.Items.Clear();
            var list = _mainController.GetTournamentList();
            foreach (var tournament in list)
                TournamentBox.Items.Add(tournament);                
        }

        private void TeamA_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = _mainController.GetLastFiveMatch(true, TeamA_Box.Text);
            A1.Text = (list.Count > 0) ? String.Format("{0} | {1} {2} vs {3} {4}", GetDate(list[0].match_date), list[0].Name_A, list[0].Score_A, list[0].Score_B, list[0].Name_B) : "Отсутствует";
            A2.Text = (list.Count > 1) ? String.Format("{0} | {1} {2} vs {3} {4}", GetDate(list[1].match_date), list[1].Name_A, list[1].Score_A, list[1].Score_B, list[1].Name_B) : "Отсутствует";
            A3.Text = (list.Count > 2) ? String.Format("{0} | {1} {2} vs {3} {4}", GetDate(list[2].match_date), list[2].Name_A, list[2].Score_A, list[2].Score_B, list[2].Name_B) : "Отсутствует";
            A4.Text = (list.Count > 3) ? String.Format("{0} | {1} {2} vs {3} {4}", GetDate(list[3].match_date), list[3].Name_A, list[3].Score_A, list[3].Score_B, list[3].Name_B) : "Отсутствует";
            A5.Text = (list.Count > 4) ? String.Format("{0} | {1} {2} vs {3} {4}", GetDate(list[4].match_date), list[4].Name_A, list[4].Score_A, list[4].Score_B, list[4].Name_B) : "Отсутствует";
        }

        private void TeamB_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = _mainController.GetLastFiveMatch(false, TeamB_Box.Text);
            B1.Text = (list.Count > 0) ? String.Format("{0} | {1} {2} vs {3} {4}", GetDate(list[0].match_date), list[0].Name_A, list[0].Score_A, list[0].Score_B, list[0].Name_B) : "Отсутствует";
            B2.Text = (list.Count > 1) ? String.Format("{0} | {1} {2} vs {3} {4}", GetDate(list[1].match_date), list[1].Name_A, list[1].Score_A, list[1].Score_B, list[1].Name_B) : "Отсутствует";
            B3.Text = (list.Count > 2) ? String.Format("{0} | {1} {2} vs {3} {4}", GetDate(list[2].match_date), list[2].Name_A, list[2].Score_A, list[2].Score_B, list[2].Name_B) : "Отсутствует";
            B4.Text = (list.Count > 3) ? String.Format("{0} | {1} {2} vs {3} {4}", GetDate(list[3].match_date), list[3].Name_A, list[3].Score_A, list[3].Score_B, list[3].Name_B) : "Отсутствует";
            B5.Text = (list.Count > 4) ? String.Format("{0} | {1} {2} vs {3} {4}", GetDate(list[4].match_date), list[4].Name_A, list[4].Score_A, list[4].Score_B, list[4].Name_B) : "Отсутствует";

        }

        private string GetDate(DateTime dt)
        {
            return String.Format("{0}.{1}.{2}", dt.Day, dt.Month, dt.Year);
        }
    }
}
