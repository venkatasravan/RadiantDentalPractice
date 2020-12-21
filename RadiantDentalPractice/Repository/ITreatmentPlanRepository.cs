using RadiantDentalPractice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.Repository
{
    public interface ITreatmentPlanRepository
    {
        int addTreatmentPlan(TreatmentPlan treatmentPlan);
        List<TreatmentPlan> getTreatmentPlans(int patientID);
        DateTime getLastTreatmentBookedDate(int patientID);
    }
}
