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
    public class StaffServicesPresenter
    {
        private IPresenterFactory presenterFactory;
        private IRepositoryFactory repositoryFactory;
        public StaffServicesPresenter(IPresenterFactory presenterFactory,IRepositoryFactory repositoryFactory)
        {
            this.presenterFactory = presenterFactory;
            this.repositoryFactory = repositoryFactory;
        }

        public void addStaff(IAddStaffView addStaffView)
        {
            AddStaffPresenter addStaffPresenter = presenterFactory.
                getAddStaffPresenter(repositoryFactory.getStaffRepository());
            addStaffPresenter.view = addStaffView;
            addStaffView.addStaffPresenter = addStaffPresenter;
        }

        public void setAvailability(ISetAvailabilityView setAvailabilityView)
        {
            SetAvailabilityPresenter setAvailabilityPresenter = presenterFactory.
                getSetAvailabilityPresenter(repositoryFactory.getStaffRepository());
            setAvailabilityPresenter.view = setAvailabilityView;
            setAvailabilityView.setAvailabilityPresenter = setAvailabilityPresenter;
            setAvailabilityView.availableStaff = loadStaffDetails();
        }

        public string[] loadStaffDetails()
        {
            HashSet<string> staffs = new HashSet<string>();
            List<Staff> staff_details = repositoryFactory.getStaffRepository().retrieveStaff();
            foreach(Staff staff in staff_details)
            {
                staffs.Add(staff.name);
            }
            return staffs.ToArray();
        }
    }
}
