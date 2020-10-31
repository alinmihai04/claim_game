using Claim_Game.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Claim_Game
{
    class Cards
    {
        private static List<Bitmap> cardsBitmap = new List<Bitmap>();
        private static List<bool> cardsUsed = new List<bool>();
        private static List<int> cardsRank = new List<int>();
        private static List<int> cardsDeck = new List<int>();
        private static int nullCard = 0;

        public static List<Bitmap> CardsBitmap
        {
           get { return cardsBitmap; }
        }
        public List<bool> CardsUsed
        {
            get { return cardsUsed; }
        }
        public static List<int> CardsRank
        {
            get { return cardsRank; }
        }
        public static List<int> CardsDeck
        {
            get { return cardsDeck; }
        }
        public static int NullCard
        {
            get { return nullCard; }
        }

        public static void initializeCardsClass()
        {
            initializeCardsBoolArray();
            initializeCardsBitmapArray();
            initializeCardsRanks();
        }

        public static void Debug_ResetBools()
        {
            for(int i = 0; i < 52; i++)
            {
                cardsUsed[i] = false;
            }
        }

        public static void generateRandomDeck()
        {
            Random rand = new Random();
            int randIndex;

            for(int i = 0; i < 47; i++)
            {
                randIndex = rand.Next(52);

                while(cardsUsed[randIndex])
                {
                    randIndex = rand.Next(52);
                }

                cardsUsed[randIndex] = true;
                cardsDeck.Add(randIndex);
            }
            /*
            randIndex = rand.Next(cardsDeck.Count); // pentru prima carte din pachet
            firstCardIndex = cardsDeck[randIndex];
            CardsDeck.RemoveAt(randIndex);
            
            
            randIndex = rand.Next(cardsDeck.Count); // cartea nula
            nullCard = cardsDeck[randIndex];
            CardsDeck.RemoveAt(randIndex);
            */
        }


        private static void initializeCardsRanks()
        {
            for(int i = 0; i < 13; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    cardsRank.Add(i+1);
                }
            }
        }

        private static void initializeCardsBoolArray()
        {
            for(int i = 0; i < 52; i++)
            {
                cardsUsed.Add(false);
            }
        }

        private static void initializeCardsBitmapArray()
        {
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._1_1));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._1_2));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._1_3));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._1_4));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._2_1));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._2_2));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._2_3));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._2_4));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._3_1));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._3_2));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._3_3));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._3_4));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._4_1));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._4_2));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._4_3));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._4_4));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._5_1));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._5_2));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._5_3));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._5_4));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._6_1));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._6_2));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._6_3));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._6_4));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._7_1));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._7_2));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._7_3));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._7_4));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._8_1));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._8_2));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._8_3));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._8_4));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._9_1));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._9_2));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._9_3));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._9_4));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._10_1));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._10_2));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._10_3));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._10_4));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._11_1));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._11_2));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._11_3));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._11_4));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._12_1));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._12_2));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._12_3));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._12_4));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._13_1));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._13_2));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._13_3));
            cardsBitmap.Add(new Bitmap(Claim_Game.Properties.Resources._13_4));
        }

        public static Bitmap generateRandomCard(ref int returning_index)
        {
            Random rand = new Random();
            int randomImageIndex = rand.Next(52);

            while(cardsUsed.ElementAt(randomImageIndex))
            {
                randomImageIndex = rand.Next(52);
            }

            cardsUsed[randomImageIndex] = true;

            returning_index = randomImageIndex;

            return cardsBitmap[randomImageIndex];
        }
    }
}
