using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    interface IPlayer
    {
        void GiveCard(string choosenCardFromMyCards);
        void ReceiveCard(string cardForReceiving);
        bool CheckCards(string currentCard, string myCurrentCard);
        List<string> MyCards { get; }
    }
}
