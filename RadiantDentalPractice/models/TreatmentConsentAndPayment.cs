using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.models
{
    public class TreatmentConsentAndPayment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        public double treatmentCost { get; set; }
        public string consentText { get; set; }
        public Boolean isAccepted { get; set; }
    }
}
