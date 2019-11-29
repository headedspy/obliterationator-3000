namespace CookApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.IPtextBox = new System.Windows.Forms.TextBox();
            this.connectionPanel = new System.Windows.Forms.Panel();
            this.connectButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.createPanel = new System.Windows.Forms.Panel();
            this.editTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.editIngredientNameButton = new System.Windows.Forms.Button();
            this.editIngredientPizzaButton = new System.Windows.Forms.Button();
            this.editIngredientIDButton = new System.Windows.Forms.Button();
            this.createPizzaButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.editPizzaNameButton = new System.Windows.Forms.Button();
            this.editPizzaPriceButton = new System.Windows.Forms.Button();
            this.editPizzaIDButton = new System.Windows.Forms.Button();
            this.pizzaIngredientsListBox = new System.Windows.Forms.ListBox();
            this.checkIngredientsButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteIngredientButton = new System.Windows.Forms.Button();
            this.deletePizzaButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pizzaPriceBox = new System.Windows.Forms.TextBox();
            this.pizzaNameBox = new System.Windows.Forms.TextBox();
            this.ingredientPizzaBox = new System.Windows.Forms.ComboBox();
            this.refreshPizzasButton = new System.Windows.Forms.Button();
            this.pizzasListBox = new System.Windows.Forms.ListBox();
            this.createIngredientButton = new System.Windows.Forms.Button();
            this.ingredientNameBox = new System.Windows.Forms.TextBox();
            this.refreshIngredientsButton = new System.Windows.Forms.Button();
            this.ingredientsListBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.orderPanel = new System.Windows.Forms.Panel();
            this.beginOrderButton = new System.Windows.Forms.Button();
            this.refreshOrdersButton = new System.Windows.Forms.Button();
            this.orderListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.createPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.orderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 542);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::CookApp.Properties.Resources.left_control_background;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.outputText);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.IPtextBox);
            this.panel2.Controls.Add(this.connectionPanel);
            this.panel2.Controls.Add(this.connectButton);
            this.panel2.Location = new System.Drawing.Point(665, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 538);
            this.panel2.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::CookApp.Properties.Resources.starttrop;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(115, 482);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 40);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // outputText
            // 
            this.outputText.AutoSize = true;
            this.outputText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.Location = new System.Drawing.Point(21, 522);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(0, 16);
            this.outputText.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CookApp.Properties.Resources.left_control_buttons_background;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(42, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Orders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::CookApp.Properties.Resources.left_control_buttons_background;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(42, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Pizzas and Ingredients";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // IPtextBox
            // 
            this.IPtextBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPtextBox.Location = new System.Drawing.Point(67, 397);
            this.IPtextBox.Name = "IPtextBox";
            this.IPtextBox.Size = new System.Drawing.Size(141, 26);
            this.IPtextBox.TabIndex = 3;
            // 
            // connectionPanel
            // 
            this.connectionPanel.Location = new System.Drawing.Point(108, 357);
            this.connectionPanel.Name = "connectionPanel";
            this.connectionPanel.Size = new System.Drawing.Size(55, 34);
            this.connectionPanel.TabIndex = 4;
            // 
            // connectButton
            // 
            this.connectButton.BackgroundImage = global::CookApp.Properties.Resources.left_control_buttons_background;
            this.connectButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.connectButton.FlatAppearance.BorderSize = 0;
            this.connectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.connectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(55, 431);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(172, 37);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::CookApp.Properties.Resources.right_control_order_list_background;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.createPanel);
            this.panel4.Controls.Add(this.orderPanel);
            this.panel4.Location = new System.Drawing.Point(1, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(664, 511);
            this.panel4.TabIndex = 8;
            // 
            // createPanel
            // 
            this.createPanel.BackColor = System.Drawing.Color.Transparent;
            this.createPanel.BackgroundImage = global::CookApp.Properties.Resources.central_control_background;
            this.createPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createPanel.Controls.Add(this.editTextBox);
            this.createPanel.Controls.Add(this.groupBox2);
            this.createPanel.Controls.Add(this.createPizzaButton);
            this.createPanel.Controls.Add(this.groupBox1);
            this.createPanel.Controls.Add(this.pizzaIngredientsListBox);
            this.createPanel.Controls.Add(this.checkIngredientsButton);
            this.createPanel.Controls.Add(this.label7);
            this.createPanel.Controls.Add(this.label6);
            this.createPanel.Controls.Add(this.label4);
            this.createPanel.Controls.Add(this.label3);
            this.createPanel.Controls.Add(this.deleteIngredientButton);
            this.createPanel.Controls.Add(this.deletePizzaButton);
            this.createPanel.Controls.Add(this.label2);
            this.createPanel.Controls.Add(this.label1);
            this.createPanel.Controls.Add(this.pizzaPriceBox);
            this.createPanel.Controls.Add(this.pizzaNameBox);
            this.createPanel.Controls.Add(this.ingredientPizzaBox);
            this.createPanel.Controls.Add(this.refreshPizzasButton);
            this.createPanel.Controls.Add(this.pizzasListBox);
            this.createPanel.Controls.Add(this.createIngredientButton);
            this.createPanel.Controls.Add(this.ingredientNameBox);
            this.createPanel.Controls.Add(this.refreshIngredientsButton);
            this.createPanel.Controls.Add(this.ingredientsListBox);
            this.createPanel.Controls.Add(this.panel3);
            this.createPanel.Controls.Add(this.label8);
            this.createPanel.Location = new System.Drawing.Point(21, 13);
            this.createPanel.Name = "createPanel";
            this.createPanel.Size = new System.Drawing.Size(623, 482);
            this.createPanel.TabIndex = 2;
            // 
            // editTextBox
            // 
            this.editTextBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editTextBox.Location = new System.Drawing.Point(258, 361);
            this.editTextBox.Name = "editTextBox";
            this.editTextBox.Size = new System.Drawing.Size(154, 21);
            this.editTextBox.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImage = global::CookApp.Properties.Resources.central_control_background;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.editIngredientNameButton);
            this.groupBox2.Controls.Add(this.editIngredientPizzaButton);
            this.groupBox2.Controls.Add(this.editIngredientIDButton);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(331, 399);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(103, 73);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edit Ingredient";
            // 
            // editIngredientNameButton
            // 
            this.editIngredientNameButton.BackgroundImage = global::CookApp.Properties.Resources.left_control_buttons_background;
            this.editIngredientNameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editIngredientNameButton.FlatAppearance.BorderSize = 0;
            this.editIngredientNameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editIngredientNameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editIngredientNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editIngredientNameButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.editIngredientNameButton.Location = new System.Drawing.Point(7, 43);
            this.editIngredientNameButton.Name = "editIngredientNameButton";
            this.editIngredientNameButton.Size = new System.Drawing.Size(88, 23);
            this.editIngredientNameButton.TabIndex = 24;
            this.editIngredientNameButton.Text = "Name";
            this.editIngredientNameButton.UseVisualStyleBackColor = true;
            this.editIngredientNameButton.Click += new System.EventHandler(this.editIngredientNameButton_Click);
            // 
            // editIngredientPizzaButton
            // 
            this.editIngredientPizzaButton.BackgroundImage = global::CookApp.Properties.Resources.left_control_buttons_background;
            this.editIngredientPizzaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editIngredientPizzaButton.FlatAppearance.BorderSize = 0;
            this.editIngredientPizzaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editIngredientPizzaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editIngredientPizzaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editIngredientPizzaButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.editIngredientPizzaButton.Location = new System.Drawing.Point(40, 16);
            this.editIngredientPizzaButton.Name = "editIngredientPizzaButton";
            this.editIngredientPizzaButton.Size = new System.Drawing.Size(57, 23);
            this.editIngredientPizzaButton.TabIndex = 23;
            this.editIngredientPizzaButton.Text = "Pizza";
            this.editIngredientPizzaButton.UseVisualStyleBackColor = true;
            this.editIngredientPizzaButton.Click += new System.EventHandler(this.editIngredientPizzaButton_Click);
            // 
            // editIngredientIDButton
            // 
            this.editIngredientIDButton.BackgroundImage = global::CookApp.Properties.Resources.left_control_buttons_background;
            this.editIngredientIDButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editIngredientIDButton.FlatAppearance.BorderSize = 0;
            this.editIngredientIDButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editIngredientIDButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editIngredientIDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editIngredientIDButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.editIngredientIDButton.Location = new System.Drawing.Point(3, 16);
            this.editIngredientIDButton.Name = "editIngredientIDButton";
            this.editIngredientIDButton.Size = new System.Drawing.Size(33, 23);
            this.editIngredientIDButton.TabIndex = 22;
            this.editIngredientIDButton.Text = "ID";
            this.editIngredientIDButton.UseVisualStyleBackColor = true;
            this.editIngredientIDButton.Click += new System.EventHandler(this.editIngredientIDButton_Click);
            // 
            // createPizzaButton
            // 
            this.createPizzaButton.BackgroundImage = global::CookApp.Properties.Resources.AddPizza_button_background;
            this.createPizzaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.createPizzaButton.FlatAppearance.BorderSize = 0;
            this.createPizzaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.createPizzaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.createPizzaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPizzaButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.createPizzaButton.Location = new System.Drawing.Point(14, 424);
            this.createPizzaButton.Name = "createPizzaButton";
            this.createPizzaButton.Size = new System.Drawing.Size(102, 48);
            this.createPizzaButton.TabIndex = 10;
            this.createPizzaButton.Text = "Create Pizza";
            this.createPizzaButton.UseVisualStyleBackColor = true;
            this.createPizzaButton.Click += new System.EventHandler(this.createPizzaButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::CookApp.Properties.Resources.central_control_background;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.editPizzaNameButton);
            this.groupBox1.Controls.Add(this.editPizzaPriceButton);
            this.groupBox1.Controls.Add(this.editPizzaIDButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(222, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(103, 73);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Pizza";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // editPizzaNameButton
            // 
            this.editPizzaNameButton.BackgroundImage = global::CookApp.Properties.Resources.left_control_buttons_background;
            this.editPizzaNameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editPizzaNameButton.FlatAppearance.BorderSize = 0;
            this.editPizzaNameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editPizzaNameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editPizzaNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPizzaNameButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.editPizzaNameButton.Location = new System.Drawing.Point(7, 43);
            this.editPizzaNameButton.Name = "editPizzaNameButton";
            this.editPizzaNameButton.Size = new System.Drawing.Size(88, 23);
            this.editPizzaNameButton.TabIndex = 24;
            this.editPizzaNameButton.Text = "Name";
            this.editPizzaNameButton.UseVisualStyleBackColor = true;
            this.editPizzaNameButton.Click += new System.EventHandler(this.editPizzaNameButton_Click);
            // 
            // editPizzaPriceButton
            // 
            this.editPizzaPriceButton.BackgroundImage = global::CookApp.Properties.Resources.left_control_buttons_background;
            this.editPizzaPriceButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editPizzaPriceButton.FlatAppearance.BorderSize = 0;
            this.editPizzaPriceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editPizzaPriceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editPizzaPriceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPizzaPriceButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.editPizzaPriceButton.Location = new System.Drawing.Point(46, 16);
            this.editPizzaPriceButton.Name = "editPizzaPriceButton";
            this.editPizzaPriceButton.Size = new System.Drawing.Size(49, 23);
            this.editPizzaPriceButton.TabIndex = 23;
            this.editPizzaPriceButton.Text = "Price";
            this.editPizzaPriceButton.UseVisualStyleBackColor = true;
            this.editPizzaPriceButton.Click += new System.EventHandler(this.editPizzaPriceButton_Click);
            // 
            // editPizzaIDButton
            // 
            this.editPizzaIDButton.BackgroundImage = global::CookApp.Properties.Resources.left_control_buttons_background;
            this.editPizzaIDButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editPizzaIDButton.FlatAppearance.BorderSize = 0;
            this.editPizzaIDButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.editPizzaIDButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editPizzaIDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPizzaIDButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.editPizzaIDButton.Location = new System.Drawing.Point(7, 16);
            this.editPizzaIDButton.Name = "editPizzaIDButton";
            this.editPizzaIDButton.Size = new System.Drawing.Size(33, 23);
            this.editPizzaIDButton.TabIndex = 22;
            this.editPizzaIDButton.Text = "ID";
            this.editPizzaIDButton.UseVisualStyleBackColor = true;
            this.editPizzaIDButton.Click += new System.EventHandler(this.editPizzaIDButton_Click);
            // 
            // pizzaIngredientsListBox
            // 
            this.pizzaIngredientsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pizzaIngredientsListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pizzaIngredientsListBox.FormattingEnabled = true;
            this.pizzaIngredientsListBox.ItemHeight = 14;
            this.pizzaIngredientsListBox.Location = new System.Drawing.Point(239, 38);
            this.pizzaIngredientsListBox.Name = "pizzaIngredientsListBox";
            this.pizzaIngredientsListBox.Size = new System.Drawing.Size(71, 182);
            this.pizzaIngredientsListBox.TabIndex = 20;
            // 
            // checkIngredientsButton
            // 
            this.checkIngredientsButton.BackgroundImage = global::CookApp.Properties.Resources.left_control_buttons_background;
            this.checkIngredientsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkIngredientsButton.FlatAppearance.BorderSize = 0;
            this.checkIngredientsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkIngredientsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkIngredientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkIngredientsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.checkIngredientsButton.Location = new System.Drawing.Point(222, 230);
            this.checkIngredientsButton.Name = "checkIngredientsButton";
            this.checkIngredientsButton.Size = new System.Drawing.Size(93, 49);
            this.checkIngredientsButton.TabIndex = 19;
            this.checkIngredientsButton.Text = "Check Ingredients";
            this.checkIngredientsButton.UseVisualStyleBackColor = true;
            this.checkIngredientsButton.Click += new System.EventHandler(this.checkIngredientsButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label7.Location = new System.Drawing.Point(400, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "ID   Name          Pizza";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.label6.Location = new System.Drawing.Point(17, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID   Price             Pizza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(539, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Pizza:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(531, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name:";
            // 
            // deleteIngredientButton
            // 
            this.deleteIngredientButton.BackgroundImage = global::CookApp.Properties.Resources.right_control_oreder_remove_button_background;
            this.deleteIngredientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteIngredientButton.FlatAppearance.BorderSize = 0;
            this.deleteIngredientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deleteIngredientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deleteIngredientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteIngredientButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.deleteIngredientButton.Location = new System.Drawing.Point(400, 231);
            this.deleteIngredientButton.Name = "deleteIngredientButton";
            this.deleteIngredientButton.Size = new System.Drawing.Size(93, 49);
            this.deleteIngredientButton.TabIndex = 14;
            this.deleteIngredientButton.Text = "Delete Selected";
            this.deleteIngredientButton.UseVisualStyleBackColor = true;
            this.deleteIngredientButton.Click += new System.EventHandler(this.deleteIngredientButton_Click);
            // 
            // deletePizzaButton
            // 
            this.deletePizzaButton.BackgroundImage = global::CookApp.Properties.Resources.left_control_buttons_background;
            this.deletePizzaButton.FlatAppearance.BorderSize = 0;
            this.deletePizzaButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deletePizzaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deletePizzaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePizzaButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.deletePizzaButton.Location = new System.Drawing.Point(3, 230);
            this.deletePizzaButton.Name = "deletePizzaButton";
            this.deletePizzaButton.Size = new System.Drawing.Size(93, 49);
            this.deletePizzaButton.TabIndex = 13;
            this.deletePizzaButton.Text = "Delete Selected";
            this.deletePizzaButton.UseVisualStyleBackColor = true;
            this.deletePizzaButton.Click += new System.EventHandler(this.deletePizzaButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(42, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(33, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name:";
            // 
            // pizzaPriceBox
            // 
            this.pizzaPriceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaPriceBox.Location = new System.Drawing.Point(3, 399);
            this.pizzaPriceBox.Name = "pizzaPriceBox";
            this.pizzaPriceBox.Size = new System.Drawing.Size(121, 21);
            this.pizzaPriceBox.TabIndex = 9;
            // 
            // pizzaNameBox
            // 
            this.pizzaNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaNameBox.Location = new System.Drawing.Point(3, 355);
            this.pizzaNameBox.Name = "pizzaNameBox";
            this.pizzaNameBox.Size = new System.Drawing.Size(121, 21);
            this.pizzaNameBox.TabIndex = 8;
            // 
            // ingredientPizzaBox
            // 
            this.ingredientPizzaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientPizzaBox.FormattingEnabled = true;
            this.ingredientPizzaBox.Location = new System.Drawing.Point(499, 399);
            this.ingredientPizzaBox.Name = "ingredientPizzaBox";
            this.ingredientPizzaBox.Size = new System.Drawing.Size(121, 23);
            this.ingredientPizzaBox.TabIndex = 7;
            // 
            // refreshPizzasButton
            // 
            this.refreshPizzasButton.BackgroundImage = global::CookApp.Properties.Resources.refresh;
            this.refreshPizzasButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshPizzasButton.FlatAppearance.BorderSize = 0;
            this.refreshPizzasButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.refreshPizzasButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refreshPizzasButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshPizzasButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.refreshPizzasButton.Location = new System.Drawing.Point(113, 237);
            this.refreshPizzasButton.Name = "refreshPizzasButton";
            this.refreshPizzasButton.Size = new System.Drawing.Size(89, 27);
            this.refreshPizzasButton.TabIndex = 6;
            this.refreshPizzasButton.Text = "Refresh";
            this.refreshPizzasButton.UseVisualStyleBackColor = true;
            this.refreshPizzasButton.Click += new System.EventHandler(this.refreshPizzasButton_Click);
            // 
            // pizzasListBox
            // 
            this.pizzasListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pizzasListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pizzasListBox.ItemHeight = 14;
            this.pizzasListBox.Location = new System.Drawing.Point(3, 38);
            this.pizzasListBox.Name = "pizzasListBox";
            this.pizzasListBox.Size = new System.Drawing.Size(230, 182);
            this.pizzasListBox.TabIndex = 5;
            // 
            // createIngredientButton
            // 
            this.createIngredientButton.BackgroundImage = global::CookApp.Properties.Resources.AddPizza_button_background;
            this.createIngredientButton.FlatAppearance.BorderSize = 0;
            this.createIngredientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.createIngredientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.createIngredientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createIngredientButton.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.createIngredientButton.Location = new System.Drawing.Point(510, 427);
            this.createIngredientButton.Name = "createIngredientButton";
            this.createIngredientButton.Size = new System.Drawing.Size(102, 47);
            this.createIngredientButton.TabIndex = 4;
            this.createIngredientButton.Text = "Create Ingredient";
            this.createIngredientButton.UseVisualStyleBackColor = true;
            this.createIngredientButton.Click += new System.EventHandler(this.createIngredientButton_Click);
            // 
            // ingredientNameBox
            // 
            this.ingredientNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientNameBox.Location = new System.Drawing.Point(499, 355);
            this.ingredientNameBox.Name = "ingredientNameBox";
            this.ingredientNameBox.Size = new System.Drawing.Size(121, 21);
            this.ingredientNameBox.TabIndex = 2;
            // 
            // refreshIngredientsButton
            // 
            this.refreshIngredientsButton.BackgroundImage = global::CookApp.Properties.Resources.refresh;
            this.refreshIngredientsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshIngredientsButton.FlatAppearance.BorderSize = 0;
            this.refreshIngredientsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.refreshIngredientsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refreshIngredientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshIngredientsButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshIngredientsButton.Location = new System.Drawing.Point(509, 235);
            this.refreshIngredientsButton.Name = "refreshIngredientsButton";
            this.refreshIngredientsButton.Size = new System.Drawing.Size(89, 31);
            this.refreshIngredientsButton.TabIndex = 1;
            this.refreshIngredientsButton.Text = "Refresh";
            this.refreshIngredientsButton.UseVisualStyleBackColor = true;
            this.refreshIngredientsButton.Click += new System.EventHandler(this.refreshIngredientsButton_Click);
            // 
            // ingredientsListBox
            // 
            this.ingredientsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ingredientsListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ingredientsListBox.FormattingEnabled = true;
            this.ingredientsListBox.ItemHeight = 14;
            this.ingredientsListBox.Location = new System.Drawing.Point(405, 33);
            this.ingredientsListBox.Name = "ingredientsListBox";
            this.ingredientsListBox.Size = new System.Drawing.Size(215, 182);
            this.ingredientsListBox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::CookApp.Properties.Resources.grayisbtn;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(252, 355);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 31);
            this.panel3.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label8.Location = new System.Drawing.Point(294, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "New Value:";
            // 
            // orderPanel
            // 
            this.orderPanel.BackColor = System.Drawing.Color.Transparent;
            this.orderPanel.BackgroundImage = global::CookApp.Properties.Resources.central_control_background;
            this.orderPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.orderPanel.Controls.Add(this.beginOrderButton);
            this.orderPanel.Controls.Add(this.refreshOrdersButton);
            this.orderPanel.Controls.Add(this.orderListBox);
            this.orderPanel.Controls.Add(this.label5);
            this.orderPanel.Location = new System.Drawing.Point(20, 14);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(623, 483);
            this.orderPanel.TabIndex = 7;
            // 
            // beginOrderButton
            // 
            this.beginOrderButton.BackColor = System.Drawing.Color.Transparent;
            this.beginOrderButton.BackgroundImage = global::CookApp.Properties.Resources.start;
            this.beginOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.beginOrderButton.FlatAppearance.BorderSize = 0;
            this.beginOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.beginOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.beginOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beginOrderButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.beginOrderButton.Location = new System.Drawing.Point(20, 415);
            this.beginOrderButton.Name = "beginOrderButton";
            this.beginOrderButton.Size = new System.Drawing.Size(185, 58);
            this.beginOrderButton.TabIndex = 2;
            this.beginOrderButton.Text = "Start order";
            this.beginOrderButton.UseVisualStyleBackColor = false;
            this.beginOrderButton.Click += new System.EventHandler(this.beginOrderButton_Click);
            // 
            // refreshOrdersButton
            // 
            this.refreshOrdersButton.BackColor = System.Drawing.Color.Transparent;
            this.refreshOrdersButton.BackgroundImage = global::CookApp.Properties.Resources.refresh;
            this.refreshOrdersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refreshOrdersButton.FlatAppearance.BorderSize = 0;
            this.refreshOrdersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.refreshOrdersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refreshOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshOrdersButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshOrdersButton.Location = new System.Drawing.Point(424, 415);
            this.refreshOrdersButton.Name = "refreshOrdersButton";
            this.refreshOrdersButton.Size = new System.Drawing.Size(188, 58);
            this.refreshOrdersButton.TabIndex = 1;
            this.refreshOrdersButton.Text = "Refresh";
            this.refreshOrdersButton.UseVisualStyleBackColor = false;
            this.refreshOrdersButton.Click += new System.EventHandler(this.refreshOrdersButton_Click);
            // 
            // orderListBox
            // 
            this.orderListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.orderListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderListBox.FormattingEnabled = true;
            this.orderListBox.ItemHeight = 14;
            this.orderListBox.Location = new System.Drawing.Point(20, 29);
            this.orderListBox.Name = "orderListBox";
            this.orderListBox.Size = new System.Drawing.Size(586, 378);
            this.orderListBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(595, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Order Nr     Started      Baking      Finished      Customer Nr      Pizza      P" +
    "izza Size      Time Ordered      Time Finished";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(927, 539);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Gainsboro;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.createPanel.ResumeLayout(false);
            this.createPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.orderPanel.ResumeLayout(false);
            this.orderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel createPanel;
        private System.Windows.Forms.Button refreshIngredientsButton;
        private System.Windows.Forms.ListBox ingredientsListBox;
        private System.Windows.Forms.TextBox IPtextBox;
        private System.Windows.Forms.Panel connectionPanel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label outputText;
        private System.Windows.Forms.Button refreshPizzasButton;
        private System.Windows.Forms.Button createIngredientButton;
        private System.Windows.Forms.TextBox ingredientNameBox;
        private System.Windows.Forms.Button createPizzaButton;
        private System.Windows.Forms.TextBox pizzaPriceBox;
        private System.Windows.Forms.TextBox pizzaNameBox;
        private System.Windows.Forms.ComboBox ingredientPizzaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteIngredientButton;
        private System.Windows.Forms.Button deletePizzaButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.Button refreshOrdersButton;
        private System.Windows.Forms.ListBox orderListBox;
        private System.Windows.Forms.Button beginOrderButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox pizzasListBox;
        private System.Windows.Forms.ListBox pizzaIngredientsListBox;
        private System.Windows.Forms.Button checkIngredientsButton;
        private System.Windows.Forms.TextBox editTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button editIngredientNameButton;
        private System.Windows.Forms.Button editIngredientPizzaButton;
        private System.Windows.Forms.Button editIngredientIDButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button editPizzaNameButton;
        private System.Windows.Forms.Button editPizzaPriceButton;
        private System.Windows.Forms.Button editPizzaIDButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
    }
}

