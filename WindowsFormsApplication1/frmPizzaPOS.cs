using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

        private void mtbPhone_Leave(object sender, EventArgs e)
        {
            if (mtbPhone.Text.Length == 10)
            {
                mtbPhone.ForeColor = Color.Black;
                lblError.Text = "";
            }
            else
            {
                mtbPhone.Focus();
                mtbPhone.ForeColor = Color.Red;
                lblError.Text = "Please enter a valid phone number";
            }
        }

        private void frmPizzaPOS_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgResult;
            dlgResult = MessageBox.Show("Confirm Exit", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            if (dlgResult == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCustName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <=90) // A-Z
            {

            }
            else if (e.KeyChar >= 97 && e.KeyChar <=122) //a-z
            {

            }
            else if (e.KeyChar == 8) //backspace
            {

            }
            else if (e.KeyChar == 32) //spacebar
            {

            }
            else if (e.KeyChar == 127) //delete key
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCustName_Leave(object sender, EventArgs e)
        {
            if (txtCustName.Text.Length > 2)
            {
                txtCustName.ForeColor = Color.Black;
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Please enter a valid name";
                txtCustName.Focus();
                txtCustName.ForeColor = Color.Red; 
            }

        }

        private void txtAddress1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90) // A-Z
            {

            }
            else if (e.KeyChar >= 97 && e.KeyChar <= 122) //a-z
            {

            }
            else if (e.KeyChar == 8) //backspace
            {

            }
            else if (e.KeyChar == 32) //spacebar
            {

            }
            else if (e.KeyChar == 127) //delete key
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtAddress2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90) // A-Z
            {

            }
            else if (e.KeyChar >= 97 && e.KeyChar <= 122) //a-z
            {

            }
            else if (e.KeyChar == 8) //backspace
            {

            }
            else if (e.KeyChar == 32) //spacebar
            {

            }
            else if (e.KeyChar == 127) //delete key
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 65 && e.KeyChar <= 90) // A-Z
            {

            }
            else if (e.KeyChar >= 97 && e.KeyChar <= 122) //a-z
            {

            }
            else if (e.KeyChar == 8) //backspace
            {

            }
            else if (e.KeyChar == 32) //spacebar
            {

            }
            else if (e.KeyChar == 127) //delete key
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            mtbPhone.Text = String.Empty;
            txtCustName.Text = String.Empty;
            txtAddress1.Text = String.Empty;
            txtAddress2.Text = String.Empty;
            txtCity.Text = String.Empty;
            //drpState.
            mtbZip.Text = String.Empty;
            rdoMedium.Focus();
            nudQty.Value = 1;
            lblError.Text = String.Empty;
        }
    }
}