﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyOgBedre
{
    class Program
    {
        static void Main(string[] args)
        {
            var ecs = new ECS(28, new TempSensor(new RandomGenerator()), new Heater() );

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate();
        }
    }
}
