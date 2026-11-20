using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculator
{

    /// <summary>
    /// Represents a square pyramid defined by its base side length and height
    /// Implements the <see cref="IGeometricBody"/> interface and defines methods for calculating volume and surface area.
    /// </summary>
    public class SquarePyramid : IGeometricBody
    {
        /// <summary>Gets the base edge length of the square pyramid.</summary>
        public double BaseEdgeLength { get; }

        /// <summary>Gets the height of the square pyramid.</summary>
        public double Height { get; }

        /// <summary>Initializes a new instance of the <see cref="SquarePyramid"/> class with the specified base side length and height.</summary>
        /// <param name="baseSideLength">The length of the base edge of the square pyramid. Must be a non-negative value.</param>
        /// <param name="height">The height of the square pyramid. Must be a non-negative value.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the base side length or height is negative.</exception>
        public SquarePyramid(double baseSideLength, double height)
        {
            if (baseSideLength < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(baseSideLength), "Base side length cannot be negative.");
            }
            if (height < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(height), "Height cannot be negative.");
            }
            this.BaseEdgeLength = baseSideLength;
            this.Height = height;
        }
        /// <summary>Calculates the volume of the square pyramid.</summary>
        /// <returns>The volume of the square pyramid.</returns>
        public double CalculateVolume()
        {
            return (1.0 / 3.0) * Math.Pow(BaseEdgeLength, 2) * Height;
        }
        /// <summary>Calculates the surface area of the square pyramid.</summary>
        /// <returns>The surface area of the square pyramid.</returns>
        public double CalculateSurfaceArea()
        {
            double apothem = Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(BaseEdgeLength / 2, 2));
            return Math.Pow(BaseEdgeLength, 2) + 2 * BaseEdgeLength * apothem;
        }

        /// <summary>Returns a string that represents the square pyramid.</summary> 
        /// <returns>A string that represents the square pyramid.</returns>
        public override string ToString()
        {
            return $"Square Pyramid (Base Edge Length: {BaseEdgeLength}, Height: {Height})";
        }
    }
}
