using NUnit.Framework;
using QuantityMeasurement;

namespace QuantityMeasurementTest
{
    public class QuantityMeasurementIntegrationTest
    {
        [Test]
        public void GivenZeroFeetAndZeroFeet_WhenCalculated_ThenShouldReturnEqual()
        {
            Quantity feet1 = new Quantity(Unit.FEET, 0.0);
            Quantity feet2 = new Quantity(Unit.FEET, 0.0);
            Assert.AreEqual(feet1, feet2);
        }

        [Test]
        public void GivenZeroFeetAndNull_WhenCalculated_ThenShouldReturnFalse()
        {
            Quantity feet = new Quantity(Unit.FEET, 0.0);
            var nullCheck = feet.Equals(null);
            Assert.IsFalse(nullCheck);
        }

        [Test]
        public void GivenFeet1AndFeet2_WhenCalculated_ThenShouldReturnEqual()
        {
            Quantity feet1 = new Quantity(Unit.FEET, 0.0);
            Quantity feet2 = feet1;
            Assert.AreEqual(feet1, feet2);
        }

        [Test]
        public void GivenFeet1AndFeet2_WhenCalculatedForSameType_ThenShouldReturnEqual()
        {
            Quantity feet1 = new Quantity(Unit.FEET, 0.0);
            Quantity feet2 = new Quantity(Unit.FEET, 1.0);
            Assert.AreEqual(feet1.GetType(), feet2.GetType());
        }

        [Test]
        public void GivenFeet1AndFeet2_WhenCalculated_ThenShouldNotReturnEqual()
        {
            Quantity feet1 = new Quantity(Unit.FEET, 0.0);
            Quantity feet2 = new Quantity(Unit.FEET, 1.0);
            Assert.AreNotEqual(feet1, feet2);
        }

        [Test]
        public void GivenZeroInchAndZeroInch_WhenCalculated_ThenShouldReturnEqual()
        {
            Quantity inch1 = new Quantity(Unit.INCH, 0.0);
            Quantity inch2 = new Quantity(Unit.INCH, 0.0);
            Assert.AreEqual(inch1, inch2);
        }

        [Test]
        public void GivenZeroInchAndNull_WhenCalculated_ThenShouldReturnFalse()
        {
            Quantity inch = new Quantity(Unit.INCH, 0.0);
            var nullCheck = inch.Equals(null);
            Assert.IsFalse(nullCheck);
        }

        [Test]
        public void GivenInch1AndInch2_WhenCalculatedForReference_ThenShouldReturnEqual()
        {
            Quantity inch1 = new Quantity(Unit.INCH, 0.0);
            Quantity inch2 = inch1;
            Assert.AreEqual(inch1, inch2);
        }

        [Test]
        public void GivenInch1AndInch2_WhenCalculatedForType_ThenShouldReturnEqual()
        {
            Quantity inch1 = new Quantity(Unit.INCH, 0.0);
            Quantity inch2 = new Quantity(Unit.INCH, 1.0);
            Assert.AreEqual(inch1.GetType(), inch2.GetType());
        }

        [Test]
        public void GivenZeroInchAndOneInch_WhenCalculated_ThenShouldNotReturnEqual()
        {
            Quantity inch1 = new Quantity(Unit.INCH, 0.0);
            Quantity inch2 = new Quantity(Unit.INCH, 1.0);
            Assert.AreNotEqual(inch1, inch2);
        }

        [Test]
        public void GivenZeroFeetAndZeroInch_WhenCalculated_ThenShouldReturnTrue()
        {
            Quantity feet = new Quantity(Unit.FEET, 0.0);
            Quantity inch = new Quantity(Unit.INCH, 0.0);
            Assert.IsTrue(feet.Equals(inch));

        }

        [Test]
        public void Given0FeetAnd1Inch_WhenCalculated_ThenShouldReturnFalse()
        {
            Quantity feet = new Quantity(Unit.FEET, 0.0);
            Quantity inch = new Quantity(Unit.INCH, 1.0);
            Assert.IsFalse(feet.Equals(inch));
        }

        [Test]
        public void Given1InchAnd1Feet_WhenCalculated_ThenShouldReturnFalse()
        {
            Quantity feet = new Quantity(Unit.FEET, 1.0);
            Quantity inch = new Quantity(Unit.INCH, 1.0);
            Assert.IsFalse(inch.Equals(feet));
        }

        [Test]
        public void Given1FeetAnd1Inch_WhenCalculated_ThenShouldReturnFalse()
        {
            Quantity feet = new Quantity(Unit.FEET, 1.0);
            Quantity inch = new Quantity(Unit.INCH, 1.0);
            Assert.IsFalse(feet.Equals(inch));
        }

        [Test]
        public void Given1FeetAnd12Inch_WhenCalculated_ThenShouldReturnTrue()
        {
            Quantity feet = new Quantity(Unit.FEET, 1.0);
            Quantity inch = new Quantity(Unit.INCH, 12.0);
            Assert.IsTrue(feet.Equals(inch));
        }

        [Test]
        public void Given12InchAnd1Feet_WhenCalculated_ThenShouldReturnTrue()
        {
            Quantity feet = new Quantity(Unit.FEET, 1.0);
            Quantity inch = new Quantity(Unit.INCH, 12.0);
            Assert.IsTrue(inch.Equals(feet));
        }

        [Test]
        public void Given1FeetAnd1Feet_WhenCalculated_ThenShouldReturnTrue()
        {
            Quantity feet1 = new Quantity(Unit.FEET, 1.0);
            Quantity feet2 = new Quantity(Unit.FEET, 1.0);
            Assert.IsTrue(feet1.Equals(feet2));
        }

        [Test]
        public void Given1InchAnd1Inch_WhenCalculated_ThenShouldReturnTrue()
        {
            Quantity inch1 = new Quantity(Unit.INCH, 1.0);
            Quantity inch2 = new Quantity(Unit.INCH, 1.0);
            Assert.IsTrue(inch1.Equals(inch2));
        }

        [Test]
        public void Given3FeetAnd1Yard_WhenCalculated_ThenShouldReturnTrue()
        {
            Quantity feet = new Quantity(Unit.FEET, 3.0);
            Quantity yard = new Quantity(Unit.YARD, 1.0);
            Assert.IsTrue(feet.Equals(yard));
        }

        [Test]
        public void Given1FeetAnd1Yard_WhenCalculated_ThenShouldReturnFalse()
        {
            Quantity feet = new Quantity(Unit.FEET, 1.0);
            Quantity yard = new Quantity(Unit.YARD, 1.0);
            Assert.IsFalse(feet.Equals(yard));
        }

        [Test]
        public void Given1InchAnd1Yard_WhenCalculated_ThenShouldReturnFalse()
        {
            Quantity inch = new Quantity(Unit.INCH, 1.0);
            Quantity yard = new Quantity(Unit.YARD, 1.0);
            Assert.IsFalse(inch.Equals(yard));
        }

        [Test]
        public void Given1YardAnd36Inch_WhenCalculated_ThenShouldReturnTrue()
        {
            Quantity inch = new Quantity(Unit.INCH, 36.0);
            Quantity yard = new Quantity(Unit.YARD, 1.0);
            Assert.IsTrue(yard.Equals(inch));
        }

        [Test]
        public void Given36InchAnd1Yard_WhenCalculated_ThenShouldReturnTrue()
        {
            Quantity inch = new Quantity(Unit.INCH, 36.0);
            Quantity yard = new Quantity(Unit.YARD, 1.0);
            Assert.IsTrue(inch.Equals(yard));
        }

        [Test]
        public void Given1YardAnd3Feet_WhenCalculated_ThenShouldReturnTrue()
        {
            Quantity feet = new Quantity(Unit.FEET, 3.0);
            Quantity yard = new Quantity(Unit.YARD, 1.0);
            Assert.IsTrue(yard.Equals(feet));
        }

        [Test]
        public void Given2Inchand5CentiMeter_WhenCalculated_ThenShouldReturnTrue()
        {
            Quantity inch = new Quantity(Unit.INCH, 2.0);
            Quantity centiMeter = new Quantity(Unit.CENTIMETER, 5.0);
            Assert.IsTrue(inch.Equals(centiMeter));
        }

        [Test]
        public void Given2InchesAnd2Inches_WhenAdded_ThenShouldRetunsFourInches()
        {
            Quantity inch1 = new Quantity(Unit.INCH, 2.0);
            Quantity inch2 = new Quantity(Unit.INCH, 2.0);
            Quantity expectedInch = new Quantity(Unit.INCH, 4.0);
            Quantity addedInch = inch1.AddValue(inch2);
            Assert.AreEqual(expectedInch, addedInch);
        }

        [Test]
        public void Given1FeetAnd2Inches_WhenAdded_ThenShouldRetuns14Inches()
        {
            Quantity feet = new Quantity(Unit.FEET, 1.0);
            Quantity inch = new Quantity(Unit.INCH, 2.0);
            Quantity expectedInch = new Quantity(Unit.INCH, 14.0);
            Quantity addedInchAndfeet = feet.AddValue(inch);
            Assert.AreEqual(expectedInch, addedInchAndfeet);
        }

        [Test]
        public void Given1FeetAnd1Feet_WhenAdded_ThenShouldRetuns24Inches()
        {
            Quantity feet1 = new Quantity(Unit.FEET, 1.0);
            Quantity feet2 = new Quantity(Unit.FEET, 1.0);
            Quantity expectedInch = new Quantity(Unit.INCH, 24.0);
            Quantity addedFeets = feet1.AddValue(feet2);
            Assert.AreEqual(expectedInch, addedFeets);
        }

        [Test]
        public void GivenInchAndCentimeter_WhenAdded_ThenShouldRetuns3Inch()
        {
            Quantity inch = new Quantity(Unit.INCH, 2.0);
            Quantity centiMeter = new Quantity(Unit.CENTIMETER, 2.5);
            Quantity expectedInch = new Quantity(Unit.INCH, 3.0);
            Quantity addedInchAndCentimeter = inch.AddValue(centiMeter);
            Assert.AreEqual(expectedInch, addedInchAndCentimeter);
        }

        [Test]
        public void GivenOneGallonToLitre_WhenCompared_ThenShouldReturnsEquals()
        {
            Quantity oneGallon = new Quantity(Unit.GALLON, 1.0);
            Quantity litre = new Quantity(Unit.LITRE, 3.78);
            Assert.AreEqual(oneGallon, litre);
        }

        [Test]
        public void Given1LitreAnd1000MilliLitre_WhenCompared_ThenShouldReturnsEqual()
        {
            Quantity litre = new Quantity(Unit.LITRE, 1.0);
            Quantity milliLitre = new Quantity(Unit.MILILITRE,1000.0);
            Assert.AreEqual(litre, milliLitre);
        }

        [Test]
        public void GivenGallonAndLitre_WhenAdded_ShouldReturnsCorrespndingLitres()
        {
            Quantity gallon = new Quantity(Unit.GALLON, 1.0);
            Quantity litres = new Quantity(Unit.LITRE, 3.78);
            Quantity expectedLitres = new Quantity(Unit.LITRE, 7.56);
            Quantity addedQuantity = gallon.AddValue(litres);
            Assert.AreEqual(expectedLitres, addedQuantity);
        }

        [Test]
        public void Given1LitreAnd1000MilliLitres_WhenAdded_ThenShouldReturns2Litres()
        {
            Quantity litres = new Quantity(Unit.LITRE, 1.0);
            Quantity milliLitre = new Quantity(Unit.MILILITRE, 1000.0);
            Quantity expectedLitres = new Quantity(Unit.LITRE, 2.0);
            Quantity addedQuantities = litres.AddValue(milliLitre);
            Assert.AreEqual(expectedLitres, addedQuantities);
        }

        [Test]
        public void Given1KilogramAnd1000Grams_WhenCompared_ThenShouldReturnEqual()
        {
            Quantity oneKilogram = new Quantity(Unit.KILOGRAM, 1.0);
            Quantity thousandGram = new Quantity(Unit.GRAM, 1000.0);
            Assert.AreEqual(oneKilogram, thousandGram);
        }

        [Test]
        public void Given1TonneAnd1000Killogram_WhenCompared_ThenShouldReturnEqual()
        {
            Quantity oneTonne = new Quantity(Unit.TONNE, 1.0);
            Quantity thousandKillogram = new Quantity(Unit.KILOGRAM, 1000.0);
            Assert.AreEqual(oneTonne, thousandKillogram);
        }

        [Test]
        public void Given1TonneAnd1000Gram_WhenAdded_ThenShouldReturn1001Killogram()
        {
            Quantity oneTonne = new Quantity(Unit.TONNE, 1.0);
            Quantity thousandGram = new Quantity(Unit.GRAM, 1000.0);
            Quantity expectedKillogram = new Quantity(Unit.KILOGRAM, 1001.0);
            Quantity addedQuantities = oneTonne.AddValue(thousandGram);
            Assert.AreEqual(expectedKillogram, addedQuantities);
        }

        [Test]
        public void Given212Fahrenheitand100Celsius_WhenCompared_ThenShouldReturnEqual()
        {
            Quantity fahrenheit = new Quantity(Unit.FAHRENHIET, 212.0);
            Quantity celsius = new Quantity(Unit.CELCIUS, 100.0);
            Assert.AreEqual(fahrenheit, celsius);
        }
    }
}