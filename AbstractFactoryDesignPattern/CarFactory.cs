using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactoryDesignPattern.Car;

namespace AbstractFactoryDesignPattern
{
    public static class CarFactory
    {
        public static Car? BuildCar(CarType carType, Location location)
        {
            switch (location)
            {
                case Location.USA:
                    return USACarFactory.BuildCar(carType, location);
                case Location.India:
                    return IndiaCarFactory.BuildCar(carType, location);
                default:
                    return DefaultCarFactory.BuildCar(carType, location);
            }
        }
    }
}
