using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaSimulator
{
    class Customer
    {
        private string name;
        private string coffee;
        private string extra;
        private string coffeeOrdered = "";

        public Customer(string name, string coffee, string extra)
        {
            this.name = name;
            this.coffee = coffee;
            this.extra = extra;
            this.coffeeOrdered = this.name + " zamawia: " + coffee + " z " + extra;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string SetNextCoffee
        {
            set
            {
                coffee = value;
            }
        }

        public string SetNextExtra
        {
            set
            {
                extra = value;
            }
        }

        public string EnterOrders(bool decision)
        {
            if (!decision)
                return name + " nie wystawil/a zamowienia\r\n";
            else
            {
                coffeeOrdered = this.name + " zamawia: " + coffee + " z " + extra;
                return name + " zamawia: " + coffee + " z " + extra + "\r\n";
            }
        }

        public bool ReceiveCoffee(string coffeeFromBarista)
        {
            if (coffeeFromBarista == coffeeOrdered)
                return true;
            else
                return false;
        }

        
    }
}
