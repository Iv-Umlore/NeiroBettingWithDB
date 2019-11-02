using BridgeToInterface;
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
    public partial class PredictionWindow : Form
    {
        BridgeToInterfaceController BIC;

        public PredictionWindow(BridgeToInterfaceController controller, string team_A,string team_B, string tournament)
        {
            BIC = controller;
            InitializeComponent();
            Impotant_A_comboBox.Items.AddRange(new string[] { "1", "2", "3" });
            Impotant_B.Items.AddRange(new string[] { "1", "2", "3" });
            Tournament.Text = tournament;
            Team_A.Text = team_A;
            Team_B.Text = team_B;
        }

        private void GetPredict_Click(object sender, EventArgs e)
        {
            var parameters = new string[7];

            parameters[0] = Tournament.Text;
            parameters[1] = Team_A.Text;
            parameters[2] = Team_B.Text;
            parameters[3] = Impotant_A_comboBox.Text;
            parameters[4] = Impotant_B.Text;
            parameters[5] = Replacement_A.Text;
            parameters[6] = Replacement_B.Text;

            bool flag = true;
            for (int i = 0; i < 7; i++)
                if (parameters[i] == null || parameters[i] == "") flag = false;
            if (flag)
                BIC.GetPrediction(parameters, dateTimePicker1.Value);

            Close();
        }

        private void Calsel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
