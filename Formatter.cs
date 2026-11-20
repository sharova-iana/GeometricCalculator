using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculator
{
    /// <summary>
    /// This static class is intended to provide formatting utilities for the GeometricCalculator application.
    /// </summary>
    public static class Formatter
    {
        /// <summary>
        /// Computes and formats the surface area and volume of a given geometric body.
        /// </summary>
        /// <param name="body">The geometric body for which to format results.</param>
        /// <param name="roundToTwoDecimals">Indicates whether to round values to two decimal places.</param>
        /// <returns>A formatted string containing the geometric body's dimensions and the surface area and volume.</returns>
        public static string FormatResult(IGeometricBody body, bool roundToTwoDecimals)
        {
            double surfaceArea = body.CalculateSurfaceArea();
            double volume = body.CalculateVolume();
            string formatted;

            if (roundToTwoDecimals)
            {
                formatted = $"Surface Area: {surfaceArea:F2}, Volume: {volume:F2}";
            }
            else
            {
                formatted = $"Surface Area: {surfaceArea}, Volume: {volume}";
            }

            return $"{body} -> {formatted}";
        }
    }
}
