using Dip.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentProcess pay = new PaymentProcess();
            pay.Pay("Cringe");
            Console.ReadLine();
        }
    }
}
