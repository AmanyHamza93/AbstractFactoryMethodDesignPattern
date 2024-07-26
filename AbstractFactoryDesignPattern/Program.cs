using AbstractFactoryDesignPattern;
Client client = new Client();
client.BuildCar(Car.CarType.Mini, Car.Location.USA);
client.BuildCar(Car.CarType.Micro, Car.Location.USA);
client.BuildCar(Car.CarType.Luxury, Car.Location.USA);

client.BuildCar(Car.CarType.Mini, Car.Location.India);
client.BuildCar(Car.CarType.Micro, Car.Location.India);
client.BuildCar(Car.CarType.Luxury, Car.Location.India);

client.BuildCar(Car.CarType.Mini, Car.Location.Default);
client.BuildCar(Car.CarType.Micro, Car.Location.Default);
client.BuildCar(Car.CarType.Luxury, Car.Location.Default);
