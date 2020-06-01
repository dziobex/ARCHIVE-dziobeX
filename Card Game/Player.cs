using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Player : PlayerBody, IPlayer
    {
        public Player(string nickname, List<string> myCards, string[] fullListOfCards)
            : base(nickname, myCards, fullListOfCards)
        {
        }

        public List<string> MyCards { get { return myCards; } }

        public void GiveCard(string choosenCardFromMyCards)
        {
            int helper = 0;
            foreach (string c in myCards)
            {
                if (choosenCardFromMyCards == c)
                {
                    myCards.RemoveAt(helper);
                    return;
                }
                helper++;
            }
        }

        public void ReceiveCard(string cardForReceiving)
        {
            myCards.Add(cardForReceiving);
            receivenCards++;
        }

        public bool CheckCards(string currentCard, string myCurrentCard)
        {
            if (currentCard[currentCard.Length - 1] == myCurrentCard[myCurrentCard.Length - 1])
                return true;
            else if (currentCard[0] == myCurrentCard[0] && currentCard[1] == myCurrentCard[1] && currentCard[2] == myCurrentCard[2])
                return true;
            else if (myCurrentCard[0] == 'a' && myCurrentCard[1] == 'c' && myCurrentCard[2] == 'e')
                return true;
            else if ((currentCard[0] == 'a' && currentCard[1] == 'c' && currentCard[2] == 'e') && (currentCard[4] == myCurrentCard[0] && currentCard[5] == myCurrentCard[1] && currentCard[6] == myCurrentCard[2]))
                return true;
            else
                return false;
        }
    }
}
