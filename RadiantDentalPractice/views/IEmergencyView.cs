using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.views
{
    public interface IEmergencyView
    {
        int patientID { get; set; }
        DateTime bookingDate { get; set; }
        string bookingSlot { get; set; }
    }
}
