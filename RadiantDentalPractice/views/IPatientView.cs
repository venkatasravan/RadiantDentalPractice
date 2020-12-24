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
     * interface for patient registration     * 
     * 
     * 
     */
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
