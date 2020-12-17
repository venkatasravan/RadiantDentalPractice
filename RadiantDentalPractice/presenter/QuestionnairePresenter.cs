using RadiantDentalPractice.Factory;
using RadiantDentalPractice.models;
using RadiantDentalPractice.Repository;
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
        private IViewFactory viewFactory;
        private IPresenterFactory presenterFactory;
        private IRepositoryFactory repositoryFactory;

        public QuestionnairePresenter(IQuestionView view,
            Patient patient, IViewFactory viewFactory, IPresenterFactory presenterFactory, IRepositoryFactory repositoryFactory)
        {
            this.view = view;
            this.patient = patient;
            this.viewFactory = viewFactory;
            this.presenterFactory = presenterFactory;
            this.repositoryFactory = repositoryFactory;

        }

        public void updatePatient(IGpView gpView)
        {
            updateQuestions();
            gpView.gPPresenter = presenterFactory.getGPPresenter(gpView, patient, repositoryFactory);
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
