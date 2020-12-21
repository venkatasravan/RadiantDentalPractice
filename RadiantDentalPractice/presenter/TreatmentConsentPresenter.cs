using RadiantDentalPractice.Constants;
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
    public class TreatmentConsentPresenter
    {
        ITreatmentPlanRepository treatmentPlanRepository;
        private static List<string> band_1_list = new List<string>();
        private static List<string> band_2_list = new List<string>();
        private static List<string> band_3_list = new List<string>();
        private static List<string> other_list = new List<string>();
        static TreatmentConsentPresenter()
        {
            band_1_list.Add("EXAMINATION");
            band_1_list.Add("DIAGNOSIS");
            band_1_list.Add("CORRECTION_OF_FILLINGS");
            band_2_list.Add("ROOT_CANAL_WORK");
            band_2_list.Add("FILLINGS");
            band_3_list.Add("CROWNS");
            band_3_list.Add("DENTURES");
            other_list.Add("TEETH_WHITENING");
            other_list.Add("DENTAL_IMPLANTS");
        }
        public TreatmentConsentPresenter(ITreatmentPlanRepository treatmentPlanRepository)
        {
            this.treatmentPlanRepository = treatmentPlanRepository;
        }
        public ITreatmentConsentView view { get; set; }

        public void updateTreatmentPlan(TreatmentPlan treatmentPlan)
        {
            updateTreatmentConsent(treatmentPlan);
        }
        private void updateTreatmentConsent(TreatmentPlan treatmentPlan)
        {
            treatmentPlan.treatmentConsentAndPayment.consentText = view.consentText;
            treatmentPlan.treatmentConsentAndPayment.isAccepted = view.isAccepted;
            treatmentPlan.treatmentConsentAndPayment.treatmentCost = 
                calculateCost(treatmentPlan.proposedTreatment,treatmentPlan.patientID);
        }
        public double calculateCost(string proposedTreatment, int patientID)
        {
            double cost = 0;
            if(band_1_list.Contains(proposedTreatment))
            {
                cost = ApplicationConstants.BAND1;
            }
            else if (band_2_list.Contains(proposedTreatment))
            {
                cost = ApplicationConstants.BAND2;
            }
            else if (band_3_list.Contains(proposedTreatment))
            {
                cost = ApplicationConstants.BAND3;
            }
            else if (other_list.Contains(proposedTreatment))
            {
                cost = ApplicationConstants.OTHER;
            }
            DateTime bookedDate = treatmentPlanRepository.getLastTreatmentBookedDate(patientID);
            if ((DateTime.Now.Subtract(bookedDate).TotalDays/30) < 2)
            {
                cost = ApplicationConstants.FREE;
            }
            return cost;
        }
    }
}
