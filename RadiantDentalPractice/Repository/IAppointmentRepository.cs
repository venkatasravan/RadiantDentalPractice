﻿using RadiantDentalPractice.models;
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
    * appointment operations
    */
    public interface IAppointmentRepository
    {
        int addBooking(Appointment appointment);
        List<string> bookedSlots(DateTime bookingDate, String treatmentType);
        List<Appointment> getBookings();
    }
}
