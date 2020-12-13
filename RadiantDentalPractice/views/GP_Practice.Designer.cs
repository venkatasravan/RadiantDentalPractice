namespace RadiantDentalPractice.views
{
    partial class GP_Practice
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
            this.GP_Name = new System.Windows.Forms.Label();
            this.GP_Name_Txt = new System.Windows.Forms.TextBox();
            this.GP_addressTXT = new System.Windows.Forms.TextBox();
            this.GP_Address = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GP_Name
            // 
            this.GP_Name.AutoSize = true;
            this.GP_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GP_Name.Location = new System.Drawing.Point(327, 114);
            this.GP_Name.Name = "GP_Name";
            this.GP_Name.Size = new System.Drawing.Size(76, 17);
            this.GP_Name.TabIndex = 0;
            this.GP_Name.Text = "GP Name";
            // 
            // GP_Name_Txt
            // 
            this.GP_Name_Txt.Location = new System.Drawing.Point(439, 114);
            this.GP_Name_Txt.Name = "GP_Name_Txt";
            this.GP_Name_Txt.Size = new System.Drawing.Size(100, 20);
            this.GP_Name_Txt.TabIndex = 1;
            // 
            // GP_addressTXT
            // 
            this.GP_addressTXT.Location = new System.Drawing.Point(439, 179);
            this.GP_addressTXT.Name = "GP_addressTXT";
            this.GP_addressTXT.Size = new System.Drawing.Size(132, 20);
            this.GP_addressTXT.TabIndex = 2;
            // 
            // GP_Address
            // 
            this.GP_Address.AutoSize = true;
            this.GP_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GP_Address.Location = new System.Drawing.Point(327, 182);
            this.GP_Address.Name = "GP_Address";
            this.GP_Address.Size = new System.Drawing.Size(94, 17);
            this.GP_Address.TabIndex = 3;
            this.GP_Address.Text = "GP Address";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(387, 285);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(106, 35);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // GP_Practice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.GP_Address);
            this.Controls.Add(this.GP_addressTXT);
            this.Controls.Add(this.GP_Name_Txt);
            this.Controls.Add(this.GP_Name);
            this.Name = "GP_Practice";
            this.Text = "GP_Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GP_Name;
        private System.Windows.Forms.TextBox GP_Name_Txt;
        private System.Windows.Forms.TextBox GP_addressTXT;
        private System.Windows.Forms.Label GP_Address;
        private System.Windows.Forms.Button Submit;
    }
}