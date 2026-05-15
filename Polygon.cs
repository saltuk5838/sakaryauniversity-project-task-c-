//*****************************************************************
//**                                                             **
//**        STUDENT NAME:  SALTUK BUĞRA DANİŞMENT                         **
//**        STUDENT NUMBER:  B241202023                         **
//**                                                             **
//*****************************************************************


using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Drawing;

namespace PolygonProject
{
    /// Polygon class - represents a regular polygon.
    /// Derived from ShapeBase abstract class and implements IShape interface.
    public class Polygon : ShapeBase, IShape
    {
        // Edge count data member 
        private int _numberOfEdges;

        // Rotation angle (in degrees)
        private double _rotationAngle;

        // List of vertex points 
        private List<Point2D> _vertices;

        // Random object - for random value generation
        private static Random rnd = new Random();

        // Edge count read/write property
        public int NumberOfEdges
        {
            get { return _numberOfEdges; }
            set { _numberOfEdges = value; }
        }

        /// Rotation angle read/write property
        public double RotationAngle
        {
            get { return _rotationAngle; }
            set { _rotationAngle = value; }
        }

        /// List of vertex points read/write property
        public List<Point2D> Vertices
        {
            get { return _vertices; }
            set { _vertices = value; }
        }

        /// Basic constructor - sets all values to defaults
        public Polygon() : base()
        {
            _numberOfEdges = 5;        // Default edge count
            _rotationAngle = 0;        // Default rotation angle
            _vertices = new List<Point2D>(); // Empty vertex list
        }

        /// Second constructor - creates by getting center point and edge length
        public Polygon(Point2D center, double length) : base()
        {
            _center = center;           // Set center point
            _length = length;           // Set edge length
            _numberOfEdges = 5;         // Default edge count
            _rotationAngle = 0;         // Default rotation angle
            _color = new ColorRGB();    // Default color
            _vertices = new List<Point2D>(); // Empty vertex list
        }

        /// calculateEdgeCoordinates() - Method to calculate the vertex coordinates of the polygon.
        /// The first vertex point starts as a random integer point dependent on center and length values. 
        /// Remaining vertex coordinates are calculated from this starting point.
        public void calculateEdgeCoordinates()
        {
            // Clear the vertex list
            _vertices.Clear();

            // Calculate the first point as a random integer point (dependent on center and length)
            Random rnd = new Random();
            int randomX = (int)Math.Round(_center.X) + rnd.Next(-(int)_length, (int)_length + 1);
            int randomY = (int)Math.Round(_center.Y) + rnd.Next(-(int)_length, (int)_length + 1);

            // Find the radian angle of the first point relative to the center
            double dx = randomX - _center.X;
            double dy = randomY - _center.Y;
            double startAngleRad = Math.Atan2(dy, dx);

            // Add the rotation angle to the starting angle (in degrees)
            double startAngle = startAngleRad * (180.0 / Math.PI) + _rotationAngle;

            // Calculate angle between each vertex (in degrees)
            double angleBetweenVertices = 360.0 / _numberOfEdges;

            // Calculate coordinates for each vertex point
            for (int i = 0; i < _numberOfEdges; i++)
            {
                // Calculate the angle of the current vertex (in degrees)
                double currentAngle = startAngle + i * angleBetweenVertices;

                // Convert degree to radians
                double angleRad = currentAngle * (Math.PI / 180.0);

                // Calculate vertex coordinates
                // x = center_x + length * cos
                double vertexX = _center.X + _length * Math.Cos(angleRad);

                // y = center_y + length * sin
                double vertexY = _center.Y + _length * Math.Sin(angleRad);

                // Create new Point2D object and add to list
                Point2D vertex = new Point2D(vertexX, vertexY);
                _vertices.Add(vertex);
            }
        }

        /// rotatePolygon() - Rotation method that recalculates vertex points of the polygon.
        /// <param name="counterClockwise">true if CCW (counter-clockwise), false if CW (clockwise)</param>
        public void rotatePolygon(bool counterClockwise)
        {
            // Since the RotationAngle is already set via Form1, it is enough to just recalculate edge coordinates here.
            calculateEdgeCoordinates();
        }

        /// getShapeInfo() - Method returning the polygon's details.
        /// Mandatory implementation for ShapeBase abstract class.
        public override string getShapeInfo()
        {
            // Return formatted string with polygon information
            string info = $"Polygon Info:\n";
            info += $"Center: {_center.printCoordinates()}\n";
            info += $"Length: {_length:F2}\n";
            info += $"Color: R={_color.Red}, G={_color.Green}, B={_color.Blue}\n";
            info += $"Number of Edges: {_numberOfEdges}\n";
            info += $"Rotation Angle: {_rotationAngle:F2}°\n";
            info += $"Vertices:\n";

            // Print all vertex points
            for (int i = 0; i < _vertices.Count; i++)
            {
                info += $"  Vertex {i + 1}: {_vertices[i].printCoordinates()}\n";
            }

            return info;
        }
    }
}
