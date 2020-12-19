namespace RadiantDentalPractice.views
{
    partial class RecordTreatmentForm
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
            this.PatientID = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.patientIDTXT = new System.Windows.Forms.TextBox();
            this.TreatmentNotes = new System.Windows.Forms.Label();
            this.treatmentNotesTXT = new System.Windows.Forms.TextBox();
            this.proposedTreatment = new System.Windows.Forms.Label();
            this.proposedTreatmentList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // PatientID
            // 
            this.PatientID.AutoSize = true;
            this.PatientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientID.Location = new System.Drawing.Point(251, 30);
            this.PatientID.Name = "PatientID";
            this.PatientID.Size = new System.Drawing.Size(85, 20);
            this.PatientID.TabIndex = 0;
            this.PatientID.Text = "PatientID";
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(352, 341);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(156, 37);
            this.Next.TabIndex = 1;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // patientIDTXT
            // 
            this.patientIDTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientIDTXT.Location = new System.Drawing.Point(382, 27);
            this.patientIDTXT.Name = "patientIDTXT";
            this.patientIDTXT.Size = new System.Drawing.Size(200, 26);
            this.patientIDTXT.TabIndex = 2;
            // 
            // TreatmentNotes
            // 
            this.TreatmentNotes.AutoSize = true;
            this.TreatmentNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TreatmentNotes.Location = new System.Drawing.Point(212, 87);
            this.TreatmentNotes.Name = "TreatmentNotes";
            this.TreatmentNotes.Size = new System.Drawing.Size(143, 20);
            this.TreatmentNotes.TabIndex = 3;
            this.TreatmentNotes.Text = "Treatment Notes";
            // 
            // treatmentNotesTXT
            // 
            this.treatmentNotesTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treatmentNotesTXT.Location = new System.Drawing.Point(382, 84);
            this.treatmentNotesTXT.Multiline = true;
            this.treatmentNotesTXT.Name = "treatmentNotesTXT";
            this.treatmentNotesTXT.Size = new System.Drawing.Size(200, 40);
            this.treatmentNotesTXT.TabIndex = 4;
            // 
            // proposedTreatment
            // 
            this.proposedTreatment.AutoSize = true;
            this.proposedTreatment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proposedTreatment.Location = new System.Drawing.Point(178, 177);
            this.proposedTreatment.Name = "proposedTreatment";
            this.proposedTreatment.Size = new System.Drawing.Size(177, 20);
            this.proposedTreatment.TabIndex = 5;
            this.proposedTreatment.Text = "Proposed Treatment ";
            // 
            // proposedTreatmentList
            // 
            this.proposedTreatmentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proposedTreatmentList.FormattingEnabled = true;
            this.proposedTreatmentList.Location = new System.Drawing.Point(382, 177);
            this.proposedTreatmentList.Name = "proposedTreatmentList";
            this.proposedTreatmentList.Size = new System.Drawing.Size(210, 109);
            this.proposedTreatmentList.TabIndex = 6;
            // 
            // RecordTreatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.proposedTreatmentList);
            this.Controls.Add(this.proposedTreatment);
            this.Controls.Add(this.treatmentNotesTXT);
            this.Controls.Add(this.TreatmentNotes);
            this.Controls.Add(this.patientIDTXT);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.PatientID);
            this.Name = "RecordTreatmentForm";
            this.Text = "RecordTreatmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatientID;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.TextBox patientIDTXT;
        private System.Windows.Forms.Label TreatmentNotes;
        private System.Windows.Forms.TextBox treatmentNotesTXT;
        private System.Windows.Forms.Label proposedTreatment;
        private System.Windows.Forms.CheckedListBox proposedTreatmentList;
    }
}