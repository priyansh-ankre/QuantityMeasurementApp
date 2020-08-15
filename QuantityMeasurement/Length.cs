using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Length
    {
        public enum Unit
        {
            FEET,
            INCH
        }

        public readonly Unit unit;
        public readonly double value;

        public readonly double FEET_INCH_CONVERTER = 12.0;

        public Length(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Length length && unit == length.unit && value == length.value;
        }

        public bool Compare(Length that)
        {
            if (this.unit.Equals(that.unit))
            {
                return this.Equals(that);
            }
            if (this.unit.Equals(Unit.FEET) && that.unit.Equals(Unit.INCH))
            {
                return that.value.CompareTo(this.value * FEET_INCH_CONVERTER) == 0;
            }
            if (this.unit.Equals(Unit.INCH) && that.unit.Equals(Unit.FEET))
            {
                return that.value.CompareTo(this.value / FEET_INCH_CONVERTER) == 0;
            }
            return false;
        }
    }
}
