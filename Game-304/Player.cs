using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_304
{
    public class Player
    {
        private String _Name;
        private int _GameWins = 0;
        private int _GameFails = 0;
        private List<Card> _Hand;
        private int _Bid = 0;

        public Player(String _Name)
        {
            this._Name = _Name;
            this._Hand = new List<Card>();
        }
        public String Name
        {
            get { return this._Name; }
        }
        public List<Card> Hand
        {
            get { return this._Hand; }
        }
        public int GameWins
        {
            get { return this._GameWins; }
            set { this._GameWins += value; }
        }
        public int GameFails
        {
            get { return this._GameFails; }
            set { this._GameWins += value; }
        }
        public void Reset()
        {
            this._Hand.Clear();
            this._Bid = 0;
        }
        public void SetHand(List<Card> _Hand)
        {
            this._Hand = _Hand;
            this._Hand = this._Hand.OrderBy(i => i._Suit).ThenBy(i => i._Face).ToList();
        }
        public void FreeHand()
        {
            this._Hand = new List<Card>();
        }
    }
}
