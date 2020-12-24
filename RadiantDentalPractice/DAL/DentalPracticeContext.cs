using RadiantDentalPractice.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.DAL
{
    class DentalPracticeContext : DbContext
    {
        public DentalPracticeContext() : base("DentalPracticeContext")
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<MedicalQuestions> medicalQuestions { get; set; }
        public DbSet<Question> questions { get; set; }
        public DbSet<GP> GP_details { get; set; }
        public DbSet<Address> address_details { get; set; }
        public DbSet<Appointment> appointments { get; set; }
        public DbSet<TreatmentPlan> treatmentPlans { get; set; }
        public DbSet<Staff> staff_details { get; set; }        
        public DbSet<StaffAvailability> staff_availability_details { get; set; }        
    }
}
