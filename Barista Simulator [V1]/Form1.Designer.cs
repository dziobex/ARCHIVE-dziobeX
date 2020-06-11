namespace BaristaSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.costOfOrder = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.additionBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.coffeeBox = new System.Windows.Forms.ComboBox();
            this.personBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.readyButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bank = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numberOfDays = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oBaristaSimulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 95);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(187, 208);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(41, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU na dzis:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.costOfOrder);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.additionBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.coffeeBox);
            this.groupBox1.Controls.Add(this.personBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.readyButton);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(232, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(377, 257);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zamowienia:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(242, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "PLN";
            // 
            // costOfOrder
            // 
            this.costOfOrder.AutoSize = true;
            this.costOfOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.costOfOrder.Location = new System.Drawing.Point(215, 175);
            this.costOfOrder.Name = "costOfOrder";
            this.costOfOrder.Size = new System.Drawing.Size(14, 15);
            this.costOfOrder.TabIndex = 9;
            this.costOfOrder.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(87, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Koszt przygotowania:";
            // 
            // additionBox
            // 
            this.additionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.additionBox.FormattingEnabled = true;
            this.additionBox.Items.AddRange(new object[] {
            "Bita smietana",
            "Cukier (1-2 kostki)",
            "Czekolada",
            "Kawalki orzechow",
            "Syrop karmelowy"});
            this.additionBox.Location = new System.Drawing.Point(257, 141);
            this.additionBox.Name = "additionBox";
            this.additionBox.Size = new System.Drawing.Size(89, 21);
            this.additionBox.TabIndex = 7;
            this.additionBox.SelectedIndexChanged += new System.EventHandler(this.additionBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(237, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "z";
            // 
            // coffeeBox
            // 
            this.coffeeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coffeeBox.FormattingEnabled = true;
            this.coffeeBox.Items.AddRange(new object[] {
            "Espresso",
            "Latte Macciato",
            "Americano",
            "Cafe Frappe",
            "Kawa z mlekiem",
            "Mocha",
            "Cappucino"});
            this.coffeeBox.Location = new System.Drawing.Point(134, 141);
            this.coffeeBox.Name = "coffeeBox";
            this.coffeeBox.Size = new System.Drawing.Size(89, 21);
            this.coffeeBox.TabIndex = 5;
            this.coffeeBox.SelectedIndexChanged += new System.EventHandler(this.coffeeBox_SelectedIndexChanged);
            // 
            // personBox
            // 
            this.personBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.personBox.FormattingEnabled = true;
            this.personBox.Items.AddRange(new object[] {
            "Lucy",
            "Bob",
            "Jack",
            "Amy"});
            this.personBox.Location = new System.Drawing.Point(41, 140);
            this.personBox.Name = "personBox";
            this.personBox.Size = new System.Drawing.Size(86, 21);
            this.personBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Daj";
            // 
            // readyButton
            // 
            this.readyButton.Location = new System.Drawing.Point(134, 202);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(97, 29);
            this.readyButton.TabIndex = 1;
            this.readyButton.Text = "Gotowe!";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Click += new System.EventHandler(this.readyButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(0, 34);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(377, 87);
            this.textBox2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bank:";
            // 
            // bank
            // 
            this.bank.AutoSize = true;
            this.bank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bank.Location = new System.Drawing.Point(57, 311);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(32, 18);
            this.bank.TabIndex = 4;
            this.bank.Text = "100";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 39);
            this.button2.TabIndex = 10;
            this.button2.Text = "Start!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(121, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "PLN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(362, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dzien:";
            // 
            // numberOfDays
            // 
            this.numberOfDays.AutoSize = true;
            this.numberOfDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberOfDays.Location = new System.Drawing.Point(423, 41);
            this.numberOfDays.Name = "numberOfDays";
            this.numberOfDays.Size = new System.Drawing.Size(18, 20);
            this.numberOfDays.TabIndex = 13;
            this.numberOfDays.Text = "1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oBaristaSimulatorToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // oBaristaSimulatorToolStripMenuItem
            // 
            this.oBaristaSimulatorToolStripMenuItem.Name = "oBaristaSimulatorToolStripMenuItem";
            this.oBaristaSimulatorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oBaristaSimulatorToolStripMenuItem.Text = "O Barista Simulator";
            this.oBaristaSimulatorToolStripMenuItem.Click += new System.EventHandler(this.oBaristaSimulatorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 351);
            this.Controls.Add(this.numberOfDays);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(639, 390);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(639, 390);
            this.Name = "Form1";
            this.Text = "Barista Simulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label costOfOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox additionBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox coffeeBox;
        private System.Windows.Forms.ComboBox personBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button readyButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bank;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label numberOfDays;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oBaristaSimulatorToolStripMenuItem;
    }
}

