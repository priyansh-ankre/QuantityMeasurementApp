using NUnit.Framework;
using QuantityMeasurement;

namespace QuantityMeasurementTest
{
    public class QuantityMeasurementIntegrationTest
    {
        [Test]
        public void GivenZeroFeetAndZeroFeet_WhenCalculated_ThenShouldReturnEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 0.0);
            Length feet2 = new Length(Length.Unit.FEET, 0.0);
            Assert.AreEqual(feet1, feet2);
        }

        [Test]
        public void GivenZeroFeetAndNull_WhenCalculated_ThenShouldReturnFalse()
        {
            Length feet = new Length(Length.Unit.FEET, 0.0);
            var nullCheck = feet.Equals(null);
            Assert.IsFalse(nullCheck);
        }

        [Test]
        public void GivenFeet1AndFeet2_WhenCalculated_ThenShouldReturnEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 0.0);
            Length feet2 = feet1;
            Assert.AreEqual(feet1, feet2);
        }

        [Test]
        public void GivenFeet1AndFeet2_WhenCalculatedForSameType_ThenShouldReturnEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 0.0);
            Length feet2 = new Length(Length.Unit.FEET, 1.0);
            Assert.AreEqual(feet1.GetType(), feet2.GetType());
        }

        [Test]
        public void GivenFeet1AndFeet2_WhenCalculated_ThenShouldNotReturnEqual()
        {
            Length feet1 = new Length(Length.Unit.FEET, 0.0);
            Length feet2 = new Length(Length.Unit.FEET, 1.0);
            Assert.AreNotEqual(feet1, feet2);
        }

        [Test]
        public void GivenZeroInchAndZeroInch_WhenCalculated_ThenShouldReturnEqual()
        {
            Length inch1 = new Length(Length.Unit.INCH, 0.0);
            Length inch2 = new Length(Length.Unit.INCH, 0.0);
            Assert.AreEqual(inch1, inch2);
        }

        [Test]
        public void GivenZeroInchAndNull_WhenCalculated_ThenShouldReturnFalse()
        {
            Length inch = new Length(Length.Unit.INCH, 0.0);
            var nullCheck = inch.Equals(null);
            Assert.IsFalse(nullCheck);
        }

        [Test]
        public void GivenInch1AndInch2_WhenCalculatedForReference_ThenShouldReturnEqual()
        {
            Length inch1 = new Length(Length.Unit.INCH, 0.0);
            Length inch2 = inch1;
            Assert.AreEqual(inch1, inch2);
        }

        [Test]
        public void GivenInch1AndInch2_WhenCalculatedForType_ThenShouldReturnEqual()
        {
            Length inch1 = new Length(Length.Unit.INCH, 0.0);
            Length inch2 = new Length(Length.Unit.INCH, 1.0);
            Assert.AreEqual(inch1.GetType(), inch2.GetType());
        }

        [Test]
        public void GivenZeroInchAndOneInch_WhenCalculated_ThenShouldNotReturnEqual()
        {
            Length inch1 = new Length(Length.Unit.INCH, 0.0);
            Length inch2 = new Length(Length.Unit.INCH, 1.0);
            Assert.AreNotEqual(inch1, inch2);
        }

        [Test]
        public void GivenZeroFeetAndZeroInch_WhenCalculated_ThenShouldReturnTrue()
        {
            Length feet = new Length(Length.Unit.FEET, 0.0);
            Length inch = new Length(Length.Unit.INCH, 0.0);
            Assert.IsTrue(feet.Compare(inch));

        }

        [Test]
        public void Given0FeetAnd1Inch_WhenCalculated_ThenShouldReturnFalse()
        {
            Length feet = new Length(Length.Unit.FEET, 0.0);
            Length inch = new Length(Length.Unit.INCH, 1.0);
            Assert.IsFalse(feet.Compare(inch));
        }

        [Test]
        public void Given1InchAnd1Feet_WhenCalculated_ThenShouldReturnFalse()
        {
            Length feet = new Length(Length.Unit.FEET, 1.0);
            Length inch = new Length(Length.Unit.INCH, 1.0);
            Assert.IsFalse(inch.Compare(feet));
        }

        [Test]
        public void Given1FeetAnd1Inch_WhenCalculated_ThenShouldReturnFalse()
        {
            Length feet = new Length(Length.Unit.FEET, 1.0);
            Length inch = new Length(Length.Unit.INCH, 1.0);
            Assert.IsFalse(feet.Compare(inch));
        }

        [Test]
        public void Given1FeetAnd12Inch_WhenCalculated_ThenShouldReturnTrue()
        {
            Length feet = new Length(Length.Unit.FEET, 1.0);
            Length inch = new Length(Length.Unit.INCH, 12.0);
            Assert.IsTrue(feet.Compare(inch));
        }

        [Test]
        public void Given12InchAnd1Feet_WhenCalculated_ThenShouldReturnTrue()
        {
            Length feet = new Length(Length.Unit.FEET, 1.0);
            Length inch = new Length(Length.Unit.INCH, 12.0);
            Assert.IsTrue(inch.Compare(feet));
        }

        [Test]
        public void Given1FeetAnd1Feet_WhenCalculated_ThenShouldReturnTrue()
        {
            Length feet1 = new Length(Length.Unit.FEET, 1.0);
            Length feet2 = new Length(Length.Unit.FEET, 1.0);
            Assert.IsTrue(feet1.Compare(feet2));
        }

        [Test]
        public void Given1InchAnd1Inch_WhenCalculated_ThenShouldReturnTrue()
        {
            Length inch1 = new Length(Length.Unit.INCH, 1.0);
            Length inch2 = new Length(Length.Unit.INCH, 1.0);
            Assert.IsTrue(inch1.Compare(inch2));
        }

        [Test]
        public void Given3FeetAnd1Yard_WhenCalculated_ThenShouldReturnTrue()
        {
            Length feet = new Length(Length.Unit.FEET, 3.0);
            Length yard = new Length(Length.Unit.YARD, 1);
            Assert.IsTrue(feet.Compare(yard));
        }

        [Test]
        public void Given1FeetAnd1Yard_WhenCalculated_ThenShouldReturnFalse()
        {
            Length feet = new Length(Length.Unit.FEET, 1.0);
            Length yard = new Length(Length.Unit.YARD, 1);
            Assert.IsFalse(feet.Compare(yard));
        }
    }
}