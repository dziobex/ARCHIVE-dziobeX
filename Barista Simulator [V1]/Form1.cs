using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaristaSimulator
{
    public partial class Form1 : Form
    {
        double valueOfCoffee = 0, valueOfAddition = 0;
        string[] menu;
        string[] names;
        string[] additions;
        string[] comments;
        string[] randomMenu;
        double[] randomCostsOfCoffee;
        double[] costsCoffee;
        double[] costsAdditions;
        int[] state;

        bool decision = false;
        Coffee coffee;
        Customer[] customers;
        Barista[] barista;
        Random randomizer = new Random();

        public Form1()
        {
            InitializeComponent();

            state = new int[4] { 0, 0, 0, 0 };

            comments = new string[4];
            randomMenu = new string[7];
            randomCostsOfCoffee = new double[7];
            names = new string[] { "Lucy", "Bob", "Jack", "Amy" };
            menu = new string[] { "Espresso", "Latte Macciato", "Americano", "Cafe Frappe", "Kawa z mlekiem", "Mocha", "Cappucino", "Dalgona", "Mochaccino", "Irish Coffee", "Affogato" };
            costsCoffee = new double[] { 3.5, 5, 5, 7, 4, 9, 6.2, 9.5, 7, 10, 8 };
            additions = new string[] { "Bita smietana", "Cukier (1-2 kostki)", "Czekolada", "Kawalki orzechow", "Syrop karmelowy" };
            costsAdditions = new double[] { 2, 1, 2.5, 3, 3 };

            coffee = new Coffee(menu, costsCoffee, additions, costsAdditions);
            customers = new Customer[4];
            barista = new Barista[4];

            readyButton.Enabled = false;

            GetRandomListOfCoffee();
        }

        public void FirstListOfOrders()
        {
            string orders = "";
            for (int i = 0; i < 4; i++)
            {
                comments[i] = customers[i].EnterOrders(decision);
                orders += comments[i];
            }

            textBox2.Text = orders;
        }

        public void GetRandomListOfCoffee()
        {
            for (int i = 0; i < 7; i++)
            {
                int num = randomizer.Next(menu.Length);
                randomMenu[i] = menu[num];
                randomCostsOfCoffee[i] = costsCoffee[num];
                while (IfArrayHasDuplicates(randomMenu[i], i, randomMenu))
                {
                    num = randomizer.Next(menu.Length);
                    randomMenu[i] = menu[num];
                    randomCostsOfCoffee[i] = costsCoffee[num];
                }
            }

            for (int i = 0; i < 4; i++)
            {
                customers[i] = new Customer(names[i], randomMenu[randomizer.Next(randomMenu.Length)], additions[randomizer.Next(additions.Length)]);
                barista[i] = new Barista(customers[i]);
            }

            FirstListOfOrders();
            coffee = new Coffee(randomMenu, randomCostsOfCoffee, additions, costsAdditions);
            AddItemsToCoffeeBox(randomMenu);
            textBox1.Text = coffee.Menu();
        }

        public bool IfArrayHasDuplicates(string coffee, int a, string[] coffeeList)
        {
            for (int i = 0; i < a; i++)
                if (coffeeList[i] == coffee)
                    return true;
            return false;
        }

        public void AddItemsToCoffeeBox(string[] randMenu)
        {
            coffeeBox.Items.Clear();
            for (int i=0; i<7; i++)
                coffeeBox.Items.Add(randMenu[i]);
        }

        public void ListOfOrders()
        {
            string orders = "";
            for (int i = 0; i < 4; i++)
            {
                customers[i].SetNextCoffee = randomMenu[randomizer.Next(randomMenu.Length)];
                customers[i].SetNextExtra = additions[randomizer.Next(additions.Length)];
                orders += comments[i];
            }

            textBox2.Text = orders;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decision = true;
            readyButton.Enabled = true;
            FirstListOfOrders();
            button2.Enabled = false;
        }

        private void additionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i=0; i<5; i++)
            {
                if (additionBox.Text == additions[i])
                    valueOfAddition = costsAdditions[i];
            }
            costOfOrder.Text = ((valueOfCoffee + valueOfAddition)/2).ToString();
        }

        private void readyButton_Click(object sender, EventArgs e)
        {
            int numOfCustomer=0;
            if (personBox.Text == "" || coffeeBox.Text == "" || additionBox.Text == "")
                MessageBox.Show("Nie dodales wystarczajacej liczby skladnikow do zamowienia!", "Blad!");
            else
            {
                for (int i=0; i<4; i++)
                    if (names[i] == personBox.Text)
                        numOfCustomer = i;

                if (customers[numOfCustomer].ReceiveCoffee(barista[numOfCustomer].MakeCoffee(coffeeBox.Text, additionBox.Text)))
                {
                    bank.Text = (Double.Parse(bank.Text) + (Double.Parse(costOfOrder.Text) * 2)).ToString();
                    comments[numOfCustomer] = customers[numOfCustomer].Name + " mowi: Dziekuje!\r\n";
                }
                else
                {
                    comments[numOfCustomer] = customers[numOfCustomer].Name + " mowi: To nie moje zamowienie!\r\n";
                }

                state[numOfCustomer] = 1;
                ListOfOrders();
                CheckAndUpdateNumberOfDay();

                personBox.Items.Remove(personBox.Text);
                bank.Text = (Double.Parse(bank.Text) - Double.Parse(costOfOrder.Text)).ToString();
                if (Double.Parse(bank.Text) <= 0)
                {
                    bank.Text = "0";
                    MessageBox.Show("Ups! Skonczyly Ci sie pieniadze z banku!", "Game OVER!");
                    Application.Exit();
                }

            }
        }

        public void CheckAndUpdateNumberOfDay()
        {
            int counter = 0;
            foreach (int num in state)
                if (num == 1)
                    counter++;

            if (counter == 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    state[i] = 0;
                    personBox.Items.Add(names[i]);
                }
                numberOfDays.Text = (Int32.Parse(numberOfDays.Text) + 1).ToString();
                GetRandomListOfCoffee();
            }
        }

        private void oBaristaSimulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wciel sie w role Baristy i obsluz klientow.", "O Barista Simulator");
        }

        private void coffeeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i=0; i<7; i++)
            {
                if (coffeeBox.Text == randomMenu[i])
                    valueOfCoffee = randomCostsOfCoffee[i];
            }
            costOfOrder.Text = ((valueOfCoffee + valueOfAddition)/2).ToString();
        }
    }
}
