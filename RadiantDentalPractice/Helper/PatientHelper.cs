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
    public class PatientHelper
    {
        private static IRepositoryFactory repositoryFactory = new RepositoryFactory();

        public static Boolean isPatientAvailable(int patientID)
        {
            Patient patient = repositoryFactory.getPatientRepository().getPatient(patientID);
            if(patient!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
