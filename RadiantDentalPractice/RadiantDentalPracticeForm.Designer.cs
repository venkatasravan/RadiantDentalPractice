namespace RadiantDentalPractice
{
    partial class RadiantDentalPractice
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
            this.RegisterPatient = new System.Windows.Forms.Button();
            this.DentalSurgery = new System.Windows.Forms.Button();
            this.BookCheckup = new System.Windows.Forms.Button();
            this.EmergencyAppointment = new System.Windows.Forms.Button();
            this.AppointmentReminders = new System.Windows.Forms.Button();
            this.StaffServices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegisterPatient
            // 
            this.RegisterPatient.Location = new System.Drawing.Point(175, 88);
            this.RegisterPatient.Name = "RegisterPatient";
            this.RegisterPatient.Size = new System.Drawing.Size(126, 23);
            this.RegisterPatient.TabIndex = 0;
            this.RegisterPatient.Text = "RegisterPatient";
            this.RegisterPatient.UseVisualStyleBackColor = true;
            // 
            // DentalSurgery
            // 
            this.DentalSurgery.Location = new System.Drawing.Point(468, 88);
            this.DentalSurgery.Name = "DentalSurgery";
            this.DentalSurgery.Size = new System.Drawing.Size(104, 23);
            this.DentalSurgery.TabIndex = 1;
            this.DentalSurgery.Text = "DentalSurgery";
            this.DentalSurgery.UseVisualStyleBackColor = true;
            // 
            // BookCheckup
            // 
            this.BookCheckup.Location = new System.Drawing.Point(175, 171);
            this.BookCheckup.Name = "BookCheckup";
            this.BookCheckup.Size = new System.Drawing.Size(126, 23);
            this.BookCheckup.TabIndex = 2;
            this.BookCheckup.Text = "BookCheckup";
            this.BookCheckup.UseVisualStyleBackColor = true;
            // 
            // EmergencyAppointment
            // 
            this.EmergencyAppointment.Location = new System.Drawing.Point(468, 171);
            this.EmergencyAppointment.Name = "EmergencyAppointment";
            this.EmergencyAppointment.Size = new System.Drawing.Size(151, 23);
            this.EmergencyAppointment.TabIndex = 3;
            this.EmergencyAppointment.Text = "EmergencyAppointment";
            this.EmergencyAppointment.UseVisualStyleBackColor = true;
            // 
            // AppointmentReminders
            // 
            this.AppointmentReminders.Location = new System.Drawing.Point(175, 297);
            this.AppointmentReminders.Name = "AppointmentReminders";
            this.AppointmentReminders.Size = new System.Drawing.Size(125, 23);
            this.AppointmentReminders.TabIndex = 4;
            this.AppointmentReminders.Text = "AppointmentReminders";
            this.AppointmentReminders.UseVisualStyleBackColor = true;
            // 
            // StaffServices
            // 
            this.StaffServices.Location = new System.Drawing.Point(497, 297);
            this.StaffServices.Name = "StaffServices";
            this.StaffServices.Size = new System.Drawing.Size(75, 23);
            this.StaffServices.TabIndex = 5;
            this.StaffServices.Text = "StaffServices";
            this.StaffServices.UseVisualStyleBackColor = true;
            // 
            // RadiantDentalPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StaffServices);
            this.Controls.Add(this.AppointmentReminders);
            this.Controls.Add(this.EmergencyAppointment);
            this.Controls.Add(this.BookCheckup);
            this.Controls.Add(this.DentalSurgery);
            this.Controls.Add(this.RegisterPatient);
            this.Name = "RadiantDentalPractice";
            this.Text = "RadiantDentalPractice";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegisterPatient;
        private System.Windows.Forms.Button DentalSurgery;
        private System.Windows.Forms.Button BookCheckup;
        private System.Windows.Forms.Button EmergencyAppointment;
        private System.Windows.Forms.Button AppointmentReminders;
        private System.Windows.Forms.Button StaffServices;
    }
}

