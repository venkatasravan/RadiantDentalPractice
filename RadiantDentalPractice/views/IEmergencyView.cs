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
     * interface for emergency form
     */
    public interface IEmergencyView
    {
        int patientID { get; set; }
        DateTime bookingDate { get; set; }
        string bookingSlot { get; set; }
        EmergencyPresenter emergencyPresenter { get; set; }
        string errorMessage { get; set; }
    }
}
