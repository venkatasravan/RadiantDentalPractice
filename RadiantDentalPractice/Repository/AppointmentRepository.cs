﻿using Castle.Components.DictionaryAdapter.Xml;
using RadiantDentalPractice.DAL;
using RadiantDentalPractice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        public int addBooking(Appointment appointment)
        {
            using (var db = new DentalPracticeContext())
            {
                db.appointments.Add(appointment);
                int value = db.SaveChanges();
                return value;
            }
        }

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
