using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NyOgBedre;

namespace UT_NyOgBedre
{
    
    internal class FakeTempSensor : ITempSensor
    {
        public int Temp { get; set; }

        public FakeTempSensor()
        {
            Temp = 0;
        }

        public int GetTemp()
        {
            return Temp;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
