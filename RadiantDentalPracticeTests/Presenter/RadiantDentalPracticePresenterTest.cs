using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RadiantDentalPractice.presenter;
using RadiantDentalPractice.Repository;
using RadiantDentalPractice.views;

namespace RadiantDentalPracticeTests.Presenter
{
    /*
    * @author venkata sravan kumar
    * 
    * @author Priyanka pawar
    */
    [TestClass]
    public class RadiantDentalPracticePresenterTest
    {
        [TestMethod]
        public void testRegisterPatient()
        {
            Mock<IRepositoryFactory> repositoryFactory = new Mock<IRepositoryFactory>();
            Mock<IPresenterFactory> presenterFactory = new Mock<IPresenterFactory>();

            PatientPresenter patientPresenter = new PatientPresenter(
                presenterFactory.Object, repositoryFactory.Object);

            Mock<IPatientView> patientView = new Mock<IPatientView>();

            // mock
            presenterFactory.Setup(x => x.getPatientPresenter(presenterFactory.Object, repositoryFactory.Object))
                .Returns(patientPresenter);

            RadiantDentalPracticePresenter radiantDentalPracticePresenter =
                new RadiantDentalPracticePresenter(presenterFactory.Object, repositoryFactory.Object);
            radiantDentalPracticePresenter.registerPatient(patientView.Object);

            // Bookupcheck
            Mock<ICheckupView> checkupView = new Mock<ICheckupView>();



            presenterFactory.Setup(x => x.getCheckUpPresenter(checkupView.Object, repositoryFactory.Object.getAppointmentRepository()));



            radiantDentalPracticePresenter.bookCheckup(checkupView.Object);



            //bookemergency



            Mock<IEmergencyView> emergencyView = new Mock<IEmergencyView>();



            presenterFactory.Setup(x => x.getEmergencyPresenter(emergencyView.Object, repositoryFactory.Object.getAppointmentRepository()));



            radiantDentalPracticePresenter.bookEmergency(emergencyView.Object);



            //recordtreatment



            Mock<IRecordTreatmentForm> recordTreatmentForm = new Mock<IRecordTreatmentForm>();



            RecordTreatmentPresenter recordTreatmentPresenter = new RecordTreatmentPresenter(presenterFactory.Object, repositoryFactory.Object.getTreatmentPlanRepository());
            presenterFactory.Setup(x => x.getRecordTreatmentPresenter(presenterFactory.Object, repositoryFactory.Object.getTreatmentPlanRepository())).Returns(recordTreatmentPresenter);



            radiantDentalPracticePresenter.recordTreatmentPlan(recordTreatmentForm.Object);



            //OnDentalSurgeryVisit
            Mock<IDentalSurgeryVisitView> dentalSurgeryVisitView = new Mock<IDentalSurgeryVisitView>();
            DentalSurgeryVisitPresenter dentalSurgeryVisitPresenter = new DentalSurgeryVisitPresenter(repositoryFactory.Object, presenterFactory.Object);
            presenterFactory.Setup(x => x.getDentalSurgeryVisitPresenter(repositoryFactory.Object, presenterFactory.Object)).Returns(dentalSurgeryVisitPresenter);
            radiantDentalPracticePresenter.OnDentalSurgeryVisit(dentalSurgeryVisitView.Object);
        }
    }
}
