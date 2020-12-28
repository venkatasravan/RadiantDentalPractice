using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.Repository
{
    /*
     * @author venkata sravan kumar
     * 
     * factory class to get repository objects
     * 
     */
    public class RepositoryFactory : IRepositoryFactory
    {
        private IPatientRepository getPatientRepository()
        {
            return PatientRepository.getInstance();
        }
        private IAppointmentRepository getAppointmentRepository()
        {
            return AppointmentRepository.getInstance();
        }

        private ITreatmentPlanRepository getTreatmentPlanRepository()
        {
            return TreatmentPlanRepository.getInstance();
        }

        private IStaffRepository getStaffRepository()
        {
            return StaffRepository.getInstance();
        }

        public object getRepository(string type)
        {
            if(type.Equals("PATIENT"))
            {
                return getPatientRepository();
            }
            else if(type.Equals("APPOINTMENT"))
            {
                return getAppointmentRepository();
            }
            else if (type.Equals("TREATMENTPLAN"))
            {
                return getTreatmentPlanRepository();
            }
            else if (type.Equals("STAFF"))
            {
                return getStaffRepository();
            }
            return null;
        }
    }
}
