using RadiantDentalPractice.Factory;
using RadiantDentalPractice.models;
using RadiantDentalPractice.presenter;
using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiantDentalPractice
{
    public partial class RadiantDentalPracticeForm : Form
    {
        private IViewFactory viewFactory;

        public RadiantDentalPracticeForm(IViewFactory viewFactory)
        {
            InitializeComponent();
            this.viewFactory = viewFactory;
        }
        
        public RadiantDentalPracticePresenter radiantDentalPracticePresenter { get; set; }

        private void RegisterPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientRegistration patientView = new PatientRegistration();
            radiantDentalPracticePresenter.registerPatient(patientView);
            patientView.ShowDialog();
            DialogResult checkupBooking = MessageBox.Show("Do You want to Book for the checkup?",
                    "CheckUp Booking", MessageBoxButtons.YesNo);
            if (checkupBooking == DialogResult.Yes)
            {
                CheckUpForm checkUpForm = new CheckUpForm();
                radiantDentalPracticePresenter.bookCheckup(checkUpForm);
                checkUpForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Thanks for Registering with us. Have a Nice day");
            }
            this.Close();
        }

        private void DentalSurgery_Click(object sender, EventArgs e)
        {
            //not implemented
        }

        private void BookCheckup_Click(object sender, EventArgs e)
        {
            this.Hide();
            CheckUpForm checkUpForm = new CheckUpForm();
            radiantDentalPracticePresenter.bookCheckup(checkUpForm);
            checkUpForm.ShowDialog();
            this.Close();
        }
    }
}
