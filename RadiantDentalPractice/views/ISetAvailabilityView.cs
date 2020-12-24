﻿using RadiantDentalPractice.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.views
{
    public interface ISetAvailabilityView
    {
        string name { get; set; }
        DateTime selectedDate { get; set; }
        string availabilityStatus { get; set; }
        SetAvailabilityPresenter setAvailabilityPresenter { get; set; }
        string[] availableStaff { get; set; }
        string errorDescription { get; set; }
    }
}
