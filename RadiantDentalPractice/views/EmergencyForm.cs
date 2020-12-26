using RadiantDentalPractice.Helper;
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
     * this form allow us to make emergency booking
     * 
     */
    public partial class EmergencyForm : Form,IEmergencyView
    {
        public EmergencyForm()
        {
            InitializeComponent();
        }

        public int patientID
        {
            get
            {
                if (patientIDTXT.Text.Trim().Length == 0)
                {
                    patientIDTXT.Text = "0";
                }
                return int.Parse(patientIDTXT.Text);
            }
            set
            {
                patientIDTXT.Text = value.ToString();
            }
        }
        public DateTime bookingDate
        {
            get
            {
                return bookingDateTXT.Value.Date;
            }
            set
            {
                bookingDateTXT.Value = value;
            }
        }

        public String bookingSlot
        {
            get
            {
                return bookingSlotTXT.Text;
            }
            set
            {
                bookingSlotTXT.Text = value;
            }
        }
        public EmergencyPresenter emergencyPresenter { get; set; }

        public string errorMessage { get; set; }

        private void validateInput()
        {
            errorMessage = "";
            emergencyPresenter.validate();
        }

        private void Book_Click(object sender, EventArgs e)
        {
            validateInput();
            if (errorMessage.Length != 0)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                if (!emergencyPresenter.isPatientAvailable(patientID))
                {
                    MessageBox.Show("Patient Not registered");
                    this.Close();
                }
                try
                {
                    int result = emergencyPresenter.CreateEmergencyBooking();
                    if (result > 0)
                    {
                        MessageBox.Show("Emergency Appointment Booked");
                    }
                    else
                    {
                        MessageBox.Show("Emergency Appointment Not Successful");
                    }
                }
                catch
                {
                    MessageBox.Show("Error Occured during Emergency Appointment");
                }
                this.Close();
            }            
        }

        /*
         * 
         * Loads the booking slots based on the availability
         * 
         * 
         */
        private void bookingDateTXT_ValueChanged(object sender, EventArgs e)
        {
            bookingSlotTXT.Items.Clear();
            bookingSlotTXT.Text = "";
            List<string> bookingSlots = AppointmentHelper.getEmergencySlots(bookingDateTXT.Value);
            List<string> bookedSlots = new List<string>();
            if (bookingSlots.Count != 0)
            {
                bookedSlots = AppointmentHelper.
                bookedCheckupSlots(new DateTime(bookingDate.Year, bookingDate.Month, bookingDate.Day));
            }

            List<string> availableSlots = bookingSlots.Except(bookedSlots).ToList();

            if (availableSlots.Count == 0)
            {
                NoteTXT.Text = "Note: Slots not available for this day. Please select next day";
            }

            


            bookingSlotTXT.Items.AddRange(availableSlots.ToArray());
        }

        private void EmergencyForm_Load(object sender, EventArgs e)
        {
            NoteTXT.Text = "Note: You can only book from next day. except saturday and sunday";
        }
    }
}
