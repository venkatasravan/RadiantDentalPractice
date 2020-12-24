using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.models
{
    /*
    * @author venkata sravan kumar
    * 
    */
    public class Appointment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public int patientID { get; set; }
        public DateTime bookingDate { get; set; }
        public string bookingSlot { get; set; }
        public string treatmentType { get; set; }
        public string status { get; set; }
    }
}
