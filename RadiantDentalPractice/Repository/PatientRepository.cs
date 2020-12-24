using RadiantDentalPractice.DAL;
using RadiantDentalPractice.models;
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
     * patient repository operations
     * 
     */
    public class PatientRepository : IPatientRepository
    {
        // add patient
        public int addPatient(Patient patient)
        {
            using (var db = new DentalPracticeContext())
            {
                db.Patients.Add(patient);
                db.SaveChanges();
                return patient.patientID;
            }
        }
        // retrieve all patients
        public List<Patient> getPatients()
        {
            using (var db = new DentalPracticeContext())
            {
                var result = from Patient in db.Patients
                             select Patient;
                return result.ToList();
            }
        }
        // duplicate email check
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
        //medical questions validity check
        public Boolean isMedicalQuestionExpired(int patientID)
        {
            using (var db = new DentalPracticeContext())
            {
                var result = from patient in db.Patients
                             where patient.patientID == patientID
                             select patient.medicalQuestions.lastUpdatedDate;
                if(result.Any() && result.First().AddYears(1) < DateTime.Now)
                {
                    return true;
                }
                return false;
            }
        }

        // retrieve patient
        public Patient getPatient(int patientID)
        {
            using (var db = new DentalPracticeContext())
            {
                var result = from patient in db.Patients
                             where patient.patientID == patientID
                             select patient;

                return result.Any() ? result.First() : null;
            }
        }

        // update patient questions
        public int updatePatientQuestions(int patientID, Dictionary<string, string> questions)
        {
            int updatedRecords = 0;
            using (var db = new DentalPracticeContext())
            {
                // Not implemented
                return updatedRecords;
            }
        }

        // update patient questions
        // not implemented properly 
        // not useful
        private void updateQuestions(Patient patient,Dictionary<string, string> questions)
        {
            foreach (KeyValuePair<string, string> entry in questions)
            {
                Question question = new Question();
                question.question = entry.Key;
                question.answer = entry.Value;
                patient.medicalQuestions.questions.Add(question);
            }
            patient.medicalQuestions.lastUpdatedDate = DateTime.Now;
        }
    }
}
