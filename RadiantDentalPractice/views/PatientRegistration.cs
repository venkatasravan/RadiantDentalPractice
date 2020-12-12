using RadiantDentalPractice.models;
using RadiantDentalPractice.presenter;
using System;
using System.Collections;
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
    public partial class PatientRegistration : Form
    {

        private Patient _patient = new Patient();
        Form view;
        public PatientRegistration()
        {
            InitializeComponent();
        }

        public Patient patient {
            get 
            {
                _patient.name = nameTXT.Text;
                _patient.email = emailTXT.Text;
                _patient.dob = dobTXT.Value.Date;
                _patient.address = new Address();
                _patient.address.postcode = postcodeTXT.Text;
                _patient.address.city = cityTXT.Text;
                _patient.address.country = countryTXT.Text;
                _patient.medicalQuestions = new MedicalQuestions();
                _patient.gp_details = new GP();
                return _patient;
            }
            set
            {
                _patient = value;
            }
            }

        

        public void validatePatient()
        {
            throw new NotImplementedException();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            view = new Questionnaire(patient);
            IPresenter presenter = new QuestionnairePresenter(view);
            presenter.load();
            this.Close();
        }
    }
}
