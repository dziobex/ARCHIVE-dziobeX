using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    interface IBot
    {
        void Action(string currentCard, int numberOfRound, int timer);
    }
}
