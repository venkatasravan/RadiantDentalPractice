using RadiantDentalPractice.models;
using RadiantDentalPractice.presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiantDentalPractice.views
{
    /*
     * @author venkata sravan kumar
     * 
     * this form allows us to record the medical questions
     * 
     */
    public partial class Questionnaire : Form, IQuestionView
    {


        private Dictionary<string,string> _questions = new Dictionary<string, string>();

        public Questionnaire()
        {
            InitializeComponent();
            loadQuestions();
        }



        public QuestionnairePresenter questionnairePresenter { get; set; }
        public Dictionary<string, string> questions 
        { 
            get
            {                
                return _questions;
            }
            set
            {
                _questions = value;
            }
        }
        /*
         * introduced to handle who called this form
         * because this gets called from PatientRegistration form and DentalSurgery form
         */
        public Form caller { get; set; }

        public string errorMessage { get; set; }

        private void validateInput()
        {
            errorMessage = "";
            questionnairePresenter.validate();
        }



        private void Next_Click(object sender, EventArgs e)
        {
            validateInput();
            if (errorMessage.Length != 0)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                this.Hide();
                if (caller is PatientRegistration)
                {
                    GP_Practice gP_Practice = new GP_Practice();
                    questionnairePresenter.updatePatient(gP_Practice);
                    gP_Practice.ShowDialog();
                }
                else
                {
                    questionnairePresenter.updateExistingPatient();
                }

                this.Close();
            }
        }

        /*
         * load questions directly from view to list
         * 
         */
        private void loadQuestions()
        {
            _questions.Add(Question1.Text, Question1_TXT.Text);
            _questions.Add(Question2.Text, Question2_TXT.Text);
            _questions.Add(Question3.Text, Question3_TXT.Text);
        }

        private void Question1_TXT_SelectedIndexChanged(object sender, EventArgs e)
        {
            _questions[Question1.Text] = Question1_TXT.Text;
        }

        private void Question2_TXT_SelectedIndexChanged(object sender, EventArgs e)
        {
            _questions[Question2.Text] = Question2_TXT.Text;
        }

        private void Question3_TXT_SelectedIndexChanged(object sender, EventArgs e)
        {
            _questions[Question3.Text] = Question3_TXT.Text;
        }
    }
}
