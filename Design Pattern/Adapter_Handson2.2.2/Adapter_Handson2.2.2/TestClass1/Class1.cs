using Adapter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClass1
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void whenConvertingMPHToKMPH_thenSuccessfullyConverted()
        {
            Movable bugattiVeyron = new BugattiVeyron();
            MovableAdapter bugattiVeyronAdapter = new MovableAdapterImpl(bugattiVeyron);
            Assert.AreEqual(bugattiVeyronAdapter.GetSpeed(), 431.30312, 0.00001);
        }
        [Test]
        public void whenConvertingUSDToEuro()
        {
            Movable bugattiVeyron = new BugattiVeyron();
            MovableAdapter bugattiVeyronAdapter = new MovableAdapterImpl(bugattiVeyron);
            Assert.AreEqual(bugattiVeyronAdapter.GetPrice(), 119, 0.00001);
        }

    }
}
