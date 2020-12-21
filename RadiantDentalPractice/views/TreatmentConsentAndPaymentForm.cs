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
            get
            {
                return double.Parse(Payment.Text);
            }
            set
            {
                Payment.Text = value.ToString();
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

        private void Submit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
