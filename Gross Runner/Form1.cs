using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace Gross_Runner
{
    public partial class GamePlay : Form
    {
        private double step = 1;
        private double acceleraction = 0.01;
        private Random random = new Random();
        private SoundPlayer player = new SoundPlayer(@"C:\Users\HP\source\repos\backsound.wav");
        private SoundPlayer loser = new SoundPlayer(@"C:\Users\HP\source\repos\loser.wav");
        private bool pauses = false;
        private int scoreCount = 0;

        public GamePlay()
        {
            InitializeComponent();
        }

        private void Behaviour1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                // step = -4;
                Character1.Left -= 17;
            }

            if (e.KeyCode == Keys.Right)
            {
                //step = 4;
                Character1.Left -= -17;
            }
            

        }

        private void Replace_wall()
        {
            if (Wall2.Top > 595)
            {
                Wall2.Top = random.Next(-10, -5);
                Wall2.Left = random.Next(12, 15);

            }
            if (Wall3.Top > 595)
            {
                Wall3.Top = random.Next(-45, -40);
                Wall3.Left = random.Next(252, 255);
            }

            if (Wall4.Top > 595)
            {
                Wall4.Top = random.Next(-10, -5);
                Wall4.Left = random.Next(25, 30);
            }
            if (Wall5.Top > 595)
            {
                Wall5.Top = random.Next(-80, -75);
                Wall5.Left = random.Next(150, 155);
            }

            if (Wall6.Top > 595)
            {
                Wall6.Top = random.Next(-120, -110);
                Wall6.Left = random.Next(259, 262);
            }
            if (Wall7.Top > 595)
            {
                Wall7.Top = random.Next(-95, -90);
                Wall7.Left = random.Next(341, 350);
            }
        }

        private void Crashes()
        {
            //hit the wall
            if(Character1.Bounds.IntersectsWith(Wall2.Bounds))
            {
                gameRunning.Stop();
                player.Stop();
                Character1.Enabled= false;
                Character1.Visible = false;
                try_again.Text = "Your score: " + scoreCount + ". Wanna Try Again?";
                try_again.Visible = true;
                loser.Play();
            }
            if (Character1.Bounds.IntersectsWith(Wall3.Bounds))
            {
                
                gameRunning.Stop();
                player.Stop();
                Character1.Enabled = false;
                Character1.Visible = false;
                try_again.Text = "Your score: " + scoreCount + ". Wanna Try Again?";
                try_again.Visible = true;
                loser.Play();
            }
            if (Character1.Bounds.IntersectsWith(Wall4.Bounds))
            {
                gameRunning.Stop();
                player.Stop();
                Character1.Enabled = false;
                Character1.Visible = false;
                try_again.Text = "Your score: " + scoreCount + ". Wanna Try Again?";
                try_again.Visible = true;
                loser.Play();
            }
            if (Character1.Bounds.IntersectsWith(Wall5.Bounds))
            {
                gameRunning.Stop();
                player.Stop();
                Character1.Enabled = false;
                Character1.Visible = false;
                try_again.Text = "Your score: " + scoreCount + ". Wanna Try Again?";
                try_again.Visible = true;
                loser.Play();
            }
            if (Character1.Bounds.IntersectsWith(Wall6.Bounds))
            {
                gameRunning.Stop();
                player.Stop();
                Character1.Enabled = false;
                Character1.Visible = false;
                try_again.Text = "Your score: " + scoreCount + ". Wanna Try Again?";
                try_again.Visible = true;
                loser.Play();
            }
            //ends here

            //hit the border of the form
            if(Character1.Left < 0)
            {
                gameRunning.Stop();
                player.Stop();
                Character1.Enabled = false;
                Character1.Visible = false;
                try_again.Text = "Your score: " + scoreCount + ". Wanna Try Again?";
                try_again.Visible = true;
                loser.Play();
            }
            if (Character1.Left > 435) 
            {
                gameRunning.Stop();
                player.Stop();
                Character1.Enabled = false;
                Character1.Visible = false;
                try_again.Text = "Your score: " + scoreCount + ". Wanna Try Again?";
                try_again.Visible = true;
                loser.Play();
            }
           //ends here
        }

        private void gameRunning_Tick(object sender, EventArgs e)
        {
            //count
            scoreCount++;

            step += acceleraction;
            if(step > 7)
            {
                step = 7;
            }
          //  Character1.Top -= 1;
            Wall2.Top += (int)step;
            Wall3.Top += (int)step;
            Wall4.Top += (int)step;
            Wall5.Top += (int)step;
            Wall6.Top += (int)step;
            Wall7.Top += (int)step;

            //loop the wall when hitting the top
            Replace_wall();

            //When the character hits the wall
            Crashes();

            //Show the score
            score.Text = scoreCount.ToString();

        }

        private void GamePlay_Load(object sender, EventArgs e)
        {
            //start game
            gameRunning.Start();
            player.PlayLooping();
        }

        private void try_again_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Restart_Press(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) { Application.Restart(); }
        }

        private void pause_click(object sender, EventArgs e)
        {
            if (!pauses)
            {
                pauses = true;
                gameRunning.Stop();
                Character1.Visible = false;
                player.Stop();
                Pause.Text = ">";
            }
            else
            {
                pauses = false;
                gameRunning.Start();
                Character1.Visible = true;
                player.Play();
                Pause.Text = "||";
            }
        }
    }
}
