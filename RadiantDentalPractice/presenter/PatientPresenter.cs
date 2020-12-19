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
    public class PatientPresenter
    {

        
        private Patient patient;
        private IViewFactory viewFactory;
        private IPresenterFactory presenterFactory;
        private IRepositoryFactory repositoryFactory;


        public PatientPresenter(IViewFactory viewFactory,
            IPresenterFactory presenterFactory, IRepositoryFactory repositoryFactory)
        {
            this.viewFactory = viewFactory;
            this.presenterFactory = presenterFactory;
            this.repositoryFactory = repositoryFactory;
        }

        public IPatientView view { get; set; }

        public void RegisterPatient(IQuestionView questionView)
        {
            initializePatient();
            QuestionnairePresenter questionnairePresenter = presenterFactory.getQuestionnairePresenter( 
                patient, presenterFactory, repositoryFactory);
            questionnairePresenter.view = questionView;
            questionView.questionnairePresenter = questionnairePresenter;
        }

        public void validate()
        {
            throw new NotImplementedException();
        }

        private void initializePatient()
        {
            patient = new Patient();
            patient.address = new Address();
            patient.gp_details = new GP();
            patient.medicalQuestions = new MedicalQuestions();
            patient.medicalQuestions.questions = new HashSet<Question>();
            patient.name = view.name;
            patient.email = view.email;
            patient.dob = view.dob;
            patient.address.city = view.city;
            patient.address.postcode = view.postcode;
            patient.address.country = view.country;
        }
    }
}
