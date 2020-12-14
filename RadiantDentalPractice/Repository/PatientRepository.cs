using RadiantDentalPractice.DAL;
using RadiantDentalPractice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.Repository
{
    public class PatientRepository
    {

        public int addPatient(Patient patient)
        {
            using (var db = new DentalPracticeContext())
            {
                db.Patients.Add(patient);
                db.SaveChanges();
                return patient.patientID;
            }
        }
    }
}
