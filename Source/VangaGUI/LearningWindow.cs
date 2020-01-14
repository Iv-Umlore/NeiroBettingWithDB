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
            MatchesCount.Text = BIC.DownloadInfoForTest().ToString();
            MatchesCount.Refresh();
            var loopCount = int.Parse((LoopCount.Text == string.Empty)? "1": LoopCount.Text);
            LearningStatus.Maximum = loopCount;              
            NumberOfCircleValue.Text = 0 + " из " + loopCount;
            for (int i = 0; i <= loopCount; i++)
            {
                NumberOfCircleValue.Text = i + " из " + loopCount;
                NumberOfCircleValue.Refresh();
                BIC.LearningNetwork();
                LearningStatus.Value = i;
            }
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
