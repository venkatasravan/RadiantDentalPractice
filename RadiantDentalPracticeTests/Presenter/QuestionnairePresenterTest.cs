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
    public class QuestionnairePresenterTest
    {

        //[TestMethod]
        public void testUpdatePatient()
        {
            Mock<IRepositoryFactory> repositoryFactory = new Mock<IRepositoryFactory>();
            Mock<IPresenterFactory> presenterFactory = new Mock<IPresenterFactory>();
            Mock<IQuestionView> questionView = new Mock<IQuestionView>();
            Mock<IGpView> gpView = new Mock<IGpView>();           


            Patient patient = new Patient();
            patient.medicalQuestions = new MedicalQuestions();

            Dictionary<string, string> _questions = new Dictionary<string, string>();
            _questions.Add("Do you have alergy to latex?", "No");

            //questionView.Object.questions = _questions;

            GPPresenter gPPresenter = new PresenterFactory().getGPPresenter(patient,
                repositoryFactory.Object, presenterFactory.Object);

            // mock
            presenterFactory.Setup(x => x.getGPPresenter(patient, repositoryFactory.Object,
                presenterFactory.Object)).Returns(gPPresenter);

            QuestionnairePresenter questionnairePresenter = new
                QuestionnairePresenter(patient, presenterFactory.Object, repositoryFactory.Object);
            questionnairePresenter.view = questionView.Object;
            questionnairePresenter.view.questions = _questions;
            questionnairePresenter.updatePatient(gpView.Object);
        }
    }
}
