using System;
using System.Windows.Forms;

namespace MashupView
{
    public partial class TFormAbout : Form
    {
        public TFormAbout() : base()
        {
            InitializeComponent();
        }
        private void TFormSearch_FormClosing(object Sender, FormClosingEventArgs E)
        {
            E.Cancel = true;
            Hide();
        }
    }
}
