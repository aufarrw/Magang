#include <Servo.h>

Servo myServo;
void setup() {
  myServo.attach(7);

}

void loop() {
myServo.write(90);

}
