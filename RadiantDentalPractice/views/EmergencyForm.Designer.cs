namespace RadiantDentalPractice.views
{
    partial class EmergencyForm
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
            this.BookingDate = new System.Windows.Forms.Label();
            this.BookingSlot = new System.Windows.Forms.Label();
            this.patientIDTXT = new System.Windows.Forms.TextBox();
            this.bookingDateTXT = new System.Windows.Forms.DateTimePicker();
            this.bookingSlotTXT = new System.Windows.Forms.ComboBox();
            this.Book = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PatientID";
            // 
            // BookingDate
            // 
            this.BookingDate.AutoSize = true;
            this.BookingDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingDate.Location = new System.Drawing.Point(237, 133);
            this.BookingDate.Name = "BookingDate";
            this.BookingDate.Size = new System.Drawing.Size(118, 20);
            this.BookingDate.TabIndex = 1;
            this.BookingDate.Text = "Booking Date";
            // 
            // BookingSlot
            // 
            this.BookingSlot.AutoSize = true;
            this.BookingSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingSlot.Location = new System.Drawing.Point(237, 194);
            this.BookingSlot.Name = "BookingSlot";
            this.BookingSlot.Size = new System.Drawing.Size(111, 20);
            this.BookingSlot.TabIndex = 2;
            this.BookingSlot.Text = "Booking Slot";
            // 
            // patientIDTXT
            // 
            this.patientIDTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDTXT.Location = new System.Drawing.Point(406, 69);
            this.patientIDTXT.Name = "patientIDTXT";
            this.patientIDTXT.Size = new System.Drawing.Size(173, 26);
            this.patientIDTXT.TabIndex = 3;
            // 
            // bookingDateTXT
            // 
            this.bookingDateTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingDateTXT.Location = new System.Drawing.Point(406, 133);
            this.bookingDateTXT.Name = "bookingDateTXT";
            this.bookingDateTXT.Size = new System.Drawing.Size(173, 26);
            this.bookingDateTXT.TabIndex = 4;
            this.bookingDateTXT.ValueChanged += new System.EventHandler(this.bookingDateTXT_ValueChanged);
            // 
            // bookingSlotTXT
            // 
            this.bookingSlotTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingSlotTXT.FormattingEnabled = true;
            this.bookingSlotTXT.Location = new System.Drawing.Point(406, 193);
            this.bookingSlotTXT.Name = "bookingSlotTXT";
            this.bookingSlotTXT.Size = new System.Drawing.Size(173, 28);
            this.bookingSlotTXT.TabIndex = 5;
            // 
            // Book
            // 
            this.Book.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book.Location = new System.Drawing.Point(361, 287);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(123, 37);
            this.Book.TabIndex = 6;
            this.Book.Text = "Book";
            this.Book.UseVisualStyleBackColor = false;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // EmergencyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Book);
            this.Controls.Add(this.bookingSlotTXT);
            this.Controls.Add(this.bookingDateTXT);
            this.Controls.Add(this.patientIDTXT);
            this.Controls.Add(this.BookingSlot);
            this.Controls.Add(this.BookingDate);
            this.Controls.Add(this.label1);
            this.Name = "EmergencyForm";
            this.Text = "EmergencyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BookingDate;
        private System.Windows.Forms.Label BookingSlot;
        private System.Windows.Forms.TextBox patientIDTXT;
        private System.Windows.Forms.DateTimePicker bookingDateTXT;
        private System.Windows.Forms.ComboBox bookingSlotTXT;
        private System.Windows.Forms.Button Book;
    }
}