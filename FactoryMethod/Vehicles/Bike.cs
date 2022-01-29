using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicles
{
    internal class Bike : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando delivery...");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Levando delivery...");

        }
    }
}
