//*****************************************************************
//**                                                             **
//**        STUDENT NAME:  SALTUK BUĞRA DANİŞMENT                         **
//**        STUDENT NUMBER:  B241202023                         **
//**                                                             **
//*****************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonProject
{

    /// Point2D class - Represents a 2D point.
    /// Calculates Cartesian (x,y) and polar (r,θ) coordinates.

    public class Point2D
    {
        // Data members for Cartesian coordinates
        private double _x;
        private double _y;

        // Data members for polar coordinates
        private double _r;
        private double _theta;

        // Random object - for random value generation
        private static Random rnd = new Random();


        /// X property - read/write x coordinate
        public double X
        {
            get { return _x; }
            set { _x = value; }
        }


        /// Y property - read/write y coordinate
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        /// R property - read/write polar radius
        public double R
        {
            get { return _r; }
            set { _r = value; }
        }

        /// Theta property - read/write polar angle
        public double Theta
        {
            get { return _theta; }
            set { _theta = value; }
        }

        /// Default constructor - parameterless constructor
        /// Assigns random values to x and y
        public Point2D()
        {
            _x = rnd.Next(0, 10); // Random x value
            _y = rnd.Next(0, 10); // Random y value

            // Calculate polar coordinates
            calculatePolarCoordinates();
        }

        /// Constructor generating random values
        /// Creates random 2D coordinates for x and y
        /// <param name="minX">Minimum value for x</param>
        /// <param name="maxX">Maximum value for x</param>
        /// <param name="minY">Minimum value for y</param>
        /// <param name="maxY">Maximum value for y</param>
        public Point2D(int minX, int maxX, int minY, int maxY)
        {
            // Generating random x and y values
            _x = rnd.Next(minX, maxX + 1);
            _y = rnd.Next(minY, maxY + 1);

            // Automatically calculate polar coordinates
            calculatePolarCoordinates();
        }

        /// Constructor initializing with specific x and y values
        /// <param name="x">x coordinate</param>
        /// <param name="y">y coordinate</param>
        public Point2D(double x, double y)
        {
            _x = x; // Set x value
            _y = y; // Set y value

            // Automatically calculate polar coordinates
            calculatePolarCoordinates();
        }

        /// calculatePolarCoordinates() - Calculates polar coordinates based on Cartesian coordinates.
        public void calculatePolarCoordinates()
        {
            // Calculate radius r = √(x² + y²)
            _r = Math.Sqrt((_x * _x) + (_y * _y));

            // Calculate angle theta = arctan(y/x) (in radians)
            _theta = Math.Atan2(_y, _x);
        }

        /// printCoordinates() - Returns Cartesian and polar coordinates as a formatted string.
        public string printCoordinates()
        {
            // Convert angle from radians to degrees for readability
            double thetaDegrees = _theta * (180.0 / Math.PI);

            return $"({_x:F2}, {_y:F2}) - Polar: [r={_r:F2}, θ={thetaDegrees:F2}°]";
        }
    }
}
