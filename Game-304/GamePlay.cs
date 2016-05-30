using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_304
{
    class GamePlay
    {

        protected Table _Table;
        protected List<CardBox> _PlayerCardBox = new List<CardBox>();
        protected List<CardBox> _TableCardBox = new List<CardBox>();
        protected Player _You;
        protected Label _SystemMsg;
        protected CardBox _TrumCardBox;
        protected Form _Game;
        protected Algorithm _Algorithm;
        public CardClick _CardClick;
        public Label SystemMsg
        {
            set { this._SystemMsg = value; }
        }
        public Form Game
        {
            set { this._Game = value; }
        }
        public CardBox TrumCardBox
        {
            set { this._TrumCardBox = value; }
        }
        public void AddCardBox(CardBox _CardBox)
        {
            this._PlayerCardBox.Add(_CardBox);
        }
        public void AddTableCardBox(CardBox _CardBox)
        {
            this._TableCardBox.Add(_CardBox);
        }
        public void MergeCardBox()
        {
            List<Card> _Hand = this._You.Hand;

            for (int x = 0; x < _Hand.Count; x++)
            {
                Card _Card = _Hand[x];
                CardBox _CardBox = this._PlayerCardBox[x];

                _CardBox.SetCard(_Card);
                _CardBox.Player = this._You;
            }
        }
        public void Epmty(object sender){

        }
        
        
    }
}
