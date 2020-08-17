using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class QuantityMeasurementException : Exception
    {
        public enum ExceptionType
        {
            INVALID_EXCEPTION
        }
        public readonly ExceptionType type;
         public QuantityMeasurementException(string message,ExceptionType type) : base(message)
        {
            this.type = type;
        }
    }
}
