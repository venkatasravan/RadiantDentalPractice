using RadiantDentalPractice.DAL;
using RadiantDentalPractice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.Repository
{
    /*
     * @author venkata sravan kumar
     * 
     * this contains the different operations you can perform on the treatment plan details
     * 
     * 
     * 
     */
    public class TreatmentPlanRepository : ITreatmentPlanRepository
    {
        /*
         * insert treatment plan
         * 
         */
        public int addTreatmentPlan(TreatmentPlan treatmentPlan)
        {
            using (var db = new DentalPracticeContext())
            {
                db.treatmentPlans.Add(treatmentPlan);
                int result = db.SaveChanges();
                return result;
            }
        }

        /*
         * last booked treatmentdat of the patient
         * 
         * 
         */
        public DateTime? getLastTreatmentBookedDate(int patientID)
        {
            using (var db = new DentalPracticeContext())
            {
                var result = from treatmentPlan in db.treatmentPlans
                             where treatmentPlan.patientID == patientID 
                             orderby treatmentPlan.bookedDate descending
                             select treatmentPlan.bookedDate;
                if(result.Count() == 0)
                {
                    return null;
                }
                return result.First();
            }
        }

        /*
         * gets all treatment plans of the patient
         * 
         * 
         * 
         */

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

        /*
         * gets the latest treatment plan of the patientID
         * 
         */
        public TreatmentPlan getTreatmentPlan(int patientID)
        {
            using (var db = new DentalPracticeContext())
            {
                var result = from treatmentPlan in db.treatmentPlans
                             where treatmentPlan.patientID == patientID
                             orderby treatmentPlan.bookedDate descending
                             select treatmentPlan;
                if(result.Any())
                {
                    return result.First();
                }
                return null;
            }
        }

        public List<TreatmentPlan> getTreatmentPlans()
        {
            using (var db = new DentalPracticeContext())
            {
                var result = from treatmentPlan in db.treatmentPlans
                             select treatmentPlan;
                return result.ToList();
            }
        }
    }
}
