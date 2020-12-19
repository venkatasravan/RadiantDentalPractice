using RadiantDentalPractice.models;
using RadiantDentalPractice.Repository;
using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.presenter
{
    public class RecordTreatmentPresenter
    {
        ITreatmentPlanRepository treatmentPlanRepository;
        public RecordTreatmentPresenter(ITreatmentPlanRepository treatmentPlanRepository)
        {
            this.treatmentPlanRepository = treatmentPlanRepository;
        }
        public IRecordTreatmentForm view { get; set; }
        public void recordTreatementPlan()
        {
            foreach(string treatment in view.proposedTreatments)
            {
                TreatmentPlan treatmentPlan = new TreatmentPlan();
                treatmentPlan.patientID = view.patientID;
                treatmentPlan.treatmentNotes = view.treatmentNotes;
                treatmentPlan.proposedTreatment = treatment;
                insertTreatmentPlan(treatmentPlan);
            }
        }

        private void insertTreatmentPlan(TreatmentPlan treatmentPlan)
        {

            treatmentPlanRepository.addTreatmentPlan(treatmentPlan);
        }
    }
}
