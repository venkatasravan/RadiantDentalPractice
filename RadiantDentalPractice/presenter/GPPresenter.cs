using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiantDentalPractice.presenter
{
    public class GPPresenter: IPresenter
    {

        Form view;

        public GPPresenter(Form view)
        {
            this.view = view;
        }
        public void load()
        {
            this.view.ShowDialog();
        }



        public void validate()
        {
            throw new NotImplementedException();
        }
    }
}
