﻿using RadiantDentalPractice.models;
using RadiantDentalPractice.Repository;
using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.presenter
{
    /*
    * @author venkata sravan kumar
    * 
    */
    public class AppointmentsListPresenter
    {
        private IRepositoryFactory repositoryFactory;
        private List<AppointmentList> appointmentList;
        public AppointmentsListPresenter(IRepositoryFactory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory;
            this.appointmentList = new List<AppointmentList>();
        }

        public IAppointmentListView appointmentListView { get; set; }

        public List<AppointmentList> getAppointments()
        {
            List<Appointment> bookedAppointments = ((IAppointmentRepository)repositoryFactory.getRepository("APPOINTMENT")).getBookings();
            List<TreatmentPlan> treatmentPlans = ((ITreatmentPlanRepository)repositoryFactory.getRepository("TREATMENTPLAN")).getTreatmentPlans();
            foreach(Appointment appointment in bookedAppointments)
            {
                AppointmentList appointments= new AppointmentList();
                appointments.patientID = appointment.patientID;
                Patient patient = ((IPatientRepository)repositoryFactory.getRepository("PATIENT")).getPatient(appointment.patientID);
                appointments.email = patient.email;
                appointments.treatmentType = appointment.treatmentType;
                appointments.bookingSlot = appointment.bookingSlot;
                appointments.bookingdate = appointment.bookingDate;
                appointmentList.Add(appointments);
            }
            foreach (TreatmentPlan treatmentPlan in treatmentPlans)
            {
                AppointmentList appointments = new AppointmentList();
                appointments.patientID = treatmentPlan.patientID;
                Patient patient = ((IPatientRepository)repositoryFactory.getRepository("PATIENT")).getPatient(treatmentPlan.patientID);
                appointments.email = patient.email;
                appointments.treatmentType = treatmentPlan.proposedTreatment;
                appointments.bookingSlot = "NOT BOOKED";
                appointments.bookingdate = null;
                appointmentList.Add(appointments);
            }

            return appointmentList;

        }
    }
}
