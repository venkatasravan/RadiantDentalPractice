using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiantDentalPractice.presenter
{
    public class MainFormPresenter: IPresenter
    {
        public IMainViewForm mainView;
        public MainFormPresenter(IMainViewForm mainViewForm)
        {
            this.mainView = mainViewForm;
            mainView.presenter = this;
        }

        public void load()
        {
            Console.WriteLine("loaded");
            //view.ShowDialog();
        }

        public void validate()
        {
            Console.WriteLine("validation");
        }
    }
}
