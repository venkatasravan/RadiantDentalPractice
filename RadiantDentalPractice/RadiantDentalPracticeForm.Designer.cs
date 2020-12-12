﻿namespace RadiantDentalPractice
{
    partial class RadiantDentalPracticeForm
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
            this.RegisterPatient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.RegisterPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterPatient.Location = new System.Drawing.Point(143, 73);
            this.RegisterPatient.Name = "RegisterPatient";
            this.RegisterPatient.Size = new System.Drawing.Size(157, 38);
            this.RegisterPatient.TabIndex = 0;
            this.RegisterPatient.Text = "RegisterPatient";
            this.RegisterPatient.UseVisualStyleBackColor = false;
            this.RegisterPatient.Click += new System.EventHandler(this.RegisterPatient_Click);
            // 
            // DentalSurgery
            // 
            this.DentalSurgery.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DentalSurgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DentalSurgery.Location = new System.Drawing.Point(458, 73);
            this.DentalSurgery.Name = "DentalSurgery";
            this.DentalSurgery.Size = new System.Drawing.Size(166, 38);
            this.DentalSurgery.TabIndex = 1;
            this.DentalSurgery.Text = "DentalSurgery";
            this.DentalSurgery.UseVisualStyleBackColor = false;
            // 
            // BookCheckup
            // 
            this.BookCheckup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BookCheckup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCheckup.Location = new System.Drawing.Point(143, 173);
            this.BookCheckup.Name = "BookCheckup";
            this.BookCheckup.Size = new System.Drawing.Size(157, 43);
            this.BookCheckup.TabIndex = 2;
            this.BookCheckup.Text = "BookCheckup";
            this.BookCheckup.UseVisualStyleBackColor = false;
            // 
            // EmergencyAppointment
            // 
            this.EmergencyAppointment.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EmergencyAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmergencyAppointment.Location = new System.Drawing.Point(458, 173);
            this.EmergencyAppointment.Name = "EmergencyAppointment";
            this.EmergencyAppointment.Size = new System.Drawing.Size(216, 43);
            this.EmergencyAppointment.TabIndex = 3;
            this.EmergencyAppointment.Text = "EmergencyAppointment";
            this.EmergencyAppointment.UseVisualStyleBackColor = false;
            // 
            // AppointmentReminders
            // 
            this.AppointmentReminders.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AppointmentReminders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentReminders.Location = new System.Drawing.Point(143, 278);
            this.AppointmentReminders.Name = "AppointmentReminders";
            this.AppointmentReminders.Size = new System.Drawing.Size(239, 42);
            this.AppointmentReminders.TabIndex = 4;
            this.AppointmentReminders.Text = "AppointmentReminders";
            this.AppointmentReminders.UseVisualStyleBackColor = false;
            // 
            // StaffServices
            // 
            this.StaffServices.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.StaffServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffServices.Location = new System.Drawing.Point(458, 278);
            this.StaffServices.Name = "StaffServices";
            this.StaffServices.Size = new System.Drawing.Size(166, 42);
            this.StaffServices.TabIndex = 5;
            this.StaffServices.Text = "StaffServices";
            this.StaffServices.UseVisualStyleBackColor = false;
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
