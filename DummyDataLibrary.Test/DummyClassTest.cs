using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDataLibrary.Test
{
    [TestFixture]
    class DummyClassTest
    {
        [Test]
        public void GetId_Success()
        {
            var sensor = "D[0]";
            var _result = DummyClass.GetId(sensor);
            Assert.That(sensor, Contains.Substring("D[0]"));
            Assert.That(_result, Contains.Substring("D[System]"));
        }
    }
}
