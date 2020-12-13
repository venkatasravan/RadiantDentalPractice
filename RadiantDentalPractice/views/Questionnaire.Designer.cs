namespace RadiantDentalPractice.views
{
    partial class Questionnaire
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
            this.Question1 = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Question1_TXT = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Question1
            // 
            this.Question1.AutoSize = true;
            this.Question1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question1.Location = new System.Drawing.Point(68, 115);
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(345, 20);
            this.Question1.TabIndex = 0;
            this.Question1.Text = "Do you have alergy to latex or Antibiotics?";
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(337, 295);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 38);
            this.Next.TabIndex = 3;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Question1_TXT
            // 
            this.Question1_TXT.FormattingEnabled = true;
            this.Question1_TXT.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.Question1_TXT.Location = new System.Drawing.Point(490, 115);
            this.Question1_TXT.Name = "Question1_TXT";
            this.Question1_TXT.Size = new System.Drawing.Size(121, 21);
            this.Question1_TXT.TabIndex = 4;
            this.Question1_TXT.SelectedIndexChanged += new System.EventHandler(this.Question1_TXT_SelectedIndexChanged);
            // 
            // Questionnaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Question1_TXT);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Question1);
            this.Name = "Questionnaire";
            this.Text = "Questionnaire";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Question1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.ComboBox Question1_TXT;
    }
}