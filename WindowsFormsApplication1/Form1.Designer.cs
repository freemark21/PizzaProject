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
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.grpCustomerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.lblPhone);
            this.grpCustomerInfo.Controls.Add(this.txtPhone);
            this.grpCustomerInfo.Font = new System.Drawing.Font("Book Antiqua", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomerInfo.Location = new System.Drawing.Point(13, 12);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(340, 427);
            this.grpCustomerInfo.TabIndex = 0;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Customer Info";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(112, 45);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(164, 36);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblPhone
            // 
            this.lblPhone.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(6, 45);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 36);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone:";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmPizzaPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 451);
            this.Controls.Add(this.grpCustomerInfo);
            this.Name = "frmPizzaPOS";
            this.Text = "Pizzageddon POS";
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
    }
}

