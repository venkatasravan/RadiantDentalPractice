using RadiantDentalPractice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.Repository
{
    public interface IEmergencyRepository
    {
        int addEmergencyBooking(EmergencyAppointment appointment);
        List<string> bookedEmergencySlots(DateTime bookingDate);
    }
}
