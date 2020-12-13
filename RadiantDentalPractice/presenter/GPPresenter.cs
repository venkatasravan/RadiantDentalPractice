using RadiantDentalPractice.models;
using RadiantDentalPractice.Repository;
using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiantDentalPractice.presenter
{
    public class GPPresenter
    {

        IGpView view;
        Patient patient;

        public GPPresenter(IGpView view,Patient patient)
        {
            this.view = view;
            this.patient = patient;
        }

        public void updatePatient()
        {
            updateAddress();
            Console.WriteLine("Patient name: " + patient.name);
            Console.WriteLine("Patient email: " + patient.email);
            Console.WriteLine("Patient dob: " + patient.dob.ToString());
            Console.WriteLine("Patient city: " + patient.address.city);
            Console.WriteLine("Patient postcode: " + patient.address.postcode);
            Console.WriteLine("Patient country: " + patient.address.country);
            Console.WriteLine("Patient question: " + patient.medicalQuestions.questions.First().question);
            Console.WriteLine("Patient answer: " + patient.medicalQuestions.questions.First().answer);
            Console.WriteLine("Patient gp: " + patient.gp_details.name);
            Console.WriteLine("Patient gp address: " + patient.gp_details.address);
            PatientRepository patientRepository = new PatientRepository();
            patientRepository.addPatient(patient);
        }

        private void updateAddress()
        {
            patient.gp_details.name = view.name;
            patient.gp_details.address = view.address;
        }



        public void validate()
        {
            throw new NotImplementedException();
        }
    }
}
