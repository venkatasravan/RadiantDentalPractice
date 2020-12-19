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
    public class EmergencyPresenter
    {
        private IEmergencyView emergencyView;
        private IAppointmentRepository appointmentRepository;
        public EmergencyPresenter(IEmergencyView emergencyView, IAppointmentRepository appointmentRepository)
        {
            this.emergencyView = emergencyView;
            this.appointmentRepository = appointmentRepository;
        }

        public int CreateEmergencyBooking()
        {
            Appointment appointment = new Appointment();
            appointment.patientID = emergencyView.patientID;
            appointment.bookingDate = emergencyView.bookingDate;
            appointment.bookingSlot = emergencyView.bookingSlot;
            appointment.treatmentType = "EMERGENCY";
            appointment.status = "CONFIRM";
            return appointmentRepository.addBooking(appointment);
        }
     }
}
