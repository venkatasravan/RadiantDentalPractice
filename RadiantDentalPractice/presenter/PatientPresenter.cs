using RadiantDentalPractice.models;
using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiantDentalPractice.presenter
{
    public class PatientPresenter
    {

        private IPatientView view;
        private Patient patient;

        public PatientPresenter(IPatientView view)
        {
            this.view = view;
        }

        public void RegisterPatient()
        {
            initializePatient();
            Questionnaire questionnaire = new Questionnaire();
            questionnaire.questionnairePresenter = new QuestionnairePresenter(questionnaire,patient);
            questionnaire.ShowDialog();
        }

        public void validate()
        {
            throw new NotImplementedException();
        }

        private void initializePatient()
        {
            patient = new Patient();
            patient.address = new Address();
            patient.gp_details = new GP();
            patient.medicalQuestions = new MedicalQuestions();
            patient.medicalQuestions.questions = new HashSet<Question>();
            patient.name = view.name;
            patient.email = view.email;
            patient.dob = view.dob;
            patient.address.city = view.city;
            patient.address.postcode = view.postcode;
            patient.address.country = view.country;
        }
    }
}
