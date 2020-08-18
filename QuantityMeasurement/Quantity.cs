// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Quantity.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Priyansh"/>
// --------------------------------------------------------------------------------------------------------------------
namespace QuantityMeasurement
{
    /// <summary>
    /// This Class is Used To Compare and Add Quantity
    /// </summary>
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class Quantity
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        /// <summary>
        /// The unit
        /// </summary>
        private readonly Unit unit;

        /// <summary>
        /// The value
        /// </summary>
        private readonly double value;

        /// <summary>
        /// Initializes a new instance of the <see cref="Quantity"/> class.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <param name="value">The value.</param>
        public Quantity(Unit unit, double value)
        {
            this.unit = unit;
            this.value = value;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (obj == this)
            {
                return true;
            }

            Quantity that = (Quantity)obj;
            return double.Equals(that.unit.GetConvertedValue(that.value), this.unit.GetConvertedValue(this.value));
        }

        /// <summary>
        /// Adds the value.
        /// </summary>
        /// <param name="that">The that.</param>
        /// <returns>Returns the added value of quantity</returns>
        /// <exception cref="QuantityMeasurementException">Addition of temperature is not valid</exception>
        public Quantity AddValue(Quantity that)
        {
            if (this.unit == Unit.CELCIUS || this.unit == Unit.FAHRENHIET || that.unit == Unit.CELCIUS || that.unit == Unit.FAHRENHIET)
            {
                throw new QuantityMeasurementException("Addition of temprature is not valid", QuantityMeasurementException.ExceptionType.INVALID_EXCEPTION);
            }

            return new Quantity(Unit.INCH, this.unit.GetConvertedValue(this.value) + that.unit.GetConvertedValue(that.value));
        }
    }
}
