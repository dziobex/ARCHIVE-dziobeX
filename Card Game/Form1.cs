using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardGame
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        static string[] nicknames = new string[] { "GoodDinosaur88", "Mr#Platypus", "unknow_user71", "shrimpy123", "superKnight", "cactustheHERO", "ohno", "mewthree",
            "dogger01"};
        static string[] extraRoles = new string[] { "cheater", "magician", "helper" };
        static string[] cards = new string[]
        {
            "ace clubs", "ace diamonds", "ace hearts", "ace spades",
            "clubs queen", "diamonds queen", "hearts queen", "spades queen",
            "clubs king", "diamonds king", "hearts king", "spades king",
            "clubs jack", "diamonds jack", "hearts jack", "spades jack",
            "clubs num 2", "clubs num 3", "clubs num 4", "clubs num 5", "clubs num 6", "clubs num 7", "clubs num 8", "clubs num 9", "clubs num 10",
            "diamonds num 2", "diamonds num 3", "diamonds num 4", "diamonds num 5", "diamonds num 6", "diamonds num 7", "diamonds num 8", "diamonds num 9", "diamonds num 10",
            "hearts num 2", "hearts num 3", "hearts num 4", "hearts num 5", "hearts num 6", "hearts num 7", "hearts num 8", "hearts num 9", "hearts num 10",
            "spades num 2", "spades num 3", "spades num 4", "spades num 5", "spades num 6", "spades num 7", "spades num 8", "spades num 9", "spades num 10"
        };

        List<string> playersCards = new List<string>();

        Player p;
        Bot[] bots;
        List<string>[] botsCards = new List<string>[3];

        int timer = 0;
        int numberOfRound = 0;
        bool isPlayerRound = false;

        public Form1()
        {
            InitializeComponent();
            bots = new Bot[3];

            comboBox2.Enabled = false;
            passCard.Enabled = false;
            takeNewCard.Enabled = false;

            foreach (string nick in nicknames)
                comboBox1.Items.Add(nick);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                isPlayerRound = false;
                timer = 0;
                currentCard = null;
                renewBtn.Visible = true;
                startBtn.Visible = false;
                comboBox1.Enabled = false;

                comboBox2.Enabled = false;
                passCard.Enabled = false;
                takeNewCard.Enabled = false;

                playersCards = GetRandomCards(playersCards);
                p = new Player(comboBox1.Text, playersCards, cards);

                nickTxt.Text = "Nickname: " + p.GetNickname;
                comboBox2.Items.Clear();

                foreach (string c in playersCards)
                    comboBox2.Items.Add(c);

                PrepareBotsForGame();
                gameTimer.Enabled = true;
            }
            else
                MessageBox.Show("You did not choose your nickname.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void renewBtn_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            startBtn.Visible = true;
            renewBtn.Visible = false;
            gameTimer.Enabled = false;
            comboBox2.Enabled = false;
            passCard.Enabled = false;
            takeNewCard.Enabled = false;
            prepareEverythingForNewGame();
        }

        private List<string> GetRandomCards(List<string> currentCards)
        {
            currentCards.Clear();
            for (int i=0; i<5; i++)
                currentCards.Add(cards[randomizer.Next(cards.Length)]);
            return currentCards;
        }

        private void PrepareBotsForGame()
        {
            string nick = nicknames[0];
            for (int i=0; i<botsCards.Length; i++)
            {
                nick = nicknames[randomizer.Next(nicknames.Length)];
                while (checkForReplays(bots, i, nick))
                    nick = nicknames[randomizer.Next(nicknames.Length)];
                botsCards[i] = new List<string>();
                botsCards[i] = GetRandomCards(botsCards[i]);
                bots[i] = new Bot(nick, botsCards[i], cards);
            }
        }

        private bool checkForReplays(Bot[] bots, int a, string nick)
        {
            if (nick == p.GetNickname)
                return true;
            for (int i=0; i<a; i++)
                if (bots[i].GetNickname == nick)
                    return true;
            return false;
        }

        string currentCard;

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (!isPlayerRound)
            {
                if (timer == 0)
                    textBox1.Text = "";
                if (timer <= 2)
                {
                    bots[timer].Action(currentCard, numberOfRound, timer);
                    currentCard = bots[timer].CurrentCard;
                    upLabel.Text = "current card: " + currentCard;
                    textBox1.Text += bots[timer].ShowState;
                    prepareHighcores();
                    lookForWinner();
                    timer++;
                }
                else
                {
                    warningYourTurn.Visible = true;
                    gameTimer.Enabled = false;
                    isPlayerRound = true;
                    warningYourTurn.Visible = true;
                    comboBox2.Enabled = true;
                    passCard.Enabled = true;
                    takeNewCard.Enabled = true;
                }
            }
        }

        private void everythingEnabledEqualsFalse()
        {
            foreach (Control c in Controls)
                if (c != menuStrip1 && c != renewBtn)
                    c.Enabled = false;
        }

        private void prepareEverythingForNewGame()
        {
            warningYourTurn.Visible = false;
            foreach (Control c in Controls)
                if (c != comboBox2 && c != passCard && c != takeNewCard)
                    c.Enabled = true;
            PrepareBotsForGame();
            textBox1.Text = "Nobody is playing";
            textBox2.Text = "Nobody is playing.";
        }

        private void prepareHighcores()
        {
            int[] highscores = new int[4];
            string[] highNicks = new string[4];
            textBox2.Text = "";
            for (int i = 0; i < 3; i++)
            {
                highscores[i] = bots[i].HowManyCards;
                highNicks[i] = bots[i].GetNickname;
            }
            highscores[3] = p.HowManyCards;
            highNicks[3] = p.GetNickname;

            sortedHsByID(highscores, highNicks);

            for (int i = 0; i < 4; i++)
                textBox2.Text += highNicks[i] + " has " + highscores[i].ToString() + " cards\r\n";
        }

        private void sortedHsByID(int[] highscores, string[] nicks)
        {
            for (int i=0; i<highscores.Length; i++)
            {
                for (int j=0; j<highscores.Length-1; j++)
                {
                    if (highscores[j] > highscores[j+1])
                    {
                        int helper = highscores[j];
                        highscores[j] = highscores[j + 1];
                        highscores[j + 1] = helper;
                        string helper2 = nicks[j];
                        nicks[j] = nicks[j + 1];
                        nicks[j + 1] = helper2;
                    }
                }
            }
        }

        bool infoAboutWinning = true;
        private void lookForWinner()
        {
            foreach (Bot b in bots) {
                if (b.Win() && infoAboutWinning)
                {
                    infoAboutWinning = false;
                    everythingEnabledEqualsFalse();
                    MessageBox.Show(p.GetNickname + " won!");
                }
            }
            if (p.Win() && infoAboutWinning)
            {
                infoAboutWinning = false;
                everythingEnabledEqualsFalse();
                MessageBox.Show(p.GetNickname + " won!");
            }
            int sum = 0;
            foreach (Bot b in bots)
                sum += b.ReceivenCards;
            sum += p.ReceivenCards;
            if (sum >= 52 && infoAboutWinning)
            {
                infoAboutWinning = false;
                everythingEnabledEqualsFalse();
                MessageBox.Show("Nobody won.");
            }
        }

        private void passCard_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "")
            {
                errorProvider1.SetError(comboBox2, "You did not select card.");
                return;
            }
            else
            {
                errorProvider1.SetError(passCard, null);
                errorProvider1.SetError(comboBox2, null);
                if (currentCard != null && p.CheckCards(currentCard, comboBox2.Text))
                {
                    p.GiveCard(comboBox2.Text);
                    currentCard = comboBox2.Text;
                    upLabel.Text = "current card: " + currentCard;
                    updateListOfMyCard();
                    prepareHighcores();
                    itIsNotPlayersRound();
                    lookForWinner();
                    return;
                }
                else
                {
                    errorProvider1.SetError(passCard, null);
                    if (currentCard != null)
                    {
                        errorProvider1.SetError(passCard, "You do not have required card.");
                        return;
                    }
                    else
                    {
                        p.GiveCard(comboBox2.Text);
                        currentCard = comboBox2.Text;
                        upLabel.Text = "current card: " + currentCard;
                        updateListOfMyCard();
                        prepareHighcores();
                        itIsNotPlayersRound();
                        lookForWinner();
                        return;
                    }
                }
            }
        }

        private void itIsNotPlayersRound()
        {
            isPlayerRound = false;
            warningYourTurn.Visible = false;
            comboBox2.Enabled = false;
            passCard.Enabled = false;
            takeNewCard.Enabled = false;
            timer = 0;
            comboBox2.Enabled = false;
            passCard.Enabled = false;
            takeNewCard.Enabled = false;
            gameTimer.Enabled = true;
        }

        private void updateListOfMyCard()
        {
            comboBox2.Items.Clear();
            foreach (string c in p.MyCards)
                comboBox2.Items.Add(c);
        }

        private void takeNewCard_Click(object sender, EventArgs e)
        {
            p.ReceiveCard(cards[randomizer.Next(cards.Length)]);
            updateListOfMyCard();
            prepareHighcores();
            itIsNotPlayersRound();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game created by: Dziobax1\r\n" +
                "— WARNING —\r\nIt is not macao, solitaire.\r\nThis game was based on these games, but rules are different.\r\n" +
                "There are 2 types of card: functional and non-functional. More about them in the next category.\r\n" +
                "— GAME —\r\n" + "You should start game with non-functional card. Next, your task is put a card that maches to current card (look at type of card, number of card...)\r\n" +
                "Player can ALWAYS put ace, i.e. even on a different type of card. If previous player has put ace, you can put your card in, but only if it is of the same type as the ace type.");
        }

        private void cardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("— Functional cards —\r\n" +
                "*ace (clubs, diamonds, hearts, spades)\r\n" +
                "*queen (clubs, diamonds, hearts, spades)\r\n" +
                "*king (clubs, diamonds, hearts, spades)\r\n" +
                "*jack (clubs, diamonds, hearts, spades)\r\n" +
                "— Non-Fuctional —\r\n" +
                "*clubs num <2;10>\r\n" +
                "*diamonds num <2;10>\r\n" +
                "*hearts num <2;10>\r\n" +
                "*spades num <2;10>\r\n");
        }
    }
}
