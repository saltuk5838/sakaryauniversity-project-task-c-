

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonProject
{
    /// ShapeBase - abstract base class.
    /// All shape classes inherit from this class.
    /// Common properties like center, length, and color are defined here.
    public abstract class ShapeBase
    {
        // Center point of the shape (of type Point2D)
        protected Point2D _center;

        // Edge length of the shape
        protected double _length;

        // Color of the shape (of type ColorRGB)
        protected ColorRGB _color;

        /// Center property - read/write the shape's center
        public Point2D Center
        {
            get { return _center; }
            set { _center = value; }
        }

        /// Length property - read/write edge length
        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        /// Color property - read/write the shape's color
        public ColorRGB Color
        {
            get { return _color; }
            set { _color = value; }
        }

        /// Default constructor (parameterless)
        public ShapeBase()
        {
            _center = new Point2D(); // Default center point
            _length = 0;            // Default length
            _color = new ColorRGB(); // Default color
        }

        /// Abstract method - prints shape information.
        /// Derived classes must implement this method.
        public abstract string getShapeInfo();
    }
}
