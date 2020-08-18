// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QuantityMeasurementException.cs" company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Priyansh"/>
// --------------------------------------------------------------------------------------------------------------------
namespace QuantityMeasurement
{
    using System;

    /// <summary>
    /// This Class used to Define Custom Exceptions.
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class QuantityMeasurementException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QuantityMeasurementException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="type">The type.</param>
        public QuantityMeasurementException(string message, ExceptionType type) : base(message)
        {
            this.Type = type;
        }

        /// <summary>
        /// Enum is Used to define Enumerated Data types
        /// </summary>
        public enum ExceptionType
        {
            /// <summary>
            /// The invalid exception
            /// </summary>
            INVALID_EXCEPTION
        }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public ExceptionType Type { get; set; }
    }
}
