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
            FootBall_Radio.Focus();
            ChangeController();
        }

        private void ChangeController(int type = 1)
        {
            _mainController = new BridgeToInterfaceController();
        }

        private void TeamB_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            // Открыть новое окно, вызвать оттуда AddNewTeam
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
            // Открыть окно и добавить турнир
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
    }
}
