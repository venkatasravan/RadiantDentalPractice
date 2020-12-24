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
    [TestClass]
    public class PatientPresenterTest
    {
        [TestMethod]
        public void registerPatientPositiveCase()
        {
            Mock<IQuestionView> questionview = new Mock<IQuestionView>();
            Mock<IPatientView> view = new Mock<IPatientView>();

            IPresenterFactory presenterFactory = new PresenterFactory();
            IRepositoryFactory repositoryFactory = new RepositoryFactory();

            PatientPresenter patientpresenter = new PatientPresenter(
                presenterFactory,repositoryFactory);
            patientpresenter.view = view.Object;
            patientpresenter.view.city = "newcastle";
            patientpresenter.view.country = "UK";
            patientpresenter.view.postcode = "ne48as";
            patientpresenter.view.email = "priyanka@gmail.com";
            patientpresenter.view.name = "priyanka";
            patientpresenter.view.phoneNumber = "1234567890";
            patientpresenter.view.dob = DateTime.Now;
            patientpresenter.RegisterPatient(questionview.Object);
        }
    }
}
