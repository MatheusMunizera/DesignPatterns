using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Vehicles
{
    internal class Motorcycle : IMotorcycle
    {
        private string color;
        private int year;
        private double engine;

        public Motorcycle(string color, int year, double engine)
        {
            ConfigureMotorcycle(color, year, engine);
        }
        public void ConfigureMotorcycle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
           


            Console.WriteLine($"Carro de ano {year}, motor {engine}, cor {color}");

            StartEngine();
        }

        public void StartEngine()
        {
            Console.WriteLine("Ligando motor da moto");
        }

        
    }
}
