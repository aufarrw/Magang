char a;
String SerialData;

void setup() {
  Serial.begin(9600);
  pinMode(2, OUTPUT);
  digitalWrite(2, LOW);
}

void loop() {
  while(Serial.available()>0)
  {
    a = Serial.read();
    SerialData += a;
  }

  if (a== '#'){
    if(SerialData=="ON1#"){
      digitalWrite(2, HIGH);
    }
    else if (SerialData=="OFF1#"){
      digitalWrite(2,LOW);
    }
    a=0;
    SerialData="";
  }
}
