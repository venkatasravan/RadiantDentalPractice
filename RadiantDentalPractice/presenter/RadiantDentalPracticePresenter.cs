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
    class RadiantDentalPracticePresenter
    {

        
        public RadiantDentalPracticePresenter()
        {
            
        }
        
        public void registerPatient()
        {
            IPatientView view = new PatientRegistration();
            PatientPresenter patientPresenter = new PatientPresenter(view);
            patientPresenter.RegisterPatient();
        }

       
    }
}
