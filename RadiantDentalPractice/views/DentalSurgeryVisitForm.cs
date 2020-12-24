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
     * this form asks for patientID 
     * then this calls presenter to verify medical history
     * if it is not updated it will call medical questions again
     * 
     * Note: Updating medical question feature is not implemented yet.
     */
    public partial class DentalSurgeryVisitForm : Form, IDentalSurgeryVisitView
    {
        public DentalSurgeryVisitForm()
        {
            InitializeComponent();
        }

        public int PatientID
        {
            get
            {
                return int.Parse(patientIDTXT.Text);
            }
            set
            {
                patientIDTXT.Text = value.ToString();
            }
        }

        /*
         * Presenter instance
         * 
         */
        public DentalSurgeryVisitPresenter dentalSurgeryVisitPresenter { get; set; }

        private void next_Click(object sender, EventArgs e)
        {
            // Check if patient is available with the given id
            if(!dentalSurgeryVisitPresenter.isPatientAvailable(PatientID))
            {
                MessageBox.Show("Patient Not registered");
                this.Close();
            }
            // check medcal history
            Boolean result = dentalSurgeryVisitPresenter.checkMedicalQuestionHistory();
            if(result)
            {
                Questionnaire questionnaire = new Questionnaire();
                dentalSurgeryVisitPresenter.updateQuestions(questionnaire);
                questionnaire.caller = this;
                questionnaire.ShowDialog();
            }
            else
            {
                MessageBox.Show("Medical History is up-to-date");
            }
            this.Close();
        }
    }
}
