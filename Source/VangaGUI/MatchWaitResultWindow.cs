using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BridgeToInterface;
using ProjectHelper;

namespace VangaGUI
{
    public partial class MatchWaitResultWindow : Form
    {
        private BridgeToInterfaceController BIC;
        private Dictionary<string, MatchWaitResult> matches;

        public MatchWaitResultWindow(BridgeToInterfaceController _mainController)
        {
            BIC = _mainController;
            matches = new Dictionary<string, MatchWaitResult>();
            InitializeComponent();
        }

        private void EndLerning_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MyMatchWaitResult_Click(object sender, EventArgs e)
        {
            var results = BIC.GetWaitResultMatches();
            matches.Clear();
            MyMatchWaitResult.Items.Clear();
            foreach (var res in results)
            {
                var value = string.Format("{0} vs {1} | date: {2}", res.TeamA.Team_name, res.TeamB.Team_name, res.date.ToString());
                matches.Add(value, res);
                MyMatchWaitResult.Items.Add(value);
            }
        }

        private void MyMatchWaitResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            var key = MyMatchWaitResult.SelectedItem.ToString();
            var MWRes = matches.First(it => it.Key == key).Value;

            var predictions = MWRes.Prediction.Split(';');

            statisticPredictTexBox.Text = predictions[0];
            HardPredictTextBox.Text = predictions[1];
            PredictTextBox.Text = predictions[2];
            SavePredictTextBox.Text = predictions[3];            
        }

        private void AddResult_Click(object sender, EventArgs e)
        {
            var key = MyMatchWaitResult.SelectedItem.ToString();
            var MWRes = matches.First(it => it.Key == key).Value;

            var addMatchWindow = new AddMatch(BIC, MWRes);
            addMatchWindow.ShowDialog();

            MyMatchWaitResult.Items.Clear();
            matches.Clear();
        }

        private void DeleteMatch_Click(object sender, EventArgs e)
        {

        }
    }
}
