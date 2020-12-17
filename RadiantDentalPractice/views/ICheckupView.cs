using RadiantDentalPractice.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.views
{
    public interface ICheckupView
    {
        int patientID { get; set; }
        DateTime bookingDate { get; set; }
        string bookingSlot { get; set; }
        CheckUpPresenter checkUpPresenter { get; set; }
    }
}
