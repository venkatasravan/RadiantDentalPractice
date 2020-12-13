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
        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            questionnairePresenter.updatePatient();
            this.Close();
        }

        private void loadQuestions()
        {
            _questions.Add(Question1.Text, Question1_TXT.Text);
        }

        private void Question1_TXT_SelectedIndexChanged(object sender, EventArgs e)
        {
            _questions[Question1.Text] = Question1_TXT.Text;
        }

    }
}
