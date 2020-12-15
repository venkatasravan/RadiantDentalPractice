using RadiantDentalPractice.Factory;
using RadiantDentalPractice.models;
using RadiantDentalPractice.Repository;
using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiantDentalPractice.presenter
{
    public class RadiantDentalPracticePresenter
    {

        private RadiantDentalPracticeForm formView;
        private IViewFactory viewFactory;
        private IPresenterFactory presenterFactory;
        private IRepositoryFactory repositoryFactory;
        public RadiantDentalPracticePresenter(RadiantDentalPracticeForm formView, 
            IViewFactory viewFactory, IPresenterFactory presenterFactory, IRepositoryFactory repositoryFactory)
        {
            this.formView = formView;
            this.viewFactory = viewFactory;
            this.presenterFactory = presenterFactory;
            this.repositoryFactory = repositoryFactory;
        }
        
        public void registerPatient()
        {
            PatientRegistration view = viewFactory.getPatientView();
            view.patientPresenter = presenterFactory.getPatientPresenter(view,viewFactory,presenterFactory, repositoryFactory);
            ViewHelper.showView(view);
        }

       
    }
}
