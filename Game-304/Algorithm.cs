using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_304
{
    class Algorithm
    {
        private List<Player> _Players = new List<Player>();
        public void AddPlayer(Player _Player)
        {
            this._Players.Add(_Player);
        }
        public List<Card> FourPlayersPatner(Card _Card, Player _Player)
        {
            List<Card> _CardSet = new List<Card>();

            foreach(Player _Value in _Players){

                if (_Value == _Player)
                {
                    _CardSet.Add(_Card);
                    _Value.Hand.Remove(_Card);
                }
                else
                {
                    Card _TempCard = this.SameType(_Card, _Value.Hand);
                    _CardSet.Add(_TempCard);
                    _Value.Hand.Remove(_TempCard);
                }
            }

            return _CardSet;
        }
        private Card SameType(Card _Card, List<Card> _Hand)
        {
             Random _Random = new Random();

            Card _SelectCard = null;

            Suit _Suit = _Card._Suit;

            _SelectCard = _Hand.Find(item => item._Suit.Equals(_Suit));

            if (_SelectCard == null)
            {
                int rnd = _Random.Next(_Hand.Count);
                _SelectCard = _Hand[rnd];
            }

            return _SelectCard;
        }
    }
}
