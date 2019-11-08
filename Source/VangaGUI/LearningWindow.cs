using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BridgeToInterface;

namespace VangaGUI
{
    public partial class LearningWindow : Form
    {
        private BridgeToInterfaceController BIC;
        public LearningWindow(BridgeToInterfaceController _mainController)
        {
            BIC = _mainController;
            InitializeComponent();
        }

        private void NetworkLearning_Click(object sender, EventArgs e)
        {

            BIC.LearningNetwork();
        }

        private void TestNetwork_Click(object sender, EventArgs e)
        {
            var result = BIC.TestNetwork();
            MatchesCount.Text = BIC.MatchesCount.ToString();
            AverageResultValue.Text = result.ToString();
        }

        private void ReloadWeights_Click(object sender, EventArgs e)
        {
            BIC.ReloadWeights();
        }

        private void SaveWeights_Click(object sender, EventArgs e)
        {
            BIC.SaveCurrentWeights();
        }

        private void EndLerning_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
