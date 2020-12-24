namespace RadiantDentalPractice.views
{
    partial class AppointmentsList
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
            this.AppointmentsData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsData)).BeginInit();
            this.SuspendLayout();
            // 
            // AppointmentsData
            // 
            this.AppointmentsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AppointmentsData.Location = new System.Drawing.Point(67, 76);
            this.AppointmentsData.Name = "AppointmentsData";
            this.AppointmentsData.Size = new System.Drawing.Size(536, 243);
            this.AppointmentsData.TabIndex = 0;
            // 
            // AppointmentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AppointmentsData);
            this.Name = "AppointmentsList";
            this.Text = "AppointmentsList";
            this.Load += new System.EventHandler(this.AppointmentsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AppointmentsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AppointmentsData;
    }
}