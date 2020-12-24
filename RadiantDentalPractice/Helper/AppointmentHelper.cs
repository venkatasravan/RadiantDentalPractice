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
    /*
    * @author venkata sravan kumar
    * 
    */
    public class AppointmentHelper
    {
        private static IRepositoryFactory repositoryFactory = new RepositoryFactory();
        

       
        public static List<string> getCheckupSlots(DateTime bookingDate)
        {
            List<string> checkUpSlots = new List<string>();
            DateTime dateTime = new DateTime(bookingDate.Year, bookingDate.Month, bookingDate.Day, 8, 0, 0);
            if (dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                return checkUpSlots;
            }
            if (dateTime < DateTime.Now.AddDays(7))
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

        public static List<string> bookedCheckupSlots(DateTime bookedDate)
        {
            IAppointmentRepository appointmentRepository = repositoryFactory.getAppointmentRepository();
            List<string> bookedSlots = appointmentRepository.bookedSlots(bookedDate,"CHCEKUP");
            return bookedSlots;
        }

        public static List<string> getEmergencySlots(DateTime bookingDate)
        {
            List<string> emergencySlots = new List<string>();
            DateTime dateTime = new DateTime(bookingDate.Year, bookingDate.Month, bookingDate.Day, 9, 0, 0);
            if (dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday)
            {
                return emergencySlots;
            }
            if (dateTime < DateTime.Now)
            {
                return emergencySlots;
            }
            for (int i = 0; emergencySlots.Count < ApplicationConstants.DAILY_EMERGENCY_SLOTS; i++)
            {
                DateTime startSlot = dateTime.AddMinutes(i * ( ApplicationConstants.EMERGENCY_DURATION));
                DateTime endSlot = dateTime.AddMinutes((i + 1) * ( ApplicationConstants.EMERGENCY_DURATION));
                if (startSlot.Hour == ApplicationConstants.BREAK_HOUR || startSlot.Hour == (ApplicationConstants.BREAK_HOUR-1))
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
                emergencySlots.Add(startSlot.Hour + ":" + updatedStartSlotMinute + "-" + endSlot.Hour + ":" + updatedEndSlotMinute);
            }


            return emergencySlots;
        }

        public static List<string> bookedEmergencySlots(DateTime bookedDate)
        {
            IAppointmentRepository appointmentRepository = repositoryFactory.getAppointmentRepository();
            List<string> bookedSlots = appointmentRepository.bookedSlots(bookedDate,"EMERGENCY");
            return bookedSlots;
        }
    }
}
