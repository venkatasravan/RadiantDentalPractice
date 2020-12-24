using RadiantDentalPractice.Helper;
using RadiantDentalPractice.models;
using RadiantDentalPractice.Repository;
using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiantDentalPractice.presenter
{
    /*
    * @author venkata sravan kumar
    * 
    */
    public class CheckUpPresenter
    {
        private ICheckupView checkupView;
        private IAppointmentRepository checkupRepository;
        public CheckUpPresenter(ICheckupView checkupView, IAppointmentRepository checkupRepository)
        {
            this.checkupView = checkupView;
            this.checkupRepository = checkupRepository;
        }

        public int CreateCheckupBooking()
        {
            Appointment appointment = new Appointment();
            appointment.bookingDate = checkupView.bookingDate;
            appointment.bookingSlot = checkupView.bookingSlot;
            appointment.patientID = checkupView.patientID;
            appointment.treatmentType = "CHECKUP";
            appointment.status = "CONFIRM";
            int result = checkupRepository.addBooking(appointment);
            return result;
        }

        public Boolean isPatientAvailable(int patientID)
        {
            return PatientHelper.isPatientAvailable(patientID);
        }

    }
}
