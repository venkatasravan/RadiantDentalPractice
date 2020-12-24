namespace RadiantDentalPractice.views
{
    partial class AddStaffForm
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
            this.Name = new System.Windows.Forms.Label();
            this.nameTXT = new System.Windows.Forms.TextBox();
            this.Role = new System.Windows.Forms.Label();
            this.RoleList = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.BackColor = System.Drawing.SystemColors.Control;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(195, 75);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(55, 20);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            // 
            // nameTXT
            // 
            this.nameTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTXT.Location = new System.Drawing.Point(288, 72);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(121, 26);
            this.nameTXT.TabIndex = 1;
            // 
            // Role
            // 
            this.Role.AutoSize = true;
            this.Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Role.Location = new System.Drawing.Point(199, 140);
            this.Role.Name = "Role";
            this.Role.Size = new System.Drawing.Size(46, 20);
            this.Role.TabIndex = 2;
            this.Role.Text = "Role";
            // 
            // RoleList
            // 
            this.RoleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleList.FormattingEnabled = true;
            this.RoleList.Location = new System.Drawing.Point(288, 138);
            this.RoleList.Name = "RoleList";
            this.RoleList.Size = new System.Drawing.Size(121, 28);
            this.RoleList.TabIndex = 3;
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(288, 233);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(111, 40);
            this.Submit.TabIndex = 4;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // AddStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.RoleList);
            this.Controls.Add(this.Role);
            this.Controls.Add(this.nameTXT);
            this.Controls.Add(this.Name);
            this.Text = "AddStaffForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox nameTXT;
        private System.Windows.Forms.Label Role;
        private System.Windows.Forms.ComboBox RoleList;
        private System.Windows.Forms.Button Submit;
    }
}