using RadiantDentalPractice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.views
{
    interface IPatientRegistrationForm
    {
        Patient patient { get; set; }
        void validatePatient();
        void validateQuestions();
        void validateGP();
    }
}
