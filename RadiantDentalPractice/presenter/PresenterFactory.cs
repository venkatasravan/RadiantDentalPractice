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

        public PatientPresenter getPatientPresenter(
            IPresenterFactory presenterFactory, IRepositoryFactory repositoryFactory)
        {
            return new PatientPresenter(presenterFactory, repositoryFactory);
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

        public RecordTreatmentPresenter getRecordTreatmentPresenter(IPresenterFactory presenterFactory, 
            ITreatmentPlanRepository treatmentPlanRepository)
        {
            return new RecordTreatmentPresenter(presenterFactory,treatmentPlanRepository);
        }

        public TreatmentConsentPresenter getTreatmentConsentPresenter(ITreatmentPlanRepository treatmentPlanRepository,
            TreatmentPlan treatmentPlan)
        {
            return new TreatmentConsentPresenter(treatmentPlanRepository,treatmentPlan);
        }

        public DentalSurgeryVisitPresenter getDentalSurgeryVisitPresenter(IRepositoryFactory repositoryFactory, IPresenterFactory presenterFactory)
        {
            return new DentalSurgeryVisitPresenter(repositoryFactory, presenterFactory);
        }

        public AddStaffPresenter getAddStaffPresenter(IStaffRepository staffRepository)
        {
            return new AddStaffPresenter(staffRepository);
        }

        public StaffServicesPresenter getStaffServicesPresenter(IPresenterFactory presenterFactory, IRepositoryFactory repositoryFactory)
        {
            return new StaffServicesPresenter(presenterFactory,repositoryFactory);
        }

        public SetAvailabilityPresenter getSetAvailabilityPresenter(IStaffRepository staffRepository)
        {
            return new SetAvailabilityPresenter(staffRepository);
        }
    }
}
