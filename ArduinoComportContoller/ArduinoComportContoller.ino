
void setup() 
{
  Serial.begin(9600); 

}
double i = 0;
void loop() 
{
  while (Serial.available() > 0) 
  {
      if (Serial.read() == 83 )
      {
        Serial.println(82);
        break;
      }
      Serial.println(sin(i)*100, 7);
      i = i + 0.08d;
  }
}
