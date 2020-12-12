using RadiantDentalPractice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.presenter
{
    abstract class RegistrationHandler
    {
        protected RegistrationHandler handler;
        public virtual void SetSuccessor(RegistrationHandler handler)
        {
            this.handler = handler;
        }
        public abstract void RegisterPatient(Patient patient);
    }
}
