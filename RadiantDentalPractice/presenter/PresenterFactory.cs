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
    public class PresenterFactory : IPresenterFactory
    {
        public GPPresenter getGPPresenter(Patient patient, IRepositoryFactory factory, IPresenterFactory presenterFactory)
        {
            return new GPPresenter( patient, factory,presenterFactory);
        }

        public PatientPresenter getPatientPresenter(IViewFactory factory,
            IPresenterFactory presenterFactory, IRepositoryFactory repositoryFactory)
        {
            return new PatientPresenter(factory, presenterFactory, repositoryFactory);
        }

        public QuestionnairePresenter getQuestionnairePresenter(Patient patient, IPresenterFactory presenterFactory, IRepositoryFactory repositoryFactory)
        {
            return new QuestionnairePresenter(patient, presenterFactory, repositoryFactory);
        }

        public CheckUpPresenter getCheckUpPresenter(ICheckupView checkupView, IAppointmentRepository appointmentRepository)
        {
            return new CheckUpPresenter(checkupView, appointmentRepository);
        }

        public EmergencyPresenter getEmergencyPresenter(IEmergencyView emergencyView,
            IAppointmentRepository appointmentRepository)
        {
            return new EmergencyPresenter(emergencyView, appointmentRepository);
        }

        public RecordTreatmentPresenter getRecordTreatmentPresenter(ITreatmentPlanRepository treatmentPlanRepository)
        {
            return new RecordTreatmentPresenter(treatmentPlanRepository);
        }
    }
}
