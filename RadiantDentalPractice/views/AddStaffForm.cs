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
        private void loadRoles()
        {
            RoleList.Items.Add("CHECKUP");
            RoleList.Items.Add("EMERGENCY");
            RoleList.Items.Add("SURGERY");
        }

        public AddStaffPresenter addStaffPresenter { get; set; }

        private void Submit_Click(object sender, EventArgs e)
        {
            int? staff_id;
            try
            {
                staff_id = addStaffPresenter.insertStaff();
                MessageBox.Show("Staff Registration Successful \n Your StaffID is " + staff_id);
            }
            catch
            {
                MessageBox.Show("Staff Registration Not Successful");
            }
        }
    }
}
