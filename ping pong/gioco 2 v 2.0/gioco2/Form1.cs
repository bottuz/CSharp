using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gioco2
{
    public partial class Form1 : Form
    {
        // Dichiarazione delle variabili;
        bool mod1;
        bool mod2;
        bool ballup;
        bool balldown;
        bool ballleft;
        bool ballright;
        int red;
        int green;
        int xball;
        int yball;
        int yplayer1;
        int yplayer2;
        int velplayer1;
        int scoreplayer1;
        int scoreplayer2;
        int extrahorvelball;
        int extravervelball;
        // Carica la Form1;
        public Form1()
        {
            InitializeComponent();
            reset();
            Begin();
        }
        // Esegue il codice dopo 1 millisecondo;
        private void timer_Tick(object sender, EventArgs e)
        {
            Condition();
            Ball();
            Player1();
            Player2();
            Output();
            Refresh();
        }
        // Esegue il codice dopo 1 millisecondo;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Win();
            GameOver();
        }
        // Esegue il codice dopo 5 secondi;
        private void timer2_Tick(object sender, EventArgs e)
        {
            reset();
            Begin();
        }
        // esegue il codice al caricamento della form1
        private void Begin()
        {
            scoreplayer1 = 0;
            scoreplayer2 = 0;
            extrahorvelball = 0;
            extravervelball = 0;
            timer.Enabled = false;
            timer1.Enabled = false;
            timer2.Enabled = false;
            youwin.Visible = false;
            pingpong.Visible = true;
            gameover.Visible = false;
            pressenter.Visible = true;
        }
        // inizia il gioco
        private void StartGame()
        {
            timer.Enabled = true;
            timer1.Enabled = true;
            panel1.Visible = false;
            pingpong.Visible = false;
            pressenter.Visible = false;
        }
        // Muove la palla;
        private void Ball()
        {
            ball Ball = new ball();
            xball = Ball.MoveHorizontal(xball, ballright, ballleft, extrahorvelball);
            yball = Ball.MoveVertical(yball, ballup, balldown, extravervelball);
        }
        // Muove il giocatore 1;
        private void Player1()
        {
            if (yplayer1 + velplayer1 < 228 && yplayer1 + velplayer1 > 0) yplayer1 += velplayer1;
        }
        // Muove il giocatore 2;
        private void Player2()
        {
            if (xball >= 300)
            {
                if (yball > yplayer2 + 33 && yplayer2 + 6 < 228) yplayer2 += 6;
                if (yball < yplayer2 + 33 && yplayer2 - 6 > 0) yplayer2 -= 6;
            }
        }
        // Classe per il movimento della palla;
        class ball
        {
            public int MoveHorizontal(int x, bool ballright, bool ballleft, int extrahorvelball)
            {
                if (ballright) return x + 8 + extrahorvelball;
                else return x - 8 - extrahorvelball;
            }
            public int MoveVertical(int y, bool ballup, bool balldown, int extravervelball)
            {
                if (ballup) return y - 3 - extravervelball;
                else return y + 3 + extravervelball;
            }
        }
        // Disegna la palla e i due rettangoli;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush GreenBrush = new SolidBrush(Color.FromArgb(40, 255, 40));
            SolidBrush WhiteBrush = new SolidBrush(Color.White);
            Rectangle ball = new Rectangle(xball, yball, 15, 15);
            Rectangle rect1 = new Rectangle(10, yplayer1, 10, 100);
            Rectangle rect2 = new Rectangle(564, yplayer2, 10, 100);
            e.Graphics.FillEllipse(WhiteBrush, ball);
            e.Graphics.FillRectangle(GreenBrush, rect1);
            e.Graphics.FillRectangle(GreenBrush, rect2);
        }
        // Resetta le variabili;
        private void reset()
        {
            red = 40;
            green = 40;
            xball = 25;
            yball = 156;
            yplayer1 = 113;
            yplayer2 = 113;
            mod1 = true;
            mod2 = false;
            ballright = true;
            ballleft = false;
            if (ballup) { ballup = false; balldown = true; }
            else { ballup = true; balldown = false; }
        }
        // Output dei punti;
        private void Output()
        {
            label1.Text = scoreplayer1.ToString();
            label2.Text = scoreplayer2.ToString();
        }
        // Serie di condizioni per il movimento della palla;
        private void Condition()
        {
            if (xball + 4 >= 550 && ballright && yball + 15 >= yplayer2 && yball <= yplayer2 + 100) { ballleft = true; ballright = false; }
            if (xball + 4 >= 550 && yball + 15 < yplayer2 || xball + 4 >= 550 && yball > yplayer2 + 100) { scoreplayer1++; if (scoreplayer1 == 2) { extrahorvelball++; extravervelball++; } if (scoreplayer1 < 3) reset(); }
            if (xball - 4 <= 16 && ballleft && yball + 15 >= yplayer1 && yball <= yplayer1 + 100) { ballright = true; ballleft = false; }
            if (xball - 4 <= 16 && yball + 15 < yplayer1 || xball - 4 <= 16 && yball > yplayer1 + 100) { scoreplayer2++; if (scoreplayer2 < 3) reset(); }
            if (yball + 1 > 313 && balldown) { balldown = false; ballup = true; }
            if (yball - 1 < 1 && ballup) { balldown = true; ballup = false; }
        }
        // Game over
        private void GameOver()
        {
            if (scoreplayer2 == 3)
            {
                panel1.Visible = true;
                timer.Enabled = false;
                timer2.Enabled = true;
                gameover.Visible = true;
                if (mod1) red+=5;
                if (mod2) red-=5;
                if (red == 255) { mod2 = true; mod1 = false; }
                if (red == 40) { mod1 = true; mod2 = false; }
                gameover.ForeColor = Color.FromArgb(red, 40, 40);
            }
        }
        // won
        private void Win() {
            if (scoreplayer1 == 3)
            {
                panel1.Visible = true;
                timer.Enabled = false;
                timer2.Enabled = true;
                youwin.Visible = true;
                if (mod1) green += 5;
                if (mod2) green -= 5;
                if (green == 255) { mod2 = true; mod1 = false; }
                if (green == 40) { mod2 = false; mod1 = true; }
                youwin.ForeColor = Color.FromArgb(40, green, 40);
            }
        }
        // Tasto premuto;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) velplayer1 = -6;
            if (e.KeyCode == Keys.Down) velplayer1 = 6;
            if (e.KeyCode == Keys.Enter && scoreplayer1 < 1 && scoreplayer2 < 1) StartGame();
        }
        // Tasto rilasciato;
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) velplayer1 = 0;
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
