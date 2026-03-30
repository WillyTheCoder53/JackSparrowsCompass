using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;



namespace EPQCompassSoftware
{
    public partial class Form1 : Form
    {
        bool playing = false;
        bool postcodeEnabled = true;
        bool arduinoEnabled = true; // This lets me toggle if arduino code should be run. This lets the code run when the arduino is not plugged in
        double startLatitude = -1000;
        double startLongitude = -1000;
        double endLatitude = -1000;
        double endLongitude = -1000;
        int angle = 0;


        public Form1()
        {
            InitializeComponent();
            LatitudeTextBox.Visible = false;
            LongitudeTextBox.Visible = false;
            Debug.WriteLine("Test");

            if (arduinoEnabled)
            {
                serialPort1.Open();
                serialPort1.DataReceived += serialPort1_DataReceived;
                Debug.WriteLine("SerialPort Opened");
            }
            else
            {
                var coordiantes = getLatLon("SG88DW");
                startLatitude = coordiantes.latitude;
                startLongitude = coordiantes.longitude;
            } 
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //Debug.WriteLine("Data received");
            var serialPort = (SerialPort)sender;
            string data = serialPort.ReadLine();

            //Debug.WriteLine($"{data}");

            if (data.Contains("latitude"))
            {
                //clean data to get just number
                data = data.Replace(" ", "");
                data = data.Replace("latitude", "");

                double newLatitude = Convert.ToDouble(data);

                if (startLatitude != newLatitude)
                {
                    startLatitude = newLatitude;
                    Debug.WriteLine($"Received latitude: {startLatitude}");
                }
            }
            else if (data.Contains("longitude"))
            {
                //clean data to get just number
                data = data.Replace(" ", "");
                data = data.Replace("longitude", "");

                //this.Invoke((MethodInvoker)delegate{ PostcodeTextBox.Text = data; });
                //Debug.WriteLine($"received Longitude: {data}");

                double newLongitude = Convert.ToDouble(data);

                if (startLongitude != newLongitude)
                {
                    startLongitude = newLongitude;
                    Debug.WriteLine($"Received longitude: {startLongitude}");
                }
            }
        }

        private void GetBearingAngle()
        {
            double tempDoubleAngle = 0;

            while (angle == 0)
            {
                if (startLongitude == -1000 || startLatitude == -1000)
                {
                    Thread.Sleep(1000);
                    continue;
                }

                else
                {
                    double x1 = LatOrLongToMercator(startLongitude, false);
                    double x2 = LatOrLongToMercator(endLongitude, false);

                    double y1 = LatOrLongToMercator(startLatitude, true);
                    double y2 = LatOrLongToMercator(endLatitude, true);

                    double changeInX = x2 - x1;
                    double changeInY = y2 - y1;


                    Debug.WriteLine($"Change in X: {changeInX}");
                    Debug.WriteLine($"Change in Y:  {changeInY}");

                    if (changeInX == 0 && changeInY == 0) // If in same place do not update angle
                    {
                        Thread.Sleep(1000);
                        continue;
                    }
                    else
                    {
                        tempDoubleAngle = (Math.Atan2(changeInY, changeInX) * 180 / Math.PI);
                        Debug.WriteLine($"Original bearing: {tempDoubleAngle}");

                        tempDoubleAngle = (450 - tempDoubleAngle) % 360;
                        Debug.WriteLine($"Compass bearing: {tempDoubleAngle}");
                    }

                    angle = Convert.ToInt32(tempDoubleAngle/360 * 200); // Convert to motor max steps which is 200 degrees for full circle
                    Debug.WriteLine($"Motor steps: {angle}");
                    //Debug.WriteLine(distanceToDestination());

                    if (arduinoEnabled) serialPort1.Write($"steps: {angle}");

                    break;
                }
            }

        }

        private double LatOrLongToMercator(double latOrLong, bool isLat)
        {
            double radiusOfEarth = 6378137;

            if (isLat)
            {
                return radiusOfEarth * Math.Log(Math.Tan(Math.PI / 4 + (latOrLong * Math.PI / 180.0 / 2)));
            }
            return radiusOfEarth * (latOrLong * Math.PI / 180);
        }

        /*
        private double distanceToDestination()
        {
            while (true)
            {
                if (startLatitude != -1000 && startLongitude != -1000)
                {
                    double x1 = LatOrLongToMercator(startLongitude, false);
                    double x2 = LatOrLongToMercator(endLongitude, false);

                    double y1 = LatOrLongToMercator(startLatitude, true);
                    double y2 = LatOrLongToMercator(endLatitude, true);

                    // Distance between 2 points formula using *itself instead of ^2 as you can't ^2 doubles
                    double squaredDistance = ((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1));

                    return Math.Round(Math.Sqrt(squaredDistance), 2) /1000;
                }
                Thread.Sleep(1000);
                continue;
            }
        }
        */

        private double distanceToDestination()
        {
            while (true)
            {
                if (startLatitude != -1000 && startLongitude != -1000)
                {
                    const double radius = 6371.0; // Radius of the earth in KM

                    // Using the haversine formula
                    double startLatRad = DegreesToRadians(startLatitude);
                    double endLatRad = DegreesToRadians(endLatitude);
                    double changeInLatRad = endLatRad - startLatRad;
                    double changeInLong = DegreesToRadians(endLongitude - startLongitude);

                    double a = Squared(Math.Sin(changeInLatRad / 2))
                        + Math.Cos(startLatRad) * Math.Cos(endLatRad)
                        * Squared(Math.Sin(changeInLong / 2));

                    double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

                    return Math.Round(radius * c, 2);

                }
                Thread.Sleep(1000);
            }
        }
        double DegreesToRadians(double degrees) => degrees * Math.PI / 180;
        double Squared(double value) => value * value;
        private (double latitude, double longitude) getLatLon(string targetPostcode)
        {
            if (!string.IsNullOrEmpty(targetPostcode))
            {
                string url = $"https://findthatpostcode.uk/postcodes/{targetPostcode}";

                using (HttpClient client = new HttpClient())
                {
                    var response = client.GetAsync(url).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string json = response.Content.ReadAsStringAsync().Result;
                        dynamic postcode = JsonConvert.DeserializeObject(json);

                        //Console.WriteLine(postcode);

                        double latitude = postcode.data.attributes.lat;
                        double longitude = postcode.data.attributes["long"]; // ["long"] had to be used as it identifies .long as a type 

                        //Console.WriteLine($"Latitude: {latitude}");
                        //Console.WriteLine($"Longitude: {longitude}");

                        return (latitude, longitude);
                    }
                    //Console.WriteLine("Postcode not found");
                    //Console.WriteLine("Status code: " + (int)response.StatusCode);
                }
            }
            return (-1, -1); // -1 will be the error message
        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnButton_Click(object sender, EventArgs e)
        {
            OnButton.Enabled = false;
            OffButton.Enabled = true;
            PostcodeTextBox.Enabled = true;
            PostcodeTextBox.Text = "Enter your desired postcode:";
            LatitudeTextBox.Enabled = true;
            LatitudeTextBox.Text = "Enter your desired latitude:";
            LongitudeTextBox.Enabled = true;
            LongitudeTextBox.Text = "Enter your desired longitude";
            SubmitButton.Enabled = true;
            PostcodeRadioButton.Enabled = true;
            LatLongRadioButton.Enabled = true;

            if (arduinoEnabled)
            {
                serialPort1.Write("On");
            }
        }

        private void OffButton_Click(object sender, EventArgs e)
        {
            OnButton.Enabled = true;
            OffButton.Enabled = false;
            LongitudeTextBox.Enabled = false;
            LatitudeTextBox.Enabled = false;
            PostcodeTextBox.Enabled = false;
            PostcodeTextBox.Text = string.Empty;
            SubmitButton.Enabled = false;
            PostcodeRadioButton.Enabled = false;
            LatLongRadioButton.Enabled = false;
            

            if (arduinoEnabled)
            {
                serialPort1.Write("Off");
            }
        }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private async void guna2Button1_Click_1(object sender, EventArgs e)
        {
            PostcodeTextBox.Enabled = false;
            LatitudeTextBox.Enabled = false;
            LongitudeTextBox.Enabled = false;
            SubmitButton.Enabled = false;

            if (postcodeEnabled)
            {
                string postCode = PostcodeTextBox.Text.Replace(" ", "");

                var coordinates = getLatLon(postCode);
                double latitude = coordinates.latitude;
                double longitude = coordinates.longitude;

                if (latitude != -1 && longitude != -1) // If not error
                {
                    Debug.WriteLine($"Target latitude {latitude}");
                    Debug.WriteLine($"Target longitude {longitude}");

                    endLatitude = latitude;
                    endLongitude = longitude;
                }
            }
            else 
            {
                string latText = LatitudeTextBox.Text.Replace(" ", "");
                string longText = LatitudeTextBox.Text.Replace(" ", "");
                
                try 
                {
                    endLatitude = Convert.ToDouble(latText);
                    endLongitude = Convert.ToDouble(longText);
                }
                catch
                {
                    LatitudeTextBox.Text = "Invalid input!";
                    LongitudeTextBox.Text = "Invalid input!";
                }
            }

            Thread thread2 = new Thread(GetBearingAngle);
            thread2.Start();

            Task<double> distanceTask = Task.Run(() => distanceToDestination());

            DistanceTextBox.Text = $"{await distanceTask} kilometers";
        }

        private void serialPort1_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            Debug.WriteLine("error received");
        }

        private void PostcodeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (postcodeEnabled)
            {
                postcodeEnabled = false;
                PostcodeTextBox.Visible = false;
                LatitudeTextBox.Visible = true;
                LongitudeTextBox.Visible = true;
            }
            else
            {
                postcodeEnabled = true;
                PostcodeTextBox.Visible = true;
                LatitudeTextBox.Visible = false;
                LongitudeTextBox.Visible = false;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
