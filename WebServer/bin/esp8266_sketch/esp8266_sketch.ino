#define ADMIN_PIN A0

String myStr = "";
char myChar = 0;
int i = 0;

String password = "";

void serialFlush(){
  while(Serial.available() > 0)char c = Serial.read();
}

void setup() {
   Serial.begin(9600);
   pinMode(ADMIN_PIN, INPUT);
 }
 
void loop() {
   while(Serial.available() > 0) {
     myChar = Serial.read();
     myStr += myChar;
     delay(10);
   }
  //change pass
  if(myStr[0] == 'P'){
    if(analogRead(ADMIN_PIN) == 1024){
      String serialInput = myStr.substring(2);
  
      password = serialInput;
      Serial.println("PC");
    }else{
      Serial.println("LR");
    }
  //test pass
  }else if(myStr[0] == 'C'){
    String serialInput = myStr.substring(2);

    if(serialInput == password){
      Serial.println("LA");
    }else{
      Serial.println("LI");
    }
  }
   
   if ((myStr.length() >0)&(!Serial.available())) {
     myStr="";
     serialFlush();
   }
 }
