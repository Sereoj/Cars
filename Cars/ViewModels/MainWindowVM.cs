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
        public AllCarsVM AllCarsVM { get; set; }
        public MainWindowVM()
        {
            AllCarsVM = new AllCarsVM(new Models.ModelInstance());
            AllCarsVM.CreateInformation();
        }
    }
}
