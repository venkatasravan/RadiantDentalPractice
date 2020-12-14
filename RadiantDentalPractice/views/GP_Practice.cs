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

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                int patientID = gPPresenter.updatePatient();
                MessageBox.Show("Patient Registartion Successful \n Your PatientID is " + patientID);
            }
            catch
            {
                MessageBox.Show("Patient Registartion Not Successful");
            }
            finally
            {
                this.Close();
            }
            
        }
    }
}
