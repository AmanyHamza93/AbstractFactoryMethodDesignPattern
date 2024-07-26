using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public class MicroCar : Car
    {
        public MicroCar(CarType carType, Location location)
        {
            Construct(carType, location);
        }
        public override void Construct(CarType carType, Location location)
        {
            _carType = carType;
            _location = location;
            Console.WriteLine($"Car Type : { _carType} , Location: {location}");
        }
    }
}
