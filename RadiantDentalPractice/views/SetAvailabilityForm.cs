using RadiantDentalPractice.models;
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
     * this form allows us to set availabilty for staff
     * 
     */
    public partial class SetAvailabilityForm : Form, ISetAvailabilityView
    {
        public SetAvailabilityForm()
        {
            InitializeComponent();
            loadAvailabilityOptions();
        }

        public string name
        {
            get
            {
                return StaffNameTXT.Text;
            }
            set
            {
                StaffNameTXT.Text = value;
            }
        }

        public DateTime selectedDate
        {
            get
            {
                return SelectedDateTXT.Value;
            }
            set
            {
                SelectedDateTXT.Value = value;
            }
        }

        public string availabilityStatus
        {
            get
            {
                return AvailabilityStatusTXT.Text;
            }
            set
            {
                AvailabilityStatusTXT.Text = value;
            }
        }
        public string[] availableStaff { get; set; }
        public string errorDescription { get; set; }
        public SetAvailabilityPresenter setAvailabilityPresenter { get; set; }

        private void loadAvailabilityOptions()
        {
            AvailabilityStatusTXT.Items.Add("AVAILABLE");
            AvailabilityStatusTXT.Items.Add("UNAVAILABLE");
        }

        private void SelectedDateTXT_ValueChanged(object sender, EventArgs e)
        {
            if(SelectedDateTXT.Value < DateTime.Now)
            {
                MessageBox.Show("InValid Date");
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            errorDescription = "";
            ValidateChecks();
            if(errorDescription.Length == 0 && setAvailabilityPresenter.setAvailability())
            {
                MessageBox.Show("Your availability is updated accordingly");
            }
            else
            {
                MessageBox.Show("Unable to update please check your details");
            }
            this.Close();
        }

        // validation checks can go here
        private void ValidateChecks()
        {
            if(SelectedDateTXT.Value < DateTime.Now)
            {
                MessageBox.Show("InValid Date");
                errorDescription = "InValid Date";
            }
        }

        private void StaffNameTXT_Click(object sender, EventArgs e)
        {
            StaffNameTXT.Items.AddRange(availableStaff);
        }
    }
}
