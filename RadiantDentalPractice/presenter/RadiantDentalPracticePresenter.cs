
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
    public class RadiantDentalPracticePresenter
    {
        private IPresenterFactory presenterFactory;
        private IRepositoryFactory repositoryFactory;
        public RadiantDentalPracticePresenter(
            IPresenterFactory presenterFactory, IRepositoryFactory repositoryFactory)
        {
            this.presenterFactory = presenterFactory;
            this.repositoryFactory = repositoryFactory;
        }

        public void registerPatient(IPatientView patientView)
        {
            PatientPresenter patientPresenter = presenterFactory.getPatientPresenter(presenterFactory, repositoryFactory);
            patientPresenter.view = patientView;
            patientView.patientPresenter = patientPresenter;
        }

        public void bookCheckup(ICheckupView checkupView)
        {
            checkupView.checkUpPresenter = presenterFactory.
                getCheckUpPresenter(checkupView, repositoryFactory.getAppointmentRepository());
        }

        public void bookEmergency(IEmergencyView emergencyView)
        {
            emergencyView.emergencyPresenter = presenterFactory.
                getEmergencyPresenter(emergencyView, repositoryFactory.getAppointmentRepository());
        }
        public void recordTreatmentPlan(IRecordTreatmentForm recordTreatmentForm)
        {
            RecordTreatmentPresenter recordTreatmentPresenter = presenterFactory.
                getRecordTreatmentPresenter(presenterFactory,repositoryFactory.getTreatmentPlanRepository());
            recordTreatmentPresenter.view = recordTreatmentForm;
            recordTreatmentForm.recordTreatmentPresenter = recordTreatmentPresenter;
        }

        public void OnDentalSurgeryVisit(IDentalSurgeryVisitView dentalSurgeryVisitView)
        {
            DentalSurgeryVisitPresenter dentalSurgeryVisitPresenter = presenterFactory.getDentalSurgeryVisitPresenter(
                repositoryFactory,presenterFactory);
            dentalSurgeryVisitPresenter.view = dentalSurgeryVisitView;
            dentalSurgeryVisitView.dentalSurgeryVisitPresenter = dentalSurgeryVisitPresenter;
        }

        public void staffServices(StaffServicesForm view)
        {
            StaffServicesPresenter staffServicesPresenter = presenterFactory.getStaffServicesPresenter(presenterFactory,
                repositoryFactory);
            view.staffServicesPresenter = staffServicesPresenter;
        }


    }
}
