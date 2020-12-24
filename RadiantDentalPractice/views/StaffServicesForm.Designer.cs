namespace RadiantDentalPractice.views
{
    partial class StaffServicesForm
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
            this.SetAvailability = new System.Windows.Forms.Button();
            this.AllocatePatients = new System.Windows.Forms.Button();
            this.UnAllocatedPatients = new System.Windows.Forms.Button();
            this.AddStaff = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SetAvailability
            // 
            this.SetAvailability.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SetAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetAvailability.Location = new System.Drawing.Point(445, 77);
            this.SetAvailability.Name = "SetAvailability";
            this.SetAvailability.Size = new System.Drawing.Size(158, 45);
            this.SetAvailability.TabIndex = 0;
            this.SetAvailability.Text = "Set Availability";
            this.SetAvailability.UseVisualStyleBackColor = false;
            this.SetAvailability.Click += new System.EventHandler(this.SetAvailability_Click);
            // 
            // AllocatePatients
            // 
            this.AllocatePatients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AllocatePatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllocatePatients.Location = new System.Drawing.Point(82, 184);
            this.AllocatePatients.Name = "AllocatePatients";
            this.AllocatePatients.Size = new System.Drawing.Size(181, 46);
            this.AllocatePatients.TabIndex = 1;
            this.AllocatePatients.Text = "Allocate Patients";
            this.AllocatePatients.UseVisualStyleBackColor = false;
            // 
            // UnAllocatedPatients
            // 
            this.UnAllocatedPatients.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UnAllocatedPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnAllocatedPatients.Location = new System.Drawing.Point(415, 186);
            this.UnAllocatedPatients.Name = "UnAllocatedPatients";
            this.UnAllocatedPatients.Size = new System.Drawing.Size(236, 44);
            this.UnAllocatedPatients.TabIndex = 2;
            this.UnAllocatedPatients.Text = "UnAllocated Patients";
            this.UnAllocatedPatients.UseVisualStyleBackColor = false;
            // 
            // AddStaff
            // 
            this.AddStaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStaff.Location = new System.Drawing.Point(105, 77);
            this.AddStaff.Name = "AddStaff";
            this.AddStaff.Size = new System.Drawing.Size(137, 45);
            this.AddStaff.TabIndex = 3;
            this.AddStaff.Text = "Add Staff";
            this.AddStaff.UseVisualStyleBackColor = false;
            this.AddStaff.Click += new System.EventHandler(this.AddStaff_Click);
            // 
            // StaffServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddStaff);
            this.Controls.Add(this.UnAllocatedPatients);
            this.Controls.Add(this.AllocatePatients);
            this.Controls.Add(this.SetAvailability);
            this.Name = "StaffServicesForm";
            this.Text = "StaffServicesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SetAvailability;
        private System.Windows.Forms.Button AllocatePatients;
        private System.Windows.Forms.Button UnAllocatedPatients;
        private System.Windows.Forms.Button AddStaff;
    }
}