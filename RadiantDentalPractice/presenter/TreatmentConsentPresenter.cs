using RadiantDentalPractice.Constants;
using RadiantDentalPractice.models;
using RadiantDentalPractice.Repository;
using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiantDentalPractice.presenter
{
    /*
    * @author venkata sravan kumar
    * 
    */
    public class TreatmentConsentPresenter
    {
        ITreatmentPlanRepository treatmentPlanRepository;
        private TreatmentPlan treatmentPlan;
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
        public TreatmentConsentPresenter(ITreatmentPlanRepository treatmentPlanRepository, TreatmentPlan treatmentPlan)
        {
            this.treatmentPlanRepository = treatmentPlanRepository;
            this.treatmentPlan = treatmentPlan;
        }
        public ITreatmentConsentView view { get; set; }

        public int updateTreatmentPlan()
        {
            updateTreatmentConsent();
            return treatmentPlanRepository.addTreatmentPlan(treatmentPlan);
        }
        private void updateTreatmentConsent()
        {
            treatmentPlan.treatmentConsentAndPayment.consentText = view.consentText;
            treatmentPlan.treatmentConsentAndPayment.isAccepted = view.isAccepted;
        }
        
    }
}
