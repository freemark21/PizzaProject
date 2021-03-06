﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace PizzaProject
{
    public partial class frmPizzaPOS : Form
    {
        public double orderTotal;
        public double taxRate = .07;
        public int orderNumber;
        public bool phoneValid = false;
        public bool nameValid = false;
        public bool addressValid = false;
        public bool cityValid = false;
        public bool zipValid = false;
        public bool custFound = false;
        public string filePath = Application.StartupPath;
        SqlConnection sqlConn;
        SqlDataAdapter sqlDAC;
        SqlDataAdapter sqlDAO;
        DataTable dtCust;
        DataTable dtOrders;
        SqlCommandBuilder sqlCmdBuilder;
        string strDataSrc = @"Data Source=(LocalDB)\MSSQLLocalDb;AttachDbFilename=|DataDirectory|Pizza.mdf;";
        string strSQLparms = "Integrated Security=True;Connect Timeout=10";


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
                phoneValid = true;
                btnAcceptEnabled();
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
                lblError.Text = "Please enter a valid character";
            }
        }

        private void txtCustName_Leave(object sender, EventArgs e) //Required field
        {
            if (txtCustName.Text.Length >= 5)
            {
                txtCustName.ForeColor = Color.Black;
                lblError.Text = "";
                nameValid = true;
                btnAcceptEnabled();
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
                lblError.Text = "Please enter a valid character";
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
                lblError.Text = "Please enter a valid character";
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
                lblError.Text = "Please enter a valid character";
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
                addressValid = true;
                btnAcceptEnabled();
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
                cityValid = true;
                btnAcceptEnabled();
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
        } //Dynamic pricing

        public void Pricing()
        {
            orderTotal = 0;
            if (rdoSmall.Checked)
            {
                orderTotal += 8;
            }
            if (rdoMedium.Checked)
            {
                orderTotal += 10;
            }
            if (rdoLarge.Checked)
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
            orderTotal = orderTotal * taxRate + orderTotal;
            lblTotal.Text = "TOTAL\n" + orderTotal.ToString("c");
        } //Pricing()

        private void btnPrice_Click(object sender, EventArgs e)
        {
            Pricing();
        } //Price button

        public void Reset()
        {
            mtbPhone.Text = String.Empty;
            txtCustName.Text = String.Empty;
            txtAddress1.Text = String.Empty;
            txtAddress2.Text = String.Empty;
            txtCity.Text = String.Empty;
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
            custFound = false;
            drpState.SelectedItem = "MN";
            Pricing();
            drpPayMethod.Text = String.Empty;
            mtbPhone.Focus();
        } //Reset()

        private void frmPizzaPOS_Load(object sender, EventArgs e) //Form load, U.S. streamreader
        {
            string sqlSelectLastOrd = "SELECT MAX(OrderNumber)FROM Orders;";
            string strConn = strDataSrc + strSQLparms;
            sqlConn = new SqlConnection(strConn);
            sqlConn.Open();
            sqlDAO = new SqlDataAdapter(sqlSelectLastOrd, sqlConn);
            dtOrders = new DataTable();
            sqlDAO.Fill(dtOrders);
            orderNumber = Convert.ToInt32(dtOrders.Rows[0][0]);
            lblOrderNum.Text = Convert.ToString(orderNumber + 1);
            //sqlDAO.Dispose();

            string currentState;
            try
            {
                FileStream fsStates = new FileStream(filePath + "/../../../StateAbbrev.txt", FileMode.Open);
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
            /*try
            {
                FileStream fsLog = new FileStream(filePath + "/../../../Log.txt", FileMode.Open);
                StreamReader swLog = new StreamReader(fsLog);
                swLog.Close();
            }
            catch
            {
                MessageBox.Show("Error getting Log file");
            }*/

            Reset();
        }

        private void mtbZip_Leave(object sender, EventArgs e)
        {
            if (mtbZip.Text.Length == 5)
            {
                mtbZip.ForeColor = Color.Black;
                lblError.Text = "";
                zipValid = true;
                btnAcceptEnabled();
            }
            else if (mtbZip.Text.Length == 9)
            {
                mtbZip.ForeColor = Color.Black;
                lblError.Text = "";
                zipValid = true;
            }
            else
            {
                mtbZip.Focus();
                mtbZip.ForeColor = Color.Red;
                lblError.Text = "Please enter a valid zip code";
            }
        } //Required field

        private void btnAccept_Click(object sender, EventArgs e)
        {

            Customer objCustomer = new Customer();
            objCustomer.CustPhone = mtbPhone.Text;
            objCustomer.CustName = txtCustName.Text;
            objCustomer.CustAddr1 = txtAddress1.Text;
            objCustomer.CustAddr2 = txtAddress2.Text;
            objCustomer.CustCity = txtCity.Text;
            objCustomer.CustState = drpState.Text;
            objCustomer.CustZip = mtbZip.Text;
            /*try
            {*/
                if (!custFound)
                {
                    DataRow newCust;
                    newCust = dtCust.NewRow();
                    newCust["CustPhone"] = mtbPhone.Text.ToString();
                    newCust["CustName"] = txtCustName.Text.ToString();
                    newCust["CustAddress1"] = txtAddress1.Text.ToString();
                    newCust["CustAddress2"] = txtAddress2.Text.ToString();
                    newCust["CustCity"] = txtCity.Text.ToString();
                    newCust["CustState"] = drpState.Text.ToString();
                    newCust["CustZip"] = mtbZip.Text.ToString();
                    dtCust.Rows.Add(newCust);
                    sqlCmdBuilder = new SqlCommandBuilder(sqlDAC);
                    sqlCmdBuilder.GetUpdateCommand();
                    sqlDAC.Update(dtCust);

                    DataRow newOrder;
                    newOrder = dtOrders.NewRow();
                    newOrder["OrderNumber"] = orderNumber;
                    newOrder["CustPhone"] = mtbPhone.Text.ToString();
                    newOrder["OrderDate"] = DateTime.Now.ToShortDateString();
                    if (rdoSmall.Checked)
                    {
                        newOrder["OrderSize"] = "S";
                    }
                    else if (rdoMedium.Checked)
                    {
                        newOrder["OrderSize"] = "M";
                    }
                    else
                    {
                        newOrder["OrderSize"] = "L";
                    }
                    newOrder["Qty"] = nudQty.Value;
                    newOrder["Top1"] = chkPep.Checked;
                    newOrder["Top2"] = chkOnion.Checked;
                    newOrder["Top3"] = chkHam.Checked;
                    newOrder["Top4"] = chkJalepeno.Checked;
                    newOrder["Top5"] = chkBpepper.Checked;
                    newOrder["Top6"] = chkMushrooms.Checked;
                    newOrder["Top7"] = chkPineapple.Checked;
                    newOrder["Top8"] = chkSausage.Checked;
                    newOrder["Top9"] = chkGolive.Checked;
                    newOrder["Top10"] = chkBolive.Checked;
                    dtOrders.Rows.Add(newOrder);
                    sqlCmdBuilder = new SqlCommandBuilder(sqlDAO);
                    sqlCmdBuilder.GetUpdateCommand();
                    sqlDAO.Update(dtOrders);
                }
            /*}
            catch
            {
                MessageBox.Show("Error writing data");
            }*/
            orderNumber += 1;
            Reset();
        }

        public void btnAcceptEnabled()
        {
            if (phoneValid == true && nameValid == true && addressValid == true && cityValid == true && zipValid == true)
            {
                btnAccept.Enabled = true;
            }
        }

        private void mtbPhone_TextChanged(object sender, EventArgs e)
        {
            if (mtbPhone.Text.Length == 10)
            {
                CustSearch();
            }
        }
        
        private void CustSearch()
        {
            string sqlSelectCust = "SELECT * FROM Customers WHERE CustPhone ='" + mtbPhone.Text.ToString() + "';";
            string sqlSelectOrders = "SELECT * FROM Orders WHERE CustPhone ='" + mtbPhone.Text.ToString() + "';";
            string strConn = strDataSrc + strSQLparms;
            sqlConn = new SqlConnection(strConn);
            sqlConn.Open();
            sqlDAC = new SqlDataAdapter(sqlSelectCust, sqlConn);
            sqlDAO = new SqlDataAdapter(sqlSelectOrders, sqlConn);
            dtCust = new DataTable();
            dtOrders = new DataTable();
            sqlDAC.Fill(dtCust);
            sqlDAO.Fill(dtOrders);
            if (dtCust.Rows.Count > 0)
            {
                txtCustName.Text = dtCust.Rows[0]["CustName"].ToString();
                txtAddress1.Text = dtCust.Rows[0]["CustAddress1"].ToString();
                txtAddress2.Text = dtCust.Rows[0]["CustAddress2"].ToString();
                txtCity.Text = dtCust.Rows[0]["CustCity"].ToString();
                drpState.Text = dtCust.Rows[0]["CustState"].ToString();
                mtbZip.Text = dtCust.Rows[0]["CustZip"].ToString();



                nudQty.Value = Convert.ToInt32(dtOrders.Rows[dtOrders.Rows.Count - 1]["Qty"]);
                chkPep.Checked = Convert.ToBoolean(dtOrders.Rows[dtOrders.Rows.Count - 1]["Top1"]);
                chkOnion.Checked = Convert.ToBoolean(dtOrders.Rows[dtOrders.Rows.Count - 1]["Top2"]);
                chkHam.Checked = Convert.ToBoolean(dtOrders.Rows[dtOrders.Rows.Count - 1]["Top3"]);
                chkJalepeno.Checked = Convert.ToBoolean(dtOrders.Rows[dtOrders.Rows.Count - 1]["Top4"]);
                chkBpepper.Checked = Convert.ToBoolean(dtOrders.Rows[dtOrders.Rows.Count - 1]["Top5"]);
                chkMushrooms.Checked = Convert.ToBoolean(dtOrders.Rows[dtOrders.Rows.Count - 1]["Top6"]);
                chkPineapple.Checked = Convert.ToBoolean(dtOrders.Rows[dtOrders.Rows.Count - 1]["Top7"]);
                chkSausage.Checked = Convert.ToBoolean(dtOrders.Rows[dtOrders.Rows.Count - 1]["Top8"]);
                chkGolive.Checked = Convert.ToBoolean(dtOrders.Rows[dtOrders.Rows.Count - 1]["Top9"]);
                chkBolive.Checked = Convert.ToBoolean(dtOrders.Rows[dtOrders.Rows.Count - 1]["Top10"]);


                nudQty.Focus();
                phoneValid = true;
                addressValid = true;
                nameValid = true;
                cityValid = true;
                zipValid = true;
                custFound = true;
                btnAcceptEnabled();
            }
            else
            {
                txtCustName.Focus();
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void drpPayMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (drpPayMethod.SelectedIndex == 0)
            {
                frmCreditCard FormCreditCard = new frmCreditCard();
                FormCreditCard.ShowDialog();
            }
        }

        private void chkMute_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMute.Checked)
            {
                wmpSound.settings.mute = true;
            }
            else
            {
                wmpSound.settings.mute = false;
            }
        }

        private void mnuFilePrice_Click(object sender, EventArgs e)
        {
            Pricing();
        }

        private void mnuFileReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}