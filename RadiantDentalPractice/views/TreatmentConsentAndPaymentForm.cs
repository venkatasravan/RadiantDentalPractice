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
    public partial class TreatmentConsentAndPaymentForm : Form, ITreatmentConsentView
    {
        public TreatmentConsentAndPaymentForm()
        {
            InitializeComponent();
        }

        public double treatmentCost
        {
            
            set
            {
                PaymentTXT.Text = value.ToString();
            }
        }
        public string consentText
        {
            get
            {
                return Consent.Text;
            }
            set
            {
                Consent.Text = value;
            }
        }
        public Boolean isAccepted
        {
            get
            {
                return consentTXT.Checked;
            }
            set
            {
                consentTXT.Checked = value;
            }
        }

        public TreatmentConsentPresenter treatmentConsentPresenter { get; set; }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (isAccepted)
            {
                int result = treatmentConsentPresenter.updateTreatmentPlan();
                if (result > 0)
                {
                    MessageBox.Show("Success");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Thanks for attending");
            }
            
        }
    }
}
