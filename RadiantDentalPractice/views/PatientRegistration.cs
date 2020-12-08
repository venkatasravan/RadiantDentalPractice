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
    public partial class PatientRegistration : Form
    {
        public PatientRegistration()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            Questionnaire questionnaire = new Questionnaire();
            questionnaire.ShowDialog();
            this.Close();
        }
    }
}
