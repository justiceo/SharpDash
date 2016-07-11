using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SharpDash;

namespace SharpDashTest
{
    [TestFixture]
    public class ExtensionMethodsTest
    {
        [Test]
        public void Replace()
        {
            var data = "Some data";
            var actual = data.Replace("some", "all", StringComparison.OrdinalIgnoreCase);
            var expected = "all data";
            Assert.AreEqual(expected, actual);
        }
    }
}
