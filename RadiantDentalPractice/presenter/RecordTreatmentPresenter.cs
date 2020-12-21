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
    public class RecordTreatmentPresenter
    {
        ITreatmentPlanRepository treatmentPlanRepository;
        IPresenterFactory presenterFactory;
        private static List<string> band_1_list = new List<string>();
        private static List<string> band_2_list = new List<string>();
        private static List<string> band_3_list = new List<string>();
        private static List<string> other_list = new List<string>();
        public RecordTreatmentPresenter(IPresenterFactory presenterFactory,ITreatmentPlanRepository treatmentPlanRepository)
        {
            this.treatmentPlanRepository = treatmentPlanRepository;
            this.presenterFactory = presenterFactory;
        }
        static RecordTreatmentPresenter()
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
        public IRecordTreatmentForm view { get; set; }
        public void recordTreatementPlan(ITreatmentConsentView treatmentConsentView)
        {
            TreatmentPlan treatmentPlan = createTreatmentPlan();
            treatmentPlan.treatmentConsentAndPayment.treatmentCost = 
                calculateCost(treatmentPlan.proposedTreatment,treatmentPlan.patientID);
            TreatmentConsentPresenter treatmentConsentPresenter = presenterFactory.
                getTreatmentConsentPresenter(treatmentPlanRepository,treatmentPlan);
            treatmentConsentView.treatmentConsentPresenter = treatmentConsentPresenter;
            treatmentConsentPresenter.view = treatmentConsentView;
            treatmentConsentPresenter.view.treatmentCost = treatmentPlan.treatmentConsentAndPayment.treatmentCost;
        }

        private TreatmentPlan createTreatmentPlan()
        {
            TreatmentPlan treatmentPlan = new TreatmentPlan();
            treatmentPlan.patientID = view.patientID;
            treatmentPlan.treatmentNotes = view.treatmentNotes;
            treatmentPlan.bookedDate = DateTime.Now;
            treatmentPlan.proposedTreatment = string.Join(",", view.proposedTreatments);
            treatmentPlan.treatmentConsentAndPayment = new TreatmentConsentAndPayment();
            return treatmentPlan;
        }

        private double calculateCost(string proposedTreatment, int patientID)
        {
            double cost = 0;
            if (band_1_list.Intersect(proposedTreatment.Split(',')).Count() > 0)
            {
                cost = ApplicationConstants.BAND1;
            }
            if (band_2_list.Intersect(proposedTreatment.Split(',')).Count() > 0)
            {
                cost = ApplicationConstants.BAND2;
            }
            if (band_3_list.Intersect(proposedTreatment.Split(',')).Count() > 0)
            {
                cost = ApplicationConstants.BAND3;
            }
            if (other_list.Intersect(proposedTreatment.Split(',')).Count() > 0)
            {
                cost = ApplicationConstants.OTHER;
            }
            TreatmentPlan treatmentPlan = treatmentPlanRepository.getTreatmentPlan(patientID);
            if (treatmentPlan!=null && (DateTime.Now.Subtract(treatmentPlan.bookedDate).TotalDays / 30) < 2)
            {
                cost = ApplicationConstants.FREE;
                if (band_3_list.Intersect(treatmentPlan.proposedTreatment.Split(',')).Count() > 0 &&
                    other_list.Intersect(treatmentPlan.proposedTreatment.Split(',')).Count() == 0)
                {
                    cost = ApplicationConstants.FREE;
                }
                else if(band_2_list.Intersect(treatmentPlan.proposedTreatment.Split(',')).Count() > 0 &&
                    other_list.Intersect(treatmentPlan.proposedTreatment.Split(',')).Count() == 0 &&
                    band_3_list.Intersect(treatmentPlan.proposedTreatment.Split(',')).Count() == 0)
                {
                    cost = ApplicationConstants.FREE;
                }
                else if (band_1_list.Intersect(treatmentPlan.proposedTreatment.Split(',')).Count() > 0 &&
                    other_list.Intersect(treatmentPlan.proposedTreatment.Split(',')).Count() == 0 &&
                    band_3_list.Intersect(treatmentPlan.proposedTreatment.Split(',')).Count() == 0 &&
                    band_2_list.Intersect(treatmentPlan.proposedTreatment.Split(',')).Count() == 0)
                {
                    cost = ApplicationConstants.FREE;
                }
                else if (other_list.Intersect(treatmentPlan.proposedTreatment.Split(',')).Count() > 0 &&
                    band_1_list.Intersect(treatmentPlan.proposedTreatment.Split(',')).Count() == 0 &&
                    band_3_list.Intersect(treatmentPlan.proposedTreatment.Split(',')).Count() == 0 &&
                    band_2_list.Intersect(treatmentPlan.proposedTreatment.Split(',')).Count() == 0)
                {
                    cost = ApplicationConstants.FREE;
                }
            }
            return cost;
        }
    }
}
