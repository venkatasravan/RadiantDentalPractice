namespace RadiantDentalPractice.views
{
    partial class DentalSurgeryVisitForm
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
            this.patientID = new System.Windows.Forms.Label();
            this.patientIDTXT = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patientID
            // 
            this.patientID.AutoSize = true;
            this.patientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientID.Location = new System.Drawing.Point(220, 130);
            this.patientID.Name = "patientID";
            this.patientID.Size = new System.Drawing.Size(85, 20);
            this.patientID.TabIndex = 0;
            this.patientID.Text = "PatientID";
            // 
            // patientIDTXT
            // 
            this.patientIDTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDTXT.Location = new System.Drawing.Point(339, 127);
            this.patientIDTXT.Name = "patientIDTXT";
            this.patientIDTXT.Size = new System.Drawing.Size(139, 26);
            this.patientIDTXT.TabIndex = 1;
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(323, 215);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(119, 40);
            this.next.TabIndex = 2;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // DentalSurgeryVisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.next);
            this.Controls.Add(this.patientIDTXT);
            this.Controls.Add(this.patientID);
            this.Name = "DentalSurgeryVisitForm";
            this.Text = "DentalSurgeryVisitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patientID;
        private System.Windows.Forms.TextBox patientIDTXT;
        private System.Windows.Forms.Button next;
    }
}