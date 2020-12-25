using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RadiantDentalPractice.models;
using RadiantDentalPractice.presenter;
using RadiantDentalPractice.Repository;
using RadiantDentalPractice.views;

namespace RadiantDentalPracticeTests.Presenter
{
   
    /*
    * @author venkata sravan kumar
    * 
    * 
    */
    [TestClass]
    public class SetAvailabilityPresenterTest
    {
        [TestMethod]
        public void testSetAvailability()
        {
            Mock<IStaffRepository> staffRepository = new Mock<IStaffRepository>();
            Mock<ISetAvailabilityView> setAvailabilityView = new Mock<ISetAvailabilityView>();

            setAvailabilityView.Object.name = "sravan";
            setAvailabilityView.Object.selectedDate = DateTime.Now;
            setAvailabilityView.Object.availabilityStatus = "AVAILABLE";

            staffRepository.Setup(x => x.getStaffIDByName(It.IsAny<string>())).Returns(1);
            staffRepository.Setup(x => x.updateAvailability(It.IsAny<StaffAvailability>())).Returns(true);

            SetAvailabilityPresenter setAvailabilityPresenter = new SetAvailabilityPresenter(staffRepository.Object);
            setAvailabilityPresenter.view = setAvailabilityView.Object;
            Boolean isUpdated = setAvailabilityPresenter.setAvailability();
            Assert.IsTrue(isUpdated);
        }
    }
}
