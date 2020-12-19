using RadiantDentalPractice.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.views
{
    public interface IPatientView
    {
        string name { get; set; }
        string email { get; set; }
        DateTime dob { get; set; }
        string postcode { get; set; }
        string city { get; set; }
        string country { get; set; }
        PatientPresenter patientPresenter { set; }
        string errorMessage { get; set; }
    }
}
