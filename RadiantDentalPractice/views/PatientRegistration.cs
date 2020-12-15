using RadiantDentalPractice.models;
using RadiantDentalPractice.presenter;
using System;
using System.Collections;
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
    public partial class PatientRegistration : Form, IPatientView
    {

        private Patient _patient = new Patient();
        public PatientRegistration()
        {
            InitializeComponent();
        }

        public string name 
        {
            get 
            {
                return nameTXT.Text;
            }
            set
            {
                nameTXT.Text = value;
            } 
        }
        public string email
        {
            get
            {
                return emailTXT.Text;
            }
            set
            {
                emailTXT.Text = value;
            }
        }

        public DateTime dob
        {
            get
            {
                return dobTXT.Value.Date;
            }
            set
            {
                dobTXT.Value = value;
            }
        }
        public string postcode
        {
            get
            {
                return postcodeTXT.Text;
            }
            set
            {
                postcodeTXT.Text = value;
            }
        }
        public string city
        {
            get
            {
                return cityTXT.Text;
            }
            set
            {
                cityTXT.Text = value;
            }
        }
        public string country
        {
            get
            {
                return countryTXT.Text;
            }
            set
            {
                countryTXT.Text = value;
            }
        }

        public PatientPresenter patientPresenter { get; set; }

        public void validatePatient()
        {
            throw new NotImplementedException();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientPresenter.RegisterPatient();
            this.Close();
        }
    }
}
