
using RadiantDentalPractice.presenter;
using RadiantDentalPractice.Repository;
using RadiantDentalPractice.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadiantDentalPractice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            RadiantDentalPracticeForm mainView = new RadiantDentalPracticeForm();

            IRepositoryFactory repositoryFactory = new RepositoryFactory();
            IPresenterFactory presenterFactory = new PresenterFactory();
            mainView.radiantDentalPracticePresenter = new RadiantDentalPracticePresenter(mainView, presenterFactory, repositoryFactory);
            Application.Run(mainView);
        }
    }
}
