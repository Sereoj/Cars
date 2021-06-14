using Cars.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ViewModels.Base;

namespace Cars.ViewModels
{
    public class AllCarsVM : ViewModel
    {
        private string _information;
        public string Information
        {
            get => _information;
            set => Set(ref _information, value);
        }

        public void CreateInformation()
        {
            int id = model.Car.ID;
            string name = model.Car.Name;
            Information = $"Номер автомобиля - {id}, Название - {name}";
        }
        public AllCarsVM(ModelInstance model)
        {
            this.model = model;
        }
        public AllCarsVM()
        {
        }

        private readonly ModelInstance model;
    }
}
