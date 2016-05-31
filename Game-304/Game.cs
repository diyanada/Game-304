using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_304
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();

            CardPack _CardPack = new CardPack();
            _CardPack.Shuffle();
            TrumpCardBox.SetCard(_CardPack.LastCard);

        }
        private void NewButton_Click(object sender, EventArgs e)
        {
            
        }
        public void CardBoxClick(object sender, EventArgs e)
        {
                      
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
