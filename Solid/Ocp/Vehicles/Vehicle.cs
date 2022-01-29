using System;


namespace Ocp.Vehicles
{
    class Vehicle : IVehicle
    {
        protected string color;
        protected int year;
        protected double engine;
   

        public Vehicle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;         
        }

        public void StartVehicle() { }

        public void Motorcycle() { Console.WriteLine($"Criando uma moto da cor {color},ano {year}, motor {engine}"); StartVehicle(); }

        



    }
}
