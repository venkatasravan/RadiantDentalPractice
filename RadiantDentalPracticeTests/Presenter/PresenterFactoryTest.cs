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
    * 
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
    }
}
