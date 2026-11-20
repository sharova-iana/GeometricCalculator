using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculator
{

    /// <summary>
    /// Represents a sphere defined by its radius.
    /// Implements the <see cref="IGeometricBody"/> interface and defines methods for calculating volume and surface area.
    /// </summary>
    public class Sphere : IGeometricBody
    {
        /// <summary>Gets the radius of the sphere.</summary>
        public double Radius { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sphere"/> class with the specified radius.
        /// </summary>
        /// <param name="radius">The radius of the sphere. Must be a non-negative value.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the radius is negative.</exception>
        public Sphere(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius), "Radius cannot be negative.");
            }

            this.Radius = radius;
        }

        /// <summary>
        /// Calculates the volume of the sphere.
        /// </summary>
        /// <returns>The volume of the sphere.</returns>
        public double CalculateVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }

        /// <summary>
        /// Calculates the surface area of the sphere.
        /// </summary>
        /// <returns>The surface area of the sphere.</returns>
        public double CalculateSurfaceArea()
        {
            return 4 * Math.PI * Math.Pow(Radius, 2);
        }

        /// <summary>
        /// Returns a string that represents the sphere.
        /// </summary>
        /// <returns>A string that represents the sphere.</returns>
        public override string ToString()
        {
            return $"Sphere (Radius: {Radius})";
        }
    }
}
