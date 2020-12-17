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
    public class CheckUpPresenter
    {
        private ICheckupView checkupView;
        private ICheckupRepository checkupRepository;
        public CheckUpPresenter(ICheckupView checkupView, ICheckupRepository checkupRepository)
        {
            this.checkupView = checkupView;
            this.checkupRepository = checkupRepository;
        }

        public int CreateCheckupBooking()
        {
            CheckupAppointment checkupAppointment = new CheckupAppointment();
            checkupAppointment.bookingDate = checkupView.bookingDate;
            checkupAppointment.bookingSlot = checkupView.bookingSlot;
            checkupAppointment.patientID = checkupView.patientID;
            int result = checkupRepository.addCheckupBooking(checkupAppointment);
            return result;
        }

    }
}
