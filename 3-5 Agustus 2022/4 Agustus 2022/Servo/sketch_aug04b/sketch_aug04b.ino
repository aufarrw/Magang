#include <Servo.h>

Servo myServo;

char c;
String dataIn;
int degree;

void setup() {
  Serial.begin(9600);
  Serial.println("Cpntrol Servo");
  myServo.attach(7);
}

void loop() {
  Receive_Serial_Data();
  myServo.write(degree);
}

void Receive_Serial_Data(){
  while(Serial.available()>0){
    c = Serial.read();
    if (c=='A') {
      break;
      }
    else {
      dataIn += c;
      }
  }
    if (c=='A')
    {
      degree = dataIn.toInt();
      c=0;
      dataIn="";
    }
   }
