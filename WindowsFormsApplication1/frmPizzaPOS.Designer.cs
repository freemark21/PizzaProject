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
            this.boxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.txtZip = new System.Windows.Forms.MaskedTextBox();
            this.drpState = new System.Windows.Forms.ComboBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblPizzageddon = new System.Windows.Forms.Label();
            this.picPizzageddon = new System.Windows.Forms.PictureBox();
            this.lblTimeDate = new System.Windows.Forms.Label();
            this.lblOrderNum = new System.Windows.Forms.Label();
            this.boxOrderInfo = new System.Windows.Forms.GroupBox();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.boxPizzaToppings = new System.Windows.Forms.GroupBox();
            this.boxPizzaSize = new System.Windows.Forms.GroupBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.rdoSmall = new System.Windows.Forms.RadioButton();
            this.rdoMedium = new System.Windows.Forms.RadioButton();
            this.rdoLarge = new System.Windows.Forms.RadioButton();
            this.chkPep = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkBpepper = new System.Windows.Forms.CheckBox();
            this.chkJalepeno = new System.Windows.Forms.CheckBox();
            this.chkHam = new System.Windows.Forms.CheckBox();
            this.chkBolive = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkGolive = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.boxButtons = new System.Windows.Forms.GroupBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.drpPayMethod = new System.Windows.Forms.ComboBox();
            this.boxCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizzageddon)).BeginInit();
            this.boxOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.boxPizzaToppings.SuspendLayout();
            this.boxPizzaSize.SuspendLayout();
            this.boxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxCustomerInfo
            // 
            this.boxCustomerInfo.Controls.Add(this.txtZip);
            this.boxCustomerInfo.Controls.Add(this.drpState);
            this.boxCustomerInfo.Controls.Add(this.lblZip);
            this.boxCustomerInfo.Controls.Add(this.lblState);
            this.boxCustomerInfo.Controls.Add(this.textBox1);
            this.boxCustomerInfo.Controls.Add(this.lblCity);
            this.boxCustomerInfo.Controls.Add(this.txtAddress2);
            this.boxCustomerInfo.Controls.Add(this.lblAddress2);
            this.boxCustomerInfo.Controls.Add(this.txtAddress1);
            this.boxCustomerInfo.Controls.Add(this.lblAddress1);
            this.boxCustomerInfo.Controls.Add(this.lblCustName);
            this.boxCustomerInfo.Controls.Add(this.txtCustName);
            this.boxCustomerInfo.Controls.Add(this.lblPhone);
            this.boxCustomerInfo.Controls.Add(this.txtPhone);
            this.boxCustomerInfo.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCustomerInfo.Location = new System.Drawing.Point(11, 101);
            this.boxCustomerInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxCustomerInfo.Name = "boxCustomerInfo";
            this.boxCustomerInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxCustomerInfo.Size = new System.Drawing.Size(402, 399);
            this.boxCustomerInfo.TabIndex = 0;
            this.boxCustomerInfo.TabStop = false;
            this.boxCustomerInfo.Text = "Customer Info";
            // 
            // txtZip
            // 
            this.txtZip.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZip.Location = new System.Drawing.Point(194, 336);
            this.txtZip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZip.Mask = "00000-9999";
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(94, 28);
            this.txtZip.TabIndex = 13;
            // 
            // drpState
            // 
            this.drpState.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpState.FormattingEnabled = true;
            this.drpState.Location = new System.Drawing.Point(10, 336);
            this.drpState.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drpState.MaxDropDownItems = 50;
            this.drpState.Name = "drpState";
            this.drpState.Size = new System.Drawing.Size(80, 30);
            this.drpState.TabIndex = 12;
            // 
            // lblZip
            // 
            this.lblZip.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZip.Location = new System.Drawing.Point(189, 308);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(109, 26);
            this.lblZip.TabIndex = 11;
            this.lblZip.Text = "Zip";
            this.lblZip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblState
            // 
            this.lblState.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(5, 308);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(109, 26);
            this.lblState.TabIndex = 10;
            this.lblState.Text = "State";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(10, 280);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.MaxLength = 25;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(380, 28);
            this.textBox1.TabIndex = 9;
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
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(10, 224);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress2.MaxLength = 25;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(380, 28);
            this.txtAddress2.TabIndex = 7;
            // 
            // lblAddress2
            // 
            this.lblAddress2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.Location = new System.Drawing.Point(5, 196);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(109, 26);
            this.lblAddress2.TabIndex = 6;
            this.lblAddress2.Text = "Address 2";
            this.lblAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress1.Location = new System.Drawing.Point(10, 168);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress1.MaxLength = 25;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(380, 28);
            this.txtAddress1.TabIndex = 5;
            // 
            // lblAddress1
            // 
            this.lblAddress1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.Location = new System.Drawing.Point(5, 140);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(109, 26);
            this.lblAddress1.TabIndex = 4;
            this.lblAddress1.Text = "Address 1";
            this.lblAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustName
            // 
            this.lblCustName.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(110, 67);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(172, 22);
            this.lblCustName.TabIndex = 3;
            this.lblCustName.Text = "Customer Name";
            this.lblCustName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCustName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(10, 92);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustName.MaxLength = 25;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(380, 28);
            this.txtCustName.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(59, 36);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(89, 29);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(153, 36);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(146, 32);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblPizzageddon
            // 
            this.lblPizzageddon.AutoSize = true;
            this.lblPizzageddon.Font = new System.Drawing.Font("Papyrus", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzageddon.Location = new System.Drawing.Point(169, 7);
            this.lblPizzageddon.Name = "lblPizzageddon";
            this.lblPizzageddon.Size = new System.Drawing.Size(363, 94);
            this.lblPizzageddon.TabIndex = 1;
            this.lblPizzageddon.Text = "Pizzageddon";
            // 
            // picPizzageddon
            // 
            this.picPizzageddon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPizzageddon.Image = global::PizzaProject.Properties.Resources.Pizzageddon;
            this.picPizzageddon.Location = new System.Drawing.Point(575, 7);
            this.picPizzageddon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPizzageddon.Name = "picPizzageddon";
            this.picPizzageddon.Size = new System.Drawing.Size(148, 91);
            this.picPizzageddon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPizzageddon.TabIndex = 2;
            this.picPizzageddon.TabStop = false;
            this.picPizzageddon.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.Location = new System.Drawing.Point(823, 7);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(89, 18);
            this.lblTimeDate.TabIndex = 3;
            this.lblTimeDate.Text = "Time && Date";
            // 
            // lblOrderNum
            // 
            this.lblOrderNum.Location = new System.Drawing.Point(823, 26);
            this.lblOrderNum.Name = "lblOrderNum";
            this.lblOrderNum.Size = new System.Drawing.Size(89, 18);
            this.lblOrderNum.TabIndex = 4;
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
            this.boxOrderInfo.Location = new System.Drawing.Point(435, 104);
            this.boxOrderInfo.Name = "boxOrderInfo";
            this.boxOrderInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.boxOrderInfo.Size = new System.Drawing.Size(464, 396);
            this.boxOrderInfo.TabIndex = 5;
            this.boxOrderInfo.TabStop = false;
            this.boxOrderInfo.Text = "Order Info";
            // 
            // nudQty
            // 
            this.nudQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQty.Location = new System.Drawing.Point(153, 90);
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
            this.boxPizzaToppings.Location = new System.Drawing.Point(6, 165);
            this.boxPizzaToppings.Name = "boxPizzaToppings";
            this.boxPizzaToppings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxPizzaToppings.Size = new System.Drawing.Size(206, 208);
            this.boxPizzaToppings.TabIndex = 2;
            this.boxPizzaToppings.TabStop = false;
            this.boxPizzaToppings.Text = "Pizza Toppings";
            // 
            // boxPizzaSize
            // 
            this.boxPizzaSize.Controls.Add(this.rdoLarge);
            this.boxPizzaSize.Controls.Add(this.rdoMedium);
            this.boxPizzaSize.Controls.Add(this.rdoSmall);
            this.boxPizzaSize.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPizzaSize.Location = new System.Drawing.Point(6, 33);
            this.boxPizzaSize.Name = "boxPizzaSize";
            this.boxPizzaSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxPizzaSize.Size = new System.Drawing.Size(139, 124);
            this.boxPizzaSize.TabIndex = 0;
            this.boxPizzaSize.TabStop = false;
            this.boxPizzaSize.Text = "Pizza Size";
            // 
            // lblQty
            // 
            this.lblQty.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQty.Location = new System.Drawing.Point(153, 65);
            this.lblQty.Name = "lblQty";
            this.lblQty.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblQty.Size = new System.Drawing.Size(59, 22);
            this.lblQty.TabIndex = 4;
            this.lblQty.Text = "QTY";
            this.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoSmall
            // 
            this.rdoSmall.AutoSize = true;
            this.rdoSmall.Location = new System.Drawing.Point(6, 24);
            this.rdoSmall.Name = "rdoSmall";
            this.rdoSmall.Size = new System.Drawing.Size(77, 26);
            this.rdoSmall.TabIndex = 0;
            this.rdoSmall.TabStop = true;
            this.rdoSmall.Text = "Small";
            this.rdoSmall.UseVisualStyleBackColor = true;
            // 
            // rdoMedium
            // 
            this.rdoMedium.AutoSize = true;
            this.rdoMedium.Location = new System.Drawing.Point(6, 54);
            this.rdoMedium.Name = "rdoMedium";
            this.rdoMedium.Size = new System.Drawing.Size(98, 26);
            this.rdoMedium.TabIndex = 1;
            this.rdoMedium.TabStop = true;
            this.rdoMedium.Text = "Medium";
            this.rdoMedium.UseVisualStyleBackColor = true;
            // 
            // rdoLarge
            // 
            this.rdoLarge.AutoSize = true;
            this.rdoLarge.Location = new System.Drawing.Point(6, 84);
            this.rdoLarge.Name = "rdoLarge";
            this.rdoLarge.Size = new System.Drawing.Size(75, 26);
            this.rdoLarge.TabIndex = 2;
            this.rdoLarge.TabStop = true;
            this.rdoLarge.Text = "Large";
            this.rdoLarge.UseVisualStyleBackColor = true;
            // 
            // chkPep
            // 
            this.chkPep.AutoSize = true;
            this.chkPep.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPep.Location = new System.Drawing.Point(5, 23);
            this.chkPep.Name = "chkPep";
            this.chkPep.Size = new System.Drawing.Size(98, 23);
            this.chkPep.TabIndex = 0;
            this.chkPep.Text = "Pepporoni";
            this.chkPep.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSausage.Location = new System.Drawing.Point(117, 23);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(84, 23);
            this.chkSausage.TabIndex = 1;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPineapple.Location = new System.Drawing.Point(5, 161);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(96, 23);
            this.chkPineapple.TabIndex = 2;
            this.chkPineapple.Text = "Pineapple";
            this.chkPineapple.UseVisualStyleBackColor = true;
            // 
            // chkBpepper
            // 
            this.chkBpepper.AutoSize = true;
            this.chkBpepper.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBpepper.Location = new System.Drawing.Point(5, 138);
            this.chkBpepper.Name = "chkBpepper";
            this.chkBpepper.Size = new System.Drawing.Size(104, 23);
            this.chkBpepper.TabIndex = 3;
            this.chkBpepper.Text = "Ban Pepper";
            this.chkBpepper.UseVisualStyleBackColor = true;
            // 
            // chkJalepeno
            // 
            this.chkJalepeno.AutoSize = true;
            this.chkJalepeno.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkJalepeno.Location = new System.Drawing.Point(5, 115);
            this.chkJalepeno.Name = "chkJalepeno";
            this.chkJalepeno.Size = new System.Drawing.Size(87, 23);
            this.chkJalepeno.TabIndex = 4;
            this.chkJalepeno.Text = "Jalepeno";
            this.chkJalepeno.UseVisualStyleBackColor = true;
            // 
            // chkHam
            // 
            this.chkHam.AutoSize = true;
            this.chkHam.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHam.Location = new System.Drawing.Point(5, 92);
            this.chkHam.Name = "chkHam";
            this.chkHam.Size = new System.Drawing.Size(62, 23);
            this.chkHam.TabIndex = 5;
            this.chkHam.Text = "Ham";
            this.chkHam.UseVisualStyleBackColor = true;
            // 
            // chkBolive
            // 
            this.chkBolive.AutoSize = true;
            this.chkBolive.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBolive.Location = new System.Drawing.Point(117, 69);
            this.chkBolive.Name = "chkBolive";
            this.chkBolive.Size = new System.Drawing.Size(81, 23);
            this.chkBolive.TabIndex = 6;
            this.chkBolive.Text = "B Olive";
            this.chkBolive.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(5, 69);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(74, 23);
            this.chkOnion.TabIndex = 7;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // chkGolive
            // 
            this.chkGolive.AutoSize = true;
            this.chkGolive.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGolive.Location = new System.Drawing.Point(117, 46);
            this.chkGolive.Name = "chkGolive";
            this.chkGolive.Size = new System.Drawing.Size(84, 23);
            this.chkGolive.TabIndex = 8;
            this.chkGolive.Text = "G Olive";
            this.chkGolive.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Book Antiqua", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(5, 46);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(108, 23);
            this.chkMushrooms.TabIndex = 9;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(224, 36);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotal.Size = new System.Drawing.Size(234, 127);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // boxButtons
            // 
            this.boxButtons.Controls.Add(this.btnReset);
            this.boxButtons.Controls.Add(this.btnPrice);
            this.boxButtons.Controls.Add(this.btnClose);
            this.boxButtons.Controls.Add(this.btnAccept);
            this.boxButtons.Location = new System.Drawing.Point(218, 211);
            this.boxButtons.Name = "boxButtons";
            this.boxButtons.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxButtons.Size = new System.Drawing.Size(240, 162);
            this.boxButtons.TabIndex = 6;
            this.boxButtons.TabStop = false;
            // 
            // btnAccept
            // 
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Location = new System.Drawing.Point(4, 94);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(111, 55);
            this.btnAccept.TabIndex = 0;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(121, 95);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 55);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(121, 25);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 55);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnPrice
            // 
            this.btnPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrice.Location = new System.Drawing.Point(6, 25);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(111, 55);
            this.btnPrice.TabIndex = 2;
            this.btnPrice.Text = "Price";
            this.btnPrice.UseVisualStyleBackColor = true;
            // 
            // drpPayMethod
            // 
            this.drpPayMethod.FormattingEnabled = true;
            this.drpPayMethod.Location = new System.Drawing.Point(224, 171);
            this.drpPayMethod.Name = "drpPayMethod";
            this.drpPayMethod.Size = new System.Drawing.Size(234, 40);
            this.drpPayMethod.TabIndex = 7;
            this.drpPayMethod.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmPizzaPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(923, 572);
            this.Controls.Add(this.boxOrderInfo);
            this.Controls.Add(this.lblOrderNum);
            this.Controls.Add(this.lblTimeDate);
            this.Controls.Add(this.picPizzageddon);
            this.Controls.Add(this.lblPizzageddon);
            this.Controls.Add(this.boxCustomerInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPizzaPOS";
            this.Text = "Pizzageddon POS";
            this.boxCustomerInfo.ResumeLayout(false);
            this.boxCustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizzageddon)).EndInit();
            this.boxOrderInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.boxPizzaToppings.ResumeLayout(false);
            this.boxPizzaToppings.PerformLayout();
            this.boxPizzaSize.ResumeLayout(false);
            this.boxPizzaSize.PerformLayout();
            this.boxButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox boxCustomerInfo;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.MaskedTextBox txtZip;
        private System.Windows.Forms.ComboBox drpState;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}

