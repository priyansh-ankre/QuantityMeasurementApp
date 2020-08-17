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
            return new Quantity(Unit.INCH,this.unit.GetConvertedValue(this.value) + that.unit.GetConvertedValue(that.value));
        }
    }
}
