using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactoryDesignPattern.Car;

namespace AbstractFactoryDesignPattern
{
    public class DefaultCarFactory
    {
        public static Car? BuildCar(CarType carType,Location location)
        {
            switch(carType)
            {
                case CarType.Mini:
                    return new MiniCar(CarType.Mini, location);
                case CarType.Micro:
                    return new MicroCar(CarType.Micro, location);
                case CarType.Luxury:
                    return new LuxuryCar(CarType.Luxury, location);
                default:
                    return null;

            }
        }
    }
}
