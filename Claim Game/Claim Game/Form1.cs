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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cards.initializeCardsClass();
            generateFiveCards();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cards.Debug_ResetBools();
            generateFiveCards();
        }

        private void generateFiveCards()
        {
            foreach (var pictureBox in Controls.OfType<PictureBox>())
            {
                pictureBox.Image = Cards.generateRandomCard();
            }
            
        }
    }
}
