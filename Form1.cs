//*****************************************************************
//**                                                             **
//**        STUDENT NAME:  SALTUK BUÐRA DANÝÞMENT                         **
//**        STUDENT NUMBER:  B241202023                         **
//**                                                             **
//*****************************************************************

using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PolygonProject
{
    /// Form1 - Main form class.
    /// Manages all user interactions of the polygon drawing application.
    /// Drawing, rotating, saving and loading processes are done on the PictureBox.
    public partial class Form1 : Form
    {
        // Polygon object - main polygon to be used throughout the form
        private Polygon polygon;

        // Random object - for random value generation
        private Random rnd = new Random();

        // Flag tracking whether the polygon is drawn or not
        private bool isPolygonDrawn = false;

        // Scaling factor - so the polygon is visible inside the PictureBox
        private double scaleFactor = 25.0;

        /// Form1 constructor - initializes the form
        public Form1()
        {
            // Initialize form components (controls created by Designer)
            InitializeComponent();

            // Create the polygon object
            polygon = new Polygon();

            // Set default values according to specifications when form loads
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCenterX.Text = "0";
            txtCenterY.Text = "0";
            txtLength.Text = "4";
            txtEdge.Text = "5";
            trackBarRed.Value = 0;
            trackBarGreen.Value = 0;
            trackBarBlue.Value = 0;
            lblRedValue.Text = "0";
            lblGreenValue.Text = "0";
            lblBlueValue.Text = "0";
        }

        // DRAW BUTTON CLICK EVENT
        // Creates polygon from TextBox values and draws it on PictureBox
        // =============================================================
        /// btnDraw_Click - Event method triggered when DRAW button is clicked.
        /// Reads values from TextBoxes, creates polygon object,
        /// calculates edge coordinates and draws it on PictureBox.
        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                // Read values from TextBoxes and set polygon parameters - Read Center X and Y values
                double centerX = double.Parse(txtCenterX.Text);
                double centerY = double.Parse(txtCenterY.Text);

                // Read Length value
                double length = double.Parse(txtLength.Text);

                // Read NumberOfEdges value
                int edges = int.Parse(txtEdge.Text);

                // Read Rotation Angle value
                double angle = double.Parse(txtAngle.Text);

                // Read RGB color values from TrackBars
                int red = trackBarRed.Value;
                int green = trackBarGreen.Value;
                int blue = trackBarBlue.Value;

                // Set polygon object parameters
                // Set center point
                polygon.Center = new Point2D(centerX, centerY);

                // Set edge length
                polygon.Length = length;

                // Set number of edges
                polygon.NumberOfEdges = edges;

                // Set rotation angle (initially 0, angle not used in DRAW - angle starts as 0)
                polygon.RotationAngle = 0;

                // Set color values
                polygon.Color = new ColorRGB(red, green, blue);

                // Calculate edge coordinates
                polygon.calculateEdgeCoordinates();

                // Draw polygon on PictureBox
                drawPolygon();

                // Mark the polygon as drawn
                isPolygonDrawn = true;
            }
            catch (FormatException)
            {
                // Invalid input value error
                MessageBox.Show("Please enter valid numerical values!",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                // General error catching
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ROTATE BUTTON CLICK EVENT
        // Rotates the polygon according to the entered angle
        // =============================================================
        /// btnRotate_Click - Event method triggered when ROTATE button is clicked.
        /// Rotates the polygon according to the entered rotation angle and redraws.
        private void btnRotate_Click(object sender, EventArgs e)
        {
            // If polygon is not drawn yet, call RESET button first
            if (!isPolygonDrawn)
            {
                // If no initial graph, call RESET button's click method
                btnReset_Click(sender, e);
                return;
            }

            try
            {
                // Read rotation angle from TextBox
                double angle = double.Parse(txtAngle.Text);

                // Check CCW checkbox state
                // Default direction: CW (clockwise)
                // If CCW is checked: counter-clockwise
                bool isCounterClockwise = chkCCW.Checked;

                // Set angle according to rotation direction
                if (isCounterClockwise)
                {
                    // CCW - rotate counter-clockwise (positive angle)
                    polygon.RotationAngle += angle;
                }
                else
                {
                    // CW - rotate clockwise (negative angle)
                    polygon.RotationAngle -= angle;
                }

                // Rotate polygon and recalculate vertex coordinates
                polygon.rotatePolygon(isCounterClockwise);

                // Redraw polygon on PictureBox
                drawPolygon();
            }
            catch (FormatException)
            {
                // Invalid angle value error
                MessageBox.Show("Please enter a valid angle value!",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // RESET BUTTON CLICK EVENT
        // Assigns random values to all parameters
        // =============================================================
        /// btnReset_Click - Event method triggered when RESET button is clicked.
        /// Assigns random values to all polygon parameters (center, length, color, numberOfEdges)
        /// and updates form UI elements.
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Generate random center x value in range [0, 3]
            int randomCenterX = rnd.Next(0, 4);
            txtCenterX.Text = randomCenterX.ToString();

            // Generate random center y value in range [0, 3]
            int randomCenterY = rnd.Next(0, 4);
            txtCenterY.Text = randomCenterY.ToString();

            // Generate random length value in range [3, 9]
            int randomLength = rnd.Next(3, 10);
            txtLength.Text = randomLength.ToString();

            // Generate random red value in range [0, 255]
            int randomRed = rnd.Next(0, 256);
            trackBarRed.Value = randomRed;
            lblRedValue.Text = randomRed.ToString();

            // Generate random green value in range [0, 255]
            int randomGreen = rnd.Next(0, 256);
            trackBarGreen.Value = randomGreen;
            lblGreenValue.Text = randomGreen.ToString();

            // Generate random blue value in range [0, 255]
            int randomBlue = rnd.Next(0, 256);
            trackBarBlue.Value = randomBlue;
            lblBlueValue.Text = randomBlue.ToString();

            // Generate random edge count value in range [3, 10]
            int randomEdges = rnd.Next(3, 11);
            txtEdge.Text = randomEdges.ToString();

            // Generate random angle value in range [0, 359]
            int randomAngle = rnd.Next(0, 360);
            txtAngle.Text = randomAngle.ToString();

            // Automatically call DRAW button - draw the polygon
            btnDraw_Click(sender, e);
        }

        // SAVE TO FILE BUTTON CLICK EVENT
        // Saves polygon details to text file
        // =============================================================
        /// btnSaveToFile_Click - Event raised when SAVE TO FILE button is clicked.
        /// Saves polygon details (center, color, length, numberOfEdges) to a text file.
        /// Asks the user for the file path using SaveFileDialog.
        private void btnSaveToFile_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Text File (*.txt)|*.txt"; // Only txt files
                saveDialog.Title = "Save Polygon Info";   // Window title
                saveDialog.FileName = "painttask.txt";          // Default file name


                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // File writing operation using StreamWriter
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        // Write Center X value
                        writer.WriteLine(txtCenterX.Text);

                        // Write Center Y value
                        writer.WriteLine(txtCenterY.Text);

                        // Write Length value
                        writer.WriteLine(txtLength.Text);

                        // Write Red color value
                        writer.WriteLine(trackBarRed.Value.ToString());

                        // Write Green color value
                        writer.WriteLine(trackBarGreen.Value.ToString());

                        // Write Blue color value
                        writer.WriteLine(trackBarBlue.Value.ToString());

                        // Write NumberOfEdges value
                        writer.WriteLine(txtEdge.Text);

                        // Write Rotation Angle value
                        writer.WriteLine(txtAngle.Text);
                    }

                    // Show success message
                    MessageBox.Show("Polygon details successfully saved!",
                        "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // File saving error
                MessageBox.Show("Error occurred while saving file: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // LOAD FROM FILE BUTTON CLICK EVENT
        // Loads polygon info from file, updates form elements
        // =============================================================
        /// Reads polygon info from a previously saved text file,
        /// updates form elements and redraws the polygon.
        private void btnLoadFromFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Create OpenFileDialog - file opening window
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.Filter = "Text File (*.txt)|*.txt"; // Only txt files
                openDialog.Title = "Load Polygon Info";    // Window title

                // If user selects file, start load process
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    // Read operation from file with StreamReader
                    using (StreamReader reader = new StreamReader(openDialog.FileName))
                    {
                        // Read Center X value and write to TextBox
                        txtCenterX.Text = reader.ReadLine();

                        // Read Center Y value and write to TextBox
                        txtCenterY.Text = reader.ReadLine();

                        // Read Length value and write to TextBox
                        txtLength.Text = reader.ReadLine();

                        // Read Red color value and adjust TrackBar
                        int red = int.Parse(reader.ReadLine());
                        trackBarRed.Value = red;
                        lblRedValue.Text = red.ToString();

                        // Read Green color value and adjust TrackBar
                        int green = int.Parse(reader.ReadLine());
                        trackBarGreen.Value = green;
                        lblGreenValue.Text = green.ToString();

                        // Read Blue color value and adjust TrackBar
                        int blue = int.Parse(reader.ReadLine());
                        trackBarBlue.Value = blue;
                        lblBlueValue.Text = blue.ToString();

                        // Read NumberOfEdges value and write to TextBox
                        txtEdge.Text = reader.ReadLine();

                        // Read Rotation Angle value and write to TextBox
                        txtAngle.Text = reader.ReadLine();
                    }

                    // Redraw polygon with loaded values
                    // Automatically call DRAW button
                    btnDraw_Click(sender, e);

                    // Show success message
                    MessageBox.Show("Polygon info loaded successfully!",
                        "Load Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // File loading error
                MessageBox.Show("Error occurred while loading file: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // TRACKBAR SCROLL EVENTS
        // Updates the labels of RGB color values
        // =============================================================
        /// trackBarRed_Scroll - Updates value when Red TrackBar is scrolled
        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            // Update red value label
            lblRedValue.Text = trackBarRed.Value.ToString();
        }

        /// trackBarGreen_Scroll - Updates value when Green TrackBar is scrolled
        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            // Update green value label
            lblGreenValue.Text = trackBarGreen.Value.ToString();
        }

        /// trackBarBlue_Scroll - Updates value when Blue TrackBar is scrolled
        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            // Update blue value label
            lblBlueValue.Text = trackBarBlue.Value.ToString();
        }

        // INTERVAL TRACKBAR SCROLL EVENT
        // Sets the automatic rotation interval
        // =============================================================
        /// trackBarInterval_Scroll - Updates the timer interval (frequency)
        /// when Interval TrackBar is scrolled
        private void trackBarInterval_Scroll(object sender, EventArgs e)
        {
            // If value is 0, stop rotating
            if (trackBarInterval.Value == 0)
            {
                timerRotation.Enabled = false;
            }
            else
            {
                // Enable timer and set interval for 'Value' times per second
                timerRotation.Enabled = true;
                timerRotation.Interval = 1000 / trackBarInterval.Value;
            }
        }

        // TIMER TICK EVENT
        // Automatic rotation process
        // =============================================================
        /// timerRotation_Tick - Event triggered on each timer tick.
        /// Automatically rotates the polygon at regular intervals.
        private void timerRotation_Tick(object sender, EventArgs e)
        {
            // Automatically rotate if polygon is drawn
            if (isPolygonDrawn)
            {
                // Read the rotation angle
                double angle = 0;
                double.TryParse(txtAngle.Text, out angle);

                // Check CCW status
                bool isCounterClockwise = chkCCW.Checked;

                // Set angle according to rotation direction
                if (isCounterClockwise)
                {
                    // Rotate counter-clockwise
                    polygon.RotationAngle += angle;
                }
                else
                {
                    // Rotate clockwise
                    polygon.RotationAngle -= angle;
                }

                // Recalculate vertex coordinates
                polygon.rotatePolygon(isCounterClockwise);

                // Redraw the polygon
                drawPolygon();
            }
        }

        // POLYGON DRAWING METHOD
        // The main drawing function that draws the polygon on the PictureBox
        // =============================================================
        /// drawPolygon() - Method that draws the polygon on the PictureBox.
        /// Sets the center of the PictureBox as the origin (0,0).
        /// Draws by connecting the vertex points of the polygon.
        private void drawPolygon()
        {
            // Get PictureBox dimensions
            int width = pictureBoxPolygon.Width;
            int height = pictureBoxPolygon.Height;

            // Create new bitmap (drawing surface)
            Bitmap bmp = new Bitmap(width, height);

            // Create Graphics object - for drawing operations
            using (Graphics g = Graphics.FromImage(bmp))
            {
                // Clear the background with white
                g.Clear(Color.White);

                // Improve drawing quality (anti-aliasing)
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Calculate the center point of the PictureBox (origin point)
                float originX = width / 2.0f;
                float originY = height / 2.0f;

                // Draw coordinate axes (helper lines)
                // X axis - horizontal line
                using (Pen axisPen = new Pen(Color.LightGray, 1))
                {
                    g.DrawLine(axisPen, 0, originY, width, originY);  // X axis
                    g.DrawLine(axisPen, originX, 0, originX, height); // Y axis
                }

                // If there are vertex points, draw the polygon
                if (polygon.Vertices != null && polygon.Vertices.Count > 1)
                {
                    // Convert vertex points to screen coordinates
                    // Create PointF array - for GDI+ drawing
                    PointF[] points = new PointF[polygon.Vertices.Count];

                    // Convert each vertex point to screen coordinates
                    for (int i = 0; i < polygon.Vertices.Count; i++)
                    {
                        // Convert Cartesian coordinates to screen coordinates
                        // x: center + (coordinate * scale)
                        // y: center - (coordinate * scale) (y axis inverted)
                        float screenX = originX + (float)(polygon.Vertices[i].X * scaleFactor);
                        float screenY = originY - (float)(polygon.Vertices[i].Y * scaleFactor);

                        points[i] = new PointF(screenX, screenY);
                    }

                    // Get the color of the polygon
                    Color polyColor = polygon.Color.ToDrawingColor();

                    // Fill the interior of the polygon with semi-transparent color
                    using (SolidBrush fillBrush = new SolidBrush(
                        Color.FromArgb(50, polyColor.R, polyColor.G, polyColor.B)))
                    {
                        g.FillPolygon(fillBrush, points);
                    }

                    // Draw the edges of the polygon
                    using (Pen polyPen = new Pen(polyColor, 2))
                    {
                        g.DrawPolygon(polyPen, points);
                    }

                    // Mark the vertex points as small circles
                    using (SolidBrush vertexBrush = new SolidBrush(polyColor))
                    {
                        for (int i = 0; i < points.Length; i++)
                        {
                            // Draw a 6x6 pixel ellipse at each vertex point
                            g.FillEllipse(vertexBrush,
                                points[i].X - 3, points[i].Y - 3, 6, 6);
                        }
                    }

                    // Mark the center point (red small circle)
                    float centerScreenX = originX + (float)(polygon.Center.X * scaleFactor);
                    float centerScreenY = originY - (float)(polygon.Center.Y * scaleFactor);
                    using (SolidBrush centerBrush = new SolidBrush(Color.Red))
                    {
                        g.FillEllipse(centerBrush,
                            centerScreenX - 4, centerScreenY - 4, 8, 8);
                    }
                }
            }

            // Release old bitmap (memory management)
            if (pictureBoxPolygon.Image != null)
            {
                pictureBoxPolygon.Image.Dispose();
            }

            // Assign the new bitmap to PictureBox
            pictureBoxPolygon.Image = bmp;
        }
    }
}
