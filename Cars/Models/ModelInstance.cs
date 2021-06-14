using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Models
{
    public class ModelInstance
    {
        public Car Car { get; set; }
        public ModelInstance()
        {
            Car = new Car() { ID = 1, Name = "Авто" };
        }
    }
}
