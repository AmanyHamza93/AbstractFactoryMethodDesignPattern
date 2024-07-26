using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDesignPattern
{
    public abstract class Car
    {
        public enum CarType
        {
            Mini = 1, 
            Micro,
            Luxury
        }
        public enum Location
        {
            USA = 1,
            India,
            Default
        }
        public CarType _carType { get; set; }
        public Location _location { get; set; }
        public abstract void Construct(CarType carType, Location location);
    }
}
