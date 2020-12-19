using RadiantDentalPractice.Factory;
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
    public interface IPresenterFactory
    {
        PatientPresenter getPatientPresenter(IViewFactory factory, IPresenterFactory presenterFactory, 
            IRepositoryFactory repositoryFactory);
        QuestionnairePresenter getQuestionnairePresenter(Patient patient,
            IPresenterFactory presenterFactory, IRepositoryFactory repositoryFactory);
        GPPresenter getGPPresenter(Patient patient, IRepositoryFactory factory);
        CheckUpPresenter getCheckUpPresenter(ICheckupView checkupView, ICheckupRepository checkupRepository);
        EmergencyPresenter getEmergencyPresenter(IEmergencyView emergencyView, IEmergencyRepository emergencyRepository);
    }
}
