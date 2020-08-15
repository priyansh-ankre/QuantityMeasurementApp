using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Feet
    {
        private double feet;

        public Feet(double feet)
        {
            this.feet = feet;
        }

        public override bool Equals(object obj)
        {
            return obj is Feet feet &&
                   this.feet == feet.feet;
        }
    }
}
