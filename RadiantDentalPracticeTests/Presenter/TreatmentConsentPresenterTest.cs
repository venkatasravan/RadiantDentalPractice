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
    public class TreatmentConsentPresenterTest
    {
        [TestMethod]
        public void testUpdateTreatmentPlan()
        {
            TreatmentPlan treatmentPlan = new TreatmentPlan();
            treatmentPlan.treatmentConsentAndPayment = new TreatmentConsentAndPayment();

            Mock<ITreatmentPlanRepository> treatmentPlanRepository = new Mock<ITreatmentPlanRepository>();
            Mock<ITreatmentConsentView> view = new Mock<ITreatmentConsentView>();

            view.Object.consentText = "Accept all the conditions";
            view.Object.isAccepted = true;

            treatmentPlanRepository.Setup(x => x.addTreatmentPlan(It.IsAny<TreatmentPlan>())).Returns(1);

            TreatmentConsentPresenter treatmentConsentPresenter = 
                new TreatmentConsentPresenter(treatmentPlanRepository.Object,treatmentPlan);
            treatmentConsentPresenter.view = view.Object;
            int updatedRecords = treatmentConsentPresenter.updateTreatmentPlan();
            Assert.AreEqual(1, updatedRecords);
        }
    }
}
