using System;
namespace QuantityMeasurement
{
    public class Quantity
    {

        public readonly Unit unit;
        public readonly double value;

        public Quantity(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj == this)
                return true;
            Quantity that = (Quantity)obj;
            return Double.Equals(that.unit.GetConvertedValue(that.value), this.unit.GetConvertedValue(this.value));
        }

        public Quantity AddValue(Quantity that)
        {
            if(this.unit==Unit.CELCIUS||this.unit==Unit.FAHRENHIET|| that.unit == Unit.CELCIUS || that.unit == Unit.FAHRENHIET)
                throw new QuantityMeasurementException("Addition of temprature is not valid", QuantityMeasurementException.ExceptionType.INVALID_EXCEPTION);
            return new Quantity(Unit.INCH,this.unit.GetConvertedValue(this.value) + that.unit.GetConvertedValue(that.value));
        }
    }
}
