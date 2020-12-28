using Castle.Components.DictionaryAdapter.Xml;
using RadiantDentalPractice.DAL;
using RadiantDentalPractice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.Repository
{
    /*
    * @author venkata sravan kumar
    * 
    */
    public class AppointmentRepository : IAppointmentRepository
    {
        private static IAppointmentRepository appointmentRepository = new AppointmentRepository();

        private AppointmentRepository()
        {

        }
        public static IAppointmentRepository getInstance()
        {
            return appointmentRepository;
        }
        // add booking
        public int addBooking(Appointment appointment)
        {
            using (var db = new DentalPracticeContext())
            {
                db.appointments.Add(appointment);
                int value = db.SaveChanges();
                return value;
            }
        }
        // retrieves booked slots
        public List<string> bookedSlots(DateTime bookingDate, String treatmentType)
        {
            using (var db = new DentalPracticeContext())
            {
                var result = from booking in db.appointments
                             where booking.bookingDate == bookingDate && booking.treatmentType == treatmentType
                             select booking.bookingSlot;
                return result.ToList();
            }
        }

        // get all bookings
        public List<Appointment> getBookings()
        {
            using (var db = new DentalPracticeContext())
            {
                var result = from booking in db.appointments
                             select booking;
                return result.ToList();
            }
        }
    }
}
