using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Bot : PlayerBody, IBot
    {
        string state = "";
        public Bot(string nickname, List<string> myCards, string[] fullListOfCards)
            : base(nickname, myCards, fullListOfCards)
        {
        }

        public void Action(string currentCard, int numberOfRound, int timer)
        {
            if (numberOfRound == 0 && currentCard == null)
            {
                int helper = 0;
                foreach (string c in myCards)
                {
                    if ((c[c.Length-1] >= '5' && c[c.Length-1] <= 9) || (c[c.Length-2] == '1' && c[c.Length - 1] == '0'))
                    {
                        this.currentCard = c;
                        state = nickname + " chooses " + this.currentCard + "\r\n";
                        myCards.RemoveAt(helper);
                        return;
                    }
                    helper++;
                }
                this.currentCard = currentCard;
                state = nickname + " doesn't have this card. " + nickname + " takes next card.\r\n";
                string crd = fullListOfCards[randomizer.Next(fullListOfCards.Length)];
                receivenCards++;
                myCards.Add(crd);
            }
            else
            {
                int helper = 0;
                foreach (string c in myCards)
                {
                    if ((c[c.Length - 1] >= '5' && c[c.Length - 1] <= 9) || (c[c.Length - 2] == '1' && c[c.Length - 1] == '0'))
                    {
                        if ((c[c.Length-1] == currentCard[currentCard.Length-1]) || (c[0] == currentCard[0] && c[1] == currentCard[1] && c[2] == currentCard[2]))
                        {
                            this.currentCard = c;
                            state = nickname + " chooses " + this.currentCard + "\r\n";
                            myCards.RemoveAt(helper);
                            return;
                        }
                    }
                    else
                    {
                        if (c[0] == 'a' && c[1] == 'c' && c[2] == 'e')
                        {
                            this.currentCard = c;
                            state = nickname + " chooses " + this.currentCard + "\r\n";
                            myCards.RemoveAt(helper);
                            return;
                        }
                        else if (c[0] == currentCard[0] && c[1] == currentCard[1] && c[2] == currentCard[2])
                        {
                            this.currentCard = c;
                            state = nickname + " chooses " + this.currentCard + "\r\n";
                            myCards.RemoveAt(helper);
                            return;
                        }
                    }
                    helper++;
                }
                this.currentCard = currentCard;
                state = nickname + " doesn't have this card. " + nickname + " takes next card.\r\n";
                string crd = fullListOfCards[randomizer.Next(fullListOfCards.Length)];
                receivenCards++;
                myCards.Add(crd);
            }
        }

        public string ShowState { get { return state; } }
    }
}
