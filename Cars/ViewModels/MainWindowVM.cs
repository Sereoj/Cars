using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ViewModels.Base;

namespace Cars.ViewModels
{
    public class MainWindowVM : ViewModel
    {

        public MainWindowVM()
        {
            AllCarsVM allCarsVM = new AllCarsVM(new Models.ModelInstance());
            allCarsVM.CreateInformation();
        }
    }
}
