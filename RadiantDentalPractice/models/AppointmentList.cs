using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.models
{
    public class AppointmentList
    {
        public int patientID { get; set; }
        public string email { get; set; }
        public string treatmentType { get; set; }
        public DateTime? bookingdate { get; set; }
        public string bookingSlot { get; set; }
    }
}
