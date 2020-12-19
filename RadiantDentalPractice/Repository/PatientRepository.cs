using RadiantDentalPractice.DAL;
using RadiantDentalPractice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.Repository
{
    public class PatientRepository : IPatientRepository
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

        public List<Patient> getPatients()
        {
            using (var db = new DentalPracticeContext())
            {
                var result = from Patient in db.Patients
                             select Patient;
                return result.ToList();
            }
        }

        public int isEmailRegistered(string email)
        {
            using (var db = new DentalPracticeContext())
            {
                var result = from patient in db.Patients
                             where patient.email == email
                             select patient;
                return result.Count();
            }
        }
    }
}
