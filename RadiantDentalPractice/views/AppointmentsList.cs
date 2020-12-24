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
     * this form displays appointments booked
     * 
     * 
     */
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
        /*
         * Presenter Instance
         * 
         */
        public AppointmentsListPresenter appointmentsListPresenter { get; set; }

        /*
         * retrieves appointments list
         * updates the view
         * 
         */
        private void getAppointments()
        {
            var list = appointmentsListPresenter.getAppointments();
            AppointmentsData.DataSource = list;
        }

        /*
         * calling above private method
         */
        private void AppointmentsList_Load(object sender, EventArgs e)
        {
            getAppointments();
        }
    }
}
