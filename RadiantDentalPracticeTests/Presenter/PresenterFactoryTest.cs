using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RadiantDentalPractice.models;
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
    public class PresenterFactoryTest
    {
        PresenterFactory presenterFactory = new PresenterFactory();

        [TestMethod]
        public void testGetGPPresenter()
        {
            GPPresenter gPPresenter = presenterFactory.getGPPresenter(
                new Patient(), new RepositoryFactory(), presenterFactory);

            Assert.IsNotNull(gPPresenter);
        }

        [TestMethod]
        public void testGetPatientPresenter()
        {
            PatientPresenter patientPresenter = presenterFactory.getPatientPresenter(
                 presenterFactory, new RepositoryFactory());

            Assert.IsNotNull(patientPresenter);
        }

        [TestMethod]
        public void testGetQuestionnairePresenter()
        {
            QuestionnairePresenter questionnairePresenter = presenterFactory.getQuestionnairePresenter(
                new Patient(), presenterFactory, new RepositoryFactory());

            Assert.IsNotNull(questionnairePresenter);
        }

        [TestMethod]
        public void testGetCheckUpPresenter()
        {
            Mock<ICheckupView> checkupView = new Mock<ICheckupView>();
            CheckUpPresenter checkUpPresenter = presenterFactory.getCheckUpPresenter(
                checkupView.Object, new AppointmentRepository());

            Assert.IsNotNull(checkUpPresenter);
        }

        [TestMethod]
        public void testGetEmergencyPresenter()
        {
            Mock<IEmergencyView> emergencyView = new Mock<IEmergencyView>();
            EmergencyPresenter emergencyPresenter = presenterFactory.getEmergencyPresenter(
                emergencyView.Object, new AppointmentRepository());

            Assert.IsNotNull(emergencyPresenter);
        }

        [TestMethod]
        public void testRecordTreatmentPresenter()
        {
            Mock<ITreatmentPlanRepository> treatmentPlanRepository = new Mock<ITreatmentPlanRepository>();
            RecordTreatmentPresenter recordTreatmentPresenter = presenterFactory.getRecordTreatmentPresenter(
                presenterFactory, treatmentPlanRepository.Object);



            Assert.IsNotNull(recordTreatmentPresenter);
        }
        [TestMethod]
        public void testTreatmentConsentPresenter()
        {
            Mock<ITreatmentPlanRepository> treatmentPlanRepository = new Mock<ITreatmentPlanRepository>();
            TreatmentConsentPresenter treatmentConsentPresenter = presenterFactory.getTreatmentConsentPresenter(
                treatmentPlanRepository.Object, new TreatmentPlan());



            Assert.IsNotNull(treatmentConsentPresenter);
        }
        [TestMethod]
        public void testDentalSurgeryVisitPresenter()
        {
            Mock<IRepositoryFactory> repositoryFactory = new Mock<IRepositoryFactory>();
            DentalSurgeryVisitPresenter dentalSurgeryVisitPresenter = presenterFactory.getDentalSurgeryVisitPresenter(
               repositoryFactory.Object, presenterFactory);



            Assert.IsNotNull(dentalSurgeryVisitPresenter);
        }
        [TestMethod]
        public void testAddStaffPresenter()
        {
            Mock<IStaffRepository> staffRepository = new Mock<IStaffRepository>();
            AddStaffPresenter addStaffPresenter = presenterFactory.getAddStaffPresenter(staffRepository.Object);
            Assert.IsNotNull(addStaffPresenter);
        }
        [TestMethod]
        public void testStaffServicesPresenter()
        {
            Mock<IRepositoryFactory> repositoryFactory = new Mock<IRepositoryFactory>();
            StaffServicesPresenter staffServicesPresenter = presenterFactory.getStaffServicesPresenter(presenterFactory, repositoryFactory.Object);
            Assert.IsNotNull(staffServicesPresenter);
        }
        [TestMethod]
        public void testSetAvailabilityPresenter()
        {
            Mock<IStaffRepository> staffRepository = new Mock<IStaffRepository>();
            SetAvailabilityPresenter setAvailabilityPresenter = presenterFactory.getSetAvailabilityPresenter(
                 staffRepository.Object);
            Assert.IsNotNull(setAvailabilityPresenter);
        }
        [TestMethod]
        public void testAppointmentsListPresenter()
        {
            Mock<IRepositoryFactory> repositoryFactory = new Mock<IRepositoryFactory>();
            AppointmentsListPresenter appointmentsListPresenter = presenterFactory.getAppointmentsListPresenter(
                 repositoryFactory.Object);
            Assert.IsNotNull(appointmentsListPresenter);
        }
    }
}
