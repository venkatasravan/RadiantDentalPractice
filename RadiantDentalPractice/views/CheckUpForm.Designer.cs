namespace RadiantDentalPractice.views
{
    partial class CheckUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.patientIDTXT = new System.Windows.Forms.TextBox();
            this.checkUpDateTXT = new System.Windows.Forms.DateTimePicker();
            this.CheckUpDate = new System.Windows.Forms.Label();
            this.bookingSlotTXT = new System.Windows.Forms.ComboBox();
            this.BookingSlot = new System.Windows.Forms.Label();
            this.Book = new System.Windows.Forms.Button();
            this.NoteTXT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PatientID";
            // 
            // patientIDTXT
            // 
            this.patientIDTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDTXT.Location = new System.Drawing.Point(396, 98);
            this.patientIDTXT.Name = "patientIDTXT";
            this.patientIDTXT.Size = new System.Drawing.Size(186, 26);
            this.patientIDTXT.TabIndex = 1;
            // 
            // checkUpDateTXT
            // 
            this.checkUpDateTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUpDateTXT.Location = new System.Drawing.Point(396, 145);
            this.checkUpDateTXT.Name = "checkUpDateTXT";
            this.checkUpDateTXT.Size = new System.Drawing.Size(186, 26);
            this.checkUpDateTXT.TabIndex = 2;
            this.checkUpDateTXT.ValueChanged += new System.EventHandler(this.checkUpDateTXT_ValueChanged);
            // 
            // CheckUpDate
            // 
            this.CheckUpDate.AutoSize = true;
            this.CheckUpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckUpDate.Location = new System.Drawing.Point(240, 145);
            this.CheckUpDate.Name = "CheckUpDate";
            this.CheckUpDate.Size = new System.Drawing.Size(131, 20);
            this.CheckUpDate.TabIndex = 3;
            this.CheckUpDate.Text = "Check Up Date";
            // 
            // bookingSlotTXT
            // 
            this.bookingSlotTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingSlotTXT.FormattingEnabled = true;
            this.bookingSlotTXT.Location = new System.Drawing.Point(396, 188);
            this.bookingSlotTXT.Name = "bookingSlotTXT";
            this.bookingSlotTXT.Size = new System.Drawing.Size(186, 28);
            this.bookingSlotTXT.TabIndex = 4;
            // 
            // BookingSlot
            // 
            this.BookingSlot.AutoSize = true;
            this.BookingSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingSlot.Location = new System.Drawing.Point(258, 189);
            this.BookingSlot.Name = "BookingSlot";
            this.BookingSlot.Size = new System.Drawing.Size(111, 20);
            this.BookingSlot.TabIndex = 5;
            this.BookingSlot.Text = "Booking Slot";
            // 
            // Book
            // 
            this.Book.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book.Location = new System.Drawing.Point(368, 294);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(108, 35);
            this.Book.TabIndex = 6;
            this.Book.Text = "Book";
            this.Book.UseVisualStyleBackColor = false;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // NoteTXT
            // 
            this.NoteTXT.AutoSize = true;
            this.NoteTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteTXT.Location = new System.Drawing.Point(171, 252);
            this.NoteTXT.Name = "NoteTXT";
            this.NoteTXT.Size = new System.Drawing.Size(47, 17);
            this.NoteTXT.TabIndex = 7;
            this.NoteTXT.Text = "Note:";
            // 
            // CheckUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NoteTXT);
            this.Controls.Add(this.Book);
            this.Controls.Add(this.BookingSlot);
            this.Controls.Add(this.bookingSlotTXT);
            this.Controls.Add(this.CheckUpDate);
            this.Controls.Add(this.checkUpDateTXT);
            this.Controls.Add(this.patientIDTXT);
            this.Controls.Add(this.label1);
            this.Name = "CheckUpForm";
            this.Text = "CheckUpForm";
            this.Load += new System.EventHandler(this.CheckUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patientIDTXT;
        private System.Windows.Forms.DateTimePicker checkUpDateTXT;
        private System.Windows.Forms.Label CheckUpDate;
        private System.Windows.Forms.ComboBox bookingSlotTXT;
        private System.Windows.Forms.Label BookingSlot;
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.Label NoteTXT;
    }
}