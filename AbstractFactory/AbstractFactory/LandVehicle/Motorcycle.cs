using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LandVehicle
{
    internal class Motorcycle : ILandVehicle
    {
     
        public void GetCargo()
        {
            Console.WriteLine("Delivery pego");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Delivery a caminho");
        }
    }
}
