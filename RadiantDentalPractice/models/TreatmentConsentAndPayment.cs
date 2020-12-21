using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.models
{
    public class TreatmentConsentAndPayment
    {
        public int ID { get; set; }
        public double treatmentCost { get; set; }
        public string consentText { get; set; }
        public Boolean isAccepted { get; set; }
    }
}
