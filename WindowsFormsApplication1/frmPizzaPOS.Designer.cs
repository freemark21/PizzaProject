namespace WindowsFormsApplication1
{
    partial class frmPizzaPOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.boxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.drpState = new System.Windows.Forms.ComboBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.mtbZip = new System.Windows.Forms.MaskedTextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblPizzageddon = new System.Windows.Forms.Label();
            this.picPizzageddon = new System.Windows.Forms.PictureBox();
            this.lblTimeDate = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.boxOrderInfo = new System.Windows.Forms.GroupBox();
            this.drpPayMethod = new System.Windows.Forms.ComboBox();
            this.boxButtons = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.boxPizzaToppings = new System.Windows.Forms.GroupBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkGolive = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkBolive = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkJalepeno = new System.Windows.Forms.CheckBox();
            this.chkBpepper = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkPep = new System.Windows.Forms.CheckBox();
            this.boxPizzaSize = new System.Windows.Forms.GroupBox();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.tmrDT = new System.Windows.Forms.Timer(this.components);
            this.lblError = new System.Windows.Forms.Label();
            this.boxCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizzageddon)).BeginInit();
            this.boxOrderInfo.SuspendLayout();
            this.boxButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.boxPizzaToppings.SuspendLayout();
            this.boxPizzaSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxCustomerInfo
            // 
            this.boxCustomerInfo.Controls.Add(this.drpState);
            this.boxCustomerInfo.Controls.Add(this.txtCustName);
            this.boxCustomerInfo.Controls.Add(this.txtCity);
            this.boxCustomerInfo.Controls.Add(this.txtAddress2);
            this.boxCustomerInfo.Controls.Add(this.txtAddress1);
            this.boxCustomerInfo.Controls.Add(this.mtbZip);
            this.boxCustomerInfo.Controls.Add(this.lblZip);
            this.boxCustomerInfo.Controls.Add(this.lblState);
            this.boxCustomerInfo.Controls.Add(this.lblCity);
            this.boxCustomerInfo.Controls.Add(this.lblAddress2);
            this.boxCustomerInfo.Controls.Add(this.lblAddress1);
            this.boxCustomerInfo.Controls.Add(this.lblCustName);
            this.boxCustomerInfo.Controls.Add(this.lblPhone);
            this.boxCustomerInfo.Controls.Add(this.mtbPhone);
            this.boxCustomerInfo.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCustomerInfo.Location = new System.Drawing.Point(8, 82);
            this.boxCustomerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.boxCustomerInfo.Name = "boxCustomerInfo";
            this.boxCustomerInfo.Padding = new System.Windows.Forms.Padding(2);
            this.boxCustomerInfo.Size = new System.Drawing.Size(302, 324);
            this.boxCustomerInfo.TabIndex = 1;
            this.boxCustomerInfo.TabStop = false;
            this.boxCustomerInfo.Text = "Customer Info";
            // 
            // drpState
            // 
            this.drpState.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpState.FormattingEnabled = true;
            this.drpState.Location = new System.Drawing.Point(8, 275);
            this.drpState.Margin = new System.Windows.Forms.Padding(2);
            this.drpState.MaxDropDownItems = 50;
            this.drpState.Name = "drpState";
            this.drpState.Size = new System.Drawing.Size(61, 26);
            this.drpState.TabIndex = 11;
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(8, 75);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustName.MaxLength = 25;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(286, 24);
            this.txtCustName.TabIndex = 3;
            this.txtCustName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustName_KeyPress);
            this.txtCustName.Leave += new System.EventHandler(this.txtCustName_Leave);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(8, 228);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.MaxLength = 25;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(286, 24);
            this.txtCity.TabIndex = 9;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            this.txtCity.Leave += new System.EventHandler(this.txtCity_Leave);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(8, 182);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress2.MaxLength = 25;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(286, 24);
            this.txtAddress2.TabIndex = 7;
            this.txtAddress2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress2_KeyPress);
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(8, 136);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress1.MaxLength = 25;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(286, 24);
            this.txtAddress1.TabIndex = 5;
            this.txtAddress1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress1_KeyPress);
            this.txtAddress1.Leave += new System.EventHandler(this.txtAddress1_Leave);
            // 
            // mtbZip
            // 
            this.mtbZip.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbZip.Location = new System.Drawing.Point(143, 277);
            this.mtbZip.Margin = new System.Windows.Forms.Padding(2);
            this.mtbZip.Mask = "00000-9999";
            this.mtbZip.Name = "mtbZip";
            this.mtbZip.Size = new System.Drawing.Size(72, 24);
            this.mtbZip.TabIndex = 13;
            this.mtbZip.Leave += new System.EventHandler(this.mtbZip_Leave);
            // 
            // lblZip
            // 
            this.lblZip.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(139, 254);
            this.lblZip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(72, 24);
            this.lblZip.TabIndex = 12;
            this.lblZip.Text = "Zip";
            this.lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblState
            // 
            this.lblState.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(4, 254);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(82, 21);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCity
            // 
            this.lblCity.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(4, 205);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(82, 21);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress2
            // 
            this.lblAddress2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(4, 159);
            this.lblAddress2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(82, 21);
            this.lblAddress2.TabIndex = 6;
            this.lblAddress2.Text = "Address &2";
            this.lblAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress1
            // 
            this.lblAddress1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(4, 114);
            this.lblAddress1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(82, 21);
            this.lblAddress1.TabIndex = 4;
            this.lblAddress1.Text = "Address &1";
            this.lblAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustName
            // 
            this.lblCustName.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(82, 54);
            this.lblCustName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(129, 18);
            this.lblCustName.TabIndex = 2;
            this.lblCustName.Text = "&Customer Name";
            this.lblCustName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(44, 29);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(67, 24);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPhone.Location = new System.Drawing.Point(115, 29);
            this.mtbPhone.Margin = new System.Windows.Forms.Padding(2);
            this.mtbPhone.Mask = "(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(110, 27);
            this.mtbPhone.TabIndex = 1;
            this.mtbPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbPhone.Leave += new System.EventHandler(this.mtbPhone_Leave);
            // 
            // lblPizzageddon
            // 
            this.lblPizzageddon.AutoSize = true;
            this.lblPizzageddon.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzageddon.Location = new System.Drawing.Point(115, 4);
            this.lblPizzageddon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPizzageddon.Name = "lblPizzageddon";
            this.lblPizzageddon.Size = new System.Drawing.Size(292, 76);
            this.lblPizzageddon.TabIndex = 0;
            this.lblPizzageddon.Text = "Pizzageddon";
            // 
            // picPizzageddon
            // 
            this.picPizzageddon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPizzageddon.Image = global::PizzaProject.Properties.Resources.Pizzageddon;
            this.picPizzageddon.Location = new System.Drawing.Point(406, 4);
            this.picPizzageddon.Margin = new System.Windows.Forms.Padding(2);
            this.picPizzageddon.Name = "picPizzageddon";
            this.picPizzageddon.Size = new System.Drawing.Size(111, 76);
            this.picPizzageddon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizzageddon.TabIndex = 2;
            this.picPizzageddon.TabStop = false;
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.AutoSize = true;
            this.lblTimeDate.Location = new System.Drawing.Point(565, 44);
            this.lblTimeDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(65, 13);
            this.lblTimeDate.TabIndex = 0;
            this.lblTimeDate.Text = "Time && Date";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.Location = new System.Drawing.Point(565, 65);
            this.lblOrderNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(67, 15);
            this.lblOrderNum.TabIndex = 0;
            this.lblOrderNum.Text = "0000";
            // 
            // boxOrderInfo
            // 
            this.boxOrderInfo.Controls.Add(this.drpPayMethod);
            this.boxOrderInfo.Controls.Add(this.boxButtons);
            this.boxOrderInfo.Controls.Add(this.lblTotal);
            this.boxOrderInfo.Controls.Add(this.lblQty);
            this.boxOrderInfo.Controls.Add(this.nudQty);
            this.boxOrderInfo.Controls.Add(this.boxPizzaToppings);
            this.boxOrderInfo.Controls.Add(this.boxPizzaSize);
            this.boxOrderInfo.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxOrderInfo.Location = new System.Drawing.Point(326, 84);
            this.boxOrderInfo.Margin = new System.Windows.Forms.Padding(2);
            this.boxOrderInfo.Name = "boxOrderInfo";
            this.boxOrderInfo.Padding = new System.Windows.Forms.Padding(2);
            this.boxOrderInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.boxOrderInfo.Size = new System.Drawing.Size(348, 322);
            this.boxOrderInfo.TabIndex = 2;
            this.boxOrderInfo.TabStop = false;
            this.boxOrderInfo.Text = "Order Info";
            // 
            // drpPayMethod
            // 
            this.drpPayMethod.FormattingEnabled = true;
            this.drpPayMethod.Location = new System.Drawing.Point(168, 139);
            this.drpPayMethod.Margin = new System.Windows.Forms.Padding(2);
            this.drpPayMethod.Name = "drpPayMethod";
            this.drpPayMethod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.drpPayMethod.Size = new System.Drawing.Size(176, 35);
            this.drpPayMethod.TabIndex = 5;
            // 
            // boxButtons
            // 
            this.boxButtons.Controls.Add(this.btnReset);
            this.boxButtons.Controls.Add(this.btnPrice);
            this.boxButtons.Controls.Add(this.btnClose);
            this.boxButtons.Controls.Add(this.btnAccept);
            this.boxButtons.Location = new System.Drawing.Point(164, 171);
            this.boxButtons.Margin = new System.Windows.Forms.Padding(2);
            this.boxButtons.Name = "boxButtons";
            this.boxButtons.Padding = new System.Windows.Forms.Padding(2);
            this.boxButtons.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxButtons.Size = new System.Drawing.Size(180, 132);
            this.boxButtons.TabIndex = 6;
            this.boxButtons.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(91, 20);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 45);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrice.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrice.Location = new System.Drawing.Point(4, 20);
            this.btnPrice.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(83, 45);
            this.btnPrice.TabIndex = 0;
            this.btnPrice.Text = "&Price";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(91, 77);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 45);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Enabled = false;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(3, 76);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(83, 45);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(168, 29);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(176, 104);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQty
            // 
            this.lblQty.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(115, 53);
            this.lblQty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQty.Size = new System.Drawing.Size(44, 18);
            this.lblQty.TabIndex = 2;
            this.lblQty.Text = "QTY";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudQty
            // 
            this.nudQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQty.Location = new System.Drawing.Point(115, 73);
            this.nudQty.Margin = new System.Windows.Forms.Padding(2);
            this.nudQty.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nudQty.Size = new System.Drawing.Size(44, 29);
            this.nudQty.TabIndex = 3;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.ValueChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // boxPizzaToppings
            // 
            this.boxPizzaToppings.Controls.Add(this.chkMushrooms);
            this.boxPizzaToppings.Controls.Add(this.chkGolive);
            this.boxPizzaToppings.Controls.Add(this.chkOnion);
            this.boxPizzaToppings.Controls.Add(this.chkBolive);
            this.boxPizzaToppings.Controls.Add(this.chkHam);
            this.boxPizzaToppings.Controls.Add(this.chkJalepeno);
            this.boxPizzaToppings.Controls.Add(this.chkBpepper);
            this.boxPizzaToppings.Controls.Add(this.chkPineapple);
            this.boxPizzaToppings.Controls.Add(this.chkSausage);
            this.boxPizzaToppings.Controls.Add(this.chkPep);
            this.boxPizzaToppings.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPizzaToppings.Location = new System.Drawing.Point(4, 134);
            this.boxPizzaToppings.Margin = new System.Windows.Forms.Padding(2);
            this.boxPizzaToppings.Name = "boxPizzaToppings";
            this.boxPizzaToppings.Padding = new System.Windows.Forms.Padding(2);
            this.boxPizzaToppings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxPizzaToppings.Size = new System.Drawing.Size(160, 169);
            this.boxPizzaToppings.TabIndex = 1;
            this.boxPizzaToppings.TabStop = false;
            this.boxPizzaToppings.Text = "Pizza Toppings";
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(4, 119);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(2);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(89, 20);
            this.chkMushrooms.TabIndex = 8;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // chkGolive
            // 
            this.chkGolive.AutoSize = true;
            this.chkGolive.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGolive.Location = new System.Drawing.Point(88, 37);
            this.chkGolive.Margin = new System.Windows.Forms.Padding(2);
            this.chkGolive.Name = "chkGolive";
            this.chkGolive.Size = new System.Drawing.Size(67, 20);
            this.chkGolive.TabIndex = 3;
            this.chkGolive.Text = "G Olive";
            this.chkGolive.UseVisualStyleBackColor = true;
            this.chkGolive.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(4, 39);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(60, 20);
            this.chkOnion.TabIndex = 2;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // chkBolive
            // 
            this.chkBolive.AutoSize = true;
            this.chkBolive.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBolive.Location = new System.Drawing.Point(88, 56);
            this.chkBolive.Margin = new System.Windows.Forms.Padding(2);
            this.chkBolive.Name = "chkBolive";
            this.chkBolive.Size = new System.Drawing.Size(65, 20);
            this.chkBolive.TabIndex = 5;
            this.chkBolive.Text = "B Olive";
            this.chkBolive.UseVisualStyleBackColor = true;
            this.chkBolive.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHam.Location = new System.Drawing.Point(4, 59);
            this.chkHam.Margin = new System.Windows.Forms.Padding(2);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(52, 20);
            this.chkHam.TabIndex = 4;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            this.chkHam.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // chkJalepeno
            // 
            this.chkJalepeno.AutoSize = true;
            this.chkJalepeno.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJalepeno.Location = new System.Drawing.Point(4, 79);
            this.chkJalepeno.Margin = new System.Windows.Forms.Padding(2);
            this.chkJalepeno.Name = "chkJalepeno";
            this.chkJalepeno.Size = new System.Drawing.Size(73, 20);
            this.chkJalepeno.TabIndex = 6;
            this.chkJalepeno.Text = "Jalepeno";
            this.chkJalepeno.UseVisualStyleBackColor = true;
            this.chkJalepeno.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // chkBpepper
            // 
            this.chkBpepper.AutoSize = true;
            this.chkBpepper.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBpepper.Location = new System.Drawing.Point(4, 99);
            this.chkBpepper.Margin = new System.Windows.Forms.Padding(2);
            this.chkBpepper.Name = "chkBpepper";
            this.chkBpepper.Size = new System.Drawing.Size(88, 20);
            this.chkBpepper.TabIndex = 7;
            this.chkBpepper.Text = "Ban Pepper";
            this.chkBpepper.UseVisualStyleBackColor = true;
            this.chkBpepper.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPineapple.Location = new System.Drawing.Point(4, 139);
            this.chkPineapple.Margin = new System.Windows.Forms.Padding(2);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(81, 20);
            this.chkPineapple.TabIndex = 9;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            this.chkPineapple.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSausage.Location = new System.Drawing.Point(88, 19);
            this.chkSausage.Margin = new System.Windows.Forms.Padding(2);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(70, 20);
            this.chkSausage.TabIndex = 1;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            this.chkSausage.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // chkPep
            // 
            this.chkPep.AutoSize = true;
            this.chkPep.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPep.Location = new System.Drawing.Point(4, 19);
            this.chkPep.Margin = new System.Windows.Forms.Padding(2);
            this.chkPep.Name = "chkPep";
            this.chkPep.Size = new System.Drawing.Size(82, 20);
            this.chkPep.TabIndex = 0;
            this.chkPep.Text = "Pepporoni";
            this.chkPep.UseVisualStyleBackColor = true;
            this.chkPep.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // boxPizzaSize
            // 
            this.boxPizzaSize.Controls.Add(this.rdoLarge);
            this.boxPizzaSize.Controls.Add(this.rdoMedium);
            this.boxPizzaSize.Controls.Add(this.rdoSmall);
            this.boxPizzaSize.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPizzaSize.Location = new System.Drawing.Point(4, 27);
            this.boxPizzaSize.Margin = new System.Windows.Forms.Padding(2);
            this.boxPizzaSize.Name = "boxPizzaSize";
            this.boxPizzaSize.Padding = new System.Windows.Forms.Padding(2);
            this.boxPizzaSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxPizzaSize.Size = new System.Drawing.Size(104, 101);
            this.boxPizzaSize.TabIndex = 0;
            this.boxPizzaSize.TabStop = false;
            this.boxPizzaSize.Text = "Pizza Size";
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Location = new System.Drawing.Point(4, 68);
            this.rdoLarge.Margin = new System.Windows.Forms.Padding(2);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(63, 23);
            this.rdoLarge.TabIndex = 2;
            this.rdoLarge.TabStop = true;
            this.rdoLarge.Text = "Large";
            this.rdoLarge.UseVisualStyleBackColor = true;
            this.rdoLarge.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Location = new System.Drawing.Point(4, 44);
            this.rdoMedium.Margin = new System.Windows.Forms.Padding(2);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(83, 23);
            this.rdoMedium.TabIndex = 1;
            this.rdoMedium.TabStop = true;
            this.rdoMedium.Text = "Medium";
            this.rdoMedium.UseVisualStyleBackColor = true;
            this.rdoMedium.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Location = new System.Drawing.Point(4, 20);
            this.rdoSmall.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(65, 23);
            this.rdoSmall.TabIndex = 0;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Text = "&Small";
            this.rdoSmall.UseVisualStyleBackColor = true;
            this.rdoSmall.CheckedChanged += new System.EventHandler(this.rdoSmall_CheckedChanged);
            // 
            // tmrDT
            // 
            this.tmrDT.Enabled = true;
            this.tmrDT.Interval = 1000;
            this.tmrDT.Tick += new System.EventHandler(this.tmrDT_Tick);
            // 
            // lblError
            // 
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(9, 414);
            this.lblError.Name = "lblError";
            this.lblError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblError.Size = new System.Drawing.Size(666, 27);
            this.lblError.TabIndex = 7;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPizzaPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(683, 447);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.boxOrderInfo);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.lblTimeDate);
            this.Controls.Add(this.picPizzageddon);
            this.Controls.Add(this.lblPizzageddon);
            this.Controls.Add(this.boxCustomerInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPizzaPOS";
            this.Text = "Pizzageddon POS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPizzaPOS_FormClosing_1);
            this.Load += new System.EventHandler(this.frmPizzaPOS_Load);
            this.boxCustomerInfo.ResumeLayout(false);
            this.boxCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizzageddon)).EndInit();
            this.boxOrderInfo.ResumeLayout(false);
            this.boxButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.boxPizzaToppings.ResumeLayout(false);
            this.boxPizzaToppings.PerformLayout();
            this.boxPizzaSize.ResumeLayout(false);
            this.boxPizzaSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox boxCustomerInfo;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.MaskedTextBox mtbZip;
        private System.Windows.Forms.ComboBox drpState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblPizzageddon;
        private System.Windows.Forms.PictureBox picPizzageddon;
        private System.Windows.Forms.Label lblTimeDate;
        private System.Windows.Forms.Label lblOrderNum;
        private System.Windows.Forms.GroupBox boxOrderInfo;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.GroupBox boxPizzaToppings;
        private System.Windows.Forms.GroupBox boxPizzaSize;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.GroupBox boxButtons;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkGolive;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkBolive;
        private System.Windows.Forms.CheckBox chkHam;
        private System.Windows.Forms.CheckBox chkJalepeno;
        private System.Windows.Forms.CheckBox chkBpepper;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkPep;
        private System.Windows.Forms.RadioButton rdoLarge;
        private System.Windows.Forms.RadioButton rdoMedium;
        private System.Windows.Forms.RadioButton rdoSmall;
        private System.Windows.Forms.ComboBox drpPayMethod;
        private System.Windows.Forms.Timer tmrDT;
        private System.Windows.Forms.Label lblError;
    }
}

