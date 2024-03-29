﻿using RadiantDentalPractice.presenter;
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
     * this form allows us to record treatment plan
     * 
     */
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
        public string proposedTreatmentValue 
        {
            get
            {
                return proposedTreatmentList.Text;
            }
            set
            {
                proposedTreatmentList.Text = value;
            }
        }

        public RecordTreatmentPresenter recordTreatmentPresenter { get; set; }

        /*
         * load pre-populated values
         * 
         */
        private void loadTreatmentConditions()
        {
            proposedTreatmentList.Items.Add("EXAMINATION");
            proposedTreatmentList.Items.Add("DIAGNOSIS");
            proposedTreatmentList.Items.Add("CORRECTION_OF_FILLINGS");
            proposedTreatmentList.Items.Add("TEETH_WHITENING");
            proposedTreatmentList.Items.Add("DENTAL_IMPLANTS");
            proposedTreatmentList.Items.Add("ROOT_CANAL_WORK");
            proposedTreatmentList.Items.Add("CROWNS");
            proposedTreatmentList.Items.Add("DENTURES");
            proposedTreatmentList.Items.Add("FILLINGS");
        }

        public string errorMessage { get; set; }

        private void validateInput()
        {
            errorMessage = "";
            recordTreatmentPresenter.validate();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            validateInput();
            if (errorMessage.Length != 0)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                this.Hide();
                TreatmentConsentAndPaymentForm treatmentConsentAndPaymentForm = new TreatmentConsentAndPaymentForm();
                recordTreatmentPresenter.recordTreatementPlan(treatmentConsentAndPaymentForm);
                if (!recordTreatmentPresenter.isPatientAvailable(patientID))
                {
                    MessageBox.Show("Patient Not registered");
                }
                else
                {
                    treatmentConsentAndPaymentForm.ShowDialog();
                }

                this.Close();
            }
            
        }
    }
}
