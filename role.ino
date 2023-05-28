void setup() {
  Serial.begin(9600);
int alinan = 0;
pinMode(11, OUTPUT);
digitalWrite(11, HIGH);
}

void loop() {
  if (Serial.available()) { // Serial Porta girdi değerinin olup olmadığını kontrol et
    // eğer girdi varsa oku ve yazdır.


     int alinan = Serial.read(); // Serial Porttan değer okuma
    
    Serial.print(alinan); // integer olarak alınan değeri yazdırma
    if (alinan == 49){
                digitalWrite(11, LOW);  
                Serial.println("fan calısıyor");
                }
                else{  digitalWrite(11, HIGH);
                Serial.println("fan calısmiyor");}
 }
}
