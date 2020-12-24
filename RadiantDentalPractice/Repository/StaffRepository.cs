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
    }
}
