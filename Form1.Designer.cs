//*****************************************************************
//**                                                             **
//**        STUDENT NAME:  SALTUK BUĞRA DANİŞMENT                         **
//**        STUDENT NUMBER:  B241202023                         **
//**                                                             **
//*****************************************************************

namespace PolygonProject
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;


        /// Clean up any resources being used.

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// Creates and positions all controls on the form.
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            // --- Form Controls Definitions ---
            // PictureBox - area where the polygon will be drawn
            this.pictureBoxPolygon = new System.Windows.Forms.PictureBox();

            // Buttons
            this.btnDraw = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();

            // TextBoxes for Center (x,y)
            this.txtCenterX = new System.Windows.Forms.TextBox();
            this.txtCenterY = new System.Windows.Forms.TextBox();

            // Length TextBox
            this.txtLength = new System.Windows.Forms.TextBox();

            // RGB TrackBars (slider)
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();

            // NumberOfEdges TextBox
            this.txtEdge = new System.Windows.Forms.TextBox();

            // Rotation Angle TextBox
            this.txtAngle = new System.Windows.Forms.TextBox();

            // CCW CheckBox
            this.chkCCW = new System.Windows.Forms.CheckBox();

            // Rotation Interval Slider
            this.trackBarInterval = new System.Windows.Forms.TrackBar();

            // Timer - for automatic rotation
            this.timerRotation = new System.Windows.Forms.Timer(this.components);

            // Labels
            this.lblCenterXY = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblEdge = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblInterval = new System.Windows.Forms.Label();
            this.lblRedValue = new System.Windows.Forms.Label();
            this.lblGreenValue = new System.Windows.Forms.Label();
            this.lblBlueValue = new System.Windows.Forms.Label();

            // SuspendLayout
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPolygon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInterval)).BeginInit();
            this.SuspendLayout();

            // =====================================================
            // btnDraw - DRAW button
            // Button to draw the polygon
            // =====================================================
            this.btnDraw.Location = new System.Drawing.Point(520, 20);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(100, 35);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);

            // =====================================================
            // btnRotate - ROTATE button
            // Rotates the polygon
            // =====================================================
            this.btnRotate.Location = new System.Drawing.Point(520, 65);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(100, 35);
            this.btnRotate.TabIndex = 1;
            this.btnRotate.Text = "Rotate";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);

            // =====================================================
            // btnReset - RESET button
            // Sets random values to all parameters
            // =====================================================
            this.btnReset.Location = new System.Drawing.Point(520, 110);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 35);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // =====================================================
            // lblCenterXY - Center (x,y) label
            // =====================================================
            this.lblCenterXY.AutoSize = true;
            this.lblCenterXY.Location = new System.Drawing.Point(510, 165);
            this.lblCenterXY.Name = "lblCenterXY";
            this.lblCenterXY.Size = new System.Drawing.Size(70, 15);
            this.lblCenterXY.Text = "Center (x, y)";

            // =====================================================
            // txtCenterX - Center X coordinate TextBox
            // Center point x value input
            // Range: [0, 3], default: 0
            // =====================================================
            this.txtCenterX.Location = new System.Drawing.Point(590, 162);
            this.txtCenterX.Name = "txtCenterX";
            this.txtCenterX.Size = new System.Drawing.Size(40, 23);
            this.txtCenterX.TabIndex = 3;
            this.txtCenterX.Text = "0";
            this.txtCenterX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // =====================================================
            // txtCenterY - Center Y coordinate TextBox
            // Center point y value input
            // Range: [0, 3], default: 0
            // =====================================================
            this.txtCenterY.Location = new System.Drawing.Point(635, 162);
            this.txtCenterY.Name = "txtCenterY";
            this.txtCenterY.Size = new System.Drawing.Size(40, 23);
            this.txtCenterY.TabIndex = 4;
            this.txtCenterY.Text = "0";
            this.txtCenterY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // =====================================================
            // lblLength - Length label
            // =====================================================
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(510, 200);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(47, 15);
            this.lblLength.Text = "Length";

            // =====================================================
            // txtLength - Length TextBox
            // Edge length input
            // Range: [3, 9], default: 4
            // =====================================================
            this.txtLength.Location = new System.Drawing.Point(590, 197);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(85, 23);
            this.txtLength.TabIndex = 5;
            this.txtLength.Text = "4";
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // =====================================================
            // lblRed - Red label
            // =====================================================
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(510, 235);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 15);
            this.lblRed.Text = "Red";
            this.lblRed.ForeColor = System.Drawing.Color.Red;

            // =====================================================
            // trackBarRed - Red color TrackBar (slider)
            // RGB red component slider
            // Range: [0, 255], default: 0
            // =====================================================
            this.trackBarRed.Location = new System.Drawing.Point(550, 230);
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(120, 45);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Minimum = 0;
            this.trackBarRed.Value = 0;
            this.trackBarRed.TickFrequency = 25;
            this.trackBarRed.TabIndex = 6;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);

            // lblRedValue - Red value indicator
            this.lblRedValue.AutoSize = true;
            this.lblRedValue.Location = new System.Drawing.Point(670, 235);
            this.lblRedValue.Name = "lblRedValue";
            this.lblRedValue.Size = new System.Drawing.Size(15, 15);
            this.lblRedValue.Text = "0";

            // =====================================================
            // lblGreen - Green label
            // =====================================================
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(510, 270);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(38, 15);
            this.lblGreen.Text = "Green";
            this.lblGreen.ForeColor = System.Drawing.Color.Green;

            // =====================================================
            // trackBarGreen - Green color TrackBar (slider)
            // RGB green component slider
            // Range: [0, 255], default: 0
            // =====================================================
            this.trackBarGreen.Location = new System.Drawing.Point(550, 265);
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(120, 45);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Minimum = 0;
            this.trackBarGreen.Value = 0;
            this.trackBarGreen.TickFrequency = 25;
            this.trackBarGreen.TabIndex = 7;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);

            // lblGreenValue - Green value indicator
            this.lblGreenValue.AutoSize = true;
            this.lblGreenValue.Location = new System.Drawing.Point(670, 270);
            this.lblGreenValue.Name = "lblGreenValue";
            this.lblGreenValue.Size = new System.Drawing.Size(15, 15);
            this.lblGreenValue.Text = "0";

            // =====================================================
            // lblBlue - Blue label
            // =====================================================
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(510, 305);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(30, 15);
            this.lblBlue.Text = "Blue";
            this.lblBlue.ForeColor = System.Drawing.Color.Blue;

            // =====================================================
            // trackBarBlue - Blue color TrackBar (slider)
            // RGB blue component slider
            // Range: [0, 255], default: 0
            // =====================================================
            this.trackBarBlue.Location = new System.Drawing.Point(550, 300);
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(120, 45);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Minimum = 0;
            this.trackBarBlue.Value = 0;
            this.trackBarBlue.TickFrequency = 25;
            this.trackBarBlue.TabIndex = 8;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);

            // lblBlueValue - Blue value indicator
            this.lblBlueValue.AutoSize = true;
            this.lblBlueValue.Location = new System.Drawing.Point(670, 305);
            this.lblBlueValue.Name = "lblBlueValue";
            this.lblBlueValue.Size = new System.Drawing.Size(15, 15);
            this.lblBlueValue.Text = "0";

            // =====================================================
            // lblEdge - Edge label
            // =====================================================
            this.lblEdge.AutoSize = true;
            this.lblEdge.Location = new System.Drawing.Point(510, 345);
            this.lblEdge.Name = "lblEdge";
            this.lblEdge.Size = new System.Drawing.Size(33, 15);
            this.lblEdge.Text = "Edge";

            // =====================================================
            // txtEdge - NumberOfEdges TextBox
            // Edge count input
            // Range: [3, 10], default: 5
            // =====================================================
            this.txtEdge.Location = new System.Drawing.Point(560, 342);
            this.txtEdge.Name = "txtEdge";
            this.txtEdge.Size = new System.Drawing.Size(40, 23);
            this.txtEdge.TabIndex = 9;
            this.txtEdge.Text = "5";
            this.txtEdge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // =====================================================
            // chkCCW - CCW CheckBox
            // Rotation direction checkbox
            // Checked: CCW (counter clockwise)
            // Unchecked: CW (clockwise - default)
            // =====================================================
            this.chkCCW.AutoSize = true;
            this.chkCCW.Location = new System.Drawing.Point(620, 344);
            this.chkCCW.Name = "chkCCW";
            this.chkCCW.Size = new System.Drawing.Size(52, 19);
            this.chkCCW.TabIndex = 10;
            this.chkCCW.Text = "CCW";
            this.chkCCW.UseVisualStyleBackColor = true;

            // =====================================================
            // lblAngle - Angle label
            // =====================================================
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(510, 380);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(40, 15);
            this.lblAngle.Text = "Angle";

            // =====================================================
            // txtAngle - Rotation Angle TextBox
            // Rotation angle input
            // Range: [0, 359], default: 0
            // =====================================================
            this.txtAngle.Location = new System.Drawing.Point(560, 377);
            this.txtAngle.Name = "txtAngle";
            this.txtAngle.Size = new System.Drawing.Size(50, 23);
            this.txtAngle.TabIndex = 11;
            this.txtAngle.Text = "0";
            this.txtAngle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // =====================================================
            // lblInterval - Interval label
            // =====================================================
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(510, 415);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(46, 15);
            this.lblInterval.Text = "Interval";

            // =====================================================
            // trackBarInterval - Rotation frequency TrackBar (slider)
            // Sets automatic rotation frequency (rotations per second)
            // =====================================================
            this.trackBarInterval.Location = new System.Drawing.Point(560, 410);
            this.trackBarInterval.Name = "trackBarInterval";
            this.trackBarInterval.Size = new System.Drawing.Size(120, 45);
            this.trackBarInterval.Maximum = 10;
            this.trackBarInterval.Minimum = 0;
            this.trackBarInterval.Value = 0;
            this.trackBarInterval.TickFrequency = 1;
            this.trackBarInterval.TabIndex = 12;
            this.trackBarInterval.Scroll += new System.EventHandler(this.trackBarInterval_Scroll);

            // =====================================================
            // btnLoadFromFile - LOAD FROM FILE button
            // Loads polygon information from a file
            // =====================================================
            this.btnLoadFromFile.Location = new System.Drawing.Point(510, 460);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(95, 35);
            this.btnLoadFromFile.TabIndex = 13;
            this.btnLoadFromFile.Text = "Load from File";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.btnLoadFromFile_Click);

            // =====================================================
            // btnSaveToFile - SAVE TO FILE button
            // Saves polygon information to a file
            // =====================================================
            this.btnSaveToFile.Location = new System.Drawing.Point(615, 460);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(95, 35);
            this.btnSaveToFile.TabIndex = 14;
            this.btnSaveToFile.Text = "Save to File";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);

            // =====================================================
            // pictureBoxPolygon - Polygon drawing area
            // PictureBox center is set as origin (0,0)
            // =====================================================
            this.pictureBoxPolygon.BackColor = System.Drawing.Color.White;
            this.pictureBoxPolygon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPolygon.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxPolygon.Name = "pictureBoxPolygon";
            this.pictureBoxPolygon.Size = new System.Drawing.Size(490, 490);
            this.pictureBoxPolygon.TabIndex = 15;
            this.pictureBoxPolygon.TabStop = false;

            // =====================================================
            // timerRotation - Automatic rotation timer
            // =====================================================
            this.timerRotation.Enabled = false;
            this.timerRotation.Interval = 1000; // Varsayılan 1 saniye
            this.timerRotation.Tick += new System.EventHandler(this.timerRotation_Tick);

            // =====================================================
            // Form1 - Main form settings
            // =====================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 510);

            // Tüm kontrolleri forma ekle
            this.Controls.Add(this.pictureBoxPolygon);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblCenterXY);
            this.Controls.Add(this.txtCenterX);
            this.Controls.Add(this.txtCenterY);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.lblRedValue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.lblGreenValue);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.lblBlueValue);
            this.Controls.Add(this.lblEdge);
            this.Controls.Add(this.txtEdge);
            this.Controls.Add(this.chkCCW);
            this.Controls.Add(this.lblAngle);
            this.Controls.Add(this.txtAngle);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.trackBarInterval);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.btnSaveToFile);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Polygon Drawing Application";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPolygon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // PictureBox - for drawing operations
        private System.Windows.Forms.PictureBox pictureBoxPolygon;

        // Buttons
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Button btnLoadFromFile;

        // TextBoxes
        private System.Windows.Forms.TextBox txtCenterX;
        private System.Windows.Forms.TextBox txtCenterY;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtEdge;
        private System.Windows.Forms.TextBox txtAngle;

        // TrackBars (slider)
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TrackBar trackBarInterval;

        // CheckBox
        private System.Windows.Forms.CheckBox chkCCW;

        // Labels
        private System.Windows.Forms.Label lblCenterXY;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblEdge;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label lblInterval;
        private System.Windows.Forms.Label lblRedValue;
        private System.Windows.Forms.Label lblGreenValue;
        private System.Windows.Forms.Label lblBlueValue;

        // Timer - for automatic rotation
        private System.Windows.Forms.Timer timerRotation;
    }
}
