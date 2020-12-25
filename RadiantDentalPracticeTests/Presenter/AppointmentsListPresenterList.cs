using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RadiantDentalPractice.Constants;
using RadiantDentalPractice.models;
using RadiantDentalPractice.presenter;
using RadiantDentalPractice.Repository;
using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.Text;

namespace RadiantDentalPracticeTests.Presenter
{
    /*
     * @author venkata sravan kumar
     * 
     * 
     */
    [TestClass]
    public class AppointmentsListPresenterList
    {
        [TestMethod]
        public void testGetAppointments()
        {
            Mock<IRepositoryFactory> repositoryFactory = new Mock<IRepositoryFactory>();
            Mock<IAppointmentListView> appointmentListView = new Mock<IAppointmentListView>();
            Mock<IPatientRepository> patientRepository = new Mock<IPatientRepository>();
            Mock<ITreatmentPlanRepository> treatmentPlanRepository = new Mock<ITreatmentPlanRepository>();
            Mock<IAppointmentRepository> appointmentRepository = new Mock<IAppointmentRepository>();

            List<Appointment> bookedAppointments = new List<Appointment>();
            Appointment appointment = new Appointment();
            appointment.ID = 1;
            appointment.patientID = 1;
            appointment.bookingDate = DateTime.Now.AddDays(7);
            appointment.bookingSlot = "09-10";
            appointment.treatmentType = "CHECKUP";
            bookedAppointments.Add(appointment);
            List<TreatmentPlan> treatmentPlans = new List<TreatmentPlan>();
            TreatmentPlan treatmentPlan = new TreatmentPlan();
            treatmentPlan.ID = 1;
            treatmentPlan.patientID = 2;
            treatmentPlan.proposedTreatment = "ROOT_CANAL_WORK";
            TreatmentConsentAndPayment treatmentConsentAndPayment = new TreatmentConsentAndPayment();
            treatmentConsentAndPayment.consentText = "";
            treatmentConsentAndPayment.ID = 1;
            treatmentConsentAndPayment.isAccepted = true;
            treatmentConsentAndPayment.treatmentCost = ApplicationConstants.BAND2;
            treatmentPlan.treatmentConsentAndPayment = treatmentConsentAndPayment;
            treatmentPlans.Add(treatmentPlan);

            Patient patient = new Patient();
            patient.name = "venkat";
            patient.email = "venkat@gmail.com";
            patient.phoneNumber = "1234567890";

            // mock patient repo
            repositoryFactory.Setup(x => x.getPatientRepository()).Returns(patientRepository.Object);
            patientRepository.Setup(x => x.getPatient(It.IsAny<int>())).Returns(patient);

            //mock appointment repo
            repositoryFactory.Setup(x => x.getAppointmentRepository()).Returns(appointmentRepository.Object);
            appointmentRepository.Setup(x => x.getBookings()).Returns(bookedAppointments);

            //mock treatmentplan repo
            repositoryFactory.Setup(x => x.getTreatmentPlanRepository()).Returns(treatmentPlanRepository.Object);
            treatmentPlanRepository.Setup(x => x.getTreatmentPlans()).Returns(treatmentPlans);

            AppointmentsListPresenter appointmentsListPresenter = new AppointmentsListPresenter(repositoryFactory.Object);

            List<AppointmentList> appointmentList = appointmentsListPresenter.getAppointments();
            // I passed two values as input data so I am expecting two values to be updated here
            Assert.AreEqual(2, appointmentList.Count);
        }

    }
}
