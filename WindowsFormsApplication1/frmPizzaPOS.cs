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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void lblTimeDate_Click(object sender, EventArgs e)
        {

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
