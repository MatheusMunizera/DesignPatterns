using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LandVehicle
{
    internal class Car : ILandVehicle
    {


        public void GetCargo()
        {
            Console.WriteLine("Passageiro confirmado");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando Rota");
        }
    }
}
