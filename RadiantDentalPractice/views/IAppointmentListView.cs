using RadiantDentalPractice.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.views
{
    public interface IAppointmentListView
    {
        int patientID { get; set; }
        string email { get; set; }
        string treatmentType { get; set; }
        DateTime bookingdate { get; set; }
        string bookingSlot { get; set; }
        AppointmentsListPresenter appointmentsListPresenter { get; set; }
    }
}
