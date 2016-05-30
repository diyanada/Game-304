using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_304
{
    class Table
    {
        private List<Card> _Cards = new List<Card>();
        private Random _Random = new Random();
        private int _CardPer = 8;
        private List<Card>[] _Hands;
        public Table()
        {

            foreach (Suit _Suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Face _Face in Enum.GetValues(typeof(Face)))
                {
                    Card _Card = new Card(_Suit, _Face);
                    _Cards.Add(_Card);
                }
            }
        }
        public List<Card> Cards
        {
            get { return this._Cards; }
        }
        public int CardPer
        {
            set
            {
                this._CardPer = value;
            }
        }
        public List<Card>[] Hands
        {
            get { return this._Hands;  }
        }
        public List<Card> Hand(int Index)
        {
            List<Card> _Return = new List<Card>(this._Hands[Index]);
            return _Return;
        }
        public List<Card>[] Shuffle()
        {

            int _Count = this.CardCount();

            while (_Count > 1)
            {
                _Count--;
                this.Swap(_Count);
            }

            this.Divide();

            return this._Hands;
        }
        private void Swap(int _Count){

            int k = _Random.Next(_Count + 1);
            Card _CardTemp = this._Cards[k];
            this._Cards[k] = this._Cards[_Count];
            this._Cards[_Count] = _CardTemp;
        }
        private void Divide()
        {
            int _HandsCount = (int)this.CardCount() / this._CardPer;

            this._Hands = new List<Card>[_HandsCount];

            List<Card> Temp;

            int _Skip = 0;
            int _Take = this._CardPer;

            for (int i = 0; i < _HandsCount; i++)
            {
                Temp = this._Cards.Skip(_Skip).Take(_Take).ToList();

                _Skip += _Take;

                this._Hands[i] = Temp;
            }
        }
        private int CardCount()
        {
            return this.Cards.Count;
        }
    }
}
