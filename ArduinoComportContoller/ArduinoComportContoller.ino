
void setup() 
{
  Serial.begin(9600); 

}
void loop() 
{
  while (Serial.available() > 0) 
  {
      if (Serial.read() == 83 )
      {
        Serial.println(82);
        break;
      }
      Serial.println(analogRead(A0));
      
  }
}
