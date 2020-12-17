using RadiantDentalPractice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.Repository
{
    public interface ICheckupRepository
    {
        int addCheckupBooking(CheckupAppointment appointment);
        List<string> bookedCheckupSlots(DateTime bookingDate);
    }
}
