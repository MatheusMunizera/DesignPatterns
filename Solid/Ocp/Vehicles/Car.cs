using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Vehicles
{
    class Car : Vehicle
    {
        private int seats;
        private int doors;


        public Car(string color, int year, double engine, int seats, int doors) : base(color, year, engine)
        {
            this.doors = doors;
            this.seats = seats;

            ConfigureCar();
        }

        public void ConfigureCar()
        {
            Console.WriteLine($"Criando um carro da cor {color},ano {year}, motor {engine}, porta {doors}, assentos { seats}");
            StartVehicle();
        }
    }
}
