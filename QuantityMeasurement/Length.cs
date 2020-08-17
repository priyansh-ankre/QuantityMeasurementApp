using System;
namespace QuantityMeasurement
{
    public class Length
    {

        public readonly Unit unit;
        public readonly double value;

        public Length(Unit unit, double value)
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
            Length that = (Length)obj;
            return Double.Equals(that.unit.GetConvertedValue(that.value), this.unit.GetConvertedValue(this.value));
        }
    }
}
