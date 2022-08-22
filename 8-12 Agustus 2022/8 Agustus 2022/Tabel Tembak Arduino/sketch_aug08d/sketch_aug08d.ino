#include <Servo.h>
Servo myServo;

char c;
String dataIn;
int degree;


void setup() {
  Serial.begin(9600);
  myServo.attach(7);
  myServo.write(45);
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

void loop() {
  Receive_Serial_Data();
  myServo.write(degree);
}
