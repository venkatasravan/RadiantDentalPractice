using RadiantDentalPractice.DAL;
using RadiantDentalPractice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.Repository
{
    public class CheckupRepository : ICheckupRepository
    {
        public int addCheckupBooking(CheckupAppointment appointment)
        {
            using (var db = new DentalPracticeContext())
            {
                db.checkupAppointments.Add(appointment);
                int value = db.SaveChanges();
                return value;
            }
        }

        public List<string> bookedCheckupSlots(DateTime bookingDate)
        {
            using (var db = new DentalPracticeContext())
            {
                var result = from booking in db.checkupAppointments
                             where booking.bookingDate == bookingDate
                             select booking.bookingSlot;
                return result.ToList();
            }
        }
    }
}
