#include <ESP8266WiFi.h>
#include <SoftwareSerial.h>

#define ADMIN_PIN A0

String myStr = "";
char myChar = 0;
int i = 0;

String password = "";

String WifiSsid;
String WifiPass;

WiFiServer server(80);

String header;
int WifiStatus = WL_DISCONNECTED;

void serialFlush(){
  while(Serial.available() > 0)char c = Serial.read();
}

//rx tx
SoftwareSerial port(D6, D5);
//13 - D7
//15 - D8

void setup() {
  pinMode(13, INPUT);
  pinMode(15, OUTPUT);
  
  Serial.begin(9600);
  while(!Serial);
  port.begin(9600);
  while(!port);
  
  pinMode(ADMIN_PIN, INPUT);
  WiFi.mode(WIFI_STA);
  
  WifiSsid = "";
  WifiPass = "";
}

String headerS;
 
void loop(){
  WiFiClient client = server.available();   // Listen for incoming clients

  if (client) {                             // If a new client connects,
    String currentLine = "";                // make a String to hold incoming data from the client
    while (client.connected()) { // loop while the client's connected
      //currentTime = millis();         
      if (client.available()) {             // if there's bytes to read from the client,
        char c = client.read();             // read a byte
        headerS += c;
        if (c == '\n') {                    // if the byte is a newline character
          // if the current line is blank, you got two newline characters in a row.
          // that's the end of the client HTTP request, so send a response:
          if (currentLine.length() == 0) {
            // HTTP headers always start with a response code (e.g. HTTP/1.1 200 OK)
            // and a content-type so the client knows what's coming, then a blank line:
            client.println("HTTP/1.1 200 OK");
            client.println("Content-type: text/plain");
            
            
            if (headerS.indexOf("GET /test") >= 0){
              client.println("Content-Length: 3");
              client.println();
              client.println("GET");
            }else if(headerS.indexOf("POST /db") >= 0){
              int content_length = 0, index = headerS.indexOf("Content-Length:"), i;
              
              for(i = index; headerS[i] != '\n'; i++);

              content_length = headerS.substring(index+16, i).toInt();

              delay(10);

              String data = "";

              for(int ii=0; ii<content_length; ii++){
                data += (char)client.read();
              }
              
              //delay(10);

              for(int i=0; i<data.length(); i++){
                port.write(data[i]);
              }

              delay(1000);

              //String returnData = data;

              String returnData = "";

              returnData = port.readString();

                
              client.println("Content-Length: " + String(returnData.length()));
              client.println("Connection: close");
              client.println();
              client.println(returnData);

              port.flush();
            }
            
            
            // The HTTP response ends with another blank line
            client.println();
            // Break out of the while loop
            break;
          } else { // if you got a newline, then clear currentLine
            currentLine = "";
          }
        } else if (c != '\r') {  // if you got anything else but a carriage return character,
          currentLine += c;      // add it to the end of the currentLine
        }
      }
    }
    // Clear the header variable
    headerS = "";
    // Close the connection
    //client.stop();
    //Serial.println("Client disconnected.");
    //Serial.println("");
  }
  
  while(Serial.available() > 0) {
   myChar = Serial.read();
   myStr += myChar;
   delay(10);
  }
   
  if(WiFi.status() != WifiStatus){
    if(WiFi.status() == WL_CONNECTED){
      Serial.println("WI");
      Serial.println("I" + (String)WiFi.localIP()[0] + "." + (String)WiFi.localIP()[1] + "." + (String)WiFi.localIP()[2] + "." + (String)WiFi.localIP()[3]);
    }else{
      Serial.println("WO");
    }
    WifiStatus = WiFi.status();
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
  }else if(myStr[0] == 'W'){
    String serialInput = myStr.substring(2);
    String serialSsid = "", serialPass = "";
    int i=0;

    for(; serialInput[i] != '/'; i++){
      serialSsid += serialInput[i];
    }

    for(++i; i<serialInput.length()-1; i++){
      serialPass += serialInput[i];
    }

    WifiSsid = serialSsid;
    WifiPass = serialPass;
    
    WiFi.begin(serialSsid, serialPass);
    Serial.println("I" + (String)WiFi.localIP()[0] + "." + (String)WiFi.localIP()[1] + "." + (String)WiFi.localIP()[2] + "." + (String)WiFi.localIP()[3]);
    server.begin();
  }else if(myStr[0] == 'E'){
    String thresh = myStr.substring(1);
    String dataToSend = "E";
    dataToSend += thresh;
    
    for(int i=0; i<dataToSend.length(); i++){
      port.write(dataToSend[i]);
    }
    Serial.println(">"+dataToSend);
  }else if(myStr[0] == 'e'){
    String thresh = myStr.substring(1);
    String dataToSend = "e";
    dataToSend += thresh;
    
    for(int i=0; i<dataToSend.length(); i++){
      port.write(dataToSend[i]);
    }
    Serial.println(dataToSend);
  }
   
    if (myStr.length() > 0 && !Serial.available()) {
      myStr="";
      serialFlush();
    }
 }
