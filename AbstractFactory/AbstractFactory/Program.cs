using AbstractFactory.App;
using AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Program
    {

        static Application ConfigureApplication()
        {
            Application app;

            ILandVehicleFactory vehicleFactory = null;
            IAircraftFactory airplaneFactory = null;

            string company = "Uber";

            if( company == "Lime")
            {
                vehicleFactory = new LimeTransport();
                airplaneFactory = new LimeTransport();
            }else if ( company == "Uber")
            {
                vehicleFactory = new UberTransport();
                airplaneFactory = new LimeTransport();
            }
            else
            {
                airplaneFactory = new NineNineTransport();
                vehicleFactory = new LimeTransport();
            }

            app = new Application(vehicleFactory, airplaneFactory);

            return app;


        }
        static void Main(string[] args)
        {

            Application app = ConfigureApplication();

            app.StartRoute();

            Console.ReadLine();
        }
    }
}
