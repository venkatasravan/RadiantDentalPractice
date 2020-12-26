using RadiantDentalPractice.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.views
{
    /*
     * 
     * @author venkata sravan kumar
     * 
     * interface for dental surgery vist form
     * 
     * 
     * 
     */
    public interface IDentalSurgeryVisitView
    {
        int PatientID { get; set; }
        DentalSurgeryVisitPresenter dentalSurgeryVisitPresenter { get; set; }
        string errorMessage { get; set; }
    }
}
