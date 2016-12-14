using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class frmCreditCard : Form
    {
        public bool ccNumber = false;
        public bool ccExpMonth = false;
        public bool ccExpYear = false;
        public frmCreditCard()
        {
            InitializeComponent();
        }

        private void frmCreditCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgResult;
            dlgResult = MessageBox.Show("Confirm Cancel?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            if (dlgResult == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void btnOkEnabled()
        {
            if (ccNumber == true && ccExpMonth == true && ccExpYear == true)
            {
                btnOK.Enabled = true;
            }
        }

        private void drpExpMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            ccExpMonth = true;
            btnOkEnabled();
        }

        private void drpExpYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            ccExpYear = true;
            btnOkEnabled();
        }

        private void mtbCCnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57) // 0-9
            {

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("NUMBERS ONLY");
            }
            ccNumber = true;
            btnOkEnabled();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
