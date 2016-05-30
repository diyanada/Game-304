using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_304
{
    public class CardBox : PictureBox
    {
        private Card _Card;
        private Player _Player;
        public Card Card
        {
            get { return this._Card; }
            set { this._Card = value; }
        }
        public Player Player
        {
            get { return this._Player; }
            set { this._Player = value; }
        }
        public void SetCard(Card _Card)
        {
            this._Card = _Card;
            this.Image = _Card.Graphics();
        }
    }
}
