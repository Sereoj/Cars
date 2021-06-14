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
