#include <AccelStepper.h>
#include <MultiStepper.h>
#include <TinyGPS++.h>
#include <SoftwareSerial.h>

// Define SoftwareSerial pins for the GPS module
SoftwareSerial gpsSerial(3, 4); // RX (D4), TX (D3)

// Create a TinyGPS++ object
TinyGPSPlus gps;

// Define the stepper motor and the pins that is connected to 
AccelStepper stepper1(1, 5, 2); // (Type of driver: with 2 pins, STEP, DIR) 

bool enabled = false;
unsigned long writeDelay = 5000;
unsigned long lastMillis = 0;

String data;
char firstLetter;
bool high = false;
int positionToTurnTo = -1;

void setup() {
  // put your setup code here, to run once:
  stepper1.setMaxSpeed(500);
  Serial.begin(9600);
  gpsSerial.begin(9600);
  pinMode(13, OUTPUT);


}

void loop() {
  // put your main code here, to run repeatedly:

  if (enabled)
  {
    if (positionToTurnTo != -1)
    {
      stepper1.moveTo(positionToTurnTo);
      stepper1.run();

    }

    // Check if data is available from the GPS module
    while (gpsSerial.available() > 0)
    {
      // Feed the GPS data to the TinyGPS++ object
      gps.encode(gpsSerial.read());
    }
  }

  if (gps.location.isValid() && gps.location.isUpdated())
  {
    Serial.print("latitude ");
    //Serial.println(gps.location.rawLat().deg);
    Serial.println(gps.location.lat(), 4); // 4 decimal places so it doesn't detect tiny changes
    Serial.print("longitude ");
    //Serial.println(gps.location.rawLng().deg);
    Serial.println(gps.location.lng(), 4); // 4 decimal places
  }
  if (gps.satellites.isValid() && gps.satellites.isUpdated())
  { 
    Serial.print("Satellites: ");
    Serial.println(gps.satellites.value());
  }
  if (gps.time.isValid() && gps.time.isUpdated())
  {
    Serial.print("Time: ");
    Serial.println(gps.time.value());
  }

  if (Serial.available())
  {
    data = Serial.readString();

    // If contains in C++
    if (data.indexOf("On") != -1)
    {
      enabled = true;
      digitalWrite(13, HIGH);
    }
    else if (data.indexOf("Off") != -1)
    {
      digitalWrite(13, LOW);
      enabled = false;
    }
    if (data.indexOf("steps") != -1)
    {
      positionToTurnTo = (data.substring(6)).toInt();
      



    }
  }
  /*
  
  if ( (millis() - lastMillis) >= writeDelay)
  {
    lastMillis = millis();

    Serial.println("latitude 51.2142");
    Serial.println("longitude 25.2314");

    if (high)
    {
      digitalWrite(13, HIGH);
      high = false;
    }
    else 
    {
      digitalWrite(13, LOW);
      high = true;
    }
  }
  */
}


