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
     * interface for set availability form
     * 
     * 
     */
    public interface ISetAvailabilityView
    {
        string name { get; set; }
        DateTime selectedDate { get; set; }
        string availabilityStatus { get; set; }
        SetAvailabilityPresenter setAvailabilityPresenter { get; set; }
        string[] availableStaff { get; set; }

        string errorMessage { get; set; }
    }
}
