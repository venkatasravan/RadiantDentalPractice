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
    public class CheckUpPresenterTest
    {
        [TestMethod]
        public void testCreateCheckupBooking()
        {
            Mock<IAppointmentRepository> appointmentRepository = new Mock<IAppointmentRepository>();
            Mock<ICheckupView> checkupView = new Mock<ICheckupView>();
            checkupView.Object.bookingDate = DateTime.Now.AddDays(7);
            checkupView.Object.bookingSlot = "05:00-05:30";
            checkupView.Object.patientID = 1;

            //mock appointmentRepository method
            appointmentRepository.Setup(x => x.addBooking(It.IsAny<Appointment>())).Returns(1);

            CheckUpPresenter checkUpPresenter = new CheckUpPresenter(checkupView.Object, appointmentRepository.Object);
            int updatedRecords = checkUpPresenter.CreateCheckupBooking();
            Assert.AreEqual(1, updatedRecords);
        }
    }
}
