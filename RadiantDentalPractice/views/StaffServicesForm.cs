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
    public partial class StaffServicesForm : Form
    {
        public StaffServicesForm()
        {
            InitializeComponent();
        }

        public StaffServicesPresenter staffServicesPresenter { get; set; }

        private void SetAvailability_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetAvailabilityForm setAvailabilityForm = new SetAvailabilityForm();
            staffServicesPresenter.setAvailability(setAvailabilityForm);
            setAvailabilityForm.ShowDialog();
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStaffForm addStaffForm = new AddStaffForm();
            staffServicesPresenter.addStaff(addStaffForm);
            addStaffForm.ShowDialog();
            this.Close();
        }
    }
}
