using RadiantDentalPractice.DAL;
using RadiantDentalPractice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.Repository
{
    public class EmergencyRepository : IEmergencyRepository
    {
        public int addEmergencyBooking(EmergencyAppointment appointment)
        {
            using (var db = new DentalPracticeContext())
            {
                db.emergencyAppointments.Add(appointment);
                int value = db.SaveChanges();
                return value;
            }
        }

        public List<string> bookedEmergencySlots(DateTime bookingDate)
        {
            using (var db = new DentalPracticeContext())
            {
                var result = from booking in db.emergencyAppointments
                             where booking.bookingDate == bookingDate
                             select booking.bookingSlot;
                return result.ToList();
            }
        }
    }
}
