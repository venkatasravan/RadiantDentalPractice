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
        private IEmergencyRepository emergencyRepository;
        public EmergencyPresenter(IEmergencyView emergencyView, IEmergencyRepository emergencyRepository)
        {
            this.emergencyView = emergencyView;
            this.emergencyRepository = emergencyRepository;
        }

        public int CreateEmergencyBooking()
        {
            EmergencyAppointment emergencyAppointment = new EmergencyAppointment();
            emergencyAppointment.patientID = emergencyView.patientID;
            emergencyAppointment.bookingDate = emergencyView.bookingDate;
            emergencyAppointment.bookingSlot = emergencyView.bookingSlot;
            return emergencyRepository.addEmergencyBooking(emergencyAppointment);
        }
     }
}
