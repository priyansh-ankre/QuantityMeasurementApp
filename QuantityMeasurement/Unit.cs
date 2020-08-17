namespace QuantityMeasurement
{
    public class Unit
    {
        public readonly static Unit FEET = new Unit(12.0);
        public readonly static Unit INCH = new Unit(1.0);
        public readonly static Unit YARD = new Unit(36.0);
        public readonly static Unit CENTIMETER = new Unit(0.4);


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
