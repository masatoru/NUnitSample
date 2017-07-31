using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitSample.Shared.Models;

namespace NUnitSample.Test
{
    [TestFixture]
    public class SampleModelTest
    {
        [Test]
        public void CalcTest()
        {
            Assert.AreEqual(3, SampleModel.Calc(1,2));
        }
    }
}
