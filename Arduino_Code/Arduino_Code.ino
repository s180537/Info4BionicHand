//Global Variable
uint16_t dataSensor1, dataSensor2, dataSensor3, dataSensor4, dataSensor5;

void setup() {
  // put your setup code here, to run once:
    Serial.begin(115200);
}

void loop() {
  // put your main code here, to run repeatedly:
    dataSensor1 = analogRead(A0);
    dataSensor2 = analogRead(A1);
    dataSensor3 = analogRead(A2);
    dataSensor4 = analogRead(A3);
    dataSensor5 = analogRead(A4);
    

    Serial.print((String) dataSensor1 + "A" + dataSensor2 + "B" + dataSensor3 + "C" + dataSensor4 + "D" + dataSensor5 + "E" + + "\n");

    delay(100);
}
