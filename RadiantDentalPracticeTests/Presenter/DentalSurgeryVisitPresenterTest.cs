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
    public class DentalSurgeryVisitPresenterTest
    {
        [TestMethod]
        public void testCheckMedicalQuestionHistory()
        {
            Mock<IRepositoryFactory> repositoryFactory = new Mock<IRepositoryFactory>();
            Mock<IPresenterFactory> presenterFactory = new Mock<IPresenterFactory>();
            Mock<IDentalSurgeryVisitView> dentalSurgeryVisitView = new Mock<IDentalSurgeryVisitView>();
            Mock<IPatientRepository> patientRepository = new Mock<IPatientRepository>();

            repositoryFactory.Setup(x => x.getRepository(It.IsAny<string>())).Returns(patientRepository.Object);
            patientRepository.Setup(x => x.isMedicalQuestionExpired(It.IsAny<int>())).Returns(false);

            DentalSurgeryVisitPresenter dentalSurgeryVisitPresenter = new
                DentalSurgeryVisitPresenter(repositoryFactory.Object, presenterFactory.Object);

            dentalSurgeryVisitView.Object.PatientID = 1;

            dentalSurgeryVisitPresenter.view = dentalSurgeryVisitView.Object;

            Boolean result = dentalSurgeryVisitPresenter.checkMedicalQuestionHistory();
            Assert.IsFalse(result);
        }

    }
}
