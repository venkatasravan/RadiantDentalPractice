using RadiantDentalPractice.DAL;
using RadiantDentalPractice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.Repository
{
    public class TreatmentPlanRepository : ITreatmentPlanRepository
    {
        public int addTreatmentPlan(TreatmentPlan treatmentPlan)
        {
            using (var db = new DentalPracticeContext())
            {
                db.treatmentPlans.Add(treatmentPlan);
                int result = db.SaveChanges();
                return result;
            }
        }

        public DateTime getLastTreatmentBookedDate(int patientID)
        {
            using (var db = new DentalPracticeContext())
            {
                var result = from treatmentPlan in db.treatmentPlans
                             where treatmentPlan.patientID == patientID orderby treatmentPlan.bookedDate descending
                             select treatmentPlan.bookedDate;
                return result.First();
            }
        }

        public List<TreatmentPlan> getTreatmentPlans(int patientID)
        {
            using (var db = new DentalPracticeContext())
            {
                var result = from treatmentPlan in db.treatmentPlans
                             where treatmentPlan.patientID == patientID
                             select treatmentPlan;
                return result.ToList();
            }
        }
    }
}
