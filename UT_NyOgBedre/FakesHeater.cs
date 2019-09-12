using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NyOgBedre;

namespace UT_NyOgBedre
{

    internal class FakeHeater : IHeater
    {
        public int TurnOnCalledTimes { get; set; }
        public int TurnOffCalledTimes { get; set; }

        public FakeHeater()
        {
            TurnOffCalledTimes = 0;
            TurnOnCalledTimes = 0;
        }

        public void TurnOn()
        {
            TurnOnCalledTimes++;
        }

        public void TurnOff()
        {
            TurnOffCalledTimes++;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }

}
