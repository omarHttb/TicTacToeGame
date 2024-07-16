using Draw.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private char img1 = 'n';
        private char img2 = 'n';
        private char img3 = 'n';
        private char img4 = 'n';
        private char img5 = 'n';
        private char img6 = 'n';
        private char img7 = 'n';
        private char img8 = 'n';
        private char img9 = 'n';

        private char XorO1 = 'n';
        private char XorO2 = 'n';
        private char XorO3 = 'n';
        private char XorO4 = 'n';
        private char XorO5 = 'n';
        private char XorO6 = 'n';
        private char XorO7 = 'n';
        private char XorO8 = 'n';
        private char XorO9 = 'n';


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color white = Color.FromArgb(255, 255, 255, 255);

            Pen Pen = new Pen(white);
            Pen.Width = 10;

           // Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Triangle;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Triangle;

         
            e.Graphics.DrawLine(Pen, 700, 100, 700, 450); // last horizantal line
            e.Graphics.DrawLine(Pen, 550, 100, 550, 450);// first horizantel line
            e.Graphics.DrawLine(Pen, 850, 220, 400, 220); // first vertical
            e.Graphics.DrawLine(Pen, 850, 340, 400, 340); // last vertical


        }

        private void BoxErrorValidation()
        {

            MessageBox.Show("You have already chosen!","Error",MessageBoxButtons.OK
                , MessageBoxIcon.Error);
    
        }

        public void EndGame()
        {
            MessageBox.Show("Game Over","Game over",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Pic1.Enabled = false;
            Pic2.Enabled = false;
            Pic3.Enabled = false;
            Pic4.Enabled = false;
            Pic5.Enabled = false;
            Pic6.Enabled = false;
            Pic7.Enabled = false;
            Pic8.Enabled = false;
            Pic9.Enabled = false;
        }

       public bool GameTie()
        {
            if (img1 == 'Y' && img2 == 'Y' && img3 == 'Y' && img4 == 'Y' &&
                img5 == 'Y' && img6 == 'Y' && img7 == 'Y' && img8 == 'Y' &&
                img9 == 'Y' )
            {
                LblWhoWon.Text = "Tie";
                return true;
            }
            return false; 
        }

        public bool GameWinScenario1()
        {
            if (XorO1 == 'X' && XorO2 == 'X' && XorO3 == 'X')
            {

                LblWhoWon.Text = "Player1";
                return true;
            }
            else if (XorO1 == 'O' && XorO2 == 'O' && XorO3 == 'O')
            {
                LblWhoWon.Text = "Player2";

                return true;
            } 
            return false;
        }

        public bool GameWinScenario2()
        {
            if (XorO4 == 'X' && XorO5 == 'X' && XorO6 == 'X')
            {

                LblWhoWon.Text = "Player1";

                return true;
            }
            else if (XorO4 == 'O' && XorO5 == 'O' && XorO6 == 'O')
            {
                LblWhoWon.Text = "Player2";

                return true;
            }
            return false;
        }

        public bool GameWinScenario3()
        {
            if (XorO7 == 'X' && XorO8 == 'X' && XorO9 == 'X')
            {
                LblWhoWon.Text = "Player1";

                return true;
            }
            else if (XorO7 == 'O' && XorO8 == 'O' && XorO9 == 'O')
            {
                LblWhoWon.Text = "Player2";

                return true;
            }
            return false;
        }

        public bool GameWinScenario4()
        {
            if (XorO1 == 'X' && XorO4 == 'X' && XorO7 == 'X')
            {
                LblWhoWon.Text = "Player1";

                return true;
            }
            else if (XorO1 == 'O' && XorO4 == 'O' && XorO7 == 'O')
            {
                LblWhoWon.Text = "Player2";

                return true;
            }
            return false;
        }
        public bool GameWinScenario5()
        {
            if (XorO2 == 'X' && XorO5 == 'X' && XorO8 == 'X')
            {
                LblWhoWon.Text = "Player1";

                return true;
            }
            else if (XorO2 == 'O' && XorO5 == 'O' && XorO8 == 'O')
            {
                LblWhoWon.Text = "Player2";

                return true;
            }
            return false;
        }
        public bool GameWinScenario6()
        {
            if (XorO3 == 'X' && XorO6 == 'X' && XorO9 == 'X')
            {
                LblWhoWon.Text = "Player1";

                return true;
            }
            else if (XorO3 == 'O' && XorO6 == 'O' && XorO9 == 'O')
            {
                LblWhoWon.Text = "Player2";

                return true;
            }
            return false;
        }
        public bool GameWinScenario7()
        {
            if (XorO1 == 'X' && XorO5 == 'X' && XorO9 == 'X')
            {
                LblWhoWon.Text = "Player1";

                return true;
            }
            else if (XorO1 == 'O' && XorO5 == 'O' && XorO9 == 'O')
            {
                LblWhoWon.Text = "Player2";

                return true;
            }
            return false;
        }
        public bool GameWinScenario8()
        {
            if (XorO3 == 'X' && XorO5 == 'X' && XorO7 == 'X')
            {
                LblWhoWon.Text = "Player1";

                return true;
            }
            else if (XorO3 == 'O' && XorO5 == 'O' && XorO7 == 'O')
            {
                LblWhoWon.Text = "Player2";

                return true;
            }
            return false;
        }

        public bool WinOrTie()
        {
            if (GameTie())
            {
                LblPlayer.Text = "Game over";
                return true;
            }
            else if (GameWinScenario1())
            {
                LblPlayer.Text = "Game over";

                return true;
            }
            else if (GameWinScenario2())
            {
                LblPlayer.Text = "Game over";

                return true;
            }
            else if (GameWinScenario3())
            {
                LblPlayer.Text = "Game over";

                return true;
            }
            else if (GameWinScenario4())
            {
                LblPlayer.Text = "Game over";

                return true;
            }
            else if (GameWinScenario5())
            {
                LblPlayer.Text = "Game over";

                return true;
            }
            else if (GameWinScenario6())
            {
                LblPlayer.Text = "Game over";

                return true;
            }
            else if (GameWinScenario7())
            {
                LblPlayer.Text = "Game over";

                return true;
            }
            else if (GameWinScenario8())
            {
                LblPlayer.Text = "Game over";

                return true;
            }
            return false;
               
        }
        public void CheckWinner()
        {
            if (WinOrTie())
            {
                EndGame();
            }
        }

        private bool ValidationPic1()
        {
            if (img1 == 'Y')
            {
                return true;
            }
            else 
            {
                return false; 
            }
        }
        private bool ValidationPic2()
        {
            if (img2 == 'Y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ValidationPic3()
        {
            if (img3 == 'Y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ValidationPic4()
        {
            if (img4 == 'Y')
            {
                
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ValidationPic5()
        {
            if (img5 == 'Y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ValidationPic6()
        {
            if (img6 == 'Y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ValidationPic7()
        {
            if (img7 == 'Y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ValidationPic8()
        {
            if (img8 == 'Y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool ValidationPic9()
        {
            if (img9 == 'Y')
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void UpdatePlayer1()
        {
            LblPlayer.Text = "Player1";
        }

        private void UpdatePlayer2()
        {
            LblPlayer.Text = "Player2";
        }

        private  bool WhoIsPlaying()
        {
              if(LblPlayer.Text == "Player1")
                return true;
              else 
                return false;
        }

        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LblPlayer_Click(object sender, EventArgs e)
        {

        }
        private void Pic1_Click(object sender, EventArgs e)
        {
            if(ValidationPic1())
            {
                BoxErrorValidation();
            }
            else
            {
                if(WhoIsPlaying()) 
                {
                    Pic1.Image = Resources.X;
                    UpdatePlayer2();
                    img1 = 'Y';
                    XorO1 = 'X';
                    
                }
                else 
                {

                    Pic1.Image = Resources.O;
                    UpdatePlayer1();
                    img1 = 'Y';
                    XorO1 = 'O';


                }
                CheckWinner();
            }
        }

        private void Pic2_Click(object sender, EventArgs e)
        {
            if (ValidationPic2())
            {
                BoxErrorValidation();
            }
            else
            {
                
                
                    if (WhoIsPlaying())
                    {

                        Pic2.Image = Resources.X;
                        UpdatePlayer2();
                        img2 = 'Y';
                        XorO2 = 'X';

                    }
                    else
                    {

                        Pic2.Image = Resources.O;
                        UpdatePlayer1();
                        img2 = 'Y';
                        XorO2 = 'O';

                    }
                CheckWinner();
            }
        }

        private void Pic3_Click(object sender, EventArgs e)
        {
            if (ValidationPic3())
            {
                BoxErrorValidation();
            }
            else
            {
                if (WhoIsPlaying())
                {
                    Pic3.Image = Resources.X;
                    UpdatePlayer2();
                    img3 = 'Y';
                    XorO3 = 'X';
                }
                else
                {

                    Pic3.Image = Resources.O;
                    UpdatePlayer1();
                    img3 = 'Y';
                    XorO3 = 'O';
                }
                CheckWinner();
            }
        }

        private void Pic4_Click(object sender, EventArgs e)
        {
            if (ValidationPic4())
            {
                BoxErrorValidation();
            }
            else
            {
                if (WhoIsPlaying())
                {
                    Pic4.Image = Resources.X;
                    UpdatePlayer2();
                    img4 = 'Y';
                    XorO4 = 'X';
                }
                else
                {

                    Pic4.Image = Resources.O;
                    UpdatePlayer1();
                    img4 = 'Y';
                    XorO4 = 'O';
                }
                CheckWinner();
            }
        }

        private void Pic5_Click(object sender, EventArgs e)
        {
            if (ValidationPic5())
            {
                BoxErrorValidation();
            }
            else
            {
                if (WhoIsPlaying())
                {
                    Pic5.Image = Resources.X;
                    UpdatePlayer2();
                    img5 = 'Y';
                    XorO5 = 'X';
                }
                else
                {

                    Pic5.Image = Resources.O;
                    UpdatePlayer1();
                    img5 = 'Y';
                    XorO5 = 'O';
                }
                CheckWinner();
            }
        }

        private void Pic6_Click(object sender, EventArgs e)
        {
            if (ValidationPic6())
            {
                BoxErrorValidation();
            }
            else
            {
                if (WhoIsPlaying())
                {
                    Pic6.Image = Resources.X;
                    UpdatePlayer2();
                    img6 = 'Y';
                    XorO6 = 'X';
                }
                else
                {

                    Pic6.Image = Resources.O;
                    UpdatePlayer1();
                    img6 = 'Y';
                    XorO6 = 'O';

                }
                    CheckWinner();
            }
        }

        private void Pic7_Click(object sender, EventArgs e)
        {
            if (ValidationPic7())
            {
                BoxErrorValidation();
            }
            else
            {
                if (WhoIsPlaying())
                {
                    Pic7.Image = Resources.X;
                    UpdatePlayer2();
                    img7 = 'Y';
                    XorO7 = 'X';

                }
                else
                {

                    Pic7.Image = Resources.O;
                    UpdatePlayer1();
                    img7 = 'Y';
                    XorO7 = 'O';
                }
                CheckWinner();  
            }
        }

        private void Pic8_Click(object sender, EventArgs e)
        {
            if (ValidationPic8())
            {
                BoxErrorValidation();
            }
            else
            {
                if (WhoIsPlaying())
                {
                    Pic8.Image = Resources.X;
                    UpdatePlayer2();
                    img8 = 'Y';
                    XorO8 = 'X';

                }
                else
                {

                    Pic8.Image = Resources.O;
                    UpdatePlayer1();
                    img8 = 'Y';
                    XorO8 = 'O';

                }
                CheckWinner();
            }
        }

        private void Pic9_Click(object sender, EventArgs e)
        {
            if (ValidationPic9())
            {
                BoxErrorValidation();
            }
            else
            {
                if (WhoIsPlaying())
                {
                    Pic9.Image = Resources.X;
                    UpdatePlayer2();
                    img9 = 'Y';
                    XorO9 = 'X';

                }
                else
                {

                    Pic9.Image = Resources.O;
                    UpdatePlayer1();
                    img9 = 'Y';
                    XorO9 = 'O';

                }
                CheckWinner();
            }
        }

        private void BtnRestartGame_Click(object sender, EventArgs e)
        {
            Pic1.Image = Resources.question_mark_96;
            Pic2.Image = Resources.question_mark_96;
            Pic3.Image = Resources.question_mark_96;
            Pic4.Image = Resources.question_mark_96;
            Pic5.Image = Resources.question_mark_96;
            Pic6.Image = Resources.question_mark_96;
            Pic7.Image = Resources.question_mark_96;
            Pic8.Image = Resources.question_mark_96;
            Pic9.Image = Resources.question_mark_96;

            Pic1.Enabled = true;
            Pic2.Enabled = true;
            Pic3.Enabled = true;
            Pic4.Enabled = true;
            Pic5.Enabled = true;
            Pic6.Enabled = true;
            Pic7.Enabled = true;
            Pic8.Enabled = true;
            Pic9.Enabled = true;

            img1 = 'n';
            img2 = 'n';
            img3 = 'n';
            img4 = 'n';
            img5 = 'n';
            img6 = 'n';
            img7 = 'n';
            img8 = 'n';
            img9 = 'n';

            XorO1 = 'n';
            XorO2 = 'n';
            XorO3 = 'n';
            XorO4 = 'n';
            XorO5 = 'n';
            XorO6 = 'n';
            XorO7 = 'n';
            XorO8 = 'n';
                XorO9 = 'n';

    }
}
}
