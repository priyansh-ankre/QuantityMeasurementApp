using NUnit.Framework;
using QuantityMeasurement;

namespace QuantityMeasurementTest
{
    public class QuantityMeasurementIntegrationTest
    {
        [Test]
        public void GivenZeroFeetAndZeroFeet_WhenCalculated_ThenShouldReturnEqual()
        {
            Feet feet1 = new Feet(0.0);
            Feet feet2 = new Feet(0.0);
            Assert.AreEqual(feet1, feet2);
        }

        [Test]
        public void GivenZeroFeetAndNull_WhenCalculated_ThenShouldReturnTrue()
        {
            Feet feet = new Feet(0.0);
            var nullCheck = feet.Equals(null);
            Assert.IsTrue(nullCheck);
        }
    }
}