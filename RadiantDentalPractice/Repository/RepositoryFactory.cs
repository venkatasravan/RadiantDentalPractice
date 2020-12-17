using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.Repository
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public IPatientRepository getPatientRepository()
        {
            return new PatientRepository();
        }
        public ICheckupRepository getCheckupRepository()
        {
            return new CheckupRepository();
        }

        public IEmergencyRepository getEmergencyRepository()
        {
            return new EmergencyRepository();
        }
    }
}
