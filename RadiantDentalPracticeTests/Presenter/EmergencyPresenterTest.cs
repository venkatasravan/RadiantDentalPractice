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
    public class EmergencyPresenterTest
    {
        [TestMethod]
        public void testCreateEmergencyBooking()
        {
            Mock<IAppointmentRepository> appointmentRepository = new Mock<IAppointmentRepository>();
            Mock<IEmergencyView> emergencyView = new Mock<IEmergencyView>();
            emergencyView.Object.bookingDate = DateTime.Now.AddDays(7);
            emergencyView.Object.bookingSlot = "05:00-05:30";
            emergencyView.Object.patientID = 1;

            //mock appointmentRepository method
            appointmentRepository.Setup(x => x.addBooking(It.IsAny<Appointment>())).Returns(1);

            EmergencyPresenter emergencyPresenter = new 
                EmergencyPresenter(emergencyView.Object,appointmentRepository.Object);
            int updatedRecords = emergencyPresenter.CreateEmergencyBooking();
            Assert.AreEqual(1, updatedRecords);
        }
    }
}
