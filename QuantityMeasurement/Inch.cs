using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Inch
    {
        private double inch;

        public Inch(double value)
        {
            this.inch = value;
        }

        public override bool Equals(object value)
        {
            if (value == null)
            {
                return false;
            }
            return value is Inch inch && this.inch == inch.inch;
        }
    }
}
