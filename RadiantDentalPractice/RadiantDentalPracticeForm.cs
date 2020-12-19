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

        private void EmergencyAppointment_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmergencyForm emergencyForm = new EmergencyForm();
            radiantDentalPracticePresenter.bookEmergency(emergencyForm);
            emergencyForm.ShowDialog();
            this.Close();
        }
    }
}
