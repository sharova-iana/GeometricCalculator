using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricCalculator
{
    /// <summary>
    /// Defines the interface for a 3D geometric body
    /// for the purpose of calculating its volume and surface area.
    /// </summary>
    public interface IGeometricBody
    {
        /// <summary>
        /// Calculates the volume of the geometric body.
        /// </summary>
        /// <returns>The volume of the geometric body.</returns>
        double CalculateVolume();

        /// <summary>
        /// Calculates the surface area of the geometric body.
        /// </summary>
        /// <returns>The surface area of the geometric body.</returns>
        double CalculateSurfaceArea();
    }
}
