﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3_Telega_bot
{
    internal class WeatherResponse
    {
        public TemperatureInfo Main {  get; set; }
        public string Name { get; set; }
    }
}
