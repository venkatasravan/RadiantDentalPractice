using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RadiantDentalPractice.models;
using RadiantDentalPractice.presenter;
using RadiantDentalPractice.Repository;
using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.Text;

namespace RadiantDentalPracticeTests.Presenter
{
    /*
     * @author venkata sravan kumar
     * 
     * 
     */
    [TestClass]
    public class AddStaffPresenterTest
    {
        [TestMethod]
        public void testInsertStaffSuccess()
        {
            Mock<IStaffRepository> staffRepository = new Mock<IStaffRepository>();
            Mock<IAddStaffView> addStaffView = new Mock<IAddStaffView>();
            staffRepository.Setup(x => x.addStaff(It.IsAny<Staff>())).Returns(1);
            AddStaffPresenter addStaffPresenter = new AddStaffPresenter(staffRepository.Object);
            addStaffPresenter.view = addStaffView.Object;
            addStaffView.Object.name = "sravan";
            addStaffView.Object.role = "CHECKUP";
            int updatedRecords = addStaffPresenter.insertStaff();
            Assert.AreEqual(1, updatedRecords);
        }
    }
}
