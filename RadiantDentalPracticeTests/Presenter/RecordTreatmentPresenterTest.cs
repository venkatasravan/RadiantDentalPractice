using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RadiantDentalPractice.Constants;
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
    public class RecordTreatmentPresenterTest
    {
        [TestMethod]
        public void testRecordTreatementPlan()
        {
            Mock<ITreatmentPlanRepository> treatmentPlanRepository = new Mock<ITreatmentPlanRepository>();
            Mock<IPresenterFactory> presenterFactory = new Mock<IPresenterFactory>();

            Mock<IRecordTreatmentForm> recordTreatmentForm = new Mock<IRecordTreatmentForm>();

            Mock<ITreatmentConsentView> treatmentConsentView = new Mock<ITreatmentConsentView>();

            recordTreatmentForm.Object.patientID = 1;
            recordTreatmentForm.Object.proposedTreatmentValue = "ROOT_CANAL_WORK";
            recordTreatmentForm.Object.treatmentNotes = "Root canal treatment is required";

            TreatmentPlan treatmentPlan = new TreatmentPlan();
            treatmentPlan.proposedTreatment = "EXAMINATION";
            treatmentPlan.bookedDate = DateTime.Now.Subtract(TimeSpan.FromDays(70));

            TreatmentConsentPresenter treatmentConsentPresenter = new 
                TreatmentConsentPresenter(treatmentPlanRepository.Object, treatmentPlan);

            treatmentPlanRepository.Setup(x => x.getTreatmentPlan(recordTreatmentForm.Object.patientID))
                .Returns(treatmentPlan);

            presenterFactory.Setup(x => x.getTreatmentConsentPresenter(
                It.IsAny<ITreatmentPlanRepository>(), It.IsAny<TreatmentPlan>())).Returns(treatmentConsentPresenter);

            RecordTreatmentPresenter recordTreatmentPresenter = new
                RecordTreatmentPresenter(presenterFactory.Object, treatmentPlanRepository.Object);

            recordTreatmentPresenter.view = recordTreatmentForm.Object;
            recordTreatmentPresenter.recordTreatementPlan(treatmentConsentView.Object);
            //Assert.AreEqual(ApplicationConstants.BAND2, treatmentConsentView.Object.treatmentCost);
        }
    }
}
