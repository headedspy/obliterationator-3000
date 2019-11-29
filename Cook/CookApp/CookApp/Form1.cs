using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            createPanel.Visible = false;
        }

        string uri = "";

        private void connectButton_Click(object sender, EventArgs e) {
           
            outputText.Text = "";
            uri = "http://" + IPtextBox.Text + "/db:80";

            string res = POSTrequest("H");

            if (res != "S") {
                connectionPanel.BackColor = Color.Red;
            } else {
                connectionPanel.BackColor = Color.Green;
            }
        }


        private string POSTrequest(string postData) {
            try {
                WebRequest request = WebRequest.Create(uri);
                // Set the Method property of the request to POST.
                request.Method = "POST";
                // Create POST data and convert it to a byte array.
                byte[] buffer = Encoding.UTF8.GetBytes(postData);
                // Set the ContentType property of the WebRequest.
                request.ContentType = "application/x-www-form-urlencoded";
                // Set the ContentLength property of the WebRequest. 
                request.ContentLength = buffer.Length;
                // Get the request stream.
                Stream dataStream = null;
                try {
                    dataStream = request.GetRequestStream();
                } catch (WebException) {
                    outputText.Text = "The remote host name could not be resolved!";
                    return "";
                }
                // Write the data to the request stream.
                dataStream.Write(buffer, 0, buffer.Length);
                // Close the Stream object.
                dataStream.Close();
                // Get the response.           
                WebResponse response = request.GetResponse();
                // Display the status.
                //Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.
                dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Clean up the streams.
                reader.Close();
                dataStream.Close();
                response.Close();

                return responseFromServer;
            } catch (UriFormatException) {
                outputText.Text = "Invalid server address";
                return "";
            }
        }

        private void refreshIngredientsButton_Click(object sender, EventArgs e) {
            ingredientsListBox.Items.Clear();
            String serverData = POSTrequest("I!");

            String[] ingredients = serverData.Split('\n');

            foreach (String ingredient in ingredients) {
                if (ingredient != "") {
                    String[] ingredientData = ingredient.Split('|');
                    String pizzaName = "";
                    foreach (String pizza in pizzasListBox.Items) {
                        if (pizza.Substring(0, pizza.IndexOf(' ')).Equals(ingredientData[2].Trim())) {
                            pizzaName = pizza.Substring(pizza.Length - 4);
                            break;
                        }
                    }

                    ingredientsListBox.Items.Add(ingredientData[0].PadRight(5) + ingredientData[1].PadRight(20) + pizzaName);
                }
            }
        }

        private void refreshPizzasButton_Click(object sender, EventArgs e) {
            pizzasListBox.Items.Clear();
            ingredientPizzaBox.Items.Clear();
            String serverData = POSTrequest("P!");

            String[] pizzas = serverData.Split('\n');

            foreach (String pizza in pizzas) {
                if (pizza != "") {
                    String[] pizzaData = pizza.Split('|');
                    pizzasListBox.Items.Add(pizzaData[0].PadRight(5) + pizzaData[1].PadRight(20) + pizzaData[2]);
                    ingredientPizzaBox.Items.Add(pizza.Substring(pizza.Length - 4));
                }
            }
        }

    private void createPizzaButton_Click(object sender, EventArgs e){
            
            String pizzaName = pizzaNameBox.Text;
            if(pizzaName.Length != 3) {
                outputText.Text = "Pizza name should be 3 characters long!";
                return;
            }

            foreach(String pizza in pizzasListBox.Items) {
                if(pizza.Substring(pizza.Length - 4).Trim().Equals(pizzaName)) {
                    outputText.Text = "Pizza " + pizzaName + " already exists!";
                    return;
                }
            }

            String pizzaPrice = pizzaPriceBox.Text;

            String serverData = POSTrequest(">P/" + pizzaPrice + "/" + pizzaName + "?");

            outputText.Text = serverData;

            refreshPizzasButton_Click(sender, e);
        }

        private void createIngredientButton_Click(object sender, EventArgs e){
            
            String ingredientName = ingredientNameBox.Text;

            if(ingredientName.Length != 3) {
                outputText.Text = "Name should be 3 characters long!";
                return;
            }

            String pizzaName = ingredientPizzaBox.SelectedItem.ToString().Trim();

            foreach(String pizza in pizzasListBox.Items) {
                if(pizza.Substring(pizza.Length - 4).Trim().Equals(pizzaName)) {
                    String pizzaID = pizza.Substring(0, pizza.IndexOf(' '));

                    String serverData = POSTrequest(">I/" + ingredientName + "/" + pizzaID + "?");

                    outputText.Text = serverData;
                    refreshIngredientsButton_Click(sender, e);

                    return;
                }
            }
        }

        private void deletePizzaButton_Click(object sender, EventArgs e){
            String selected = "";

            try {
                selected = pizzasListBox.SelectedItem.ToString();
            } catch (NullReferenceException) {
                outputText.Text = "Select a pizza!";
                return;
            }

            String serverData = "#P/" + selected.Substring(0, selected.IndexOf(' ')) + "?";

            String recData = POSTrequest(serverData);

            outputText.Text = recData;

            refreshPizzasButton_Click(sender, e);
            refreshIngredientsButton_Click(sender, e);
        }

        private void deleteIngredientButton_Click(object sender, EventArgs e){
            String selected = "";

            try {
                selected = ingredientsListBox.SelectedItem.ToString();
            } catch (NullReferenceException) {
                outputText.Text = "Select an ingredient!";
                return;
            }

            String serverData = "#I/" + selected.Substring(0, selected.IndexOf(' ')) + "?";
            String recData = POSTrequest(serverData);

            outputText.Text = recData;

            refreshIngredientsButton_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e){
            
            orderPanel.Visible = false;
            createPanel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e){
            
            orderPanel.Visible = true;
            createPanel.Visible = false;
        }

        private void refreshOrdersButton_Click(object sender, EventArgs e){
            orderListBox.Items.Clear();
            String serverData = POSTrequest("O!");

            if (serverData.Equals("")) return;

            String[] orders = serverData.Split('\n');

            foreach (String order in orders) {
                if (order == "") continue;
                String[] orderData = order.Split('|');

                String pizzaOrdered = "ERR";

                foreach(String pizza in pizzasListBox.Items) {
                    String pizzaID = pizza.Substring(0, pizza.IndexOf(' '));

                    if (pizzaID.Equals(orderData[5])) {
                        pizzaOrdered = pizza.Substring(pizza.Length - 4);
                        break;
                    }
                }

                orderListBox.Items.Add(orderData[0].PadRight(8) +
                                      (orderData[1].Equals("0") ? "false" : "true").PadRight(8) +
                                      (orderData[2].Equals("0") ? "false" : "true").PadRight(7) +
                                      (orderData[3].Equals("0") ? "false" : "true").PadRight(12) +
                                      orderData[4].PadRight(7) +
                                      pizzaOrdered.PadRight(10) +
                                      orderData[6].PadRight(8) +
                                      (orderData[7].Substring(0, 2) + ":" + orderData[7].Substring(2)).PadRight(10) +
                                      (orderData[8].Contains("NRDY") ? "Not Finished" : orderData[8].Substring(0, 2) + ":" + orderData[8].Substring(2)));

            }
        }

        private void beginOrderButton_Click(object sender, EventArgs e){
            String selected = "";

            try {
                selected = orderListBox.SelectedItem.ToString();
            } catch (NullReferenceException) {
                outputText.Text = "Select an order!";
                return;
            }

            String orderID = selected.Substring(0, selected.IndexOf(' '));

            String serverData = "~O/" + orderID + "/S/1?";

            String retData = POSTrequest(serverData);

            outputText.Text = retData;

            refreshOrdersButton_Click(sender, e);
        }

        private void checkIngredientsButton_Click(object sender, EventArgs e) {
            pizzaIngredientsListBox.Items.Clear();
            String pizza = "";

            try {
                pizza = pizzasListBox.SelectedItem.ToString();
            } catch (NullReferenceException) { 
                outputText.Text = "Select a pizza!";
                return;
            }

            String pizzaName = pizza.Substring(pizza.Length - 4).Trim();

            foreach (String ingredient in ingredientsListBox.Items) {
                if(ingredient.Substring(ingredient.Length - 4).Trim().Equals(pizzaName)) {
                    pizzaIngredientsListBox.Items.Add(ingredient.Substring(5, 3));
                }
            }
        }

        private void editPizzaIDButton_Click(object sender, EventArgs e){
            String newValue = editTextBox.Text;

            if(newValue == "") {
                outputText.Text = "Write down a new value!";
                return;
            }

            try {
                Convert.ToInt32(newValue);
            } catch (FormatException) {
                outputText.Text = "Input a valid number!";
                return;
            }

            String selectedPizza = "";
            try {
                selectedPizza = pizzasListBox.SelectedItem.ToString();
            } catch (NullReferenceException) {
                outputText.Text = "Select a pizza!";
                return;
            }

            foreach(String pizza in pizzasListBox.Items) {
                if (pizza.Substring(0, pizza.IndexOf(' ')).Equals(newValue)) {
                    outputText.Text = "Pizza with ID " + newValue + " already exists!";
                    return;
                }
            }
            String selectedPizzaID = selectedPizza.Substring(0, selectedPizza.IndexOf(' '));
            String serverData = "~P/"+selectedPizzaID+"/P/"+newValue+"?";

            String resServer = POSTrequest(serverData);

            outputText.Text = resServer;

            refreshPizzasButton_Click(sender, e);
        }

        private void editPizzaPriceButton_Click(object sender, EventArgs e){
            String newValue = editTextBox.Text;

            if (newValue == "") {
                outputText.Text = "Write down a new value!";
                return;
            }

            try {
                float.Parse(newValue);
            } catch (FormatException) {
                outputText.Text = "Input a valid number!";
                return;
            }

            String selectedPizza = "";
            try {
                selectedPizza = pizzasListBox.SelectedItem.ToString();
            } catch (NullReferenceException) {
                outputText.Text = "Select a pizza!";
                return;
            }
            
            String selectedPizzaID = selectedPizza.Substring(0, selectedPizza.IndexOf(' '));
            String serverData = "~P/" + selectedPizzaID + "/p/" + newValue + "?";

            String resServer = POSTrequest(serverData);

            outputText.Text = resServer;

            refreshPizzasButton_Click(sender, e);
        }

        private void editPizzaNameButton_Click(object sender, EventArgs e){
            String newValue = editTextBox.Text;

            if (newValue == "") {
                outputText.Text = "Write down a new value!";
                return;
            }

            if(newValue.Length != 3) {
                outputText.Text = "Name should be 3 characters long!";
                return;
            }

            String selectedPizza = "";
            try {
                selectedPizza = pizzasListBox.SelectedItem.ToString();
            } catch (NullReferenceException) {
                outputText.Text = "Select a pizza!";
                return;
            }

            String selectedPizzaID = selectedPizza.Substring(0, selectedPizza.IndexOf(' '));
            String serverData = "~P/" + selectedPizzaID + "/N/" + newValue + "?";

            String resServer = POSTrequest(serverData);

            outputText.Text = resServer;

            refreshPizzasButton_Click(sender, e);
        }

        private void editIngredientIDButton_Click(object sender, EventArgs e){
            String newValue = editTextBox.Text;

            if (newValue == "") {
                outputText.Text = "Write down a new value!";
                return;
            }

            try {
                Convert.ToInt32(newValue);
            } catch (FormatException) {
                outputText.Text = "Input a valid number!";
                return;
            }

            String selectedIngredient = "";
            try {
                selectedIngredient = ingredientsListBox.SelectedItem.ToString();
            } catch (NullReferenceException) {
                outputText.Text = "Select an ingredient!";
                return;
            }

            foreach (String ingredient in ingredientsListBox.Items) {
                if (ingredient.Substring(0, ingredient.IndexOf(' ')).Equals(newValue)) {
                    outputText.Text = "Ingredient with ID " + newValue + " already exists!";
                    return;
                }
            }
            String selectedIngredientID = selectedIngredient.Substring(0, selectedIngredient.IndexOf(' '));
            String serverData = "~I/" + selectedIngredientID + "/I/" + newValue + "?";

            String resServer = POSTrequest(serverData);

            outputText.Text = resServer;

            refreshIngredientsButton_Click(sender, e);
        }

        private void editIngredientPizzaButton_Click(object sender, EventArgs e){
            String newValue = editTextBox.Text;
            String pizzaID = "";

            foreach(String pizza in pizzasListBox.Items) {
                if(pizza.Substring(pizza.Length - 4).Trim().Equals(newValue)) {
                    pizzaID = pizza.Substring(0, pizza.IndexOf(' '));
                    break;
                }
            }

           if(pizzaID == "") {
                outputText.Text = "Pizza " + newValue + " doesn't exist!";
                return;
           }

            String selectedIngredient = "";
            try {
                selectedIngredient = ingredientsListBox.SelectedItem.ToString();
            } catch (NullReferenceException) {
                outputText.Text = "Select an ingredient!";
                return;
            }
            
            String selectedIngredientID = selectedIngredient.Substring(0, selectedIngredient.IndexOf(' '));

            String serverData = "~I/" + selectedIngredientID + "/P/" + pizzaID + "?";

            String resServer = POSTrequest(serverData);

            outputText.Text = resServer;

            refreshIngredientsButton_Click(sender, e);
        }

        private void editIngredientNameButton_Click(object sender, EventArgs e){
            String newValue = editTextBox.Text;

            if(newValue.Length != 3) {
                outputText.Text = "Name should be 3 characters long!";
                return;
            }

            String selectedIngredient = "";
            try {
                selectedIngredient = ingredientsListBox.SelectedItem.ToString();
            } catch (NullReferenceException) {
                outputText.Text = "Select an ingredient!";
                return;
            }

            String selectedIngredientID = selectedIngredient.Substring(0, selectedIngredient.IndexOf(' '));

            String serverData = "~I/" + selectedIngredientID + "/N/" + newValue + "?";

            String resServer = POSTrequest(serverData);

            outputText.Text = resServer;

            refreshIngredientsButton_Click(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
