using BridgeToInterface;
using System;
using System.Windows.Forms;

namespace VangaGUI
{
    public partial class AddNewTournament : Form
    {
        private BridgeToInterfaceController _mainController;
        
            public AddNewTournament(BridgeToInterfaceController controller)
            {
                InitializeComponent();
                _mainController = controller;
                TournamentSize.Text = "1";
            }

        private void Send_Click(object sender, EventArgs e)
        {
            _mainController.AddNewTournament(TournamentName.Text, int.Parse(TournamentSize.Text));
            Close();
        }

        private void Cansel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
