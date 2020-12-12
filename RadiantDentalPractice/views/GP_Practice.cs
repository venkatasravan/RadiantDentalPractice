using RadiantDentalPractice.models;
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
    public partial class GP_Practice : Form
    {

        private Patient patient;

        public GP_Practice(Patient patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            // need to add
            MessageBox.Show("Patient Registartion Successful");
        }
    }
}
