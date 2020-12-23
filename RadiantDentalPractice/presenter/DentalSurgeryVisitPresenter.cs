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
    public class DentalSurgeryVisitPresenter
    {
        IRepositoryFactory repositoryFactory;
        IPresenterFactory presenterFactory;
        public DentalSurgeryVisitPresenter(IRepositoryFactory repositoryFactory, IPresenterFactory presenterFactory)
        {
            this.repositoryFactory = repositoryFactory;
            this.presenterFactory = presenterFactory;
        }

        public IDentalSurgeryVisitView view { get; set; }

        public Boolean checkMedicalQuestionHistory()
        {
            IPatientRepository patientRepository = repositoryFactory.getPatientRepository();
            return patientRepository.isMedicalQuestionExpired(view.PatientID);
        }
        public void updateQuestions(IQuestionView questionView)
        {
            QuestionnairePresenter questionnairePresenter = presenterFactory.getQuestionnairePresenter(
                new Patient(), presenterFactory, repositoryFactory);
            questionnairePresenter.view = questionView;
            questionView.questionnairePresenter = questionnairePresenter;
            questionnairePresenter.patientID = view.PatientID;
        }
    }
}
