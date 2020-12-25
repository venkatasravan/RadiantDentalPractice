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
    public class StaffServicesPresenterTest
    {
        [TestMethod]
        public void testAddStaff()
        {
            Mock<IPresenterFactory> presenterFactory = new Mock<IPresenterFactory>();
            Mock<IRepositoryFactory> repositoryFactory = new Mock<IRepositoryFactory>();

            Mock<IStaffRepository> staffRepository = new Mock<IStaffRepository>();

            Mock<IAddStaffView> addStaffView = new Mock<IAddStaffView>();
            AddStaffPresenter addStaffPresenter = new AddStaffPresenter(staffRepository.Object);

            presenterFactory.Setup(x => x.getAddStaffPresenter(It.IsAny<IStaffRepository>())).Returns(addStaffPresenter);
            repositoryFactory.Setup(x => x.getStaffRepository()).Returns(staffRepository.Object);

            StaffServicesPresenter staffServices = new StaffServicesPresenter(presenterFactory.Object, repositoryFactory.Object);
            staffServices.addStaff(addStaffView.Object);
        }
    }
}
