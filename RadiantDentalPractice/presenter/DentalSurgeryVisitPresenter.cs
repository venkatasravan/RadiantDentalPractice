using RadiantDentalPractice.Helper;
using RadiantDentalPractice.models;
using RadiantDentalPractice.Repository;
using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.presenter
{
    /*
     * @author venkata sravan kumar
     * this class contains logic to check medical history
     * it also contans logic to check patient available or not using helper class
     * 
     */
    public class DentalSurgeryVisitPresenter
    {
        private IRepositoryFactory repositoryFactory;
        private IPresenterFactory presenterFactory;
        public DentalSurgeryVisitPresenter(IRepositoryFactory repositoryFactory, IPresenterFactory presenterFactory)
        {
            this.repositoryFactory = repositoryFactory;
            this.presenterFactory = presenterFactory;
        }

        /*
         * view to access and update fields
         * 
         */
        public IDentalSurgeryVisitView view { get; set; }

        /*
         * method to check medical question history
         * 
         * 
         */
        public Boolean checkMedicalQuestionHistory()
        {
            IPatientRepository patientRepository = ((IPatientRepository)repositoryFactory.getRepository("PATIENT"));
            return patientRepository.isMedicalQuestionExpired(view.PatientID);
        }

        /*
         * updates the latest questions to the database
         * 
         */
        public void updateQuestions(IQuestionView questionView)
        {
            QuestionnairePresenter questionnairePresenter = presenterFactory.getQuestionnairePresenter(
                new Patient(), presenterFactory, repositoryFactory);
            questionnairePresenter.view = questionView;
            questionView.questionnairePresenter = questionnairePresenter;
            questionnairePresenter.patientID = view.PatientID;
        }

        /*
         * 
         * Check if patient registered with that id
         * 
         */
        public Boolean isPatientAvailable(int patientID)
        {
            return PatientHelper.isPatientAvailable(patientID);
        }

        public void validate()
        {
            validationChecks();
        }
        private void validationChecks()
        {
            if (view.PatientID == 0)
            {
                view.errorMessage = "Please enter patientID";
            }
        }
    }
}
