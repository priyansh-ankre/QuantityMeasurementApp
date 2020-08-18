// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Unit.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Priyansh"/>
// --------------------------------------------------------------------------------------------------------------------
namespace QuantityMeasurement
{
    /// <summary>
    /// This class contains different quantities
    /// </summary>
    public class Unit
    {
        /// <summary>
        /// This enum is used for feet with baseUnitConversion value as 12.0
        /// </summary>
        public static readonly Unit FEET = new Unit(12.0);

        /// <summary>
        /// This enum is used for inch with baseUnitConversion value as 1.0
        /// </summary>
        public static readonly Unit INCH = new Unit(1.0);

        /// <summary>
        /// This enum is used for yard with baseUnitConversion value as 36.0
        /// </summary>
        public static readonly Unit YARD = new Unit(36.0);

        /// <summary>
        /// This enum is used for centimeter with baseUnitConversion value as 0.4
        /// </summary>
        public static readonly Unit CENTIMETER = new Unit(0.4);

        /// <summary>
        /// This enum is used for liter with baseUnitConversion value as 1.0
        /// </summary>
        public static readonly Unit LITRE = new Unit(1.0);

        /// <summary>
        /// This enum is used for gallon with baseUnitConversion value as 3.78
        /// </summary>
        public static readonly Unit GALLON = new Unit(3.78);

        /// <summary>
        /// This enum is used for milliliter with baseUnitConversion value as 0.001
        /// </summary>
        public static readonly Unit MILILITRE = new Unit(0.001);

        /// <summary>
        /// This enum is used for kiloGram with baseUnitConversion value as 1.0
        /// </summary>
        public static readonly Unit KILOGRAM = new Unit(1.0);

        /// <summary>
        /// This enum is used for gram with baseUnitConversion value as 0.001
        /// </summary>
        public static readonly Unit GRAM = new Unit(0.001);

        /// <summary>
        /// This enum is used for tone with baseUnitConversion value as 1000
        /// </summary>
        public static readonly Unit TONNE = new Unit(1000);

        /// <summary>
        /// This enum is used for fahrenheit with baseUnitConversion value as 1.0
        /// </summary>
        public static readonly Unit FAHRENHIET = new Unit(1.0);

        /// <summary>
        /// This enum is used for celsius with baseUnitConversion value as 2.12
        /// </summary>
        public static readonly Unit CELCIUS = new Unit(2.12);

        /// <summary>
        /// This value is used when the enum is called 
        /// </summary>
        private readonly double baseUnitConvertor;

        /// <summary>
        /// Initializes a new instance of the <see cref="Unit"/> class.
        /// </summary>
        /// <param name="baseUnitConvertor">It contains the value for converting the enum of same type</param>
        private Unit(double baseUnitConvertor)
        {
            this.baseUnitConvertor = baseUnitConvertor;
        }

        /// <summary>
        /// This method convert the value from one quantity to another quantity of same type
        /// </summary>
        /// <param name="value">It contains the value when the method is passed</param>
        /// <returns>It returns the converted value from one quantity to another quantity of same type</returns>
        public double GetConvertedValue(double value)
        {
            return this.baseUnitConvertor * value;
        }
    }
}
