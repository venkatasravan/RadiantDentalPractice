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
        public IPatientRepository getPatientRepository()
        {
            return new PatientRepository();
        }
        public IAppointmentRepository getAppointmentRepository()
        {
            return new AppointmentRepository();
        }

        public ITreatmentPlanRepository getTreatmentPlanRepository()
        {
            return new TreatmentPlanRepository();
        }

        public IStaffRepository getStaffRepository()
        {
            return new StaffRepository();
        }
    }
}
