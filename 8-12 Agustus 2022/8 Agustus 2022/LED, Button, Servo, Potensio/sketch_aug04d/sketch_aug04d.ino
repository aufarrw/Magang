#include <Servo.h>
uint16_t dataSensor1;
uint16_t derajat, servo1degree, buttondegree;
int8_t indexOfA, indexOfB;
Servo myServo;
char c;
char a;
String dataIn;
String tembak;
String SerialData;
int degree;
const int LED1 = 2;
const int LED2 = 3;
const int LED3 = 4;
const int LED4 = 5;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  myServo.attach(7);
  myServo.write(45);
  pinMode(12, INPUT_PULLUP);
  pinMode(13, INPUT_PULLUP);
  pinMode(2, OUTPUT);
  digitalWrite(2, LOW);
  pinMode(3, OUTPUT);
  digitalWrite(3, LOW);
  pinMode(4, OUTPUT);
  digitalWrite(4, LOW);
  pinMode(5, OUTPUT);
  digitalWrite(5, LOW);
}

void Receive_Serial_Data(){
  while(Serial.available()>0){
    c = Serial.read();
    if (c=='\n') {
      break;
      }
    else {
      dataIn += c;
      }
  }
    if (c=='\n')
    {
      degree = dataIn.toInt();
      c=0;
      dataIn="";
    }
  }

 void LED(){
  while(Serial.available()>0){
    a = Serial.read();
    SerialData += a;
  }

  if(a=='#'){
    if(SerialData == "ON1#"){
      digitalWrite(LED1, HIGH);
    }
    else if(SerialData=="OFF1#"){
      digitalWrite(LED1, LOW);
    }
    if(SerialData == "ON2#"){
      digitalWrite(LED2, HIGH);
    }
    else if(SerialData=="OFF2#"){
      digitalWrite(LED2, LOW);
    }
    if(SerialData == "ON3#"){
      digitalWrite(LED3, HIGH);
    }
    else if(SerialData=="OFF3#"){
      digitalWrite(LED3, LOW);
    }
    if(SerialData == "ON4#"){
      digitalWrite(LED4, HIGH);
    }
    else if(SerialData=="OFF4#"){
      digitalWrite(LED4, LOW);
    }

    a=0;
    SerialData="";
  }
 }

  void perseData(){
    String servo1, button;

    indexOfA = dataIn.indexOf("A");
    indexOfB = dataIn.indexOf("B");

    if (indexOfA > -1){
      servo1 = dataIn.substring(0, indexOfA);
      servo1degree = servo1.toInt();
    }
    if (indexOfB > -1){
      button = dataIn.substring(indexOfA - 2, indexOfB + 3);
      buttondegree = button.toInt();
    }
  }


void loop() {
  // put your main code here, to run repeatedly:
  
  /*if ( digitalRead(13)==HIGH){
    Serial.print ("Close#");
  }*/
  
  dataSensor1 = analogRead(A0)/18;
  derajat = 45 + dataSensor1;
  Serial.print ((String) derajat + "A" + "\n");
  Receive_Serial_Data();
  myServo.write(degree);
  if ( digitalRead(13)==HIGH){
    Serial.println ((String)derajat + "A" + derajat + "B");
    //delay(1000);
  }
  /*else {
    Serial.print ("");
  }*/
  LED();
delay(100);
}
