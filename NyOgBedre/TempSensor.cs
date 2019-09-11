using System;

namespace NyOgBedre
{

    public interface ITempSensor
    {
        int GetTemp();
        bool RunSelfTest();
    }

    public interface IRandomGenerator
    {
        int GetRandom();
    }

    internal class RandomGenerator : IRandomGenerator
    {
        private readonly Random _gen = new Random();
        public int GetRandom()
        {
            return _gen.Next(-5, 45);
        }
    }

    internal class TempSensor : ITempSensor
    {
        private readonly IRandomGenerator _gen;

        public TempSensor(IRandomGenerator rng)
        {
            _gen = rng;
        }

        public int GetTemp()
        {
            return _gen.GetRandom();
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}