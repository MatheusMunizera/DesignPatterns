using AbstractFactory.LandVehicle;


namespace AbstractFactory.Factories
{
    internal interface ILandVehicleFactory
    {
        ILandVehicle CreateTransportVehicle();

    }
}
