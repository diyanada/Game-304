using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_304
{
    public class Card
    {
        public Suit _Suit;
        public Face _Face;
        private static readonly Dictionary <Face, int> _PointTable = new Dictionary <Face, int> 
        {
            { Face.Jack, 30 },
            { Face.Nine, 20 },
            { Face.Ace, 11 },
            { Face.Ten, 10 },
            { Face.King, 3 },
            { Face.Queen, 2 }
        };
        public Size _Size = new Size(150, 200);
        public Card(Suit _Suit, Face _Face)
        {

            this._Suit = _Suit;
            this._Face = _Face;
        }
        public int Points()
        {
            return _PointTable[this._Face];
        }
        public Image Graphics()
        {
            Image Card = null;
            String Path = "C:/Users/Diyanada Gunawardhan/Documents/visual studio 2013/Projects/304-Game/304-Game/bin/Debug/CardsPack/";

            try
            {
                
                Card = Image.FromFile(Path + this._Suit + "/" + this._Face + ".png");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            Card = (Image)(new Bitmap(Card, this._Size));

            return Card;
        }
        public String CardName()
        {
            return this._Suit.ToString() + "-" + this._Face.ToString();
        }
    }
}
