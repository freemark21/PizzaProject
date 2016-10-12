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
        public int orderTotal;
        public double taxRate = 7.5;
        public frmPizzaPOS()
        {
            InitializeComponent();
        }
                
        private void tmrDT_Tick(object sender, EventArgs e) //Date & Time populated into label
        {
            lblTimeDate.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        private void mtbPhone_Leave(object sender, EventArgs e) //Phone number validation
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

        private void frmPizzaPOS_FormClosing_1(object sender, FormClosingEventArgs e) //Close() event
        {
            DialogResult dlgResult;
            dlgResult = MessageBox.Show("Confirm Exit", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button2);
            if (dlgResult == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e) //Close button
        {
            Close();
        }

        private void txtCustName_KeyPress(object sender, KeyPressEventArgs e) //Keypress validation
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

        private void txtCustName_Leave(object sender, EventArgs e) //Required field
        {
            if (txtCustName.Text.Length >= 5)
            {
                txtCustName.ForeColor = Color.Black;
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "This is a required field";
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
            else if (e.KeyChar >= 48 && e.KeyChar <= 57) //0-9
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
            else if (e.KeyChar >= 48 && e.KeyChar <= 57) //0-9
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

        private void btnReset_Click(object sender, EventArgs e) //Reset button
        {
            Reset();
        }

        private void txtAddress1_Leave(object sender, EventArgs e) //Required field
        {
            if (txtAddress1.Text.Length >= 5)
            {
                txtAddress1.ForeColor = Color.Black;
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "This is a required field.";
                txtAddress1.Focus();
                txtAddress1.ForeColor = Color.Red;
            }
        }

        private void txtCity_Leave(object sender, EventArgs e) //Required field
        {
            if (txtCity.Text.Length >= 2)
            {
                txtCity.ForeColor = Color.Black;
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "This is a required field.";
                txtCity.Focus();
                txtCity.ForeColor = Color.Red;
            }
        }

        private void rdoSmall_CheckedChanged(object sender, EventArgs e)
        {
            Pricing();
        }

        public void Pricing()
        {
            orderTotal = 0;
            if (rdoSmall.Checked)
            {
                orderTotal += 8;
            }
            else if (rdoMedium.Checked)
            {
                orderTotal += 10;
            }
            else
            {
                orderTotal += 15;
            }

            if (chkBolive.Checked)
            {
                orderTotal += 1;
            }
            if (chkBpepper.Checked)
            {
                orderTotal += 1;
            }
            if (chkGolive.Checked)
            {
                orderTotal += 1;
            }
            if (chkHam.Checked)
            {
                orderTotal += 1;
            }
            if (chkJalepeno.Checked)
            {
                orderTotal += 1;
            }
            if (chkMushrooms.Checked)
            {
                orderTotal += 1;
            }
            if (chkOnion.Checked)
            {
                orderTotal += 1;
            }
            if (chkPep.Checked)
            {
                orderTotal += 1;
            }
            if (chkPineapple.Checked)
            {
                orderTotal += 1;
            }
            if (chkSausage.Checked)
            {
                orderTotal += 1;
            }
            orderTotal *= Convert.ToInt32(nudQty.Value);
            lblTotal.Text = "TOTAL\n" + orderTotal.ToString("c");
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            Pricing();
        }

        public void Reset()
        {
            mtbPhone.Text = String.Empty;
            txtCustName.Text = String.Empty;
            txtAddress1.Text = String.Empty;
            txtAddress2.Text = String.Empty;
            txtCity.Text = String.Empty;
            //drpState.
            mtbZip.Text = String.Empty;
            nudQty.Value = 1;
            lblError.Text = String.Empty;
            rdoMedium.Checked = true;
            chkPep.Checked = true;
            chkBolive.Checked = false;
            chkBpepper.Checked = false;
            chkGolive.Checked = false;
            chkHam.Checked = false;
            chkJalepeno.Checked = false;
            chkMushrooms.Checked = false;
            chkOnion.Checked = false;
            chkPineapple.Checked = false;
            chkSausage.Checked = false;
            Pricing();
        }

        private void frmPizzaPOS_Load(object sender, EventArgs e)
        {
            Reset();
            string filePath = Application.StartupPath + "/../../../StateAbbrev.txt";
            string currentState;
            try
            {
                FileStream fsStates = new FileStream(filePath, FileMode.Open);
                StreamReader srStates = new StreamReader(fsStates);
                while (!srStates.EndOfStream)
                {
                    currentState = srStates.ReadLine();
                    drpState.Items.Add(currentState);
                }
            }
            catch
            {
                MessageBox.Show("Error getting list of States");
            }
        }
    }
}