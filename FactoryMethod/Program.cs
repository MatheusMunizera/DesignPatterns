using FactoryMethod.Factories;
using System;

namespace FactoryMethod
{
     class Program
    {
        static void Main(string[] args)
        {

            Transport transport = null;

            if (args.Length > 0 && args[0] == "--uber")
            {
                transport = new CarTransport();

            }
            else if (args.Length > 0 && args[0] == "--log")
            {
                transport = new MotorcycleTransport();
            }
            else if (args[0] == "--bike" && args.Length > 0)
            {
               transport = new BikeTransport();
            }

            if (transport != null)
            {
                transport.StartTransport();
            }

            Console.ReadLine();


        }
    }
}
