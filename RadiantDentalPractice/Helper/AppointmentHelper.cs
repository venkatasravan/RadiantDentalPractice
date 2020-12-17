using RadiantDentalPractice.Constants;
using RadiantDentalPractice.models;
using RadiantDentalPractice.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.Helper
{
    public class AppointmentHelper
    {
        private static IRepositoryFactory repositoryFactory = new RepositoryFactory();
        

        public static Boolean checkAvailabilityForDate(string bookingSlot, DateTime bookingDate)
        {
            IRepositoryFactory repositoryFactory = new RepositoryFactory();
            /*IAppointmentRepository appointmentRepository =repositoryFactory.getAppointmentRepository();
            int value=appointmentRepository.checkAvailableSlots(bookingDate, bookingSlot);
            if(value>1)
            {
                return false;
            }*/
            return true;
        }

        public static List<string> getCheckupSlots(DateTime bookingDate)
        {
            List<string> checkUpSlots = new List<string>();
            DateTime dateTime = new DateTime(bookingDate.Year, bookingDate.Month, bookingDate.Day, 8, 0, 0);
            if (dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                return checkUpSlots;
            }
            if (dateTime < DateTime.Now.AddDays(4))
            {
                return checkUpSlots;
            }
            for (int i = 0; checkUpSlots.Count < ApplicationConstants.DAILY_CHECKUP_SLOTS; i++)
            {
                DateTime startSlot = dateTime.AddMinutes(i * (2 * ApplicationConstants.CHECKUP_DURATION));
                DateTime endSlot = dateTime.AddMinutes((i + 1) * (2 * ApplicationConstants.CHECKUP_DURATION));
                if (startSlot.Hour == ApplicationConstants.BREAK_HOUR)
                {
                    continue;
                }
                string updatedStartSlotMinute = startSlot.Minute.ToString();
                string updatedEndSlotMinute = endSlot.Minute.ToString();
                if (startSlot.Minute == 0)
                {
                    updatedStartSlotMinute = startSlot.Minute + "0";
                }
                if (endSlot.Minute == 0)
                {
                    updatedEndSlotMinute = endSlot.Minute + "0";
                }
                checkUpSlots.Add(startSlot.Hour + ":" + updatedStartSlotMinute + "-" + endSlot.Hour + ":" + updatedEndSlotMinute);
            }

            return checkUpSlots;
        }

        public static List<string> availableCheckupSlots(DateTime bookedDate)
        {
            ICheckupRepository checkupRepository = repositoryFactory.getCheckupRepository();
            List<string> bookedSlots = checkupRepository.bookedCheckupSlots(bookedDate);
            return bookedSlots;
        }

        public static List<string> getEmergencySlots(DateTime bookingDate)
        {
            List<string> emergencySlots = new List<string>();
            DateTime dateTime = new DateTime(bookingDate.Year, bookingDate.Month, bookingDate.Day, 8, 0, 0);
            if (dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                return emergencySlots;
            }
            if (dateTime < DateTime.Now.AddDays(4))
            {
                return emergencySlots;
            }


            return emergencySlots;
        }
    }
}
