using RadiantDentalPractice.Constants;
using RadiantDentalPractice.Helper;
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
    /*
    * @author venkata sravan kumar
    * 
    */
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

        public void validate()
        {
            validationChecks();
        }
        private void validationChecks()
        {
            if (view.patientID == 0)
            {
                view.errorMessage = "Please enter patientID";
            }
            else if (view.treatmentNotes.Trim().Length == 0)
            {
                view.errorMessage = "Please enter treatmentNotes";
            }
            else if (view.proposedTreatmentValue.Trim().Length == 0)
            {
                view.errorMessage = "Please select Proposed treatment";
            }

        }

        public Boolean isPatientAvailable(int patientID)
        {
            return PatientHelper.isPatientAvailable(patientID);
        }

        private TreatmentPlan createTreatmentPlan()
        {
            TreatmentPlan treatmentPlan = new TreatmentPlan();
            treatmentPlan.patientID = view.patientID;
            treatmentPlan.treatmentNotes = view.treatmentNotes;
            treatmentPlan.bookedDate = DateTime.Now;
            treatmentPlan.proposedTreatment = view.proposedTreatmentValue;
            treatmentPlan.treatmentConsentAndPayment = new TreatmentConsentAndPayment();
            return treatmentPlan;
        }

        private double calculateCost(string proposedTreatment, int patientID)
        {
            double cost = 0;
            if (band_1_list.Contains(proposedTreatment))
            {
                cost = ApplicationConstants.BAND1;
            }
            if (band_2_list.Contains(proposedTreatment))
            {
                cost = ApplicationConstants.BAND2;
            }
            if (band_3_list.Contains(proposedTreatment))
            {
                cost = ApplicationConstants.BAND3;
            }
            if (other_list.Contains(proposedTreatment))
            {
                cost = ApplicationConstants.OTHER;
            }
            TreatmentPlan treatmentPlan = treatmentPlanRepository.getTreatmentPlan(patientID);
            if (treatmentPlan!=null && (DateTime.Now.Subtract(treatmentPlan.bookedDate).TotalDays / 30) < 2)
            {
                if (band_3_list.Contains(proposedTreatment) &&
                    !other_list.Contains(proposedTreatment))
                {
                    cost = ApplicationConstants.FREE;
                    if (other_list.Contains(proposedTreatment))
                    {
                        cost = ApplicationConstants.OTHER;
                    }
                }
                else if(band_2_list.Contains(proposedTreatment) &&
                    !other_list.Contains(proposedTreatment) &&
                    !band_3_list.Contains(proposedTreatment))
                {
                    cost = ApplicationConstants.FREE;
                    if (band_3_list.Contains(proposedTreatment))
                    {
                        cost = ApplicationConstants.BAND3;
                    }
                    if (other_list.Contains(proposedTreatment))
                    {
                        cost = ApplicationConstants.OTHER;
                    }
                }
                else if (band_1_list.Contains(proposedTreatment) &&
                    !other_list.Contains(proposedTreatment) &&
                    !band_3_list.Contains(proposedTreatment) &&
                    !band_2_list.Contains(proposedTreatment))
                {
                    cost = ApplicationConstants.FREE;
                    if (band_2_list.Contains(proposedTreatment))
                    {
                        cost = ApplicationConstants.BAND2;
                    }
                    if (band_3_list.Contains(proposedTreatment))
                    {
                        cost = ApplicationConstants.BAND3;
                    }
                    if (other_list.Contains(proposedTreatment))
                    {
                        cost = ApplicationConstants.OTHER;
                    }
                }
                else if (other_list.Contains(proposedTreatment) &&
                    !band_1_list.Contains(proposedTreatment) &&
                    !band_3_list.Contains(proposedTreatment) &&
                    !band_2_list.Contains(proposedTreatment))
                {
                    cost = ApplicationConstants.FREE;
                    if (band_1_list.Contains(proposedTreatment))
                    {
                        cost = ApplicationConstants.BAND1;
                    }
                    if (band_2_list.Contains(proposedTreatment))
                    {
                        cost = ApplicationConstants.BAND2;
                    }
                    if (band_3_list.Contains(proposedTreatment))
                    {
                        cost = ApplicationConstants.BAND3;
                    }
                }
            }
            return cost;
        }
    }
}
