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
     * interface for StaffRepository
     */
    public interface IStaffRepository
    {
        int addStaff(Staff staff);
        int getStaffIDByName(string name);
        Boolean updateAvailability(StaffAvailability staffAvailability);
        List<Staff> retrieveStaff();
    }
}
