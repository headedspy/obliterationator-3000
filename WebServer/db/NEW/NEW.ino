#include <SoftwareSerial.h>

#define TRIG1 8
#define ECHO1 9

#define TRIG2 10
#define ECHO2 11

#define BUZZ 3

int DIST_THRESH_1 = 20;
int DIST_THRESH_2 = 20; 

typedef struct{
  int PizzaID;
  float price;
  char name[3];
} Pizza;

typedef struct{
  int OrderID;
  bool isStarted;
  bool isBaking;
  bool isFinished;
  int customerID;
  int pizzaID;
  int pizzaSize;
  char timeCreated[4];
  char timeFinished[4];
} Order;

typedef struct{
  int IngredientID;
  char name[3];
  int pizzaID;
} Ingredient;

int pizzaDBcap = 5;
int pizzaDBsize = 0;
int orderDBcap = 5;
int orderDBsize = 0;
int ingredientDBcap = 5;
int ingredientDBsize = 0;

Pizza* pizzaDB;
Order* orderDB;
Ingredient* ingredientDB;

SoftwareSerial s(5, 6);

bool pizzaPassed1 = false, pizzaPassed2 = false;
unsigned long sensTimer;

void setup() {
  Serial.begin(9600);
  while(!Serial);
  s.begin(9600);
  while(!s);

  pizzaDB = (Pizza*) malloc(pizzaDBcap * sizeof(Pizza));
  orderDB = (Order*) malloc(orderDBcap * sizeof(Order));
  ingredientDB = (Ingredient*) malloc(ingredientDBcap * sizeof(Ingredient));

  pinMode(TRIG1, OUTPUT);
  pinMode(ECHO1, INPUT);
  pinMode(TRIG2, OUTPUT);
  pinMode(ECHO2, INPUT);
  
  digitalWrite(TRIG1, LOW);
  digitalWrite(TRIG2, LOW);

  pinMode(BUZZ, OUTPUT);

  pinMode(LED_BUILTIN, OUTPUT);
  sensTimer = millis();
}

String data = "";


  int duration1, duration2;
  float distance1, distance2;

void loop() {
  
  if(millis() - sensTimer < 1500){
    digitalWrite(TRIG1, HIGH);
    delayMicroseconds(10);
    digitalWrite(TRIG1, LOW);
    
    duration1 = pulseIn(ECHO1, HIGH);
    
    distance1 = duration1*0.0343/2;
    
  }else if(millis() - sensTimer > 1500){
    digitalWrite(TRIG2, HIGH);
    delay(10);
    digitalWrite(TRIG2, LOW);

    duration2 = pulseIn(ECHO2, HIGH);
    
    distance2 = duration2*0.0343/2;
    
    sensTimer = millis();
  }

  if(distance1 != 0.0 && distance1 < (float)DIST_THRESH_1){
    if(!pizzaPassed1){
      Serial.println("D1 ACTIVE");

      for(int i=0; i<orderDBsize; i++){
        if(orderDB[i].isStarted && !orderDB[i].isBaking){
          orderDB[i].isBaking = true;
          break;
        }
      }
    }
    pizzaPassed1 = true;
  }else{
    pizzaPassed1 = false;
  }

  if(distance2 != 0.0 && distance2 < (float)DIST_THRESH_2){
    if(!pizzaPassed2){
      Serial.println("D2 ACTIVE");

      for(int i=0; i<orderDBsize; i++){
        if(orderDB[i].isStarted && orderDB[i].isBaking && !orderDB[i].isFinished){
          tone(BUZZ, 1000, 1000);
          orderDB[i].isFinished = true;
          break;
        }
      }
    }
    pizzaPassed2 = true;
  }else{
    pizzaPassed2 = false;
  }
  
  if(s.available() >= 0)data = s.readString();
  data.trim();
  Serial.println(data);
  Serial.println("D1>"+String(distance1));
  Serial.println("D2>"+String(distance2));

  if(data[0]=='E'){
    int thresh = data.substring(1).toInt();

    DIST_THRESH_1 = thresh;
    data = "";
    return;
  }else if(data[0]=='e'){
    int thresh = data.substring(1).toInt();

    DIST_THRESH_2 = thresh;
    data = "";
    return;
  }else if(data == "H"){
    while(s.availableForWrite() != 0);
    s.write('S');
    data = "";
    return;
  }

  if(data.endsWith("?")){
    data.trim();
    
    char dataArr[data.length()];
    data.toCharArray(dataArr, data.length());
    
    if(dataArr[0] == '>'){
      if(dataArr[1] == 'P'){
        String pPrice, pName;
        byte counter = 0;
        
        char *pch;
        pch = strtok(dataArr+2, "/");
        
        while(pch != NULL){
          if(counter == 0)pPrice = pch;
          else if(counter == 1)pName = pch;
          
          pch = strtok(NULL, "/");
          counter++;
        }
        counter = 0;
        
        float pPriceFloat = pPrice.toFloat();
        char pNameArr[3] = {pName[0], pName[1], pName[2]};

        Pizza *ptr = NULL;
        ptr = pizzaDB + pizzaDBsize;

        ptr->PizzaID = pizzaDBsize;
        ptr->price = pPriceFloat;
        ptr->name[0] = pNameArr[0];
        ptr->name[1] = pNameArr[1];
        ptr->name[2] = pNameArr[2];

        s.print("CREATED PIZZA " + String(pizzaDB[pizzaDBsize].PizzaID) + "|" + String(pizzaDB[pizzaDBsize].price) + "|");
        s.print(pizzaDB[pizzaDBsize].name[0]);
        s.print(pizzaDB[pizzaDBsize].name[1]);
        s.print(pizzaDB[pizzaDBsize].name[2]);
        s.println("");
        
        pizzaDBsize++;
        if(pizzaDBsize == pizzaDBcap-1){
          pizzaDBcap += 5;
          pizzaDB = (Pizza*) realloc(pizzaDB, pizzaDBcap * sizeof(Pizza));
        }
        data = "";

      
      }else if(dataArr[1] == 'I'){
        // new ingredient
        String iName, iPizzaID;
        byte counter = 0;

        char *pch;
        pch = strtok(dataArr+2, "/");

        while(pch != NULL){
          if(counter == 0)iName = pch;
          else if(counter == 1)iPizzaID = pch;

          pch = strtok(NULL, "/");
          counter++;
        }
        counter = 0;

        iPizzaID.trim();
        int iPizzaIDint = iPizzaID.toInt();

        char iNameArr[3] = {iName[0], iName[1], iName[2]};

        Ingredient *ptr = NULL;
        ptr = ingredientDB + ingredientDBsize;

        ptr->IngredientID = ingredientDBsize;
        ptr->name[0] = iNameArr[0];
        ptr->name[1] = iNameArr[1];
        ptr->name[2] = iNameArr[2];
        ptr->pizzaID = iPizzaIDint;

        s.print("CREATED INGREDIENT " + String(ingredientDB[ingredientDBsize].IngredientID) + "|");
        s.print(ingredientDB[ingredientDBsize].name[0]);
        s.print(ingredientDB[ingredientDBsize].name[1]);
        s.print(ingredientDB[ingredientDBsize].name[2]);
        s.print("|" + String(ingredientDB[ingredientDBsize].pizzaID));
        s.println("");

        ingredientDBsize++;
        if(ingredientDBsize == ingredientDBcap-1){
          ingredientDBcap += 5;
          ingredientDB = (Ingredient *) realloc(ingredientDB, ingredientDBcap * sizeof(Ingredient));
        }
        data = "";
        //----------------------------------
      }else if(dataArr[1] == 'O'){
        // new order
        String oCustomerID, oPizzaID, oPizzaSize, oTimeCreated;
        int counter = 0;

        char *pch;
        pch = strtok(dataArr+2, "/");

        while(pch != NULL){
          if(counter == 0)oCustomerID = pch;
          else if(counter == 1)oPizzaID = pch;
          else if(counter == 2)oPizzaSize = pch;
          else if(counter == 3)oTimeCreated = pch;

          pch = strtok(NULL, "/");
          counter++;
        }
        counter = 0;

        oTimeCreated.trim();
        
        int oCustomerIDint = oCustomerID.toInt();
        int oPizzaIDint = oPizzaID.toInt();
        int oPizzaSizeInt = oPizzaSize.toInt();

        Order *ptr = NULL;

        ptr = orderDB + orderDBsize;
        
        ptr->OrderID = orderDBsize;
        ptr->isStarted = false;
        ptr->isBaking = false;
        ptr->isFinished = false;
        ptr->customerID = oCustomerIDint;
        ptr->pizzaID = oPizzaIDint;
        ptr->pizzaSize = oPizzaSizeInt;
        ptr->timeCreated[0] = oTimeCreated[0];
        ptr->timeCreated[1] = oTimeCreated[1];
        ptr->timeCreated[2] = oTimeCreated[2];
        ptr->timeCreated[3] = oTimeCreated[3];
        ptr->timeFinished[0] = 'N';
        ptr->timeFinished[1] = 'R';
        ptr->timeFinished[2] = 'D';
        ptr->timeFinished[3] = 'Y';

        s.print("CREATED ORDER " + String(orderDB[orderDBsize].OrderID) + "|" + String(orderDB[orderDBsize].isStarted) + "|" + String(orderDB[orderDBsize].isBaking) + "|");
        s.print(String(orderDB[orderDBsize].isFinished) + "|" + String(orderDB[orderDBsize].customerID) + "|" + String(orderDB[orderDBsize].pizzaID) + "|" + String(orderDB[orderDBsize].pizzaSize) + "|");
        s.print(orderDB[orderDBsize].timeCreated[0]);
        s.print(orderDB[orderDBsize].timeCreated[1]);
        s.print(orderDB[orderDBsize].timeCreated[2]);
        s.print(orderDB[orderDBsize].timeCreated[3]);
        s.print("|");
        s.print(orderDB[orderDBsize].timeFinished[0]);
        s.print(orderDB[orderDBsize].timeFinished[1]);
        s.print(orderDB[orderDBsize].timeFinished[2]);
        s.print(orderDB[orderDBsize].timeFinished[3]);
        s.println("");

        orderDBsize++;
        if(orderDBsize == orderDBcap-1){
          orderDBcap += 5;
          orderDB = (Order*) realloc(orderDB, orderDBcap * sizeof(Order));
        }
        digitalWrite(9, LOW);
        digitalWrite(8, HIGH);
      }
      data = "";
    }else if(dataArr[0] == '~'){
      int counter = 0;
      String id, col, val;

      char *pch;

      pch = strtok(dataArr+2, "/");

      while(pch != NULL){
        if(counter == 0)id = pch;
        else if(counter == 1){
          col = pch;
          col.trim();
        }
        else if(counter == 2)val = pch;

        pch = strtok(NULL, "/");
        counter++;
      }

      val.trim();
      
      if(dataArr[1] == 'O'){
        for(int i=0; i<orderDBsize; i++){
          if(orderDB[i].OrderID == id.toInt()){
            if(col == "O"){
              s.println("ORDER ID EDITED (" + String(orderDB[i].OrderID) + "->" + val + ")");
              orderDB[i].OrderID = val.toInt();
            }else if(col == "S"){
              s.println("ORDER STARTED STATE EDITED (" + String(orderDB[i].isStarted ? "true" : "false") + "->" + val + ")");
              orderDB[i].isStarted = val == "0" ? false : true;
            }else if(col == "B"){
              s.println("ORDER BAKING STATE EDITED (" + String(orderDB[i].isBaking ? "true" : "false") + "->" + val + ")");
              orderDB[i].isBaking = val == "0" ? false : true;
            }else if(col == "F"){
              s.println("ORDER FINISHED STATE EDITED (" + String(orderDB[i].isFinished ? "true" : "false") + "->" + val + ")");
              orderDB[i].isFinished = val == "0" ? false : true;
            }else if(col == "C"){
              s.println("ORDER CUSTOMER ID EDITED (" + String(orderDB[i].customerID) + "->" + val + ")");
              orderDB[i].customerID = val.toInt();
            }else if(col == "p"){
              s.println("ORDER PIZZA ID EDITED (" + String(orderDB[i].pizzaID) + "->" + val + ")");
              orderDB[i].pizzaID = val.toInt();
            }else if(col == "P"){
              s.println("ORDER PIZZA SIZE EDITED (" + String(orderDB[i].pizzaSize) + "->" + val + ")");
              orderDB[i].pizzaSize = val.toInt();
            }else if(col == "t"){
              s.print("ORDER TIME CREATED EDITED (");
              s.print(orderDB[i].timeCreated[0]);
              s.print(orderDB[i].timeCreated[1]);
              s.print(orderDB[i].timeCreated[2]);
              s.print(orderDB[i].timeCreated[3]);
              s.println("->" + val + ")");
              
              orderDB[i].timeCreated[0] = val[0];
              orderDB[i].timeCreated[1] = val[1];
              orderDB[i].timeCreated[2] = val[2];
              orderDB[i].timeCreated[3] = val[3];
            }else if(col == "T"){
              s.print("ORDER TIME FINISHED EDITED (");
              s.print(orderDB[i].timeFinished[0]);
              s.print(orderDB[i].timeFinished[1]);
              s.print(orderDB[i].timeFinished[2]);
              s.print(orderDB[i].timeFinished[3]);
              s.println(" -> " + val + ")");
              
              orderDB[i].timeFinished[0] = val[0];
              orderDB[i].timeFinished[1] = val[1];
              orderDB[i].timeFinished[2] = val[2];
              orderDB[i].timeFinished[3] = val[3];
            }
            break;
          }
        }
      }else if(dataArr[1] == 'P'){
        for(int i=0; i<pizzaDBsize; i++){
          if(pizzaDB[i].PizzaID == id.toInt()){
            if(col == "P"){
              s.println("PIZZA ID EDITED (" + String(pizzaDB[i].PizzaID) + "->" + val + ")");
              pizzaDB[i].PizzaID = val.toInt();
            }else if(col == "p"){
              s.println("PIZZA PRICE EDITED (" + String(pizzaDB[i].price) + "->" + val + ")");
              pizzaDB[i].price = val.toFloat();
            }else if(col == "N"){
              s.print("PIZZA NAME EDITED (");
              s.print(pizzaDB[i].name[0]);
              s.print(pizzaDB[i].name[1]);
              s.print(pizzaDB[i].name[2]);
              s.println("->" + val + ")");
              pizzaDB[i].name[0] = val[0];
              pizzaDB[i].name[1] = val[1];
              pizzaDB[i].name[2] = val[2];
            }
          }
        }
      }else if(dataArr[1] == 'I'){
        for(int i=0; i<ingredientDBsize; i++){
          if(ingredientDB[i].IngredientID == id.toInt()){
            if(col == "I"){
              s.println("INGREDIENT ID EDITED (" + String(ingredientDB[i].IngredientID) + "->" + val + ")");
              ingredientDB[i].IngredientID = val.toInt();
            }else if(col == "N"){
              s.print("INGREDIENT NAME EDITED (");
              s.print(ingredientDB[i].name[0]);
              s.print(ingredientDB[i].name[1]);
              s.print(ingredientDB[i].name[2]);
              s.println("->" + val + ")");
              ingredientDB[i].name[0] = val[0];
              ingredientDB[i].name[1] = val[1];
              ingredientDB[i].name[2] = val[2];
            }else if(col == "P"){
              s.println("INGREDIENT PIZZA ID EDITED (" + String(ingredientDB[i].pizzaID) + "->" + val + ")");
              ingredientDB[i].pizzaID = val.toInt();
            }
          }
        }
      }
    }else if(dataArr[0] == '#'){
      String id = "";

      id = dataArr+3;
      id.trim();

      int idAsInt = id.toInt();
      
      if(dataArr[1] == 'O'){
        bool found = false;

        for(int i=0; i<orderDBsize; i++){
          if(orderDB[i].OrderID == idAsInt){
            s.println("DELETE ORDER " + id);
            found = true;

            for(int ii=0; ii<orderDBsize; ii++){
              orderDB[ii+1].OrderID = ii;
              orderDB[ii] = orderDB[ii+1];
            }

            break;
          }
        }

        if(found){
          orderDBsize--;
          orderDB = (Order*) realloc(orderDB, orderDBsize * sizeof(Order));
        }
      }else if(dataArr[1] == 'P'){
        bool found = false;
        
        for(int i=0; i<pizzaDBsize; i++){
          if(pizzaDB[i].PizzaID == idAsInt){
            s.println("DELETE PIZZA " + id);
            found = true;
            
            for(int ii=i; ii<pizzaDBsize; ii++){
              pizzaDB[ii] = pizzaDB[ii+1];
            }

            for(int ii=0; ii<ingredientDBsize; ii++){
              if(ingredientDB[ii].pizzaID == idAsInt){
                ingredientDB[ii].pizzaID = -1;
              }
            }

            for(int ii=0; ii<orderDBsize; ii++){
              if(orderDB[ii].pizzaID == idAsInt){
                orderDB[ii].pizzaID = -1;
              }
            }
            
            for(int ii=0; ii<pizzaDBsize; ii++){
              
              int oldID = pizzaDB[ii].PizzaID;
              pizzaDB[ii].PizzaID = ii;

              for(int iii=0; iii<ingredientDBsize; iii++){
                if(ingredientDB[iii].pizzaID == oldID){
                  ingredientDB[iii].pizzaID = ii;
                }
              }

              for(int iii=0; iii<orderDBsize; iii++){
                if(orderDB[iii].pizzaID == oldID){
                  orderDB[iii].pizzaID = ii;
                }
              }
            }
            break;
          }
        }
        if(found){
          pizzaDBsize--;
          pizzaDB = (Pizza*) realloc(pizzaDB, pizzaDBsize * sizeof(Pizza));
        }
      }else if(dataArr[1] == 'I'){
        bool found = false;

        for(int i=0; i<ingredientDBsize; i++){
          if(ingredientDB[i].IngredientID == idAsInt){
            s.println("DELETE INGREDIENT " + id);
            found = true;

            for(int ii=i; ii<ingredientDBsize; ii++){
              ingredientDB[ii+1].IngredientID = ii;
              ingredientDB[ii] = ingredientDB[ii+1];
            }
            
            break;
          }
        }
        if(found){
          ingredientDBsize--;
          ingredientDB = (Ingredient*) realloc(ingredientDB, ingredientDBsize * sizeof(Ingredient));
        }
      }
    }
    data = "";
  }else if(data.endsWith("!")){
    data.trim();
    if(data[0] == 'P'){
      for(int i=0; i<pizzaDBsize; i++){
        //while(s.availableForWrite() != 0);
        s.print(String(pizzaDB[i].PizzaID) + "|" + String(pizzaDB[i].price) + "|");
        //while(s.availableForWrite() != 0);
        s.print(pizzaDB[i].name[0]);
        //while(s.availableForWrite() != 0);
        s.print(pizzaDB[i].name[1]);
        //while(s.availableForWrite() != 0);
        s.print(pizzaDB[i].name[2]);
        //while(s.availableForWrite() != 0);
        s.println("");
      }
    }else if(data[0] == 'I'){
      for(int i=0; i<ingredientDBsize; i++){
        s.print(String(ingredientDB[i].IngredientID) + "|");
        s.print(ingredientDB[i].name[0]);
        s.print(ingredientDB[i].name[1]);
        s.print(ingredientDB[i].name[2]);
        s.print("|" + String(ingredientDB[i].pizzaID));
        s.println("");
      }
    }else if(data[0] == 'O'){
      for(int i=0; i<orderDBsize; i++){
        s.print(String(orderDB[i].OrderID) + "|" + String(orderDB[i].isStarted) + "|" + String(orderDB[i].isBaking) + "|");
        s.print(String(orderDB[i].isFinished) + "|" + String(orderDB[i].customerID) + "|" + String(orderDB[i].pizzaID) + "|" + String(orderDB[i].pizzaSize) + "|");
        s.print(orderDB[i].timeCreated[0]);
        s.print(orderDB[i].timeCreated[1]);
        s.print(orderDB[i].timeCreated[2]);
        s.print(orderDB[i].timeCreated[3]);
        s.print("|");
        s.print(orderDB[i].timeFinished[0]);
        s.print(orderDB[i].timeFinished[1]);
        s.print(orderDB[i].timeFinished[2]);
        s.print(orderDB[i].timeFinished[3]);
        s.println("");
      }
    }
    data = "";
  }
}
