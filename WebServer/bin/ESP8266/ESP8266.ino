#include <ESP8266WiFi.h>

const char* ssid = "WiFi 5-506";
const char* pass = "";

WiFiServer server(80);

String header;

unsigned long currentTime = millis();
unsigned long previousTime = 0;

const long timeoutTime = 2000;

void setup() {
  Serial.begin(115200);

  WiFi.begin(ssid, pass);
  while(WiFi.status() != WL_CONNECTED)delay(500);

  Serial.println(WiFi.localIP());
  server.begin();
}

void loop() {
  WiFiClient client = server.available();

  if(client){
    Serial.println("New client");
    String currentLine = "";

    previousTime = currentTime;
    currentTime = millis();

    while(client.connected() && currentTime - previousTime <= timeoutTime){
      currentTime = millis();

      if(client.available()){
        char c = client.read();
        Serial.write(c);

        header += c;

        if(c == '\n'){
          if(currentLine.length() == 0){
            client.println("HTTP/1.1 200 OK");
            client.println("Content-type:text/html");
            client.println("Connection: close");
            client.println();

            if(header.indexOf("GET /test") >= 0){
              Serial.println("in");
            }

            client.println("<!DOCTYPE html><html>");
            client.println("<head></head>");
            client.println("<body>");
            client.println("<h1>web server</h1>");
            client.println("</body></html>");

            client.println();
            break;
          }else{
            currentLine = "";
          }
        }else if(c != '\r'){
          currentLine += c;
        }
      }
    }
    header = "";
    client.stop();
  }
}
