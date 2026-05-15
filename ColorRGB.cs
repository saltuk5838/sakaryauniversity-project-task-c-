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

    /// ColorRGB class - Represents RGB color values.
    /// Stores red, green, and blue color components.

    public class ColorRGB
    {
        // Data members for color values
        private int _red;
        private int _green;
        private int _blue;

        // Random object - for random color generation
        private static Random rnd = new Random();

        /// Red property - read/write red color value
        public int Red
        {
            get { return _red; }
            set { _red = value; }
        }

        /// Green property - read/write green color value
        public int Green
        {
            get { return _green; }
            set { _green = value; }
        }

        /// Blue property - read/write blue color value
        public int Blue
        {
            get { return _blue; }
            set { _blue = value; }
        }


        /// Default constructor - parameterless constructor
        /// Sets all color values randomly between 0-255.

        public ColorRGB()
        {
            _red = rnd.Next(0, 256);   // Random red value
            _green = rnd.Next(0, 256); // Random green value
            _blue = rnd.Next(0, 256);  // Random blue value
        }

        public ColorRGB(int red, int green, int blue)
        {
            _red = red;     // Set red value
            _green = green; // Set green value
            _blue = blue;   // Set blue value
        }

        /// Used in drawing operations
        public System.Drawing.Color ToDrawingColor()
        {
            // Create System.Drawing.Color object from RGB values
            return System.Drawing.Color.FromArgb(_red, _green, _blue);
        }
    }
}
