using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.models
{
    public class MedicalQuestions
    {
        public HashSet<Question> questions { get; set; }
        public DateTime lastUpdatedDate { get; set; }
    }
}
