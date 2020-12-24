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
    public partial class SetAvailabilityForm : Form
    {
        public SetAvailabilityForm()
        {
            InitializeComponent();
            loadAvailabilityOptions();
        }

        private void loadAvailabilityOptions()
        {
            AvailabilityStatusTXT.Items.Add("AVAILABLE");
            AvailabilityStatusTXT.Items.Add("UNAVAILABLE");
        }

        private void SelectedDateTXT_ValueChanged(object sender, EventArgs e)
        {
            if(SelectedDateTXT.Value < DateTime.Now)
            {
                MessageBox.Show("InValid Date");
            }
        }
    }
}
