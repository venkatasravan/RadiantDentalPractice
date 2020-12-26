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
     * 
     * this form allows to staff operations such as adding staff,setting up availability
     */
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

        private void AllocatePatients_Click(object sender, EventArgs e)
        {
            MessageBox.Show("As of now only Manual Allocation is possible, Please click on Unallocated Patients to view appointments");
            this.Close();
        }

        private void UnAllocatedPatients_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentsList appointmentsList = new AppointmentsList();
            staffServicesPresenter.listPatients(appointmentsList);
            appointmentsList.ShowDialog();
            this.Close();
        }
    }
}
