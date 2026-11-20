using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculator
{
    /// <summary>
    /// Represents a cone defined by its radius and height.
    /// Implements the <see cref="IGeometricBody"/> interface and defines methods for calculating volume and surface area.
    /// </summary>
    public class Cone : IGeometricBody
    {
        
        /// <summary>
        /// Gets the radius of the cone.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Gets the height of the cone.
        /// </summary>
        public double Height { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cone"/> class with the specified radius and height.
        /// </summary>
        /// <param name="radius">The radius of the cone. Must be a non-negative value.</param>
        /// <param name="height">The height of the cone. Must be a non-negative value.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the radius or height is negative.</exception>
        public Cone(double radius, double height)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius), "Radius cannot be negative.");
            }

            if (height < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(height), "Height cannot be negative.");
            }

            this.Radius = radius;
            this.Height = height;
        }

        /// <summary>
        /// Calculates the volume of the cone.
        /// </summary>
        /// <returns>The volume of the cone.</returns>
        public double CalculateVolume()
        {
            return (1.0 / 3.0) * Math.PI * Math.Pow(Radius, 2) * Height;
        }

        /// <summary>
        /// Calculates the surface area of the cone.
        /// </summary>
        /// <returns>The surface area of the cone.</returns>
        public double CalculateSurfaceArea()
        {
            double slantHeight = Math.Sqrt(Math.Pow(Radius, 2) + Math.Pow(Height, 2));
            return Math.PI * Radius * (Radius + slantHeight);
        }

        /// <summary>
        /// Returns a string that represents the cone.
        /// </summary>
        /// <returns>A string that represents the cone.</returns>
        public override string ToString()
        {
            return $"Cone (Radius: {Radius}, Height: {Height})";
        }
    }
}
