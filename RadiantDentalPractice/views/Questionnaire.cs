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
    public partial class Questionnaire : Form
    {

        Patient patient;
        Form view;
        Question _question = new Question();


        public Questionnaire(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        public Question question
        {
            get
            {
                _question.question = Question1.Text;
                _question.answer = Yes.Checked? Yes.Text:No.Text;
                return _question;
            }
            set
            {
                _question = value;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient.medicalQuestions.questions = new HashSet<Question>();
            patient.medicalQuestions.questions.Add(question);
            view = new GP_Practice(patient);
            IPresenter presenter = new GPPresenter(view);
            presenter.load();
            this.Close();
        }
    }
}
