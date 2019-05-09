using System;
using System.Collections;

namespace FitnessTrackerApp.Helpers
{
    public static class ParameterValidator
    {
        public static void ValidateObjectIsNotNull(object parameter, string parameterName)
        {
            if (parameter == null)
            {
                throw new ArgumentNullException(parameterName, $"{parameter.GetType()} cannot be null.");
            }
        }

        public static void ValidateStringIsNotNullOrEmpty(string parameter, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(parameter))
            {
                throw new ArgumentException(parameterName, "String cannot be null or empty.");
            }
        }

        public static void ValidateIntInRange(int parameter, string parameterName, int lowerLimit = int.MinValue, int upperLimit = int.MaxValue)
        {
            if (parameter < lowerLimit)
            {
                throw new ArgumentException(parameterName, $"Int cannot be less than {lowerLimit}");
            }

            if (parameter > upperLimit)
            {
                throw new ArgumentException(parameterName, $"Int cannot be greater than {upperLimit}");
            }
        }

        public static void ValidateCollectionIsNotNullOrEmpty(ICollection parameter, string parameterName)
        {
            if (parameter == null || parameter.Count == 0)
            {
                throw new ArgumentNullException(parameterName, $"Collection cannot be null or empty.");
            }
        }
    }
}
