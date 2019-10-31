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
    public partial class AddNewTeam : Form
    {
        private BridgeToInterfaceController _mainController;
        public AddNewTeam(BridgeToInterfaceController controller)
        {
            InitializeComponent();
            _mainController = controller;
            tier_team.Text = "8";
        }

        private void CanselButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            _mainController.AddNewTeam(teamAbbr.Text, TeamName.Text, int.Parse(tier_team.Text), 0);
            Close();
        }

        private void TeamName_TextChanged(object sender, EventArgs e)
        {
            teamAbbr.Text = TeamName.Text.Take(4).ToString();
        }
    }
}
