using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_304
{
    class CardPack
    {
        private List<Card> _Cards;
        private List<CardHand> _CardHands;
        private Random _Random;
        private int _CardPer;
        public CardPack()
        {
            this._Cards = new List<Card>();
            this._CardHands = new List<CardHand>();
            this._Random = new Random();
            this._CardPer = 8;

            foreach (Suit _Suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Face _Face in Enum.GetValues(typeof(Face)))
                {
                    Card _Card = new Card(_Suit, _Face);
                    _Cards.Add(_Card);
                }
            }
        }
        public void Shuffle()
        {

            int _Count = this.CardCount();

            while (_Count > 1)
            {
                _Count--;
                this.Swap(_Count);
            }

            this.Divide();
        }
        private void Swap(int _Count)
        {

            int k = _Random.Next(_Count + 1);
            Card _CardTemp = this._Cards[k];
            this._Cards[k] = this._Cards[_Count];
            this._Cards[_Count] = _CardTemp;
        }
        private void Divide()
        {

            List<Card> _Temp;

            int _Skip = 0;
            int _Take = this._CardPer;

            for (int i = 0; i < this._CardPer; i++)
            {
                _Temp = this._Cards.Skip(_Skip).Take(_Take).ToList();

                _Skip += _Take;

                CardHand _CardHand = new CardHand(_Temp);
                this._CardHands.Add(_CardHand);
            }
        }
        private int CardCount()
        {
            return this._Cards.Count;
        }
        public Card LastCard
        {
            get
            {
                Card _Card = this._Cards.ElementAt(7);
                return _Card;
            }
        }
    }
}
