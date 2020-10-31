using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Claim_Game
{
    public partial class Form1 : Form
    {
        private int selectedCardRanking = 0, lastCardIndex = 0, firstCardIndex = 0;
        private Bitmap blankImage = null;
        private bool droppedCard = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cards.initializeCardsClass();
            generateFiveCards();
            //Cards.generateRandomDeck();
        }

        // ---- FORM CONTROL FUNCTIONS

        private void button1_Click(object sender, EventArgs e)
        {
            Cards.Debug_ResetBools();
            generateFiveCards();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CardSelectEventHandler(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CardSelectEventHandler(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CardSelectEventHandler(pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CardSelectEventHandler(pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            CardSelectEventHandler(pictureBox5);
        }
        private void buttonDropCards_Click(object sender, EventArgs e)
        {
            DropCards();
        }

        // ------ ADDITIONAL FUNCTIONS

        private void generateFiveCards()
        {
            int currentIndex = 0;

            foreach (var pictureBox in Controls.OfType<Custom_Picture_Box>())
            {
                if (pictureBox == drawCardsPicture || pictureBox == lastCardPictureBox || pictureBox == droppedCardPicture || pictureBox == nullCardPicture)
                    continue;

                pictureBox.Image = Cards.generateRandomCard(ref currentIndex);

                pictureBox.BackColor = SystemColors.Control;
                pictureBox.SelectedCardIndex = currentIndex;
                pictureBox.Clicked = false;
            }

            selectedCardRanking = 0;

            drawCardsPicture.Image = Claim_Game.Properties.Resources.red_back;
        }


        private void CardSelectEventHandler(Custom_Picture_Box pictureBox)
        {
            if (pictureBox.Clicked)
            {
                pictureBox.Clicked = false;
                pictureBox.BackColor = SystemColors.Control;
                buttonDropCards.Enabled = false;
            }
            else
            {
                if(selectedCardRanking != 0 && selectedCardRanking != Cards.CardsRank[pictureBox.SelectedCardIndex])
                {
                    foreach (var pb in Controls.OfType<Custom_Picture_Box>())
                    {
                        if (pb == drawCardsPicture)
                            continue;

                        pb.Clicked = false;
                        pb.BackColor = SystemColors.Control;
                    }

                    pictureBox.Clicked = true;
                    pictureBox.BackColor = Color.Green;
                    selectedCardRanking = Cards.CardsRank[pictureBox.SelectedCardIndex];

                    lastCardIndex = pictureBox.SelectedCardIndex;
                }
                else
                {
                    pictureBox.Clicked = true;
                    pictureBox.BackColor = Color.Green;
                    selectedCardRanking = Cards.CardsRank[pictureBox.SelectedCardIndex];

                    lastCardIndex = pictureBox.SelectedCardIndex;
                }

                buttonDropCards.Enabled = true;
            }
        }

        private void drawCardsPicture_Click(object sender, EventArgs e)
        {
            if(!droppedCard)
            {
                MessageBox.Show("Drop a card first!");
            }
        }

        private void DropCards()
        {
            foreach (var pb in Controls.OfType<Custom_Picture_Box>())
            {
                if (pb == drawCardsPicture)
                    continue;

                if(pb.Clicked)
                {
                    pb.Image = null;
                    pb.BackColor = SystemColors.Control;
                }
            }

            droppedCardPicture.Image = Cards.CardsBitmap[lastCardIndex];
            droppedCard = true;
        }

    }
}
