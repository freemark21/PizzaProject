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
            this.boxCustomerInfo.Location = new System.Drawing.Point(11, 101);
            this.boxCustomerInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxCustomerInfo.Name = "boxCustomerInfo";
            this.boxCustomerInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxCustomerInfo.Size = new System.Drawing.Size(403, 399);
            this.boxCustomerInfo.TabIndex = 1;
            this.boxCustomerInfo.TabStop = false;
            this.boxCustomerInfo.Text = "Customer Info";
            // 
            // drpState
            // 
            this.drpState.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpState.FormattingEnabled = true;
            this.drpState.Location = new System.Drawing.Point(11, 338);
            this.drpState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpState.MaxDropDownItems = 50;
            this.drpState.Name = "drpState";
            this.drpState.Size = new System.Drawing.Size(80, 30);
            this.drpState.TabIndex = 11;
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(11, 92);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustName.MaxLength = 25;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(380, 28);
            this.txtCustName.TabIndex = 3;
            this.txtCustName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustName_KeyPress);
            this.txtCustName.Leave += new System.EventHandler(this.txtCustName_Leave);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(11, 281);
            this.txtCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCity.MaxLength = 25;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(380, 28);
            this.txtCity.TabIndex = 9;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(11, 224);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress2.MaxLength = 25;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(380, 28);
            this.txtAddress2.TabIndex = 7;
            this.txtAddress2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress2_KeyPress);
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(11, 167);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress1.MaxLength = 25;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(380, 28);
            this.txtAddress1.TabIndex = 5;
            this.txtAddress1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress1_KeyPress);
            // 
            // mtbZip
            // 
            this.mtbZip.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbZip.Location = new System.Drawing.Point(191, 341);
            this.mtbZip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbZip.Mask = "00000-9999";
            this.mtbZip.Name = "mtbZip";
            this.mtbZip.Size = new System.Drawing.Size(95, 28);
            this.mtbZip.TabIndex = 13;
            // 
            // lblZip
            // 
            this.lblZip.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(185, 313);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(96, 30);
            this.lblZip.TabIndex = 12;
            this.lblZip.Text = "Zip";
            this.lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblState
            // 
            this.lblState.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(5, 313);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(109, 26);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCity
            // 
            this.lblCity.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(5, 252);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(109, 26);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress2
            // 
            this.lblAddress2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(5, 196);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(109, 26);
            this.lblAddress2.TabIndex = 6;
            this.lblAddress2.Text = "Address &2";
            this.lblAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress1
            // 
            this.lblAddress1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(5, 140);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(109, 26);
            this.lblAddress1.TabIndex = 4;
            this.lblAddress1.Text = "Address &1";
            this.lblAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustName
            // 
            this.lblCustName.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(109, 66);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(172, 22);
            this.lblCustName.TabIndex = 2;
            this.lblCustName.Text = "&Customer Name";
            this.lblCustName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(59, 36);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(89, 30);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbPhone.Location = new System.Drawing.Point(153, 36);
            this.mtbPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbPhone.Mask = "(999) 000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(145, 32);
            this.mtbPhone.TabIndex = 1;
            this.mtbPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbPhone.Leave += new System.EventHandler(this.mtbPhone_Leave);
            // 
            // lblPizzageddon
            // 
            this.lblPizzageddon.AutoSize = true;
            this.lblPizzageddon.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzageddon.Location = new System.Drawing.Point(153, 5);
            this.lblPizzageddon.Name = "lblPizzageddon";
            this.lblPizzageddon.Size = new System.Drawing.Size(363, 94);
            this.lblPizzageddon.TabIndex = 0;
            this.lblPizzageddon.Text = "Pizzageddon";
            // 
            // picPizzageddon
            // 
            this.picPizzageddon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPizzageddon.Image = global::PizzaProject.Properties.Resources.Pizzageddon;
            this.picPizzageddon.Location = new System.Drawing.Point(541, 5);
            this.picPizzageddon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPizzageddon.Name = "picPizzageddon";
            this.picPizzageddon.Size = new System.Drawing.Size(148, 94);
            this.picPizzageddon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizzageddon.TabIndex = 2;
            this.picPizzageddon.TabStop = false;
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.AutoSize = true;
            this.lblTimeDate.Location = new System.Drawing.Point(753, 54);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(86, 17);
            this.lblTimeDate.TabIndex = 0;
            this.lblTimeDate.Text = "Time && Date";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.Location = new System.Drawing.Point(753, 80);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(89, 18);
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
            this.boxOrderInfo.Location = new System.Drawing.Point(435, 103);
            this.boxOrderInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxOrderInfo.Name = "boxOrderInfo";
            this.boxOrderInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxOrderInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.boxOrderInfo.Size = new System.Drawing.Size(464, 396);
            this.boxOrderInfo.TabIndex = 2;
            this.boxOrderInfo.TabStop = false;
            this.boxOrderInfo.Text = "Order Info";
            // 
            // drpPayMethod
            // 
            this.drpPayMethod.FormattingEnabled = true;
            this.drpPayMethod.Location = new System.Drawing.Point(224, 171);
            this.drpPayMethod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpPayMethod.Name = "drpPayMethod";
            this.drpPayMethod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.drpPayMethod.Size = new System.Drawing.Size(233, 40);
            this.drpPayMethod.TabIndex = 5;
            // 
            // boxButtons
            // 
            this.boxButtons.Controls.Add(this.btnReset);
            this.boxButtons.Controls.Add(this.btnPrice);
            this.boxButtons.Controls.Add(this.btnClose);
            this.boxButtons.Controls.Add(this.btnAccept);
            this.boxButtons.Location = new System.Drawing.Point(219, 210);
            this.boxButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxButtons.Name = "boxButtons";
            this.boxButtons.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxButtons.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxButtons.Size = new System.Drawing.Size(240, 162);
            this.boxButtons.TabIndex = 6;
            this.boxButtons.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(121, 25);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 55);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnPrice
            // 
            this.btnPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrice.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrice.Location = new System.Drawing.Point(5, 25);
            this.btnPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(111, 55);
            this.btnPrice.TabIndex = 0;
            this.btnPrice.Text = "&Price";
            this.btnPrice.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(121, 95);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 55);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(4, 94);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(111, 55);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "&Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(224, 36);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(234, 128);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQty
            // 
            this.lblQty.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(153, 65);
            this.lblQty.Name = "lblQty";
            this.lblQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQty.Size = new System.Drawing.Size(59, 22);
            this.lblQty.TabIndex = 2;
            this.lblQty.Text = "QTY";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudQty
            // 
            this.nudQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQty.Location = new System.Drawing.Point(153, 90);
            this.nudQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.nudQty.Size = new System.Drawing.Size(59, 34);
            this.nudQty.TabIndex = 3;
            this.nudQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.boxPizzaToppings.Location = new System.Drawing.Point(5, 165);
            this.boxPizzaToppings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxPizzaToppings.Name = "boxPizzaToppings";
            this.boxPizzaToppings.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxPizzaToppings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxPizzaToppings.Size = new System.Drawing.Size(213, 208);
            this.boxPizzaToppings.TabIndex = 1;
            this.boxPizzaToppings.TabStop = false;
            this.boxPizzaToppings.Text = "Pizza Toppings";
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(5, 146);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(108, 23);
            this.chkMushrooms.TabIndex = 8;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkGolive
            // 
            this.chkGolive.AutoSize = true;
            this.chkGolive.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGolive.Location = new System.Drawing.Point(117, 46);
            this.chkGolive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkGolive.Name = "chkGolive";
            this.chkGolive.Size = new System.Drawing.Size(84, 23);
            this.chkGolive.TabIndex = 3;
            this.chkGolive.Text = "G Olive";
            this.chkGolive.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(5, 48);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(74, 23);
            this.chkOnion.TabIndex = 2;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // chkBolive
            // 
            this.chkBolive.AutoSize = true;
            this.chkBolive.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBolive.Location = new System.Drawing.Point(117, 69);
            this.chkBolive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkBolive.Name = "chkBolive";
            this.chkBolive.Size = new System.Drawing.Size(81, 23);
            this.chkBolive.TabIndex = 5;
            this.chkBolive.Text = "B Olive";
            this.chkBolive.UseVisualStyleBackColor = true;
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHam.Location = new System.Drawing.Point(5, 73);
            this.chkHam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(62, 23);
            this.chkHam.TabIndex = 4;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            // 
            // chkJalepeno
            // 
            this.chkJalepeno.AutoSize = true;
            this.chkJalepeno.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJalepeno.Location = new System.Drawing.Point(5, 97);
            this.chkJalepeno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkJalepeno.Name = "chkJalepeno";
            this.chkJalepeno.Size = new System.Drawing.Size(87, 23);
            this.chkJalepeno.TabIndex = 6;
            this.chkJalepeno.Text = "Jalepeno";
            this.chkJalepeno.UseVisualStyleBackColor = true;
            // 
            // chkBpepper
            // 
            this.chkBpepper.AutoSize = true;
            this.chkBpepper.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBpepper.Location = new System.Drawing.Point(5, 122);
            this.chkBpepper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkBpepper.Name = "chkBpepper";
            this.chkBpepper.Size = new System.Drawing.Size(104, 23);
            this.chkBpepper.TabIndex = 7;
            this.chkBpepper.Text = "Ban Pepper";
            this.chkBpepper.UseVisualStyleBackColor = true;
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPineapple.Location = new System.Drawing.Point(5, 171);
            this.chkPineapple.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(96, 23);
            this.chkPineapple.TabIndex = 9;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSausage.Location = new System.Drawing.Point(117, 23);
            this.chkSausage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(84, 23);
            this.chkSausage.TabIndex = 1;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkPep
            // 
            this.chkPep.AutoSize = true;
            this.chkPep.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPep.Location = new System.Drawing.Point(5, 23);
            this.chkPep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPep.Name = "chkPep";
            this.chkPep.Size = new System.Drawing.Size(98, 23);
            this.chkPep.TabIndex = 0;
            this.chkPep.Text = "Pepporoni";
            this.chkPep.UseVisualStyleBackColor = true;
            // 
            // boxPizzaSize
            // 
            this.boxPizzaSize.Controls.Add(this.rdoLarge);
            this.boxPizzaSize.Controls.Add(this.rdoMedium);
            this.boxPizzaSize.Controls.Add(this.rdoSmall);
            this.boxPizzaSize.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPizzaSize.Location = new System.Drawing.Point(5, 33);
            this.boxPizzaSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxPizzaSize.Name = "boxPizzaSize";
            this.boxPizzaSize.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxPizzaSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxPizzaSize.Size = new System.Drawing.Size(139, 124);
            this.boxPizzaSize.TabIndex = 0;
            this.boxPizzaSize.TabStop = false;
            this.boxPizzaSize.Text = "Pizza Size";
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Location = new System.Drawing.Point(5, 84);
            this.rdoLarge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(75, 26);
            this.rdoLarge.TabIndex = 2;
            this.rdoLarge.TabStop = true;
            this.rdoLarge.Text = "Large";
            this.rdoLarge.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Location = new System.Drawing.Point(5, 54);
            this.rdoMedium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(98, 26);
            this.rdoMedium.TabIndex = 1;
            this.rdoMedium.TabStop = true;
            this.rdoMedium.Text = "Medium";
            this.rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Location = new System.Drawing.Point(5, 25);
            this.rdoSmall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(77, 26);
            this.rdoSmall.TabIndex = 0;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Text = "&Small";
            this.rdoSmall.UseVisualStyleBackColor = true;
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
            this.lblError.Location = new System.Drawing.Point(11, 506);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblError.Size = new System.Drawing.Size(888, 33);
            this.lblError.TabIndex = 7;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPizzaPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(911, 550);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.boxOrderInfo);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.lblTimeDate);
            this.Controls.Add(this.picPizzageddon);
            this.Controls.Add(this.lblPizzageddon);
            this.Controls.Add(this.boxCustomerInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPizzaPOS";
            this.Text = "Pizzageddon POS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPizzaPOS_FormClosing_1);
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

