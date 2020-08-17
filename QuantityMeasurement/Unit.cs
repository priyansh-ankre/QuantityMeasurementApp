namespace QuantityMeasurement
{
    public class Unit
    {
        public readonly static Unit FEET = new Unit(12.0);
        public readonly static Unit INCH = new Unit(1.0);
        public readonly static Unit YARD = new Unit(36.0);
        public readonly static Unit CENTIMETER = new Unit(0.4);
        public readonly static Unit LITRE = new Unit(1.0);
        public readonly static Unit GALLON = new Unit(3.78);
        public readonly static Unit MILILITRE = new Unit(0.001);
        public readonly static Unit KILOGRAM = new Unit(1.0);
        public readonly static Unit GRAM = new Unit(0.001);
        public readonly static Unit TONNE = new Unit(1000);
        public readonly static Unit FAHRENHIET = new Unit(1.0);
        public readonly static Unit CELCIUS = new Unit(2.12);

        private double baseUnitConvertor;

        private Unit(double baseUnitConvertor)
        {
            this.baseUnitConvertor = baseUnitConvertor;
        }
            

        public double GetConvertedValue(double value)
        {
            return this.baseUnitConvertor * value;
        }
    }
}
