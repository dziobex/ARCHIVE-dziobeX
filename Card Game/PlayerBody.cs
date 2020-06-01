using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    abstract class PlayerBody
    {
        protected Random randomizer = new Random();
        protected string nickname;
        protected List<string> myCards = new List<string>();
        protected string[] fullListOfCards;

        protected string currentCard;
        protected int receivenCards;

        public PlayerBody(string nickname, List<string> myCards, string[] fullListOfCards)
        {
            this.nickname = nickname;
            this.myCards = myCards;
            this.fullListOfCards = fullListOfCards;
        }

        public string GetNickname { get { return nickname; } }
        public string CurrentCard { get { return currentCard; } }
        public int HowManyCards { get { return myCards.Count; } }
        public int ReceivenCards { get { return receivenCards; } set { receivenCards = value; } }

        public void TakeNewCard(string nameOfCard)
        {
            myCards.Add(nameOfCard);
        }

        public bool Win()
        {
            if (myCards.Count == 0)
                return true;
            else
                return false;
        }
    }
}
