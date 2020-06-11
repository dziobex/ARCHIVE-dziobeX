using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaSimulator
{
    class Barista
    {
        Customer customer;

        public Barista(Customer customer)
        {
            this.customer = customer;
        }

        public string MakeCoffee(string coffee, string extra)
        {
            return customer.Name + " zamawia: " + coffee +  " z " + extra;
        }
    }
}
