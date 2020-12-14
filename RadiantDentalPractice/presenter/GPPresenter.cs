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

        public int updatePatient()
        {
            updateAddress();
            PatientRepository patientRepository = new PatientRepository();
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
