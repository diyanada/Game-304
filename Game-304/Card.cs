using System;
using System.Configuration;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Game_304
{
    public class Card
    {
        private Suit _Suit;
        public Suit Suit
        {
            get { return this._Suit; }
        }
        private Face _Face;
        public Face Face
        {
            get { return this._Face; }
        }
        private int _Point;
        public int Point
        {
            get { return this._Point; }
        }
        private Image _Image;
        public Image Image
        {
            get { return this._Image; }
        }
        private Image _SuitImage;
        public Image SuitImage
        {
            get { return this._SuitImage; }
        }
        private Dictionary<Face, int> _PointTable;
        private Size _ImageSize;
        public Card(Suit _Suit, Face _Face)
        {
            try
            {
                this._Suit = _Suit;
                this._Face = _Face;

                int _Width = 150;
                int _Height = 200;
                this._ImageSize = new Size(_Width, _Height);

                String _ImagePath;
                _ImagePath = this.GetAppConfig("AppPath");
                _ImagePath += this.GetAppConfig("ImagePath");

                String _Image = @"\" + this.Suit.ToString() + @"\" + this.Face.ToString() + ".png";
                this._Image = this.GetImage(_ImagePath + _Image);

                _Image = @"\" + this.Suit.ToString() + ".png";
                this._SuitImage = this.GetImage(_ImagePath + _Image);
                

                this._PointTable = new Dictionary<Face, int>();

                foreach (Face _FaceTemp in Enum.GetValues(typeof(Face)))
                {
                    int _Point = int.Parse(this.GetAppConfig(_FaceTemp.ToString()));
                    _PointTable.Add(_FaceTemp, _Point);
                }

                this._Point = _PointTable[this._Face];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private Image GetImage(String _Path){

            Image _Image = Image.FromFile(_Path);
            _Image = (Image)(new Bitmap(_Image, this._ImageSize));
            return _Image;
        }
        private String GetAppConfig(String _Key){

            return ConfigurationManager.AppSettings[_Key].ToString();
        }
        public String Name
        {
            get {
                String _Name;
                _Name = this._Suit.ToString() + "-" + this._Face.ToString();
                return _Name;
            }
        }
    }
}
