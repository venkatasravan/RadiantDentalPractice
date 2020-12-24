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
    /*
     * @author Venkata Sravan Kumar(w19051025)
     * 
     */
    public partial class RadiantDentalPracticeForm : Form
    {

        public RadiantDentalPracticeForm()
        {
            InitializeComponent();
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
            this.Hide();
            DentalSurgeryVisitForm dentalSurgeryVisitForm = new DentalSurgeryVisitForm();
            radiantDentalPracticePresenter.OnDentalSurgeryVisit(dentalSurgeryVisitForm);
            dentalSurgeryVisitForm.ShowDialog();
            this.Close();
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

        private void RecordTreatmentPlan_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecordTreatmentForm recordTreatmentForm = new RecordTreatmentForm();
            radiantDentalPracticePresenter.recordTreatmentPlan(recordTreatmentForm);
            recordTreatmentForm.ShowDialog();
            this.Close();
        }

        private void StaffServices_Click(object sender, EventArgs e)
        {
            this.Hide();
            StaffServicesForm staffServicesForm = new StaffServicesForm();
            radiantDentalPracticePresenter.staffServices(staffServicesForm);
            staffServicesForm.ShowDialog();
            this.Close();
        }
    }
}
