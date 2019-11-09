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
    public partial class AddMatch : Form
    {
        private BridgeToInterfaceController _mainController;
        private bool isGoodMatch;
        public AddMatch(BridgeToInterfaceController BIC, MatchWaitResult waitR = null)
        {
            isGoodMatch = false;
            _mainController = BIC;
            InitializeComponent();
            if (waitR != null)
            {
                isGoodMatch = true;
                TournamentBox.Text = waitR.Tournament.Tournament_name;
                TournamentBox.Enabled = false;
                TeamA_Box.Enabled = false;
                TeamA_Box.Text = waitR.TeamA.Team_name;
                TeamB_Box.Enabled = false;
                TeamB_Box.Text = waitR.TeamB.Team_name;

                Replace_A.Enabled = false;
                Replace_A.Text = waitR.ReplasmentA.ToString();
                Replace_B.Enabled = false;
                Replace_B.Text = waitR.ReplasmentB.ToString();

                Impotant_A_comboBox.Enabled = false;
                Impotant_A_comboBox.Text = waitR.ImportantA.ToString();
                Impotant_B_comboBox.Enabled = false;
                Impotant_B_comboBox.Text = waitR.ImportantB.ToString();

                DatePicker.Enabled = false;
                DatePicker.Value = waitR.date;

                isGoodMatch = true;
            }
            else
            {
                Impotant_A_comboBox.Items.AddRange(new string[] { "1", "2", "3" });
                Impotant_B_comboBox.Items.AddRange(new string[] { "1", "2", "3" });
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            var date = new DateTime();
            var parameters = GetAllParameters(out date);
            bool flag = true;
            for (int i = 0; i < 15; i++)
                if (parameters[i] == null || parameters[i] == "") flag = false;
            if (flag)
                _mainController.SaveLastMatchResult(isGoodMatch, date, parameters);
            Close();
        }

        private void Cansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TeamA_Box_Click(object sender, EventArgs e)
        {
            TeamA_Box.Items.Clear();
            var list = new List<string>();
            if (TeamB_Box.SelectedItem == null)
                list = _mainController.GetTeamList();
            else list = _mainController.GetTeamList(TeamB_Box.SelectedItem.ToString());
            list.Sort();
            foreach (var name in list)
                TeamA_Box.Items.Add(name);
        }

        private void TeamB_Box_Click(object sender, EventArgs e)
        {
            TeamB_Box.Items.Clear();
            var list = new List<string>();
            if (TeamA_Box.SelectedItem == null)
                list = _mainController.GetTeamList();
            else list = _mainController.GetTeamList(TeamA_Box.SelectedItem.ToString());
            list.Sort();
            foreach (var name in list)
                TeamB_Box.Items.Add(name);
        }

        private void AddTournament_Click(object sender, EventArgs e)
        {
            var wind = new AddNewTournament(_mainController);
            wind.Show();
        }

        private void AddTeam_Click(object sender, EventArgs e)
        {
            var wind = new AddNewTeam(_mainController);
            wind.Show();
        }

        private void TournamentBox_Click(object sender, EventArgs e)
        {
            TournamentBox.Items.Clear();
            var list = _mainController.GetTournamentList();
            foreach (var tournament in list)
                TournamentBox.Items.Add(tournament);
        }

        private string[] GetAllParameters(out DateTime dateTime)
        {
            var parameters = new string[15];

            parameters[0] = TournamentBox.Text;
            parameters[1] = TeamA_Box.Text;
            parameters[2] = TeamB_Box.Text;
            parameters[3] = Replace_A.Text;
            parameters[4] = Replace_B.Text;
            parameters[5] = Impotant_A_comboBox.Text;
            parameters[6] = Impotant_B_comboBox.Text;
            parameters[7] = Score_A.Text;
            parameters[8] = Score_B.Text;
            parameters[9] = Shot_on_target_A.Text;
            parameters[10] = Shot_on_target_B.Text;
            parameters[11] = Save_A.Text;
            parameters[12] = Save_B.Text;
            parameters[13] = Violations_A.Text;
            parameters[14] = Violations_B.Text;
            dateTime = DatePicker.Value;

            return parameters;
        }

    }
}
