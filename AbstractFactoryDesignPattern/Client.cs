using static AbstractFactoryDesignPattern.Car;

namespace AbstractFactoryDesignPattern
{
    public class Client
    {
        public void BuildCar(CarType carType, Location location)
        {
            CarFactory.BuildCar(carType, location);
        }
    }
}
