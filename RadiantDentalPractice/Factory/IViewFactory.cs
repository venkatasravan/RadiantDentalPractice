using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiantDentalPractice.Factory
{
    public interface IViewFactory
    {
        PatientRegistration getPatientView();
        Questionnaire getQuestionView();
        GP_Practice getGPView();
        CheckUpForm getCheckUpView();
    }
}
