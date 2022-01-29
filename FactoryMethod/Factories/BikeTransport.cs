using FactoryMethod.Vehicles;


namespace FactoryMethod.Factories
{
    internal class BikeTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Bike();
        }
    }
}
