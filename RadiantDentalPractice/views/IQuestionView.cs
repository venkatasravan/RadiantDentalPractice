using RadiantDentalPractice.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.views
{
    /*
     * @author venkata sravan kumar
     * 
     * interface for medical question form
     * 
     * 
     * 
     */
    public interface IQuestionView
    {
        Dictionary<string, string> questions { get; set; }
        QuestionnairePresenter questionnairePresenter { get; set; }
    }
}
