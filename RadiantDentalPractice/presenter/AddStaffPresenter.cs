using RadiantDentalPractice.models;
using RadiantDentalPractice.Repository;
using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.presenter
{
    /*
    * @author venkata sravan kumar
    * 
    */
    public class AddStaffPresenter
    {
        private IStaffRepository staffRepository;
        public AddStaffPresenter(IStaffRepository staffRepository)
        {
            this.staffRepository = staffRepository;
        }

        public IAddStaffView view { get; set; }

        public int insertStaff()
        {
            Staff staff = new Staff();
            staff.name = view.name;
            staff.role = view.role;
            return staffRepository.addStaff(staff);
        }

        public void validate()
        {
            validationChecks();
        }
        private void validationChecks()
        {
            if (view.name.Trim().Length == 0)
            {
                view.errorMessage = "Please enter name";
            }
            else if (view.role.Trim().Length == 0)
            {
                view.errorMessage = "Please enter Role";
            }
        }
    }
}
