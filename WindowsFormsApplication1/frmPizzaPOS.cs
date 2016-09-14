using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPizzaPOS : Form
    {
        public frmPizzaPOS()
        {
            InitializeComponent();
        }
                
        private void tmrDT_Tick(object sender, EventArgs e)
        {
            lblTimeDate.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        private void frmPizzaPOS_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgResult;
            dlgResult = MessageBox.Show("Confirm Exit", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            if (dlgResult == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
