using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Vehicles
{
    internal class Car : ICar
    {
        private string color;
        private double engine;
        private int year;
        private int seats;
        private int doors;


        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar( color, year, engine, seats, doors);
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            this.color = color; 
            this.year = year;
            this.engine = engine;   
            this.seats = seats;
            this.doors = doors;


            Console.WriteLine($"Carro de ano {year}, motor {engine}, cor {color}, assentos {seats}, portas { doors}");

                StartEngine();
        }

        public void StartEngine()
        {
            Console.WriteLine("Ligando motor do carro");
        }
    }
}
