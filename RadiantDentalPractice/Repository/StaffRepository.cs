using RadiantDentalPractice.DAL;
using RadiantDentalPractice.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.Repository
{
    public class StaffRepository : IStaffRepository
    {
        public int addStaff(Staff staff)
        {
            using (var db = new DentalPracticeContext())
            {
                db.staff_details.Add(staff);
                db.SaveChanges();
                return staff.ID;
            }
        }
        public int getStaffIDByName(string name)
        {
            using (var db = new DentalPracticeContext())
            {
                var result = from staff in db.staff_details
                             where staff.name == name
                             select staff.ID;
                return result.Any() ? result.First() : 0;
            }
        }

        public Boolean updateAvailability(StaffAvailability staffAvailability)
        {
            using (var db = new DentalPracticeContext())
            {
                db.staff_availability_details.Add(staffAvailability);
                int result = db.SaveChanges();
                return result!=0? true:false;
            }
        }

        public List<Staff> retrieveStaff()
        {
            using (var db = new DentalPracticeContext())
            {
                var result = from staff in db.staff_details
                             select staff;
                return result.Any() ? result.ToList() : null;
            }
        }
    }
}
