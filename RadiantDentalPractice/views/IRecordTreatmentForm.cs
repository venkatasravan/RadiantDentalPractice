using RadiantDentalPractice.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.views
{
    /*
     * @author venkata sravan kumar
     * 
     * interface for record treatment form     * 
     * 
     */
    public interface IRecordTreatmentForm
    {
        int patientID { get; set; }
        string treatmentNotes { get; set; }
        string proposedTreatmentValue { get; set; }
        RecordTreatmentPresenter recordTreatmentPresenter { get; set; }
        string errorMessage { get; set; }
    }
}
