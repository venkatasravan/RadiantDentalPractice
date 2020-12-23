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
        GPPresenter getGPPresenter(Patient patient, IRepositoryFactory factory, IPresenterFactory presenterFactory);
        CheckUpPresenter getCheckUpPresenter(ICheckupView checkupView, IAppointmentRepository appointmentRepository);
        EmergencyPresenter getEmergencyPresenter(IEmergencyView emergencyView, 
            IAppointmentRepository appointmentRepository);
        RecordTreatmentPresenter getRecordTreatmentPresenter(IPresenterFactory presenterFactory,
            ITreatmentPlanRepository treatmentPlanRepository);
        TreatmentConsentPresenter getTreatmentConsentPresenter(
            ITreatmentPlanRepository treatmentPlanRepository, TreatmentPlan treatmentPlan);
        DentalSurgeryVisitPresenter getDentalSurgeryVisitPresenter(IRepositoryFactory repositoryFactory, IPresenterFactory presenterFactory);
    }
}
