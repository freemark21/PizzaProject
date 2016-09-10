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
            this.boxPizzaSize = new System.Windows.Forms.GroupBox();
            this.boxPizzaToppings = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.boxCustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPizzageddon)).BeginInit();
            this.boxOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.boxOrderInfo.Controls.Add(this.numericUpDown1);
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
            // boxPizzaSize
            // 
            this.boxPizzaSize.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPizzaSize.Location = new System.Drawing.Point(23, 39);
            this.boxPizzaSize.Name = "boxPizzaSize";
            this.boxPizzaSize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxPizzaSize.Size = new System.Drawing.Size(200, 100);
            this.boxPizzaSize.TabIndex = 0;
            this.boxPizzaSize.TabStop = false;
            this.boxPizzaSize.Text = "Pizza Size";
            // 
            // boxPizzaToppings
            // 
            this.boxPizzaToppings.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPizzaToppings.Location = new System.Drawing.Point(23, 175);
            this.boxPizzaToppings.Name = "boxPizzaToppings";
            this.boxPizzaToppings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxPizzaToppings.Size = new System.Drawing.Size(200, 100);
            this.boxPizzaToppings.TabIndex = 2;
            this.boxPizzaToppings.TabStop = false;
            this.boxPizzaToppings.Text = "Pizza Toppings";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(229, 89);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown1.Size = new System.Drawing.Size(59, 38);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox boxPizzaToppings;
        private System.Windows.Forms.GroupBox boxPizzaSize;
    }
}

