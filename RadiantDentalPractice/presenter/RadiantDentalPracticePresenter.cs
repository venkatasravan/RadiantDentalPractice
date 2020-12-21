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
    public class RadiantDentalPracticePresenter
    {

        private RadiantDentalPracticeForm formView;
        private IViewFactory viewFactory;
        private IPresenterFactory presenterFactory;
        private IRepositoryFactory repositoryFactory;
        public RadiantDentalPracticePresenter(RadiantDentalPracticeForm formView,
            IViewFactory viewFactory, IPresenterFactory presenterFactory, IRepositoryFactory repositoryFactory)
        {
            this.formView = formView;
            this.viewFactory = viewFactory;
            this.presenterFactory = presenterFactory;
            this.repositoryFactory = repositoryFactory;
        }

        public void registerPatient(IPatientView patientView)
        {
            PatientPresenter patientPresenter = presenterFactory.getPatientPresenter(viewFactory, presenterFactory, repositoryFactory);
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


    }
}
