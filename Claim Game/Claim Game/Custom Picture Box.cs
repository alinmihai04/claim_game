using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Claim_Game
{
    class Custom_Picture_Box : PictureBox
    {
        private bool clicked = false;
        private int selectedCardIndex = 0;


        public bool Clicked
        {
            get { return clicked; }
            set { clicked = value; }
        }

        public int SelectedCardIndex
        {
            get { return selectedCardIndex; }
            set { selectedCardIndex = value; }
        }
    }
}
