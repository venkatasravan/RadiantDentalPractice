﻿using RadiantDentalPractice.models;
using RadiantDentalPractice.presenter;
using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiantDentalPractice
{
    public partial class RadiantDentalPracticeForm : Form
    {

        public RadiantDentalPracticeForm()
        {
            InitializeComponent();
        }
        
        public RadiantDentalPracticePresenter radiantDentalPracticePresenter { get; set; }

        private void RegisterPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            radiantDentalPracticePresenter.registerPatient();
            this.Close();
        }

        private void DentalSurgery_Click(object sender, EventArgs e)
        {
            //not implemented
        }
    }
}
