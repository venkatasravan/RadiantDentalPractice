﻿using RadiantDentalPractice.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.views
{
    public interface ITreatmentConsentView
    {
        double treatmentCost { set; }
        string consentText { get; set; }
        Boolean isAccepted { get; set; }
        TreatmentConsentPresenter treatmentConsentPresenter { get; set; }
    }
}