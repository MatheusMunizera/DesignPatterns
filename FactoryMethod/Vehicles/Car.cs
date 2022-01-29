using System;

namespace FactoryMethod.Vehicles
{
     class Car : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos o passageiro!");
        }

        public void StartRoute()
        {
            Console.WriteLine("Iniciando o trajeto.");
            GetCargo();
        }
    }
}
