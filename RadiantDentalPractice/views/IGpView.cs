using RadiantDentalPractice.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.views
{
    public interface IGpView
    {
        string name { get; set; }
        string address { get; set; }
        GPPresenter gPPresenter { get; set; }
    }
}
