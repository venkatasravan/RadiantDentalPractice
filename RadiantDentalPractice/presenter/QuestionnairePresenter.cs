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
        private Patient patient;
        private IPresenterFactory presenterFactory;
        private IRepositoryFactory repositoryFactory;

        public QuestionnairePresenter(
            Patient patient, 
            IPresenterFactory presenterFactory, IRepositoryFactory repositoryFactory)
        {
            this.patient = patient;
            this.presenterFactory = presenterFactory;
            this.repositoryFactory = repositoryFactory;

        }

        public QuestionnairePresenter()
        {

        }

        public IQuestionView view { get; set; }

        public void updatePatient(IGpView gpView)
        {
            updateQuestions();
            GPPresenter gPPresenter = presenterFactory.getGPPresenter(patient, repositoryFactory,presenterFactory);
            gPPresenter.view = gpView;
            gpView.gPPresenter = gPPresenter;
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
