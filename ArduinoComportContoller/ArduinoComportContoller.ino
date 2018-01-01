#define SENSORPIN A0
#define LAZERPIN 13

void setup() 
{
  Serial.begin(9600); 
  pinMode(LAZERPIN, OUTPUT);
}
int Mode = 'X';
void loop() 
{
  switch (Mode)
  {
    case 'X':
      Mode = Mode_1();
      break;
    case 'Y': 
      Mode = Mode_2();
      break;
    default:
      Mode = Mode_1();
      break;  
  }
}

int Mode_1() //Режим по символу X
{
  while (true)
  {
    while (Serial.available() > 0) 
    {
      char buf = Serial.read(); 
      switch (buf)
      {
        case 'R':
          Serial.println(analogRead(SENSORPIN));
          break;
        case 'S':
          Serial.println(82);//82 = 'R'
          break;
        default:
          if(isMode(buf))
          {
            return buf;
          }
      }
    }
  }
}
int Mode_2() //Режим по символу Y
{
  int pause = 100;
  while (true)
  {
    while (Serial.available() > 0) 
    {
      int buf = Serial.read(); 
      switch (buf)
      {
        case 'P':
          digitalWrite(LAZERPIN, HIGH);
          delay(pause);
          Serial.println(analogRead(SENSORPIN));
          digitalWrite(LAZERPIN, LOW);
          delay(pause);
          Serial.println(analogRead(SENSORPIN)); 
          break;     
        case 'T':     
          digitalWrite(LAZERPIN, HIGH);
          break;    
        case 'Z':     
          digitalWrite(LAZERPIN, LOW);
          break;     
        case 'D':      
          break;
        case 'R':
          Serial.println('R');
        default:
          if(isMode(buf))
          {
            return buf;
          }
          break;  
        } 
    }
  }
}
bool isMode(int key) //Является ли код режимом
{
  return (key >=88 & key<=90); //Символы X, Y, Z
}

