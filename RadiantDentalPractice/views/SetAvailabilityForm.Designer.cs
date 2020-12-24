namespace RadiantDentalPractice.views
{
    partial class SetAvailabilityForm
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
            this.StaffNameTXT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectDate = new System.Windows.Forms.Label();
            this.SelectedDateTXT = new System.Windows.Forms.DateTimePicker();
            this.AvailabilityStatusTXT = new System.Windows.Forms.ComboBox();
            this.AvailabilityStatus = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StaffNameTXT
            // 
            this.StaffNameTXT.BackColor = System.Drawing.Color.White;
            this.StaffNameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaffNameTXT.FormattingEnabled = true;
            this.StaffNameTXT.Location = new System.Drawing.Point(382, 80);
            this.StaffNameTXT.Name = "StaffNameTXT";
            this.StaffNameTXT.Size = new System.Drawing.Size(168, 28);
            this.StaffNameTXT.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff Name";
            // 
            // SelectDate
            // 
            this.SelectDate.AutoSize = true;
            this.SelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectDate.Location = new System.Drawing.Point(256, 145);
            this.SelectDate.Name = "SelectDate";
            this.SelectDate.Size = new System.Drawing.Size(104, 20);
            this.SelectDate.TabIndex = 2;
            this.SelectDate.Text = "Select Date";
            // 
            // SelectedDateTXT
            // 
            this.SelectedDateTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedDateTXT.Location = new System.Drawing.Point(382, 144);
            this.SelectedDateTXT.Name = "SelectedDateTXT";
            this.SelectedDateTXT.Size = new System.Drawing.Size(168, 26);
            this.SelectedDateTXT.TabIndex = 3;
            this.SelectedDateTXT.ValueChanged += new System.EventHandler(this.SelectedDateTXT_ValueChanged);
            // 
            // AvailabilityStatusTXT
            // 
            this.AvailabilityStatusTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailabilityStatusTXT.FormattingEnabled = true;
            this.AvailabilityStatusTXT.Location = new System.Drawing.Point(382, 207);
            this.AvailabilityStatusTXT.Name = "AvailabilityStatusTXT";
            this.AvailabilityStatusTXT.Size = new System.Drawing.Size(168, 28);
            this.AvailabilityStatusTXT.TabIndex = 4;
            // 
            // AvailabilityStatus
            // 
            this.AvailabilityStatus.AutoSize = true;
            this.AvailabilityStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvailabilityStatus.Location = new System.Drawing.Point(209, 208);
            this.AvailabilityStatus.Name = "AvailabilityStatus";
            this.AvailabilityStatus.Size = new System.Drawing.Size(151, 20);
            this.AvailabilityStatus.TabIndex = 5;
            this.AvailabilityStatus.Text = "Availability Status";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(370, 303);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(100, 36);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            // 
            // SetAvailabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.AvailabilityStatus);
            this.Controls.Add(this.AvailabilityStatusTXT);
            this.Controls.Add(this.SelectedDateTXT);
            this.Controls.Add(this.SelectDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StaffNameTXT);
            this.Name = "SetAvailabilityForm";
            this.Text = "SetAvailabilityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StaffNameTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SelectDate;
        private System.Windows.Forms.DateTimePicker SelectedDateTXT;
        private System.Windows.Forms.ComboBox AvailabilityStatusTXT;
        private System.Windows.Forms.Label AvailabilityStatus;
        private System.Windows.Forms.Button Submit;
    }
}