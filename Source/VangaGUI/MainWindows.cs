using BridgeToInterface;
using ProjectHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        
        private void TeamA_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = new List<string>();
            if (TeamB_Box.SelectedItem == null)
                list = _mainController.GetTeamList();
            else list = _mainController.GetTeamList(TeamB_Box.SelectedItem.ToString());
            foreach (var name in list)
                TeamA_Box.Items.Add(name);
            
        }

        private void TeamB_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            var list = new List<string>();
            if (TeamA_Box.SelectedItem == null)
                list = _mainController.GetTeamList();
            else list = _mainController.GetTeamList(TeamA_Box.SelectedItem.ToString());
            foreach (var name in list)
                TeamB_Box.Items.Add(name);
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

        }
        
        private void AddMatch_TeamA_Click(object sender, EventArgs e)
        {

        }

        private void AddMatch_TeamB_Click(object sender, EventArgs e)
        {

        }

        private void TestNetwork_Click(object sender, EventArgs e)
        {

        }

        private void NetworkLearning_Click(object sender, EventArgs e)
        {
            PredictionPanel.Hide();
            LearningProgressPanel.Show();
        }

        private void ChangeDiscipline_Click(object sender, EventArgs e)
        {
            Console.Write("Была нажата кнопка");
        }
    }
}
