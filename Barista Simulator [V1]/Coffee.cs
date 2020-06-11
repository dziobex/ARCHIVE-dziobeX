using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaSimulator
{
    class Coffee
    {
        private string currentMenu;
        private string[] menu;
        private string[] additions;
        private double[] costsCoffee;
        private double[] costsAdditions;
        Random randomizer = new Random();

        public Coffee(string[] menu, double[] costsCoffee, string[] additions, double[] costsAdditions)
        {
            this.menu = menu;
            this.costsCoffee = costsCoffee;
            this.additions = additions;
            this.costsAdditions = costsAdditions;
        }

        public string Menu()
        {
            string menuList = "";
            for (int i = 0; i < menu.Length; i++)
                menuList += "* " + menu[i] + " " +  costsCoffee[i].ToString() + " PLN" + "\r\n";

            menuList += "\r\n" + "DODATKI: " + "\r\n";
            for (int i = 0; i < additions.Length; i++)
                menuList += "* " + additions[i] + " " + costsAdditions[i].ToString() + " PLN" + "\r\n";

            currentMenu = menuList;
            return menuList;
        }
    }
}
