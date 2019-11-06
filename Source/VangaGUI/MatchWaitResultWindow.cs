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
    public partial class MatchWaitResultWindow : Form
    {
        private BridgeToInterfaceController BIC;
        public MatchWaitResultWindow(BridgeToInterfaceController _mainController)
        {
            BIC = _mainController;
            InitializeComponent();
        }

        private void EndLerning_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
