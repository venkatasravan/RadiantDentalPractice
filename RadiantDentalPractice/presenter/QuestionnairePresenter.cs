using RadiantDentalPractice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiantDentalPractice.presenter
{
    class QuestionnairePresenter : RegistrationHandler, IPresenter
    {
        protected RegistrationHandler handler;
        private Form view;

        public QuestionnairePresenter(Form view)
        {
            this.view = view;
        }
        public void load()
        {
            this.view.ShowDialog();
        }

        public override void RegisterPatient(Patient patient)
        {
            Console.WriteLine("good");
        }

        public void validate()
        {
            throw new NotImplementedException();
        }
    }
}
