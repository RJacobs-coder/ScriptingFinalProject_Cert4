// Name: Robert Jacobs 30018755
// Date: 02/12/2020
// Project: Environment Controller / Version 1
// Description: Records, uses and displays temperature, humidity and light values alongside user notifications when certain thresholds have been exceeded.

// DHT Library to use the DHT11 temp and humidity sensor.
#include <DHT.h>
#include <DHT_U.h>

//OutPut assignments
const int buzzer = 5;
const int redMood = 9;
const int greenMood = 10;
const int blueMood = 11;
const int redLED = 12;
const int blueLED = 13;

//Input assignments
//Constant Values
const int button = 2;
const int tempDHT = 4;
const int rotateDial = A0;
const int lightSensor = A1;
const int tempLM = A2;
DHT dht(tempDHT, DHT11);

//Variable Assignments.
const int wait = 1000;
const int lightMax = 500; // Works in my apartment. May need to change depending on light in room.
int tempMax;

//Printed Values
float tempOut;
float tempIn;
float humidIn;
int lightValue;
float data1;

void setup(){
  // Arduino Functionality
  Serial.begin(9600);
  dht.begin();

  // Output PinModes
  pinMode(redLED, OUTPUT);
  pinMode(blueLED, OUTPUT);
  pinMode(blueMood, OUTPUT);
  pinMode(redMood, OUTPUT);
  pinMode(greenMood, OUTPUT);
  pinMode(buzzer, OUTPUT);

// Input PinModes
  pinMode(tempLM, INPUT);
  pinMode(tempDHT, INPUT);
  pinMode(lightSensor, INPUT);
  pinMode(rotateDial, INPUT);
  pinMode(button, INPUT);
}

void loop(){

  
  // Reads the different devices to recieve data/
  tempOut = analogRead(tempLM);
  tempIn = dht.readTemperature();
  humidIn = dht.readHumidity();
 // Serial.Read allows the arduino to receive value from C#.
 int val = Serial.parseInt();
  tempOut = analogRead(tempLM); // Reads outdoor temp.
  tempIn = dht.readTemperature(); // Reads indoor temp.
  humidIn = dht.readHumidity();// Reads indoor humidity.

  // Prints out Serial Ports to C#. Only instance of printing.
  Serial.print(tempOut);
  Serial.print(',');
  Serial.print(tempIn);
  Serial.print(',');
  Serial.println(humidIn);
  delay(wait);

    int lightValue = analogRead(lightSensor);
    //Serial.print(lightValue);
    if(lightValue > lightMax)
    {
        if(digitalRead(blueLED) == HIGH)
        {
          delay(wait * 2); // Set to two seconds for testing. Usually 10
          digitalWrite(blueLED, LOW);
        }   
    }
    else{
          digitalWrite(blueLED, HIGH);
    }
  
  // Rotate Dial Switch case
  int data = analogRead(rotateDial);
  data = data / 300;
  // Switch case uses the values from Rotate Dial to switch on / off moodlight.
  switch (data){
    case 1:
           digitalWrite(redMood, HIGH);
           digitalWrite(greenMood, LOW);
           digitalWrite(blueMood, LOW);
           break;
           
    case 2:
           digitalWrite(redMood, LOW);
           digitalWrite(greenMood, HIGH);
           digitalWrite(blueMood, LOW);
           break;
           
    case 3:
           digitalWrite(redMood, LOW);
           digitalWrite(greenMood, LOW);
           digitalWrite(blueMood, HIGH);
           break;
           
    default:
           digitalWrite(redMood, LOW);
           digitalWrite(greenMood, LOW);
           digitalWrite(blueMood, LOW);
           break;
  }

  // Serial.parseInt(); is the data recieved from C#.
  // Depending on the value given a different outcome is provided.
    int toggle = Serial.parseInt();
    switch (toggle){

      // Case 100 + 101 turns the redLED on and off.
    case 100: digitalWrite(redLED, HIGH);
    break;
    case 101: digitalWrite(redLED,LOW);
    break;

    // Case 20 - 25 sets the max temp. From the combo box on form.
    case 20: tempMax = 20;
    break;
    case 21: tempMax = 21;
    break;
    case 22: tempMax = 22;
    break;
    case 23: tempMax = 23;
    break;
    case 24: tempMax = 24;
    break;
    case 25: tempMax = 25;
    break;
    case 26: tempMax = 26;
    break;
    case 27: tempMax = 27;
    break;
    case 28: tempMax = 28;
    break;
    case 29: tempMax = 29;
    break;
    case 30: tempMax = 30;
    break;
    case 31: tempMax = 31;
    break;
    case 32: tempMax = 32;
    break;
    case 33: tempMax = 33;
    break;
    case 34: tempMax = 34;
    break;
    case 35: tempMax = 35;
    break;
    default:
    break;
    }
    // If the Max temp set by switch case is above the current temp - Do Method.
   if(tempMax <= tempIn)
   {
    tempThreshold();
   }
}

// Method sounds a buzzer when Temp is above threshold.
void tempThreshold(){
    tone(buzzer, 1000,50);
    delay(wait / 5);
    tone(buzzer, 2000, 100);
}
