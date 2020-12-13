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
    public class QuestionnairePresenter
    {
        private IQuestionView view;
        private Patient patient;

        public QuestionnairePresenter(IQuestionView view, Patient patient)
        {
            this.view = view;
            this.patient = patient;
            
        }

        public void updatePatient()
        {
            updateQuestions();
            GP_Practice gP_Practice = new GP_Practice();
            gP_Practice.gPPresenter = new GPPresenter(gP_Practice,patient);
            gP_Practice.ShowDialog();
        }

        public void validate()
        {
            throw new NotImplementedException();
        }

        private void updateQuestions()
        {
            foreach (KeyValuePair<string, string> entry in view.questions)
            {
                Question question = new Question();
                question.question = entry.Key;
                question.answer = entry.Value;
                patient.medicalQuestions.questions.Add(question);
            }
            patient.medicalQuestions.lastUpdatedDate = DateTime.Now;
        }
    }
}
