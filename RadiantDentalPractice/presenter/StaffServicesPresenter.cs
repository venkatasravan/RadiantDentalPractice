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
                getAddStaffPresenter(((IStaffRepository)repositoryFactory.getRepository("STAFF")));
            addStaffPresenter.view = addStaffView;
            addStaffView.addStaffPresenter = addStaffPresenter;
        }

        public void setAvailability(ISetAvailabilityView setAvailabilityView)
        {
            SetAvailabilityPresenter setAvailabilityPresenter = presenterFactory.
                getSetAvailabilityPresenter(((IStaffRepository)repositoryFactory.getRepository("STAFF")));
            setAvailabilityPresenter.view = setAvailabilityView;
            setAvailabilityView.setAvailabilityPresenter = setAvailabilityPresenter;
            setAvailabilityView.availableStaff = loadStaffDetails();
        }

        public void listPatients(IAppointmentListView appointmentListView)
        {
            AppointmentsListPresenter appointmentsListPresenter = presenterFactory.
                getAppointmentsListPresenter(repositoryFactory);
            appointmentListView.appointmentsListPresenter = appointmentsListPresenter;
        }

        public string[] loadStaffDetails()
        {
            HashSet<string> staffs = new HashSet<string>();
            List<Staff> staff_details = ((IStaffRepository)repositoryFactory.getRepository("STAFF")).retrieveStaff();
            if (staff_details is null)
            {
                return null;
            }
            foreach(Staff staff in staff_details)
            {
                staffs.Add(staff.name);
            }
            return staffs.ToArray();
        }
    }
}
