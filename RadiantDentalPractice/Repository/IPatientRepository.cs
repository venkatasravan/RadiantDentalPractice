using RadiantDentalPractice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.Repository
{
    public interface IPatientRepository
    {
        int addPatient(Patient patient);
        List<Patient> getPatients();
        int isEmailRegistered(string email);
        Boolean isMedicalQuestionExpired(int patientID);
        Patient getPatient(int patientID);
        int updatePatientQuestions(int patientID, Dictionary<string, string> questions);
    }
}
