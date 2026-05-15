
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonProject
{
    /// IShape interface - to be implemented by all shape classes.
    /// Defines functionalities to calculate edge coordinates and rotation.
    public interface IShape
    {

        /// Calculates the edge coordinates of the shape
        void calculateEdgeCoordinates();

        /// Rotates the shape depending on the specified direction
        /// <param name="counterClockwise">True for counter-clockwise, false for clockwise.</param>
        void rotatePolygon(bool counterClockwise);
    }
}
