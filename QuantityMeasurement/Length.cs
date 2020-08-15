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
            return true;
        }
    }
}
