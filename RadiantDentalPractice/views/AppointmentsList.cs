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
    public partial class AppointmentsList : Form, IAppointmentListView
    {
        public AppointmentsList()
        {
            InitializeComponent();
        }

        public int patientID { get; set; }
        public string email { get; set; }
        public string treatmentType { get; set; }
        public DateTime bookingdate { get; set; }
        public string bookingSlot { get; set; }
        public AppointmentsListPresenter appointmentsListPresenter { get; set; }

        public void getAppointments()
        {
            var list = appointmentsListPresenter.getAppointments();
            AppointmentsData.DataSource = list;
        }

        private void AppointmentsList_Load(object sender, EventArgs e)
        {
            getAppointments();
        }
    }
}
