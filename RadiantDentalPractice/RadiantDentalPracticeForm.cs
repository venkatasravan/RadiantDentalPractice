using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiantDentalPractice
{
    public partial class RadiantDentalPractice : Form
    {
        public RadiantDentalPractice()
        {
            InitializeComponent();
        }

        private void RegisterPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientRegistration patientRegistration = new PatientRegistration();
            patientRegistration.ShowDialog();
            this.Close();
        }
    }
}
