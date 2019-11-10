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
            var wind = new MatchWaitResultWindow(_mainController);
            wind.ShowDialog();
        }

        private void GetPrediction_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TeamA_Box.Text) && !string.IsNullOrEmpty(TeamB_Box.Text) && !string.IsNullOrEmpty(TournamentBox.Text))
            {
                var wind = new PredictionWindow(_mainController, TeamA_Box.Text, TeamB_Box.Text, TournamentBox.Text);
                wind.ShowDialog();
            }
        }

        private void AddTeam_Click(object sender, EventArgs e)
        {
            var wind = new AddNewTeam(_mainController);
            wind.Show();
        }

        private void AddMatch_TeamA_Click(object sender, EventArgs e)
        {
            var wind = new AddMatch(_mainController);
            wind.ShowDialog();
            TeamA_Box_SelectedIndexChanged(sender, e);
            TeamB_Box_SelectedIndexChanged(sender, e);
        }

        private void AddMatch_TeamB_Click(object sender, EventArgs e)
        {
            var wind = new AddMatch(_mainController);
            wind.ShowDialog();
            TeamA_Box_SelectedIndexChanged(sender, e);
            TeamB_Box_SelectedIndexChanged(sender, e);
        }

        private void ChangeDiscipline_Click(object sender, EventArgs e)
        {
            _mainController.ChangeDiscipline(Discipline.Football);
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
            list.Sort();
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
            list.Sort();
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
            B1.Text = (list.Count > 0) ? String.Format("{0} {1} vs {2} {3} | {4}", list[0].Name_A, list[0].Score_A, list[0].Score_B, list[0].Name_B, GetDate(list[0].match_date)) : "Отсутствует";
            B2.Text = (list.Count > 1) ? String.Format("{0} {1} vs {2} {3} | {4}", list[1].Name_A, list[1].Score_A, list[1].Score_B, list[1].Name_B, GetDate(list[1].match_date)) : "Отсутствует";
            B3.Text = (list.Count > 2) ? String.Format("{0} {1} vs {2} {3} | {4}", list[2].Name_A, list[2].Score_A, list[2].Score_B, list[2].Name_B, GetDate(list[2].match_date)) : "Отсутствует";
            B4.Text = (list.Count > 3) ? String.Format("{0} {1} vs {2} {3} | {4}", list[3].Name_A, list[3].Score_A, list[3].Score_B, list[3].Name_B, GetDate(list[3].match_date)) : "Отсутствует";
            B5.Text = (list.Count > 4) ? String.Format("{0} {1} vs {2} {3} | {4}", list[4].Name_A, list[4].Score_A, list[4].Score_B, list[4].Name_B, GetDate(list[4].match_date)) : "Отсутствует";

        }

        private string GetDate(DateTime dt)
        {
            return String.Format("{0}.{1}.{2}",
                (dt.Day < 10)? "0" + dt.Day : dt.Day.ToString(),
                (dt.Month < 10) ? "0" + dt.Month : dt.Month.ToString(),
                dt.Year);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Подумать над сохранением весов перед обучение и выход с (без) сохранением
            var wind = new LearningWindow(_mainController);
            wind.ShowDialog();
        }
    }
}
