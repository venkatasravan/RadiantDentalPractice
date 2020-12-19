using RadiantDentalPractice.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.views
{
    public interface IRecordTreatmentForm
    {
        int patientID { get; set; }
        string treatmentNotes { get; set; }
        List<string> proposedTreatments { get; set; }
        RecordTreatmentPresenter recordTreatmentPresenter { get; set; }
    }
}
