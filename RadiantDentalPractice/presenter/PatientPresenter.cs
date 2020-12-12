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
    class PatientPresenter : RegistrationHandler, IPresenter
    {

        private Form view;

        public PatientPresenter(Form view)
        {
            this.view = view;
        }
        public void load()
        {
            this.view.ShowDialog();
        }

        public override void RegisterPatient(Patient patient)
        {
            QuestionnairePresenter questionnairePresenter = new QuestionnairePresenter(new Questionnaire(patient));
            Console.WriteLine("patient");
        }

        public void validate()
        {
            throw new NotImplementedException();
        }
    }
}
