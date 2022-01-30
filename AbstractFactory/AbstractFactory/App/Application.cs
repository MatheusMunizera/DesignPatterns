using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.LandVehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.App
{
    internal class Application
    {
        private IAircraft aircraft;
        private ILandVehicle vehicle;

        public Application(ILandVehicleFactory landVehicleFactory, IAircraftFactory aircraftFactory)
        {
            aircraft = aircraftFactory.CreateTransportAircraft();
            vehicle = landVehicleFactory.CreateTransportVehicle();
        }

        public void StartRoute()
        {
            vehicle.StartRoute();
            aircraft.StartRoute();


        }
    }
}
