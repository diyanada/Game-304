using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_304
{
    public partial class Game : Form
    {
        private FourPlayers _Game;
        public Game()
        {
            InitializeComponent();      

            this._Game = new FourPlayers();

            this._Game.AddCardBox(this.CardBox1);
            this._Game.AddCardBox(this.CardBox2);
            this._Game.AddCardBox(this.CardBox3);
            this._Game.AddCardBox(this.CardBox4);
            this._Game.AddCardBox(this.CardBox5);
            this._Game.AddCardBox(this.CardBox6);
            this._Game.AddCardBox(this.CardBox7);
            this._Game.AddCardBox(this.CardBox8);

            this._Game.AddTableCardBox(this.TableCardBox1);
            this._Game.AddTableCardBox(this.TableCardBox2);
            this._Game.AddTableCardBox(this.TableCardBox3);
            this._Game.AddTableCardBox(this.TableCardBox4);
            this._Game.AddTableCardBox(this.TableCardBox5);
            this._Game.AddTableCardBox(this.TableCardBox6);

            this._Game.SystemMsg = this.SystemMsg;

            this._Game.TrumCardBox = this.TrumpCardBox;

            this._Game.Game = this;

            this._Game.NewGame();
        }
        private void NewButton_Click(object sender, EventArgs e)
        {
            this._Game.NewGame();
        }
        public void CardBoxClick(object sender, EventArgs e)
        {
            try
            {
                this._Game._CardClick(sender);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Developed yet.");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
