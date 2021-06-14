using Cars.Models;
using Test.ViewModels.Base;

namespace Cars.ViewModels
{
    public class AllCarsVM : ViewModel
    {
        private string _information;
        public string Information
        {
            get => _information;
            set
            {
                _information = value;
                OnPropertyChanged();
            }
        }

        public void CreateInformation()
        {
            int id = model.Car.ID;
            string name = model.Car.Name;
            Information = $"Номер автомобиля - {id}, Название - {name}";
        }
        public AllCarsVM(ModelInstance model)
        {
            /**
             * В MainWindowVM такой код.
             *public MainWindowVM()
             *AllCarsVM allCarsVM = new AllCarsVM(new Models.ModelInstance());
             *allCarsVM.CreateInformation();
             * 
             */
            this.model = model; // здесь есть значения
            Information = "Работает 2";

        }
        public AllCarsVM()
        {
            Information = "Работает 1";
        }

        private readonly ModelInstance model;
    }
}
