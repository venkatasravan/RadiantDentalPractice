using RadiantDentalPractice.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.views
{
    public interface IQuestionView
    {
        Dictionary<string, string> questions { get; set; }
        QuestionnairePresenter questionnairePresenter { get; set; }
    }
}
