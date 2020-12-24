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
     * contains staff operations
     */
    public class StaffRepository : IStaffRepository
    {
        /*
         * add staff details
         * 
         */
        public int addStaff(Staff staff)
        {
            using (var db = new DentalPracticeContext())
            {
                db.staff_details.Add(staff);
                db.SaveChanges();
                return staff.ID;
            }
        }
        /*
         * get staffid by name
         * 
         */
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

        /*
         * update availability of the staff
         */
        public Boolean updateAvailability(StaffAvailability staffAvailability)
        {
            using (var db = new DentalPracticeContext())
            {
                db.staff_availability_details.Add(staffAvailability);
                int result = db.SaveChanges();
                return result!=0? true:false;
            }
        }

        /*
         * get all the staff
         * 
         */
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
