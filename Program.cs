//*****************************************************************
//**                                                             **
//**        STUDENT NAME:  SALTUK BUÐRA DANÝÞMENT                         **
//**        STUDENT NUMBER:  B241202023                         **
//**                                                             **
//*****************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolygonProject
{
    /// Program class - entry point of the application.
    /// Initializes and runs the main form.
    internal static class Program
    {
        /// The main entry point for the application.
        [STAThread]
        static void Main()
        {
            // Enable visual styles
            Application.EnableVisualStyles();

            // Set compatible text rendering default
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize high DPI settings
            ApplicationConfiguration.Initialize();

            // Create and run the main form
            Application.Run(new Form1());
        }
    }
}