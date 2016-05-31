namespace Game_304
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SystemMsg = new System.Windows.Forms.Label();
            this.DevelopedLabel = new System.Windows.Forms.Label();
            this.NewButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TableCardBox4 = new Game_304.CardBox();
            this.TableCardBox3 = new Game_304.CardBox();
            this.TableCardBox2 = new Game_304.CardBox();
            this.TableCardBox1 = new Game_304.CardBox();
            this.LossPane = new System.Windows.Forms.Panel();
            this.LossLabel = new System.Windows.Forms.Label();
            this.LosTopic = new System.Windows.Forms.Label();
            this.WinsPane = new System.Windows.Forms.Panel();
            this.WinLabel = new System.Windows.Forms.Label();
            this.WinTopic = new System.Windows.Forms.Label();
            this.TrumpPane = new System.Windows.Forms.Panel();
            this.TrumpCardBox = new Game_304.CardBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CardBox8 = new Game_304.CardBox();
            this.CardBox7 = new Game_304.CardBox();
            this.CardBox6 = new Game_304.CardBox();
            this.CardBox5 = new Game_304.CardBox();
            this.CardBox4 = new Game_304.CardBox();
            this.CardBox3 = new Game_304.CardBox();
            this.CardBox2 = new Game_304.CardBox();
            this.CardBox1 = new Game_304.CardBox();
            this.MainPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableCardBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableCardBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableCardBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableCardBox1)).BeginInit();
            this.LossPane.SuspendLayout();
            this.WinsPane.SuspendLayout();
            this.TrumpPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrumpCardBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CardBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainPanel.Controls.Add(this.panel3);
            this.MainPanel.Controls.Add(this.DevelopedLabel);
            this.MainPanel.Controls.Add(this.NewButton);
            this.MainPanel.Controls.Add(this.ExitButton);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Controls.Add(this.LossPane);
            this.MainPanel.Controls.Add(this.WinsPane);
            this.MainPanel.Controls.Add(this.TrumpPane);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Location = new System.Drawing.Point(10, 10);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(760, 540);
            this.MainPanel.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SystemMsg);
            this.panel3.Location = new System.Drawing.Point(221, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(272, 59);
            this.panel3.TabIndex = 19;
            // 
            // SystemMsg
            // 
            this.SystemMsg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SystemMsg.AutoSize = true;
            this.SystemMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SystemMsg.ForeColor = System.Drawing.Color.Red;
            this.SystemMsg.Location = new System.Drawing.Point(63, 24);
            this.SystemMsg.Name = "SystemMsg";
            this.SystemMsg.Size = new System.Drawing.Size(0, 13);
            this.SystemMsg.TabIndex = 0;
            this.SystemMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DevelopedLabel
            // 
            this.DevelopedLabel.AutoSize = true;
            this.DevelopedLabel.Font = new System.Drawing.Font("Bodoni MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevelopedLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DevelopedLabel.Location = new System.Drawing.Point(231, 521);
            this.DevelopedLabel.Name = "DevelopedLabel";
            this.DevelopedLabel.Size = new System.Drawing.Size(322, 16);
            this.DevelopedLabel.TabIndex = 18;
            this.DevelopedLabel.Text = "Developed By - Diyanada J. Gunawardena  (diyanada@gmail.com)";
            // 
            // NewButton
            // 
            this.NewButton.Location = new System.Drawing.Point(499, 240);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(100, 50);
            this.NewButton.TabIndex = 16;
            this.NewButton.Text = "New Game";
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(605, 240);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(100, 50);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TableCardBox4);
            this.panel2.Controls.Add(this.TableCardBox3);
            this.panel2.Controls.Add(this.TableCardBox2);
            this.panel2.Controls.Add(this.TableCardBox1);
            this.panel2.Location = new System.Drawing.Point(381, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 220);
            this.panel2.TabIndex = 11;
            // 
            // TableCardBox4
            // 
            this.TableCardBox4.Location = new System.Drawing.Point(160, 10);
            this.TableCardBox4.Margin = new System.Windows.Forms.Padding(0);
            this.TableCardBox4.Name = "TableCardBox4";
            this.TableCardBox4.Size = new System.Drawing.Size(150, 200);
            this.TableCardBox4.TabIndex = 6;
            this.TableCardBox4.TabStop = false;
            // 
            // TableCardBox3
            // 
            this.TableCardBox3.Location = new System.Drawing.Point(110, 10);
            this.TableCardBox3.Margin = new System.Windows.Forms.Padding(0);
            this.TableCardBox3.Name = "TableCardBox3";
            this.TableCardBox3.Size = new System.Drawing.Size(150, 200);
            this.TableCardBox3.TabIndex = 5;
            this.TableCardBox3.TabStop = false;
            // 
            // TableCardBox2
            // 
            this.TableCardBox2.Location = new System.Drawing.Point(60, 10);
            this.TableCardBox2.Margin = new System.Windows.Forms.Padding(0);
            this.TableCardBox2.Name = "TableCardBox2";
            this.TableCardBox2.Size = new System.Drawing.Size(150, 200);
            this.TableCardBox2.TabIndex = 4;
            this.TableCardBox2.TabStop = false;
            // 
            // TableCardBox1
            // 
            this.TableCardBox1.Location = new System.Drawing.Point(10, 10);
            this.TableCardBox1.Margin = new System.Windows.Forms.Padding(0);
            this.TableCardBox1.Name = "TableCardBox1";
            this.TableCardBox1.Size = new System.Drawing.Size(150, 200);
            this.TableCardBox1.TabIndex = 3;
            this.TableCardBox1.TabStop = false;
            // 
            // LossPane
            // 
            this.LossPane.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.LossPane.Controls.Add(this.LossLabel);
            this.LossPane.Controls.Add(this.LosTopic);
            this.LossPane.Location = new System.Drawing.Point(135, 235);
            this.LossPane.Name = "LossPane";
            this.LossPane.Size = new System.Drawing.Size(80, 60);
            this.LossPane.TabIndex = 14;
            // 
            // LossLabel
            // 
            this.LossLabel.AutoSize = true;
            this.LossLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LossLabel.Location = new System.Drawing.Point(30, 25);
            this.LossLabel.Name = "LossLabel";
            this.LossLabel.Size = new System.Drawing.Size(24, 25);
            this.LossLabel.TabIndex = 16;
            this.LossLabel.Text = "0";
            // 
            // LosTopic
            // 
            this.LosTopic.AutoSize = true;
            this.LosTopic.Location = new System.Drawing.Point(25, 8);
            this.LosTopic.Name = "LosTopic";
            this.LosTopic.Size = new System.Drawing.Size(29, 13);
            this.LosTopic.TabIndex = 16;
            this.LosTopic.Text = "Loss";
            // 
            // WinsPane
            // 
            this.WinsPane.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.WinsPane.Controls.Add(this.WinLabel);
            this.WinsPane.Controls.Add(this.WinTopic);
            this.WinsPane.Location = new System.Drawing.Point(45, 235);
            this.WinsPane.Name = "WinsPane";
            this.WinsPane.Size = new System.Drawing.Size(80, 60);
            this.WinsPane.TabIndex = 13;
            // 
            // WinLabel
            // 
            this.WinLabel.AutoSize = true;
            this.WinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinLabel.Location = new System.Drawing.Point(27, 25);
            this.WinLabel.Name = "WinLabel";
            this.WinLabel.Size = new System.Drawing.Size(24, 25);
            this.WinLabel.TabIndex = 15;
            this.WinLabel.Text = "0";
            // 
            // WinTopic
            // 
            this.WinTopic.AutoSize = true;
            this.WinTopic.Location = new System.Drawing.Point(24, 8);
            this.WinTopic.Name = "WinTopic";
            this.WinTopic.Size = new System.Drawing.Size(31, 13);
            this.WinTopic.TabIndex = 15;
            this.WinTopic.Text = "Wins";
            // 
            // TrumpPane
            // 
            this.TrumpPane.Controls.Add(this.TrumpCardBox);
            this.TrumpPane.Location = new System.Drawing.Point(45, 10);
            this.TrumpPane.Name = "TrumpPane";
            this.TrumpPane.Size = new System.Drawing.Size(170, 220);
            this.TrumpPane.TabIndex = 12;
            // 
            // TrumpCardBox
            // 
            this.TrumpCardBox.Location = new System.Drawing.Point(10, 11);
            this.TrumpCardBox.Margin = new System.Windows.Forms.Padding(0);
            this.TrumpCardBox.Name = "TrumpCardBox";
            this.TrumpCardBox.Size = new System.Drawing.Size(150, 200);
            this.TrumpCardBox.TabIndex = 11;
            this.TrumpCardBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CardBox8);
            this.panel1.Controls.Add(this.CardBox7);
            this.panel1.Controls.Add(this.CardBox6);
            this.panel1.Controls.Add(this.CardBox5);
            this.panel1.Controls.Add(this.CardBox4);
            this.panel1.Controls.Add(this.CardBox3);
            this.panel1.Controls.Add(this.CardBox2);
            this.panel1.Controls.Add(this.CardBox1);
            this.panel1.Location = new System.Drawing.Point(45, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 220);
            this.panel1.TabIndex = 2;
            // 
            // CardBox8
            // 
            this.CardBox8.Location = new System.Drawing.Point(500, 10);
            this.CardBox8.Margin = new System.Windows.Forms.Padding(0);
            this.CardBox8.Name = "CardBox8";
            this.CardBox8.Size = new System.Drawing.Size(150, 200);
            this.CardBox8.TabIndex = 10;
            this.CardBox8.TabStop = false;
            this.CardBox8.Click += new System.EventHandler(this.CardBoxClick);
            // 
            // CardBox7
            // 
            this.CardBox7.Location = new System.Drawing.Point(430, 10);
            this.CardBox7.Margin = new System.Windows.Forms.Padding(0);
            this.CardBox7.Name = "CardBox7";
            this.CardBox7.Size = new System.Drawing.Size(150, 200);
            this.CardBox7.TabIndex = 9;
            this.CardBox7.TabStop = false;
            this.CardBox7.Click += new System.EventHandler(this.CardBoxClick);
            // 
            // CardBox6
            // 
            this.CardBox6.Location = new System.Drawing.Point(360, 10);
            this.CardBox6.Margin = new System.Windows.Forms.Padding(0);
            this.CardBox6.Name = "CardBox6";
            this.CardBox6.Size = new System.Drawing.Size(150, 200);
            this.CardBox6.TabIndex = 8;
            this.CardBox6.TabStop = false;
            this.CardBox6.Click += new System.EventHandler(this.CardBoxClick);
            // 
            // CardBox5
            // 
            this.CardBox5.Location = new System.Drawing.Point(290, 10);
            this.CardBox5.Margin = new System.Windows.Forms.Padding(0);
            this.CardBox5.Name = "CardBox5";
            this.CardBox5.Size = new System.Drawing.Size(150, 200);
            this.CardBox5.TabIndex = 7;
            this.CardBox5.TabStop = false;
            this.CardBox5.Click += new System.EventHandler(this.CardBoxClick);
            // 
            // CardBox4
            // 
            this.CardBox4.Location = new System.Drawing.Point(220, 10);
            this.CardBox4.Margin = new System.Windows.Forms.Padding(0);
            this.CardBox4.Name = "CardBox4";
            this.CardBox4.Size = new System.Drawing.Size(150, 200);
            this.CardBox4.TabIndex = 6;
            this.CardBox4.TabStop = false;
            this.CardBox4.Click += new System.EventHandler(this.CardBoxClick);
            // 
            // CardBox3
            // 
            this.CardBox3.Location = new System.Drawing.Point(150, 10);
            this.CardBox3.Margin = new System.Windows.Forms.Padding(0);
            this.CardBox3.Name = "CardBox3";
            this.CardBox3.Size = new System.Drawing.Size(150, 200);
            this.CardBox3.TabIndex = 5;
            this.CardBox3.TabStop = false;
            this.CardBox3.Click += new System.EventHandler(this.CardBoxClick);
            // 
            // CardBox2
            // 
            this.CardBox2.Location = new System.Drawing.Point(80, 10);
            this.CardBox2.Margin = new System.Windows.Forms.Padding(0);
            this.CardBox2.Name = "CardBox2";
            this.CardBox2.Size = new System.Drawing.Size(150, 200);
            this.CardBox2.TabIndex = 4;
            this.CardBox2.TabStop = false;
            this.CardBox2.Click += new System.EventHandler(this.CardBoxClick);
            // 
            // CardBox1
            // 
            this.CardBox1.Location = new System.Drawing.Point(10, 10);
            this.CardBox1.Margin = new System.Windows.Forms.Padding(0);
            this.CardBox1.Name = "CardBox1";
            this.CardBox1.Size = new System.Drawing.Size(150, 200);
            this.CardBox1.TabIndex = 3;
            this.CardBox1.TabStop = false;
            this.CardBox1.Click += new System.EventHandler(this.CardBoxClick);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainPanel);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game 304";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableCardBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableCardBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableCardBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableCardBox1)).EndInit();
            this.LossPane.ResumeLayout(false);
            this.LossPane.PerformLayout();
            this.WinsPane.ResumeLayout(false);
            this.WinsPane.PerformLayout();
            this.TrumpPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TrumpCardBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CardBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CardBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label WinTopic;
        private System.Windows.Forms.Panel LossPane;
        private System.Windows.Forms.Panel WinsPane;
        private System.Windows.Forms.Panel TrumpPane;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LosTopic;
        private System.Windows.Forms.Label LossLabel;
        private System.Windows.Forms.Label WinLabel;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DevelopedLabel;
        public CardBox CardBox8;
        public CardBox CardBox7;
        public CardBox CardBox6;
        public CardBox CardBox5;
        public CardBox CardBox4;
        public CardBox CardBox3;
        public CardBox CardBox2;
        public CardBox CardBox1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label SystemMsg;
        public CardBox TrumpCardBox;
        public CardBox TableCardBox4;
        public CardBox TableCardBox3;
        public CardBox TableCardBox2;
        public CardBox TableCardBox1;
    }
}

