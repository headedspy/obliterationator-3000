using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CashApp{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
            customPizzaPanel.Visible = false;
            ordersPanel.Visible = false;
        }

        string uri = "";

        private void connectButton_Click(object sender, EventArgs e){
            outputText.Text = "";
            uri = "http://" + IPtextBox.Text + "/db:80";

            string res = POSTrequest("H");

            if (res != "S") {
                connectionPanel.BackColor = Color.Red;
            } else {
                connectionPanel.BackColor = Color.Green;
            }
        }

        private string POSTrequest(string postData){
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

        private void newOrderButton_Click(object sender, EventArgs e){
            newOrderButton.BackgroundImage = Properties.Resources.main_buttons_hover;
            newPizzaButton.BackgroundImage = Properties.Resources.main_buttons;
            ordersButton.BackgroundImage = Properties.Resources.main_buttons;
            newOrderPanel.Visible = true;
            customPizzaPanel.Visible = false;
            ordersPanel.Visible = false;
        }

        private void newPizzaButton_Click(object sender, EventArgs e){
            newOrderButton.BackgroundImage = Properties.Resources.main_buttons;
            newPizzaButton.BackgroundImage = Properties.Resources.main_buttons_hover;
            ordersButton.BackgroundImage = Properties.Resources.main_buttons;
            customPizzaPanel.Visible = true;
            newOrderPanel.Visible = false;
            ordersPanel.Visible = false;
        }



        private void ordersButton_Click(object sender, EventArgs e){
            newOrderButton.BackgroundImage = Properties.Resources.main_buttons;
            newPizzaButton.BackgroundImage = Properties.Resources.main_buttons;
            ordersButton.BackgroundImage = Properties.Resources.main_buttons_hover;
            ordersPanel.Visible = true;
            newOrderPanel.Visible = false;
            customPizzaPanel.Visible = false;
        }

        private void refreshPizzasButton_Click(object sender, EventArgs e){
            pizzasListBox.Items.Clear();
            String serverData = POSTrequest("P!");

            String[] pizzas = serverData.Split('\n');

            foreach(String pizza in pizzas) {
                if (pizza == "") continue;
                String[] pizzaInfo = pizza.Split('|');
                pizzasListBox.Items.Add(pizzaInfo[0].PadRight(4) + pizzaInfo[1].PadRight(7) + pizzaInfo[2]);
            }
        }

        private void clientNumInc_Click(object sender, EventArgs e){
            clientNum.Text = (Convert.ToInt32(clientNum.Text) + 1).ToString();
        }

        private void clientNumDec_Click(object sender, EventArgs e){
            clientNum.Text = (Convert.ToInt32(clientNum.Text) - 1 < 0 ? 0 : Convert.ToInt32(clientNum.Text) - 1).ToString();
        }

        private void smallButton_Click(object sender, EventArgs e){
            sizeLabel.Text = "Small";
        }

        private void mediumButton_Click(object sender, EventArgs e){
            sizeLabel.Text = "Medium";
        }

        private void largeButton_Click(object sender, EventArgs e){
            sizeLabel.Text = "Large";
        }

        private void createOrderButton_Click(object sender, EventArgs e){
            String selectedPizza = "";
            try {
                selectedPizza = pizzasListBox.SelectedItem.ToString();
            }catch(NullReferenceException) {
                outputText.Text = "Select a pizza!";
                return;
            }

            String selectedPizzaID = selectedPizza.Substring(0, selectedPizza.IndexOf(' '));

            String size = "1";

            if (sizeLabel.Text == "Medium") size = "2";
            else if (sizeLabel.Text == "Large") size = "3";

            String currentTime = DateTime.Now.ToString("hhmm");

            String serverData = ">O/" + clientNum.Text + "/" + selectedPizzaID + "/" + size + "/" + currentTime + "?";

            String serverRes = POSTrequest(serverData);

            outputText.Text = serverRes;
        }

        private void refreshIngredientsButton_Click(object sender, EventArgs e){
            ingredientsListBox.Items.Clear();
            String serverData = POSTrequest("I!");

            String[] ingredients = serverData.Split('\n');

            foreach(String ingredient in ingredients) {
                if (ingredient == "") continue;
                String newIngredient = ingredient.Split('|')[1];
                if(!ingredientsListBox.Items.Contains(newIngredient))ingredientsListBox.Items.Add(newIngredient);
            }
        }

        private void showPizzasButton_Click(object sender, EventArgs e){
            pizzasListBoxForSelection.Items.Clear();
            String serverData = POSTrequest("P!");

            String[] pizzas = serverData.Split('\n');

            foreach (String pizza in pizzas) {
                if (pizza == "") continue;
                String[] pizzaInfo = pizza.Split('|');
                pizzasListBoxForSelection.Items.Add(pizzaInfo[0].PadRight(6) + pizzaInfo[2]);
            }
        }

        private void showSelectedIngredients_Click(object sender, EventArgs e){
            ingredientsListBox.Items.Clear();
            String selectedPizza = "";

            try {
                selectedPizza = pizzasListBoxForSelection.SelectedItem.ToString();
            } catch (NullReferenceException) {
                outputText.Text = "Select a pizza!";
                return;
            }

            String pizzaID = selectedPizza.Substring(0, selectedPizza.IndexOf(' '));

            String serverData = POSTrequest("I!");

            String[] ingredients = serverData.Split('\n');

            foreach (String ingredient in ingredients) {
                if (ingredient == "") continue;

                if (ingredient.Substring(ingredient.IndexOf('|')).Contains(pizzaID)) {
                    String ingredientName = ingredient.Split('|')[1];
                    if(!ingredientsListBox.Items.Contains(ingredientName))ingredientsListBox.Items.Add(ingredientName);
                }
            }
        }

        private void newIngredientButton_Click(object sender, EventArgs e){
            String ingredientName = newIngredient.Text;
            if(ingredientName.Length != 3) {
                outputText.Text = "Ingredient name should consist of 3 characters!";
                return;
            }

            if (!newIngredientsListBox.Items.Contains(ingredientName)) newIngredientsListBox.Items.Add(ingredientName);
            else outputText.Text = "Ingredient " + ingredientName + " already added!";
        }

        private void removeIngredientButton_Click(object sender, EventArgs e){
            newIngredientsListBox.Items.Remove(newIngredientsListBox.SelectedItem);
        }

        private void createPizzaButton_Click(object sender, EventArgs e){
            
            try {
                float.Parse(pizzaPriceBox.Text);
            } catch (FormatException) {
                outputText.Text = "Input valid price";
                return;
            }

            if(pizzaNameBox.Text.Length != 3) {
                outputText.Text = "The pizza name should consist of 3 characters!";
                return;
            }

            List<String> ingredients = new List<String>();

            foreach(String checkedItem in ingredientsListBox.CheckedItems) {
                ingredients.Add(checkedItem);
            }

            foreach(String newItem in newIngredientsListBox.Items) {
                ingredients.Add(newItem);
            }


            String sendData = ">P/" + pizzaPriceBox.Text + "/" + pizzaNameBox.Text + "?";
            String serverData = POSTrequest(sendData);
            

            String newPizzaID = serverData.Split('|')[0].Split(' ')[2];

            foreach(String ingredient in ingredients) {
                String data = ">I/" + ingredient + "/" + newPizzaID + "?";
                outputText.Text = POSTrequest(data);
            }

        }

        private void refreshButton_Click(object sender, EventArgs e){
            orderListBox.Items.Clear();

            String serverData = POSTrequest("O!");

            String[] orders = serverData.Split('\n');

            String[] pizzas = POSTrequest("P!").Split('\n');

            foreach(String order in orders) {
                if (order == "") continue;
                String[] orderData = order.Split('|');


                String status = "Ordered";

                if (orderData[1] == "1") status = "Preparing";
                if (orderData[2] == "1") status = "Baking";
                if (orderData[3] == "1") status = "Finished";


                if (!allOrders.Checked && !order.Contains("NRDY")) continue;

                String pizzaName = "ERROR";

                foreach(String pizza in pizzas) {
                    if (pizza == "") continue;
                    if (pizza.Split('|')[0].Equals(orderData[5])) {
                        pizzaName = pizza.Split('|')[2];
                        break;
                    }
                }

                String timeFinished = orderData[8];
                if (!timeFinished.Contains("NRDY")) timeFinished = orderData[8].Substring(0, 2) + ":" + orderData[8].Substring(2, 2);
                else timeFinished = "Not Ready";

                String pizzaSize = "Small";

                if (orderData[6] == "2") pizzaSize = "Medium";
                if (orderData[6] == "3") pizzaSize = "Large";

                orderListBox.Items.Add(orderData[0].PadRight(3) +
                                       status.PadRight(10) +
                                       orderData[4].PadRight(6) +
                                       pizzaName.PadRight(10) +
                                       pizzaSize.PadRight(10) +
                                       (orderData[7].Substring(0, 2) + ":" + orderData[7].Substring(2, 2)).PadRight(10) +
                                       timeFinished.PadRight(10));
            }
        }

        private void button1_Click(object sender, EventArgs e){
            String selectedOrder = "";
            try {
                selectedOrder = orderListBox.SelectedItem.ToString();
            } catch (NullReferenceException) {
                outputText.Text = "Select and order!";
                return;
            }

            if (!selectedOrder.Contains("Finished")) { 
                outputText.Text = "You can only complete an order if it finished baking!";
                return;
            }

            String serverSend = "~O/" + selectedOrder.Substring(0, selectedOrder.IndexOf(' ')) + "/T/" + DateTime.Now.ToString("hhmm") + "?";

            outputText.Text = POSTrequest(serverSend);
        }

        private void sendOrderAgainButton_Click(object sender, EventArgs e){
            String selectedOrder = "";
            try {
                selectedOrder = orderListBox.SelectedItem.ToString();
            } catch (NullReferenceException) {
                outputText.Text = "Select and order!";
                return;
            }

            if (selectedOrder.Contains("NRDY")) {
                outputText.Text = "Complete the order before sending it again!";
                return;
            }

            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);
            selectedOrder = regex.Replace(selectedOrder, " ");

            String[] selectedOrderData = selectedOrder.Split(' ');

            String[] pizzas = POSTrequest("P!").Split('\n');

            String pizzaID = "ERR";

            foreach (String pizza in pizzas) {
                if (pizza.Contains(selectedOrderData[3])) {
                    pizzaID = pizza.Substring(0, pizza.IndexOf('|'));
                    break;
                }
            }

            if (pizzaID == "ERR") {
                outputText.Text = "Pizza not found!";
                return;
            }

            String size = "1";
            if (selectedOrderData[4] == "Medium") size = "2";
            if (selectedOrderData[4] == "Large") size = "3";

            String serverSend = ">O/" + selectedOrderData[2] + "/" + pizzaID + "/" + size + "/" + DateTime.Now.ToString("hhmm") + "?";

            outputText.Text = POSTrequest(serverSend);
        }

        private void button3_Click(object sender, EventArgs e){
            String[] orders = POSTrequest("O!").Split('\n');

            foreach(String order in orders) {
                if (order == "") continue;

                outputText.Text = POSTrequest("#O/" + order.Split('|')[0] + "?");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
