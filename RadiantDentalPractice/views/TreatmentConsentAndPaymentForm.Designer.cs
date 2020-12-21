namespace RadiantDentalPractice.views
{
    partial class TreatmentConsentAndPaymentForm
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
            this.Payment = new System.Windows.Forms.Label();
            this.PaymentTXT = new System.Windows.Forms.Label();
            this.consentTXT = new System.Windows.Forms.CheckBox();
            this.Consent = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Payment.Location = new System.Drawing.Point(263, 67);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(155, 20);
            this.Payment.TabIndex = 0;
            this.Payment.Text = "You need to pay £";
            this.Payment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PaymentTXT
            // 
            this.PaymentTXT.AutoSize = true;
            this.PaymentTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentTXT.Location = new System.Drawing.Point(412, 67);
            this.PaymentTXT.Name = "PaymentTXT";
            this.PaymentTXT.Size = new System.Drawing.Size(19, 20);
            this.PaymentTXT.TabIndex = 1;
            this.PaymentTXT.Text = "0";
            // 
            // consentTXT
            // 
            this.consentTXT.AutoSize = true;
            this.consentTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consentTXT.Location = new System.Drawing.Point(22, 170);
            this.consentTXT.Name = "consentTXT";
            this.consentTXT.Size = new System.Drawing.Size(15, 14);
            this.consentTXT.TabIndex = 3;
            this.consentTXT.UseVisualStyleBackColor = true;
            // 
            // Consent
            // 
            this.Consent.AutoSize = true;
            this.Consent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consent.Location = new System.Drawing.Point(33, 166);
            this.Consent.Name = "Consent";
            this.Consent.Size = new System.Drawing.Size(740, 20);
            this.Consent.TabIndex = 2;
            this.Consent.Text = "I understand the nature of the proposed NHS treatment services and accept those s" +
    "ervices";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(333, 267);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(98, 35);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // TreatmentConsentAndPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.consentTXT);
            this.Controls.Add(this.Consent);
            this.Controls.Add(this.PaymentTXT);
            this.Controls.Add(this.Payment);
            this.Name = "TreatmentConsentAndPaymentForm";
            this.Text = "TreatmentConsentAndPaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Payment;
        private System.Windows.Forms.Label PaymentTXT;
        private System.Windows.Forms.CheckBox consentTXT;
        private System.Windows.Forms.Label Consent;
        private System.Windows.Forms.Button Submit;
    }
}