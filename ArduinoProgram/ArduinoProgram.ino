/* mert4x4 MagicLed */
class led
{
  private:
    byte redVal = 0;
    byte greenVal = 0;
    byte blueVal = 0;

    uint8_t led_red;
    uint8_t led_green;
    uint8_t led_blue;

  public:
    byte temp = 0;
    led(int led_red, int led_green , int led_blue)
    {
      this->led_red = led_red;
      this->led_green = led_green;
      this->led_blue = led_blue;
    }
    void Setup()
    {
      pinMode(led_red, OUTPUT);
      pinMode(led_green , OUTPUT);
      pinMode(led_blue , OUTPUT);
    }
    void alloff()
    {
      digitalWrite(led_red, LOW);
      digitalWrite(led_green, LOW);
      digitalWrite(led_blue, LOW);
    }

    void play()
    {
      if (temp >= 30 && temp <= 45)
      {
        alloff();
        greenVal = map(temp, 30, 45, 0, 255);
        digitalWrite(led_blue, HIGH);
        analogWrite(led_green, greenVal);
      }
      else if (temp > 45 && temp <= 55)
      {
        alloff();
        analogWrite(led_green, 255);
        blueVal = map(temp, 45, 55, 0, 255);
        analogWrite(led_blue, 255 - blueVal);
      }

      else if (temp > 55 && temp <= 65)
      {
        alloff();
        analogWrite(led_green, 255);
        redVal = map(temp, 55, 65, 0, 255);
        analogWrite(led_red, redVal);
      }

      else if (temp > 55 && temp <= 65)
      {
        alloff();
        analogWrite(led_green, 255);
        redVal = map(temp, 55, 65, 0, 255);
        analogWrite(led_red, redVal);
      }

      else if (temp > 65 && temp <= 70)
      {
        alloff();
        analogWrite(led_blue, 0);
        analogWrite(led_red, 255);
        greenVal = map(temp, 65, 90, 0, 255);
        analogWrite(led_green, 255 - greenVal);
      }
      else if (temp > 70 && temp <= 75)
      {
        alloff();
        analogWrite(led_blue, 0);
        analogWrite(led_red, 255);
        greenVal = map(temp, 65, 70, 0, 255);
        analogWrite(led_green, 255 - greenVal);
      }


      else if (temp > 75 && temp <= 200)
      {
        alloff();
        analogWrite(led_blue, 0);
        analogWrite(led_green, 0);
        analogWrite(led_red, 255);
        blueVal = map(temp, 70, 200, 0, 255);
        analogWrite(led_blue, blueVal);
      }
    }
};

unsigned long oldTime = 0;
unsigned long newTime;

led gpu(9, 10, 11);

const uint8_t latchPin = 5;
const uint8_t clockPin = 6;
const uint8_t dataPin = 4;
byte leds = 0;

byte ram_usage = 0;

void setup() {
  Serial.begin(9600);
  gpu.Setup();
  pinMode(latchPin, OUTPUT);
  pinMode(dataPin, OUTPUT);
  pinMode(clockPin, OUTPUT);
}

void editReg(){
  digitalWrite(latchPin, LOW);
  shiftOut(dataPin, clockPin, LSBFIRST, leds);
  digitalWrite(latchPin, HIGH);
}

void CpuLeds(int i)
{
  if (ram_usage >= 0 && ram_usage <= 14)
  {
    leds = B10000000;
    editReg();
  }
  else if (ram_usage > 14 && ram_usage <= 28)
  {
    leds = B11000000;
    editReg();
  }
  else if (ram_usage > 28 && ram_usage <= 42)
  {
    leds = B11100000;
    editReg();
  }

  else if (ram_usage > 42 && ram_usage <= 56)
  {
    leds = B11110000;
    editReg();
  }

  else if (ram_usage > 56 && ram_usage <= 70)
  {
    leds = B11111000;
    editReg();
  }
  else if (ram_usage > 70 && ram_usage <= 84)
  {
    leds = B11111100;
    editReg();
  } else if (ram_usage > 84 && ram_usage <= 95)
  {
    leds = B11111110;
    editReg();
  } else if (ram_usage > 95 && ram_usage <= 200)
  {
    leds = B11111111;
    editReg();
  }
}

void loop() {
  if (Serial.available() > 10)
  {
    gpu.temp = Serial.parseInt();
    ram_usage = Serial.parseInt();
    
    if (gpu.temp == 201) //spotify effect
    {
      for (int i = 30; i < 80; i++)
      {
        gpu.temp = i;
        gpu.play();
        delay(30);
      }
    }
    
    gpu.play(); //play gpu led
    CpuLeds(ram_usage); //play ram usage leds
  }
  
  newTime = millis();
  if (gpu.temp == 70)//buzzer
  {
    if (newTime - oldTime > 60000)
    {
      gpu.alloff();
      oldTime = newTime;
    }
  }
}
