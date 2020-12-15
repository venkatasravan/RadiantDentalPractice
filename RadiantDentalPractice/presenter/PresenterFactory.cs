using RadiantDentalPractice.Factory;
using RadiantDentalPractice.models;
using RadiantDentalPractice.Repository;
using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.presenter
{
    public class PresenterFactory : IPresenterFactory
    {
        public GPPresenter getGPPresenter(IGpView view, Patient patient, IRepositoryFactory factory)
        {
            return new GPPresenter(view, patient, factory);
        }

        public PatientPresenter getPatientPresenter(IPatientView view, IViewFactory factory,
            IPresenterFactory presenterFactory, IRepositoryFactory repositoryFactory)
        {
            return new PatientPresenter(view, factory,presenterFactory,repositoryFactory);
        }

        public QuestionnairePresenter getQuestionnairePresenter(IQuestionView view, Patient patient, IViewFactory factory, IPresenterFactory presenterFactory, IRepositoryFactory repositoryFactory)
        {
            return new QuestionnairePresenter(view, patient, factory,presenterFactory,repositoryFactory);
        }
    }
}
