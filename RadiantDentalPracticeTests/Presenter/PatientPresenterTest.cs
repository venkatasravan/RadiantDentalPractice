using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RadiantDentalPractice.Factory;
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
            IViewFactory viewFactory = new ViewFactory();

            PatientPresenter patientpresenter = new PatientPresenter(
                viewFactory,presenterFactory,repositoryFactory);
            patientpresenter.view = view.Object;
            patientpresenter.view.city = "newcastle";
            patientpresenter.view.country = "UK";
            patientpresenter.view.postcode = "ne48as";
            patientpresenter.view.email = "priyanka@gmail.com";
            patientpresenter.view.name = "priyanka";
            patientpresenter.view.dob = DateTime.Now;
            patientpresenter.RegisterPatient(questionview.Object);
        }
    }
}
