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
     * 
     * @author venkata sravan kumar
     * 
     * This form allow to us to make check up booking
     * 
     * 
     * 
     */
    public partial class CheckUpForm : Form, ICheckupView
    {
        public CheckUpForm()
        {
            InitializeComponent();
        }

        public int patientID
        {
            get
            {
                if(patientIDTXT.Text.Trim().Length == 0)
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
                return checkUpDateTXT.Value.Date;
            }
            set
            {
                checkUpDateTXT.Value = value;
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

        /*
         * 
         * Presenter instance
         * 
         * 
         */
        public CheckUpPresenter checkUpPresenter { get; set; }

        public string errorMessage { get; set; }

        /*
         * 
         * 
         * Loads booking slots based on the datetime dynamically by calliing database
         * 
         * 
         */
        private void checkUpDateTXT_ValueChanged(object sender, EventArgs e)
        {
            NoteTXT.Text = "";
            bookingSlotTXT.Items.Clear();
            bookingSlotTXT.Text = "";
            List<string> bookingSlots = AppointmentHelper.getCheckupSlots(checkUpDateTXT.Value);
            List<string> bookedSlots = new List<string>();
            if (bookingSlots.Count != 0)
            {
                bookedSlots = AppointmentHelper.
                bookedCheckupSlots(new DateTime(bookingDate.Year, bookingDate.Month, bookingDate.Day));
            }
            
            List<string> availableSlots = bookingSlots.Except(bookedSlots).ToList();

            if(availableSlots.Count==0)
            {
                NoteTXT.Text = "Note: Slots not available for this day. Please select next day";
            }

            if (availableSlots.Count == 0 && checkUpDateTXT.Value.CompareTo(DateTime.Now.AddDays(7))<= 0)
            {
                DayOfWeek dayOfWeek = DateTime.Now.AddDays(8).DayOfWeek;
                if(dayOfWeek == DayOfWeek.Saturday)
                {
                    dayOfWeek = DateTime.Now.AddDays(10).DayOfWeek;
                }
                else if (dayOfWeek == DayOfWeek.Sunday)
                {
                    dayOfWeek = DateTime.Now.AddDays(9).DayOfWeek;
                }
                NoteTXT.Text = "Note: You can not book slots this week. Try to select from "+dayOfWeek.ToString() + " of next week";
            }

            bookingSlotTXT.Items.AddRange(availableSlots.ToArray());
        }

        private void validateInput()
        {
            errorMessage = "";
            NoteTXT.Text = "";
            checkUpPresenter.validate();
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
                if (!checkUpPresenter.isPatientAvailable(patientID))
                {
                    MessageBox.Show("Patient Not registered");
                    this.Close();
                }
                try
                {
                    int result = checkUpPresenter.CreateCheckupBooking();
                    if (result > 0)
                    {
                        MessageBox.Show("CheckUp Appointment Booked");
                    }
                    else
                    {
                        MessageBox.Show("CheckUp Appointment Not Successful");
                    }
                }
                catch
                {
                    MessageBox.Show("Error Occured during CheckUp Appointment");
                }
                this.Close();
            }
            
        }

        private void CheckUpForm_Load(object sender, EventArgs e)
        {
            NoteTXT.Text = "Note: You can only book one week in advance. except saturday and sunday";
        }
    }
}
