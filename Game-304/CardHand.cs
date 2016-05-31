using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_304
{
    class CardHand
    {
        private List<Card> _Cards;
        private int _CardCount;
        public List<Card> FirstTake
        {
            get { return this._Cards.Take(this._CardCount).ToList(); }
        }
        public List<Card> SecondTake
        {
            get { return this._Cards.Skip(this._CardCount).Take(this._CardCount).ToList(); }
        }
        public List<Card> Cards
        {
            get { return this._Cards; }
        }
        public CardHand(List<Card> _Cards)
        {
            this._Cards = _Cards;
            this._CardCount = 4;
        }
    }
}
