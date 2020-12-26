using RadiantDentalPractice.presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiantDentalPractice.views
{
    /*
     * @author venkata sravan kumar
     * 
     * interface for GP form
     * 
     * 
     */
    public interface IGpView
    {
        string name { get; set; }
        string address { get; set; }
        GPPresenter gPPresenter { get; set; }
        string errorMessage { get; set; }
    }
}
