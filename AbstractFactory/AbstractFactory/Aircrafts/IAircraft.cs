using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    internal interface IAircraft
    {
        void CheckWind();
        void StartRoute();

        void GetCargo();


    }
}
