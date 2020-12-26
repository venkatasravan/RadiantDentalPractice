using RadiantDentalPractice.presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiantDentalPractice.views
{
    /*
     * @author venkata sravan kumar
     * This form allow us to add staff to the database
     * 
     * 
     */
    public partial class AddStaffForm : Form, IAddStaffView
    {
        public AddStaffForm()
        {
            InitializeComponent();
            loadRoles();
        }

        public string name
        {
            get
            {
                return nameTXT.Text;
            }
            set
            {
                nameTXT.Text = value;
            }
        }
        public string role
        {
            get
            {
                return RoleList.Text;
            }
            set
            {
                RoleList.Text = value;
            }
        }

        /*
         * Load the roles
         * 
         * 
         */
        private void loadRoles()
        {
            RoleList.Items.Add("CHECKUP");
            RoleList.Items.Add("EMERGENCY");
            RoleList.Items.Add("SURGERY");
        }

        /*
         * 
         * Presenter instance
         * 
         */
        public AddStaffPresenter addStaffPresenter { get; set; }

        public string errorMessage { get; set; }

        private void validateInput()
        {
            errorMessage = "";
            addStaffPresenter.validate();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
            int? staff_id;
            validateInput();
            if (errorMessage.Length != 0)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                try
                {
                    staff_id = addStaffPresenter.insertStaff();
                    MessageBox.Show("Staff Registration Successful \n Your StaffID is " + staff_id);
                }
                catch
                {
                    MessageBox.Show("Staff Registration Not Successful");
                }
                this.Close();
            }
        }
    }
}
