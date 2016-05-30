using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_304
{
    class FourPlayers : GamePlay
    {        
        private Player _Partner;

        private Player _OppPlayer1;
        private Player _OppPlayer2;
        public FourPlayers() : base()
        {
            this._Table = new Table();

            this._You = new Player("You");
            this._Partner = new Player("Partner");

            this._OppPlayer1 = new Player("Opposite Player");
            this._OppPlayer2 = new Player("Opposite Player");

            this._CardClick = new CardClick(this.Epmty);

            this._Algorithm = new Algorithm();

            _Algorithm.AddPlayer(this._You);
            _Algorithm.AddPlayer(this._OppPlayer1);

            _Algorithm.AddPlayer(this._Partner);
            _Algorithm.AddPlayer(this._OppPlayer2);

            
        }
        public Player You
        {
            get { return this._You; }
        }
        public Player Partner
        {
            get { return this._Partner; }
        }
        public Player OppPlayer1
        {
            get { return this._OppPlayer1; }
        }
        public Player OppPlayer2
        {
            get { return this._OppPlayer2; }
        }
        public void Initialize()
        {           

            this._Table.Shuffle();

            this._You.SetHand(this._Table.Hand(0));

            this._Partner.SetHand(this._Table.Hand(1));

            this._OppPlayer1.SetHand(this._Table.Hand(2));

            this._OppPlayer2.SetHand(this._Table.Hand(3));
        }
        public void NewGame()
        {
            this._TrumCardBox.Image = null;
            this._TrumCardBox.Card = null;

            foreach (CardBox _Cardbox in this._PlayerCardBox)
            {
                _Cardbox.Enabled = true;
                _Cardbox.Visible = true;
            }

            this._Table = new Table();

            this.Initialize();

            this.MergeCardBox();

            this._SystemMsg.Text = "Select Trumps!";

            this._CardClick = new CardClick(this.SetTrump);
        }
        public void SetTrump(object sender)
        {

            CardBox _CardBox = (CardBox)sender;

            Card _Card = _CardBox.Card;

            this._TrumCardBox.SetCard(_Card);

            this._CardClick -= this.SetTrump;

            this._CardClick += this.Click;
        }
        public void Click(object sender)
        {
            CardBox _CardBoxSender = (CardBox)sender;

            _CardBoxSender.Image = null;
            _CardBoxSender.Enabled = false;
            _CardBoxSender.Visible = false;

            List<Card> _CardSet = this._Algorithm.FourPlayersPatner(_CardBoxSender.Card, _CardBoxSender.Player);

            for (int x = 0; x < _CardSet.Count; x++)
            {
                Card _Card = _CardSet[x];
                CardBox _CardBox = this._TableCardBox[x];

                _CardBox.SetCard(_Card);
            }
        }
    }
}
