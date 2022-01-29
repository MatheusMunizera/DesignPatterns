﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Vehicles
{
    internal interface IMotorcycle : IVehicle
    {
        void ConfigureMotorcycle(string color, int year, double engine);
    }
}
