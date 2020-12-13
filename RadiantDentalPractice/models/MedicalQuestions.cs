using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.models
{
    public class MedicalQuestions
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int medicalID { get; set; }
        public HashSet<Question> questions { get; set; }
        public DateTime lastUpdatedDate { get; set; }
    }
}
