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
     * this form allow us to add gp details to the database
     * 
     */
    public partial class GP_Practice : Form,IGpView
    {



        public GP_Practice()
        {
            InitializeComponent();
        }

        public GPPresenter gPPresenter { get; set; }
        public string name 
        { 
            get
            {
                return GP_Name_Txt.Text;
            }
            set
            {
                GP_Name_Txt.Text = value;
            } 
        }
        public string address 
        { 
            get
            {
                return GP_addressTXT.Text;
            } 
            set
            {
                GP_addressTXT.Text = value;
            }
        }

        public string errorMessage { get; set; }

        private void validateInput()
        {
            errorMessage = "";
            gPPresenter.validate();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            validateInput();
            if (errorMessage.Length != 0)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                int? patientID = null;
                try
                {
                    patientID = gPPresenter.updatePatient();
                    MessageBox.Show("Patient Registration Successful \n Your PatientID is " + patientID);
                }
                catch
                {
                    MessageBox.Show("Patient Registration Not Successful");
                }
                if (patientID != null)
                {
                    // Give the option to the patient to book checkup
                    DialogResult checkupBooking = MessageBox.Show("Do You want to Book for the checkup?",
                        "CheckUp Booking", MessageBoxButtons.YesNo);
                    if (checkupBooking == DialogResult.Yes)
                    {
                        CheckUpForm checkUpForm = new CheckUpForm();
                        gPPresenter.registerCheckupPresenter(checkUpForm);
                        checkUpForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Thanks for Registering with us. Have a Nice day");
                    }
                }

                this.Close();
            }
            

        }
    }
}
