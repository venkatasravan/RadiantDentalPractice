using RadiantDentalPractice.models;
using RadiantDentalPractice.Repository;
using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * GPPresenter responsible to update the GP details to the patient model.
 * It will call Patient Repository to insert the data to database
 */

namespace RadiantDentalPractice.presenter
{
    public class GPPresenter
    {

        
        Patient patient;
        IRepositoryFactory factory;

        public GPPresenter(Patient patient, IRepositoryFactory factory)
        {
            this.patient = patient;
            this.factory = factory;
        }

        public IGpView view { get; set; }

        public int updatePatient()
        {
            updateAddress();
            IPatientRepository patientRepository = factory.getPatientRepository();
            return patientRepository.addPatient(patient);
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
