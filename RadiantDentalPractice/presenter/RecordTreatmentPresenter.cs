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
        public void recordTreatementPlan(ITreatmentConsentView treatmentConsentView)
        {
            TreatmentPlan treatmentPlan = new TreatmentPlan();
            treatmentPlan.patientID = view.patientID;
            treatmentPlan.treatmentNotes = view.treatmentNotes;
            treatmentPlan.proposedTreatment = string.Join(",",view.proposedTreatments);
            treatmentPlan.treatmentConsentAndPayment = new TreatmentConsentAndPayment();
        }

        private void insertTreatmentPlan(TreatmentPlan treatmentPlan)
        {
            treatmentPlanRepository.addTreatmentPlan(treatmentPlan);
        }
    }
}
