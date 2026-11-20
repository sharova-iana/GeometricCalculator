using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculator
{
    /// <summary>
    /// Represents a cylinder defined by its radius and height.
    /// Implements the <see cref="IGeometricBody"/> interface and the methods for calculating volume and surface area.
    /// </summary>
    public class Cylinder : IGeometricBody
    {
        /// <summary>
        /// Gets the radius of the cylinder.
        /// </summary>
        public double Radius { get; }

        /// <summary>
        /// Gets the height of the cylinder.
        /// </summary>
        public double Height { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Cylinder"/> class with the specified radius and height.
        /// </summary>
        /// <param name="radius">The radius of the cylinder. Must be a non-negative value.</param>
        /// <param name="height">The height of the cylinder. Must be a non-negative value.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the radius or height is negative.</exception>
        public Cylinder(double radius, double height)
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
        /// Calculates the volume of the cylinder.
        /// </summary>
        /// <returns>The volume of the cylinder.</returns>
        public double CalculateVolume()
        {
            return Math.PI * Math.Pow(Radius, 2) * Height;
        }

        /// <summary>
        /// Calculates the surface area of the cylinder.
        /// </summary>
        /// <returns>The surface area of the cylinder.</returns>
        public double CalculateSurfaceArea()
        {
            return 2 * Math.PI * Radius * (Radius + Height);
        }

        /// <summary>
        /// Returns a string representation of the cylinder.
        /// </summary>
        /// <returns>A string representing the cylinder.</returns>
        public override string ToString()
        {
            return $"Cylinder (Radius: {Radius}, Height: {Height})";
        }
    }
}
