using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using RadiantDentalPractice.Repository;
using RadiantDentalPractice.presenter;
using RadiantDentalPractice.views;
using RadiantDentalPractice.models;
using Moq.Protected;

namespace RadiantDentalPracticeTests.Presenter
{
    [TestClass]
    public class GPPresenterTest
    {
        [TestMethod]
        public void GpDetailsAddedPositiveCase()
        {
            Mock<GPPresenter> Gp = new Mock<GPPresenter>();
            Mock<IPatientRepository> repo = new Mock<IPatientRepository>();
            
            Mock<IGpView> gpView = new Mock<IGpView>();
            Mock<IFactory> factory = new Mock<IFactory>();
            factory.Setup(x => x.getObject()).Returns(repo.Object);
            gpView.Object.name = "Biddlestone Health Group";
            gpView.Object.address = "Biddlestone Road, Heaton, Newcastle";
            Patient patient = new Patient();
            GP gp_details = new GP();
            patient.gp_details = gp_details;
            repo.Setup(x => x.addPatient(patient)).Returns(1);
            GPPresenter gPPresenter = new GPPresenter(gpView.Object, patient, factory.Object);
            int value = gPPresenter.updatePatient();
            Assert.AreEqual(1, value);
        }

    }
}
