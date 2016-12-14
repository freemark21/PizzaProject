namespace PizzaProject
{
    partial class frmCreditCard
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
            this.lblCCPtitle = new System.Windows.Forms.Label();
            this.mtbCCnumber = new System.Windows.Forms.MaskedTextBox();
            this.drpExpMonth = new System.Windows.Forms.ComboBox();
            this.drpExpYear = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCCPtitle
            // 
            this.lblCCPtitle.AutoSize = true;
            this.lblCCPtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCPtitle.Location = new System.Drawing.Point(117, 9);
            this.lblCCPtitle.Name = "lblCCPtitle";
            this.lblCCPtitle.Size = new System.Drawing.Size(245, 25);
            this.lblCCPtitle.TabIndex = 0;
            this.lblCCPtitle.Text = "Credit Card Proccessing";
            // 
            // mtbCCnumber
            // 
            this.mtbCCnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbCCnumber.Location = new System.Drawing.Point(123, 66);
            this.mtbCCnumber.Mask = "0000-0000-0000-0000";
            this.mtbCCnumber.Name = "mtbCCnumber";
            this.mtbCCnumber.Size = new System.Drawing.Size(233, 31);
            this.mtbCCnumber.TabIndex = 1;
            this.mtbCCnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbCCnumber_KeyPress);
            // 
            // drpExpMonth
            // 
            this.drpExpMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpExpMonth.FormattingEnabled = true;
            this.drpExpMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.drpExpMonth.Location = new System.Drawing.Point(169, 128);
            this.drpExpMonth.Name = "drpExpMonth";
            this.drpExpMonth.Size = new System.Drawing.Size(67, 33);
            this.drpExpMonth.TabIndex = 2;
            this.drpExpMonth.SelectedIndexChanged += new System.EventHandler(this.drpExpMonth_SelectedIndexChanged);
            // 
            // drpExpYear
            // 
            this.drpExpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drpExpYear.FormattingEnabled = true;
            this.drpExpYear.Items.AddRange(new object[] {
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.drpExpYear.Location = new System.Drawing.Point(242, 128);
            this.drpExpYear.Name = "drpExpYear";
            this.drpExpYear.Size = new System.Drawing.Size(67, 33);
            this.drpExpYear.TabIndex = 3;
            this.drpExpYear.SelectedIndexChanged += new System.EventHandler(this.drpExpYear_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(122, 208);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(98, 47);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(258, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 47);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(478, 307);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.drpExpYear);
            this.Controls.Add(this.drpExpMonth);
            this.Controls.Add(this.mtbCCnumber);
            this.Controls.Add(this.lblCCPtitle);
            this.Name = "frmCreditCard";
            this.Text = "frmCreditCard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCreditCard_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCCPtitle;
        private System.Windows.Forms.MaskedTextBox mtbCCnumber;
        private System.Windows.Forms.ComboBox drpExpMonth;
        private System.Windows.Forms.ComboBox drpExpYear;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}