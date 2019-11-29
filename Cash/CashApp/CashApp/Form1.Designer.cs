namespace CashApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ordersPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sendOrderAgainButton = new System.Windows.Forms.Button();
            this.allOrders = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.newOrderPanel = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.smallButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            this.largeButton = new System.Windows.Forms.Button();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.clientNum = new System.Windows.Forms.Label();
            this.clientNumDec = new System.Windows.Forms.Button();
            this.clientNumInc = new System.Windows.Forms.Button();
            this.refreshPizzasButton = new System.Windows.Forms.Button();
            this.pizzasListBox = new System.Windows.Forms.ListBox();
            this.customPizzaPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.showSelectedIngredientsButton = new System.Windows.Forms.Button();
            this.showPizzasButton = new System.Windows.Forms.Button();
            this.pizzasListBoxForSelection = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ingredientsListBox = new System.Windows.Forms.CheckedListBox();
            this.refreshIngredientsButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.newIngredientsListBox = new System.Windows.Forms.ListBox();
            this.newIngredient = new System.Windows.Forms.TextBox();
            this.newIngredientButton = new System.Windows.Forms.Button();
            this.removeIngredientButton = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.createPizzaButton = new System.Windows.Forms.Button();
            this.pizzaPriceBox = new System.Windows.Forms.TextBox();
            this.pizzaNameBox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.newPizzaButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.connectionPanel = new System.Windows.Forms.Panel();
            this.IPtextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.ordersPanel.SuspendLayout();
            this.newOrderPanel.SuspendLayout();
            this.panel9.SuspendLayout();
            this.customPizzaPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputText
            // 
            this.outputText.AutoSize = true;
            this.outputText.Location = new System.Drawing.Point(148, 531);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(0, 13);
            this.outputText.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.BackgroundImage = global::CashApp.Properties.Resources.right_control_order_list_background;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.ordersPanel);
            this.panel2.Controls.Add(this.newOrderPanel);
            this.panel2.Controls.Add(this.customPizzaPanel);
            this.panel2.Location = new System.Drawing.Point(253, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 510);
            this.panel2.TabIndex = 13;
            // 
            // ordersPanel
            // 
            this.ordersPanel.BackColor = System.Drawing.Color.Transparent;
            this.ordersPanel.BackgroundImage = global::CashApp.Properties.Resources.central_control_background;
            this.ordersPanel.Controls.Add(this.button3);
            this.ordersPanel.Controls.Add(this.label3);
            this.ordersPanel.Controls.Add(this.sendOrderAgainButton);
            this.ordersPanel.Controls.Add(this.allOrders);
            this.ordersPanel.Controls.Add(this.button1);
            this.ordersPanel.Controls.Add(this.refreshButton);
            this.ordersPanel.Controls.Add(this.orderListBox);
            this.ordersPanel.Location = new System.Drawing.Point(17, 11);
            this.ordersPanel.Name = "ordersPanel";
            this.ordersPanel.Size = new System.Drawing.Size(617, 488);
            this.ordersPanel.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::CashApp.Properties.Resources.main_buttons;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(262, 433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 32);
            this.button3.TabIndex = 18;
            this.button3.Text = "Finish Day (Delete all Orders)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "ID     State    Customer Nr    Pizza           Size           Time Ordered       " +
    " Time Completed";
            // 
            // sendOrderAgainButton
            // 
            this.sendOrderAgainButton.BackgroundImage = global::CashApp.Properties.Resources.main_buttons;
            this.sendOrderAgainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendOrderAgainButton.FlatAppearance.BorderSize = 0;
            this.sendOrderAgainButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.sendOrderAgainButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.sendOrderAgainButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sendOrderAgainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendOrderAgainButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendOrderAgainButton.Location = new System.Drawing.Point(87, 368);
            this.sendOrderAgainButton.Name = "sendOrderAgainButton";
            this.sendOrderAgainButton.Size = new System.Drawing.Size(102, 32);
            this.sendOrderAgainButton.TabIndex = 16;
            this.sendOrderAgainButton.Text = "Send Order Again";
            this.sendOrderAgainButton.UseVisualStyleBackColor = true;
            this.sendOrderAgainButton.Click += new System.EventHandler(this.sendOrderAgainButton_Click);
            // 
            // allOrders
            // 
            this.allOrders.AutoSize = true;
            this.allOrders.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allOrders.Location = new System.Drawing.Point(553, 34);
            this.allOrders.Name = "allOrders";
            this.allOrders.Size = new System.Drawing.Size(48, 25);
            this.allOrders.TabIndex = 15;
            this.allOrders.Text = "All";
            this.allOrders.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CashApp.Properties.Resources.main_buttons;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(232, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Complete Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImage = global::CashApp.Properties.Resources.main_buttons;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.FlatAppearance.BorderSize = 0;
            this.refreshButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.refreshButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.refreshButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(433, 369);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(102, 31);
            this.refreshButton.TabIndex = 13;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // orderListBox
            // 
            this.orderListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orderListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.ItemHeight = 14;
            this.orderListBox.Location = new System.Drawing.Point(87, 32);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(448, 326);
            this.orderListBox.TabIndex = 12;
            // 
            // newOrderPanel
            // 
            this.newOrderPanel.BackColor = System.Drawing.Color.Transparent;
            this.newOrderPanel.BackgroundImage = global::CashApp.Properties.Resources.central_control_background;
            this.newOrderPanel.Controls.Add(this.panel9);
            this.newOrderPanel.Controls.Add(this.sizeLabel);
            this.newOrderPanel.Controls.Add(this.createOrderButton);
            this.newOrderPanel.Controls.Add(this.clientNum);
            this.newOrderPanel.Controls.Add(this.clientNumDec);
            this.newOrderPanel.Controls.Add(this.clientNumInc);
            this.newOrderPanel.Controls.Add(this.refreshPizzasButton);
            this.newOrderPanel.Controls.Add(this.pizzasListBox);
            this.newOrderPanel.Location = new System.Drawing.Point(17, 15);
            this.newOrderPanel.Name = "newOrderPanel";
            this.newOrderPanel.Size = new System.Drawing.Size(617, 484);
            this.newOrderPanel.TabIndex = 4;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BackgroundImage = global::CashApp.Properties.Resources.b1;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Controls.Add(this.smallButton);
            this.panel9.Controls.Add(this.mediumButton);
            this.panel9.Controls.Add(this.largeButton);
            this.panel9.Location = new System.Drawing.Point(101, 11);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(418, 48);
            this.panel9.TabIndex = 10;
            // 
            // smallButton
            // 
            this.smallButton.BackColor = System.Drawing.Color.Transparent;
            this.smallButton.BackgroundImage = global::CashApp.Properties.Resources.Size_buttons_background;
            this.smallButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.smallButton.FlatAppearance.BorderSize = 0;
            this.smallButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.smallButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.smallButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.smallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.smallButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallButton.Location = new System.Drawing.Point(18, 9);
            this.smallButton.Name = "smallButton";
            this.smallButton.Size = new System.Drawing.Size(101, 30);
            this.smallButton.TabIndex = 5;
            this.smallButton.Text = "Small";
            this.smallButton.UseVisualStyleBackColor = false;
            this.smallButton.Click += new System.EventHandler(this.smallButton_Click);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = System.Drawing.Color.Transparent;
            this.mediumButton.BackgroundImage = global::CashApp.Properties.Resources.Size_buttons_background;
            this.mediumButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mediumButton.FlatAppearance.BorderSize = 0;
            this.mediumButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.mediumButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.mediumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mediumButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.Location = new System.Drawing.Point(157, 9);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(101, 30);
            this.mediumButton.TabIndex = 6;
            this.mediumButton.Text = "Medium";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // largeButton
            // 
            this.largeButton.BackColor = System.Drawing.Color.Transparent;
            this.largeButton.BackgroundImage = global::CashApp.Properties.Resources.Size_buttons_background;
            this.largeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.largeButton.FlatAppearance.BorderSize = 0;
            this.largeButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.largeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.largeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.largeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.largeButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeButton.Location = new System.Drawing.Point(302, 9);
            this.largeButton.Name = "largeButton";
            this.largeButton.Size = new System.Drawing.Size(101, 30);
            this.largeButton.TabIndex = 7;
            this.largeButton.Text = "Large";
            this.largeButton.UseVisualStyleBackColor = false;
            this.largeButton.Click += new System.EventHandler(this.largeButton_Click);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.Location = new System.Drawing.Point(278, 62);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(55, 22);
            this.sizeLabel.TabIndex = 9;
            this.sizeLabel.Text = "Small";
            // 
            // createOrderButton
            // 
            this.createOrderButton.BackColor = System.Drawing.Color.Transparent;
            this.createOrderButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createOrderButton.BackgroundImage")));
            this.createOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createOrderButton.FlatAppearance.BorderSize = 0;
            this.createOrderButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.createOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.createOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.createOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createOrderButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createOrderButton.Location = new System.Drawing.Point(220, 425);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(175, 56);
            this.createOrderButton.TabIndex = 8;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = false;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // clientNum
            // 
            this.clientNum.AutoSize = true;
            this.clientNum.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNum.Location = new System.Drawing.Point(294, 88);
            this.clientNum.Name = "clientNum";
            this.clientNum.Size = new System.Drawing.Size(19, 21);
            this.clientNum.TabIndex = 4;
            this.clientNum.Text = "1";
            this.clientNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clientNumDec
            // 
            this.clientNumDec.BackColor = System.Drawing.Color.Transparent;
            this.clientNumDec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clientNumDec.BackgroundImage")));
            this.clientNumDec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clientNumDec.FlatAppearance.BorderSize = 0;
            this.clientNumDec.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.clientNumDec.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clientNumDec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clientNumDec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientNumDec.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNumDec.Location = new System.Drawing.Point(241, 85);
            this.clientNumDec.Name = "clientNumDec";
            this.clientNumDec.Size = new System.Drawing.Size(28, 31);
            this.clientNumDec.TabIndex = 3;
            this.clientNumDec.Text = "<";
            this.clientNumDec.UseVisualStyleBackColor = false;
            this.clientNumDec.Click += new System.EventHandler(this.clientNumDec_Click);
            // 
            // clientNumInc
            // 
            this.clientNumInc.BackColor = System.Drawing.Color.Transparent;
            this.clientNumInc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clientNumInc.BackgroundImage")));
            this.clientNumInc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clientNumInc.FlatAppearance.BorderSize = 0;
            this.clientNumInc.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.clientNumInc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clientNumInc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clientNumInc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clientNumInc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientNumInc.Location = new System.Drawing.Point(330, 85);
            this.clientNumInc.Name = "clientNumInc";
            this.clientNumInc.Size = new System.Drawing.Size(31, 31);
            this.clientNumInc.TabIndex = 2;
            this.clientNumInc.Text = ">";
            this.clientNumInc.UseVisualStyleBackColor = false;
            this.clientNumInc.Click += new System.EventHandler(this.clientNumInc_Click);
            // 
            // refreshPizzasButton
            // 
            this.refreshPizzasButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshPizzasButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshPizzasButton.BackgroundImage")));
            this.refreshPizzasButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshPizzasButton.FlatAppearance.BorderSize = 0;
            this.refreshPizzasButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.refreshPizzasButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.refreshPizzasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refreshPizzasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshPizzasButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshPizzasButton.Location = new System.Drawing.Point(258, 385);
            this.refreshPizzasButton.Name = "refreshPizzasButton";
            this.refreshPizzasButton.Size = new System.Drawing.Size(103, 42);
            this.refreshPizzasButton.TabIndex = 1;
            this.refreshPizzasButton.Text = "Refresh";
            this.refreshPizzasButton.UseVisualStyleBackColor = false;
            this.refreshPizzasButton.Click += new System.EventHandler(this.refreshPizzasButton_Click);
            // 
            // pizzasListBox
            // 
            this.pizzasListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pizzasListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pizzasListBox.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzasListBox.FormattingEnabled = true;
            this.pizzasListBox.ItemHeight = 21;
            this.pizzasListBox.Location = new System.Drawing.Point(16, 154);
            this.pizzasListBox.Name = "pizzasListBox";
            this.pizzasListBox.Size = new System.Drawing.Size(587, 210);
            this.pizzasListBox.TabIndex = 0;
            // 
            // customPizzaPanel
            // 
            this.customPizzaPanel.BackColor = System.Drawing.Color.Transparent;
            this.customPizzaPanel.BackgroundImage = global::CashApp.Properties.Resources.central_control_background;
            this.customPizzaPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customPizzaPanel.Controls.Add(this.panel3);
            this.customPizzaPanel.Controls.Add(this.panel4);
            this.customPizzaPanel.Controls.Add(this.panel5);
            this.customPizzaPanel.Controls.Add(this.panel6);
            this.customPizzaPanel.Location = new System.Drawing.Point(17, 15);
            this.customPizzaPanel.Name = "customPizzaPanel";
            this.customPizzaPanel.Size = new System.Drawing.Size(617, 484);
            this.customPizzaPanel.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::CashApp.Properties.Resources.left_control_background1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.showSelectedIngredientsButton);
            this.panel3.Controls.Add(this.showPizzasButton);
            this.panel3.Controls.Add(this.pizzasListBoxForSelection);
            this.panel3.Location = new System.Drawing.Point(88, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 104);
            this.panel3.TabIndex = 15;
            // 
            // showSelectedIngredientsButton
            // 
            this.showSelectedIngredientsButton.BackColor = System.Drawing.Color.Transparent;
            this.showSelectedIngredientsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showSelectedIngredientsButton.BackgroundImage")));
            this.showSelectedIngredientsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showSelectedIngredientsButton.FlatAppearance.BorderSize = 0;
            this.showSelectedIngredientsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.showSelectedIngredientsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.showSelectedIngredientsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.showSelectedIngredientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showSelectedIngredientsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showSelectedIngredientsButton.Location = new System.Drawing.Point(247, 54);
            this.showSelectedIngredientsButton.Name = "showSelectedIngredientsButton";
            this.showSelectedIngredientsButton.Size = new System.Drawing.Size(160, 55);
            this.showSelectedIngredientsButton.TabIndex = 10;
            this.showSelectedIngredientsButton.Text = "Show Selected Pizza\'s Ingredients";
            this.showSelectedIngredientsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.showSelectedIngredientsButton.UseVisualStyleBackColor = false;
            this.showSelectedIngredientsButton.Click += new System.EventHandler(this.showSelectedIngredients_Click);
            // 
            // showPizzasButton
            // 
            this.showPizzasButton.BackColor = System.Drawing.Color.Transparent;
            this.showPizzasButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showPizzasButton.BackgroundImage")));
            this.showPizzasButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showPizzasButton.FlatAppearance.BorderSize = 0;
            this.showPizzasButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.showPizzasButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.showPizzasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.showPizzasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPizzasButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPizzasButton.Location = new System.Drawing.Point(247, 6);
            this.showPizzasButton.Name = "showPizzasButton";
            this.showPizzasButton.Size = new System.Drawing.Size(134, 40);
            this.showPizzasButton.TabIndex = 9;
            this.showPizzasButton.Text = "Show Pizzas";
            this.showPizzasButton.UseVisualStyleBackColor = false;
            this.showPizzasButton.Click += new System.EventHandler(this.showPizzasButton_Click);
            // 
            // pizzasListBoxForSelection
            // 
            this.pizzasListBoxForSelection.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pizzasListBoxForSelection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pizzasListBoxForSelection.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzasListBoxForSelection.FormattingEnabled = true;
            this.pizzasListBoxForSelection.ItemHeight = 15;
            this.pizzasListBoxForSelection.Location = new System.Drawing.Point(12, 6);
            this.pizzasListBoxForSelection.Name = "pizzasListBoxForSelection";
            this.pizzasListBoxForSelection.Size = new System.Drawing.Size(215, 90);
            this.pizzasListBoxForSelection.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::CashApp.Properties.Resources.left_control_background1;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.ingredientsListBox);
            this.panel4.Controls.Add(this.refreshIngredientsButton);
            this.panel4.Location = new System.Drawing.Point(14, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 268);
            this.panel4.TabIndex = 16;
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ingredientsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ingredientsListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsListBox.FormattingEnabled = true;
            this.ingredientsListBox.Location = new System.Drawing.Point(3, 38);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(241, 224);
            this.ingredientsListBox.TabIndex = 2;
            // 
            // refreshIngredientsButton
            // 
            this.refreshIngredientsButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshIngredientsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("refreshIngredientsButton.BackgroundImage")));
            this.refreshIngredientsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshIngredientsButton.FlatAppearance.BorderSize = 0;
            this.refreshIngredientsButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.refreshIngredientsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.refreshIngredientsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refreshIngredientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshIngredientsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshIngredientsButton.Location = new System.Drawing.Point(46, 5);
            this.refreshIngredientsButton.Name = "refreshIngredientsButton";
            this.refreshIngredientsButton.Size = new System.Drawing.Size(153, 38);
            this.refreshIngredientsButton.TabIndex = 6;
            this.refreshIngredientsButton.Text = "Show All Ingredients";
            this.refreshIngredientsButton.UseVisualStyleBackColor = false;
            this.refreshIngredientsButton.Click += new System.EventHandler(this.refreshIngredientsButton_Click);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::CashApp.Properties.Resources.left_control_background1;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.newIngredientsListBox);
            this.panel5.Controls.Add(this.newIngredient);
            this.panel5.Controls.Add(this.newIngredientButton);
            this.panel5.Controls.Add(this.removeIngredientButton);
            this.panel5.Location = new System.Drawing.Point(357, 119);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(247, 268);
            this.panel5.TabIndex = 17;
            // 
            // newIngredientsListBox
            // 
            this.newIngredientsListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newIngredientsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newIngredientsListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newIngredientsListBox.FormattingEnabled = true;
            this.newIngredientsListBox.ItemHeight = 15;
            this.newIngredientsListBox.Location = new System.Drawing.Point(3, 35);
            this.newIngredientsListBox.Name = "newIngredientsListBox";
            this.newIngredientsListBox.Size = new System.Drawing.Size(241, 180);
            this.newIngredientsListBox.TabIndex = 7;
            // 
            // newIngredient
            // 
            this.newIngredient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newIngredient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newIngredient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newIngredient.Location = new System.Drawing.Point(72, 216);
            this.newIngredient.Name = "newIngredient";
            this.newIngredient.Size = new System.Drawing.Size(106, 20);
            this.newIngredient.TabIndex = 3;
            // 
            // newIngredientButton
            // 
            this.newIngredientButton.BackColor = System.Drawing.Color.Transparent;
            this.newIngredientButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newIngredientButton.BackgroundImage")));
            this.newIngredientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newIngredientButton.FlatAppearance.BorderSize = 0;
            this.newIngredientButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.newIngredientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newIngredientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newIngredientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newIngredientButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newIngredientButton.Location = new System.Drawing.Point(64, 237);
            this.newIngredientButton.Name = "newIngredientButton";
            this.newIngredientButton.Size = new System.Drawing.Size(124, 35);
            this.newIngredientButton.TabIndex = 4;
            this.newIngredientButton.Text = "Add Ingredient";
            this.newIngredientButton.UseVisualStyleBackColor = false;
            this.newIngredientButton.Click += new System.EventHandler(this.newIngredientButton_Click);
            // 
            // removeIngredientButton
            // 
            this.removeIngredientButton.BackColor = System.Drawing.Color.Transparent;
            this.removeIngredientButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("removeIngredientButton.BackgroundImage")));
            this.removeIngredientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeIngredientButton.FlatAppearance.BorderSize = 0;
            this.removeIngredientButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.removeIngredientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.removeIngredientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.removeIngredientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeIngredientButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeIngredientButton.Location = new System.Drawing.Point(26, 3);
            this.removeIngredientButton.Name = "removeIngredientButton";
            this.removeIngredientButton.Size = new System.Drawing.Size(204, 39);
            this.removeIngredientButton.TabIndex = 11;
            this.removeIngredientButton.Text = "Remove Selected Ingredient";
            this.removeIngredientButton.UseVisualStyleBackColor = false;
            this.removeIngredientButton.Click += new System.EventHandler(this.removeIngredientButton_Click);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::CashApp.Properties.Resources.left_control_background1;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.createPizzaButton);
            this.panel6.Controls.Add(this.pizzaPriceBox);
            this.panel6.Controls.Add(this.pizzaNameBox);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Location = new System.Drawing.Point(88, 393);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(440, 84);
            this.panel6.TabIndex = 18;
            // 
            // createPizzaButton
            // 
            this.createPizzaButton.BackColor = System.Drawing.Color.Transparent;
            this.createPizzaButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createPizzaButton.BackgroundImage")));
            this.createPizzaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createPizzaButton.FlatAppearance.BorderSize = 0;
            this.createPizzaButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.createPizzaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.createPizzaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.createPizzaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPizzaButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPizzaButton.Location = new System.Drawing.Point(305, 22);
            this.createPizzaButton.Name = "createPizzaButton";
            this.createPizzaButton.Size = new System.Drawing.Size(109, 56);
            this.createPizzaButton.TabIndex = 5;
            this.createPizzaButton.Text = "Create Pizza";
            this.createPizzaButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createPizzaButton.UseVisualStyleBackColor = false;
            this.createPizzaButton.Click += new System.EventHandler(this.createPizzaButton_Click);
            // 
            // pizzaPriceBox
            // 
            this.pizzaPriceBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pizzaPriceBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pizzaPriceBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaPriceBox.Location = new System.Drawing.Point(113, 50);
            this.pizzaPriceBox.Name = "pizzaPriceBox";
            this.pizzaPriceBox.Size = new System.Drawing.Size(186, 20);
            this.pizzaPriceBox.TabIndex = 13;
            // 
            // pizzaNameBox
            // 
            this.pizzaNameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pizzaNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pizzaNameBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaNameBox.Location = new System.Drawing.Point(113, 17);
            this.pizzaNameBox.Name = "pizzaNameBox";
            this.pizzaNameBox.Size = new System.Drawing.Size(186, 20);
            this.pizzaNameBox.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::CashApp.Properties.Resources.Size_buttons_panel_background;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(3, 11);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(104, 29);
            this.panel7.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Pizza Name:";
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::CashApp.Properties.Resources.Size_buttons_panel_background;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(3, 46);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(104, 29);
            this.panel8.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Pizza Price:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BackgroundImage = global::CashApp.Properties.Resources.left_control_background;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.newOrderButton);
            this.panel1.Controls.Add(this.newPizzaButton);
            this.panel1.Controls.Add(this.ordersButton);
            this.panel1.Controls.Add(this.connectionPanel);
            this.panel1.Controls.Add(this.IPtextBox);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 528);
            this.panel1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::CashApp.Properties.Resources.starttrop;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(86, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 52);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.Transparent;
            this.newOrderButton.BackgroundImage = global::CashApp.Properties.Resources.main_buttons_hover;
            this.newOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newOrderButton.FlatAppearance.BorderSize = 0;
            this.newOrderButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.newOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newOrderButton.Location = new System.Drawing.Point(35, 143);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(180, 47);
            this.newOrderButton.TabIndex = 0;
            this.newOrderButton.Text = "New Pizza";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // newPizzaButton
            // 
            this.newPizzaButton.BackColor = System.Drawing.Color.Transparent;
            this.newPizzaButton.BackgroundImage = global::CashApp.Properties.Resources.main_buttons;
            this.newPizzaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newPizzaButton.FlatAppearance.BorderSize = 0;
            this.newPizzaButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.newPizzaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.newPizzaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newPizzaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPizzaButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPizzaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newPizzaButton.Location = new System.Drawing.Point(35, 200);
            this.newPizzaButton.Name = "newPizzaButton";
            this.newPizzaButton.Size = new System.Drawing.Size(180, 42);
            this.newPizzaButton.TabIndex = 1;
            this.newPizzaButton.Text = "Custom Pizza";
            this.newPizzaButton.UseVisualStyleBackColor = false;
            this.newPizzaButton.Click += new System.EventHandler(this.newPizzaButton_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.BackColor = System.Drawing.Color.Transparent;
            this.ordersButton.BackgroundImage = global::CashApp.Properties.Resources.main_buttons;
            this.ordersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ordersButton.FlatAppearance.BorderSize = 0;
            this.ordersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ordersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ordersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ordersButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersButton.Location = new System.Drawing.Point(35, 250);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(180, 43);
            this.ordersButton.TabIndex = 3;
            this.ordersButton.Text = "Orders";
            this.ordersButton.UseVisualStyleBackColor = false;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // connectionPanel
            // 
            this.connectionPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.connectionPanel.Location = new System.Drawing.Point(79, 483);
            this.connectionPanel.Name = "connectionPanel";
            this.connectionPanel.Size = new System.Drawing.Size(84, 42);
            this.connectionPanel.TabIndex = 7;
            // 
            // IPtextBox
            // 
            this.IPtextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.IPtextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPtextBox.Location = new System.Drawing.Point(58, 419);
            this.IPtextBox.Name = "IPtextBox";
            this.IPtextBox.Size = new System.Drawing.Size(130, 27);
            this.IPtextBox.TabIndex = 5;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.Transparent;
            this.connectButton.BackgroundImage = global::CashApp.Properties.Resources.main_buttons;
            this.connectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.connectButton.FlatAppearance.BorderSize = 0;
            this.connectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.connectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(58, 451);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(130, 35);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(908, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Snow;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.ordersPanel.ResumeLayout(false);
            this.ordersPanel.PerformLayout();
            this.newOrderPanel.ResumeLayout(false);
            this.newOrderPanel.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.customPizzaPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.Button newPizzaButton;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Panel newOrderPanel;
        private System.Windows.Forms.ListBox pizzasListBox;
        private System.Windows.Forms.TextBox IPtextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Panel connectionPanel;
        private System.Windows.Forms.Label outputText;
        private System.Windows.Forms.Button refreshPizzasButton;
        private System.Windows.Forms.Label clientNum;
        private System.Windows.Forms.Button clientNumDec;
        private System.Windows.Forms.Button clientNumInc;
        private System.Windows.Forms.Button largeButton;
        private System.Windows.Forms.Button mediumButton;
        private System.Windows.Forms.Button smallButton;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Panel customPizzaPanel;
        private System.Windows.Forms.Button refreshIngredientsButton;
        private System.Windows.Forms.Button createPizzaButton;
        private System.Windows.Forms.Button newIngredientButton;
        private System.Windows.Forms.TextBox newIngredient;
        private System.Windows.Forms.CheckedListBox ingredientsListBox;
        private System.Windows.Forms.TextBox pizzaNameBox;
        private System.Windows.Forms.ListBox newIngredientsListBox;
        private System.Windows.Forms.Button showSelectedIngredientsButton;
        private System.Windows.Forms.Button showPizzasButton;
        private System.Windows.Forms.ListBox pizzasListBoxForSelection;
        private System.Windows.Forms.Button removeIngredientButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pizzaPriceBox;
        private System.Windows.Forms.Panel ordersPanel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Button sendOrderAgainButton;
        private System.Windows.Forms.CheckBox allOrders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button2;
    }
}

