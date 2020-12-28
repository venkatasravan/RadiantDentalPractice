
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
    /*
    * @author venkata sravan kumar
    * 
    */
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
        public int patientID { get; set; }

        public void updatePatient(IGpView gpView)
        {
            updateQuestions();
            GPPresenter gPPresenter = presenterFactory.getGPPresenter(patient, repositoryFactory,presenterFactory);
            gPPresenter.view = gpView;
            gpView.gPPresenter = gPPresenter;
        }

        public void validate()
        {
            validationChecks();
        }
        private void validationChecks()
        {
            if (view.questions.Values.ToList().Contains(""))
            {
                view.errorMessage = "You must answer all three questions";
            }

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

        public void updateExistingPatient()
        {
            IPatientRepository patientRepository = ((IPatientRepository)repositoryFactory.getRepository("PATIENT"));
            patientRepository.updatePatientQuestions(patientID,view.questions);
        }
    }
}
