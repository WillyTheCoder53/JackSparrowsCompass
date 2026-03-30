namespace EPQCompassSoftware
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.XButton = new Guna.UI2.WinForms.Guna2Button();
            this.MinusButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.DistanceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CompassPicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.OnButton = new Guna.UI2.WinForms.Guna2Button();
            this.OffButton = new Guna.UI2.WinForms.Guna2Button();
            this.PostcodeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SubmitButton = new Guna.UI2.WinForms.Guna2Button();
            this.PostcodeRadioButton = new System.Windows.Forms.RadioButton();
            this.LatLongRadioButton = new System.Windows.Forms.RadioButton();
            this.LatitudeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.LongitudeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CompassPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // XButton
            // 
            this.XButton.Animated = true;
            this.XButton.BorderRadius = 10;
            this.XButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.XButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.XButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.XButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.XButton.FillColor = System.Drawing.Color.Silver;
            this.XButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.XButton.ForeColor = System.Drawing.Color.Black;
            this.XButton.Location = new System.Drawing.Point(766, 13);
            this.XButton.Name = "XButton";
            this.XButton.Size = new System.Drawing.Size(56, 58);
            this.XButton.TabIndex = 0;
            this.XButton.Text = "X";
            this.XButton.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Animated = true;
            this.MinusButton.BorderRadius = 10;
            this.MinusButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MinusButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MinusButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MinusButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MinusButton.FillColor = System.Drawing.Color.Silver;
            this.MinusButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinusButton.ForeColor = System.Drawing.Color.Black;
            this.MinusButton.Location = new System.Drawing.Point(704, 13);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(56, 58);
            this.MinusButton.TabIndex = 1;
            this.MinusButton.Text = "-";
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // DistanceTextBox
            // 
            this.DistanceTextBox.BorderThickness = 0;
            this.DistanceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DistanceTextBox.DefaultText = "Distance to destination:";
            this.DistanceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DistanceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DistanceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DistanceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DistanceTextBox.FillColor = System.Drawing.SystemColors.Control;
            this.DistanceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DistanceTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistanceTextBox.ForeColor = System.Drawing.Color.Black;
            this.DistanceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DistanceTextBox.Location = new System.Drawing.Point(15, 428);
            this.DistanceTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.DistanceTextBox.Name = "DistanceTextBox";
            this.DistanceTextBox.PlaceholderText = "";
            this.DistanceTextBox.ReadOnly = true;
            this.DistanceTextBox.SelectedText = "";
            this.DistanceTextBox.Size = new System.Drawing.Size(415, 57);
            this.DistanceTextBox.TabIndex = 3;
            this.DistanceTextBox.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // CompassPicture
            // 
            this.CompassPicture.Image = global::EPQCompassSoftware.Properties.Resources.CompassImage_removebg_preview;
            this.CompassPicture.ImageRotate = 11F;
            this.CompassPicture.Location = new System.Drawing.Point(440, 109);
            this.CompassPicture.Name = "CompassPicture";
            this.CompassPicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CompassPicture.Size = new System.Drawing.Size(400, 322);
            this.CompassPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CompassPicture.TabIndex = 2;
            this.CompassPicture.TabStop = false;
            // 
            // serialPort1
            // 
            this.serialPort1.DtrEnable = true;
            this.serialPort1.PortName = "COM4";
            this.serialPort1.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPort1_ErrorReceived);
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // OnButton
            // 
            this.OnButton.Animated = true;
            this.OnButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OnButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OnButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OnButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OnButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OnButton.ForeColor = System.Drawing.Color.White;
            this.OnButton.Location = new System.Drawing.Point(15, 355);
            this.OnButton.Name = "OnButton";
            this.OnButton.Size = new System.Drawing.Size(180, 45);
            this.OnButton.TabIndex = 5;
            this.OnButton.Text = "On";
            this.OnButton.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // OffButton
            // 
            this.OffButton.Animated = true;
            this.OffButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.OffButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.OffButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.OffButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.OffButton.Enabled = false;
            this.OffButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OffButton.ForeColor = System.Drawing.Color.White;
            this.OffButton.Location = new System.Drawing.Point(250, 355);
            this.OffButton.Name = "OffButton";
            this.OffButton.Size = new System.Drawing.Size(180, 45);
            this.OffButton.TabIndex = 6;
            this.OffButton.Text = "Off";
            this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // PostcodeTextBox
            // 
            this.PostcodeTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PostcodeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PostcodeTextBox.DefaultText = "Enter your desired postcode:";
            this.PostcodeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PostcodeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PostcodeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PostcodeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PostcodeTextBox.Enabled = false;
            this.PostcodeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PostcodeTextBox.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostcodeTextBox.ForeColor = System.Drawing.Color.Black;
            this.PostcodeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PostcodeTextBox.Location = new System.Drawing.Point(15, 13);
            this.PostcodeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.PostcodeTextBox.Name = "PostcodeTextBox";
            this.PostcodeTextBox.PlaceholderText = "";
            this.PostcodeTextBox.SelectedText = "";
            this.PostcodeTextBox.Size = new System.Drawing.Size(415, 77);
            this.PostcodeTextBox.TabIndex = 7;
            this.PostcodeTextBox.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Animated = true;
            this.SubmitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SubmitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SubmitButton.Enabled = false;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubmitButton.ForeColor = System.Drawing.Color.White;
            this.SubmitButton.Location = new System.Drawing.Point(15, 293);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(415, 45);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // PostcodeRadioButton
            // 
            this.PostcodeRadioButton.AutoSize = true;
            this.PostcodeRadioButton.Checked = true;
            this.PostcodeRadioButton.Enabled = false;
            this.PostcodeRadioButton.Location = new System.Drawing.Point(15, 494);
            this.PostcodeRadioButton.Name = "PostcodeRadioButton";
            this.PostcodeRadioButton.Size = new System.Drawing.Size(133, 29);
            this.PostcodeRadioButton.TabIndex = 9;
            this.PostcodeRadioButton.TabStop = true;
            this.PostcodeRadioButton.Text = "Postcode";
            this.PostcodeRadioButton.UseVisualStyleBackColor = true;
            this.PostcodeRadioButton.CheckedChanged += new System.EventHandler(this.PostcodeRadioButton_CheckedChanged);
            // 
            // LatLongRadioButton
            // 
            this.LatLongRadioButton.AutoSize = true;
            this.LatLongRadioButton.Enabled = false;
            this.LatLongRadioButton.Location = new System.Drawing.Point(174, 494);
            this.LatLongRadioButton.Name = "LatLongRadioButton";
            this.LatLongRadioButton.Size = new System.Drawing.Size(256, 29);
            this.LatLongRadioButton.TabIndex = 10;
            this.LatLongRadioButton.Text = "Latitude and longitude";
            this.LatLongRadioButton.UseVisualStyleBackColor = true;
            // 
            // LatitudeTextBox
            // 
            this.LatitudeTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LatitudeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LatitudeTextBox.DefaultText = "Enter your desired latitude:";
            this.LatitudeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LatitudeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LatitudeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LatitudeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LatitudeTextBox.Enabled = false;
            this.LatitudeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LatitudeTextBox.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LatitudeTextBox.ForeColor = System.Drawing.Color.Black;
            this.LatitudeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LatitudeTextBox.Location = new System.Drawing.Point(15, 109);
            this.LatitudeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.LatitudeTextBox.Name = "LatitudeTextBox";
            this.LatitudeTextBox.PlaceholderText = "";
            this.LatitudeTextBox.SelectedText = "";
            this.LatitudeTextBox.Size = new System.Drawing.Size(415, 77);
            this.LatitudeTextBox.TabIndex = 11;
            // 
            // LongitudeTextBox
            // 
            this.LongitudeTextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LongitudeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LongitudeTextBox.DefaultText = "Enter your desired longitude";
            this.LongitudeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LongitudeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LongitudeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LongitudeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LongitudeTextBox.Enabled = false;
            this.LongitudeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LongitudeTextBox.Font = new System.Drawing.Font("Segoe UI", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LongitudeTextBox.ForeColor = System.Drawing.Color.Black;
            this.LongitudeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LongitudeTextBox.Location = new System.Drawing.Point(15, 198);
            this.LongitudeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.LongitudeTextBox.Name = "LongitudeTextBox";
            this.LongitudeTextBox.PlaceholderText = "";
            this.LongitudeTextBox.SelectedText = "";
            this.LongitudeTextBox.Size = new System.Drawing.Size(415, 77);
            this.LongitudeTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 555);
            this.Controls.Add(this.LongitudeTextBox);
            this.Controls.Add(this.LatitudeTextBox);
            this.Controls.Add(this.LatLongRadioButton);
            this.Controls.Add(this.PostcodeRadioButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.PostcodeTextBox);
            this.Controls.Add(this.OffButton);
            this.Controls.Add(this.OnButton);
            this.Controls.Add(this.DistanceTextBox);
            this.Controls.Add(this.CompassPicture);
            this.Controls.Add(this.MinusButton);
            this.Controls.Add(this.XButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CompassPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button XButton;
        private Guna.UI2.WinForms.Guna2Button MinusButton;
        private Guna.UI2.WinForms.Guna2CirclePictureBox CompassPicture;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox DistanceTextBox;
        private System.IO.Ports.SerialPort serialPort1;
        private Guna.UI2.WinForms.Guna2Button OnButton;
        private Guna.UI2.WinForms.Guna2Button OffButton;
        private Guna.UI2.WinForms.Guna2TextBox PostcodeTextBox;
        private Guna.UI2.WinForms.Guna2Button SubmitButton;
        private System.Windows.Forms.RadioButton LatLongRadioButton;
        private System.Windows.Forms.RadioButton PostcodeRadioButton;
        private Guna.UI2.WinForms.Guna2TextBox LongitudeTextBox;
        private Guna.UI2.WinForms.Guna2TextBox LatitudeTextBox;
    }
}

