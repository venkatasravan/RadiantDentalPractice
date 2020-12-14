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
    public class RadiantDentalPracticePresenter
    {

        private RadiantDentalPracticeForm formView;
        public RadiantDentalPracticePresenter(RadiantDentalPracticeForm formView)
        {
            this.formView = formView;
        }
        
        public void registerPatient()
        {
            PatientRegistration view = new PatientRegistration();
            PatientPresenter patientPresenter = new PatientPresenter(view);
            view.ShowDialog();
        }

       
    }
}
