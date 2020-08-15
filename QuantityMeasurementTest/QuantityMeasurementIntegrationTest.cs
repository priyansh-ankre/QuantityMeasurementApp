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

        [Test]
        public void GivenFeet1AndFeet2_WhenCalculated_ThenShouldReturnEqual()
        {
            Feet feet1 = new Feet(0.0);
            Feet feet2 = feet1;
            Assert.AreEqual(feet1, feet2);
        }

        [Test]
        public void GivenFeet1AndFeet2_WhenCalculatedForSameType_ThenShouldReturnEqual()
        {
            Feet feet1 = new Feet(0.0);
            Feet feet2 = new Feet(1.0);
            Assert.AreEqual(feet1.GetType(), feet2.GetType());
        }

        [Test]
        public void GivenFeet1AndFeet2_WhenCalculated_ThenShouldNotReturnEqual()
        {
            Feet feet1 = new Feet(0.0);
            Feet feet2 = new Feet(1.0);
            Assert.AreNotEqual(feet1, feet2);
        }

        [Test]
        public void GivenZeroInchAndZeroInch_WhenCalculated_ThenShouldReturnEqual()
        {
            Inch inch1 = new Inch(0.0);
            Inch inch2 = new Inch(0.0);
            Assert.AreEqual(inch1, inch2);
        }
    }
}