using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
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
    public class RadiantDentalPracticePresenterTest
    {
        [TestMethod]
        public void testRegisterPatient()
        {
            Mock<IRepositoryFactory> repositoryFactory = new Mock<IRepositoryFactory>();
            Mock<IPresenterFactory> presenterFactory = new Mock<IPresenterFactory>();

            PatientPresenter patientPresenter = new PatientPresenter(
                presenterFactory.Object, repositoryFactory.Object);

            Mock<IPatientView> patientView = new Mock<IPatientView>();

            // mock
            presenterFactory.Setup(x => x.getPatientPresenter(presenterFactory.Object, repositoryFactory.Object))
                .Returns(patientPresenter);

            RadiantDentalPracticePresenter radiantDentalPracticePresenter =
                new RadiantDentalPracticePresenter(presenterFactory.Object, repositoryFactory.Object);
            radiantDentalPracticePresenter.registerPatient(patientView.Object);
        }
    }
}
