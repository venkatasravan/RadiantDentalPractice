using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiantDentalPractice.Factory
{
    public class ViewFactory : IViewFactory
    {
        public GP_Practice getGPView()
        {
            return new GP_Practice();
        }

        public PatientRegistration getPatientView()
        {
            return new PatientRegistration();
        }

        public Questionnaire getQuestionView()
        {
            return new Questionnaire();
        }
        public CheckUpForm getCheckUpView()
        {
            return new CheckUpForm();
        }
    }
}
