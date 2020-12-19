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
    public partial class RecordTreatmentForm : Form, IRecordTreatmentForm
    {
        public RecordTreatmentForm()
        {
            InitializeComponent();
            loadTreatmentConditions();
        }

        public int patientID
        {
            get
            {
                return int.Parse(patientIDTXT.Text);
            }
            set
            {
                patientIDTXT.Text = value.ToString();
            }
        }
        public string treatmentNotes 
        { 
            get
            {
                return treatmentNotesTXT.Text;
            }
            set
            {
                treatmentNotesTXT.Text = value;
            }
        }
        public List<string> proposedTreatments 
        {
            get
            {
                return proposedTreatmentList.CheckedItems.OfType<string>().ToList();
            }
            set
            {
                proposedTreatmentList.Items.AddRange(value.ToArray());
            }
        }

        public RecordTreatmentPresenter recordTreatmentPresenter { get; set; }

        private void loadTreatmentConditions()
        {
            proposedTreatmentList.Items.Add("EXAMINATION", CheckState.Unchecked);
            proposedTreatmentList.Items.Add("DIAGNOSIS", CheckState.Unchecked);
            proposedTreatmentList.Items.Add("CORRECTION_OF_FILLINGS", CheckState.Unchecked);
            proposedTreatmentList.Items.Add("TEETH_WHITENING", CheckState.Unchecked);
            proposedTreatmentList.Items.Add("DENTAL_IMPLANTS", CheckState.Unchecked);
            proposedTreatmentList.Items.Add("ROOT_CANAL_WORK", CheckState.Unchecked);
            proposedTreatmentList.Items.Add("CROWNS", CheckState.Unchecked);
            proposedTreatmentList.Items.Add("DENTURES", CheckState.Unchecked);
            proposedTreatmentList.Items.Add("FILLINGS", CheckState.Unchecked);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hello " + proposedTreatments.Count);
            recordTreatmentPresenter.recordTreatementPlan();
            MessageBox.Show("Success");
            this.Close();
        }
    }
}
