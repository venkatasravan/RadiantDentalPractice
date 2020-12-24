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
    public class Patient
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int patientID { get; set; }
        public string name { get; set; }
        [Key, Column(Order = 1), Index(IsUnique = true)]
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public DateTime dob { get; set; }
        public virtual Address address { get; set; }
        public virtual MedicalQuestions medicalQuestions { get; set; }
        public virtual GP gp_details { get; set; }
    }
}
