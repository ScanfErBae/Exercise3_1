using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NyOgBedre;
using NUnit.Framework;

namespace UT_NyOgBedre
{
    [TestFixture]
    public class UUT_NyOgBedre
    {
        private ECS _uut;
        private FakeHeater _heater;
        private FakeTempSensor _sensor;

        
        [SetUp]

        public void Setup()
        {
            _heater = new FakeHeater();
            _sensor = new FakeTempSensor();
            _uut = new ECS(25, _sensor,_heater);
        }

        [Test]
        public void ECS_Regulate_Test()
        {
            //Arrange
            //Act
            _sensor.Temp = 20;
            _uut.Regulate();
            //Assert
            Assert.That(_heater.TurnOnCalledTimes, Is.EqualTo(1));
        }



    }
}
