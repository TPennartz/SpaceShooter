using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SpaceShooter
{
    public partial class Form1 : Form
    {
        //sound
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootgMedia;
        WindowsMediaPlayer explosion;

        //stars
        PictureBox[] stars;
        int backgroundspeed;
        Random rnd;
        int playerSpeed;

        //munitions
        PictureBox[] munitions;
        int MunitionSpeed;

        //enemies
        PictureBox[] enemies;
        int enemySpeed;
        PictureBox[] enemiesMunition;
        int enemyMunitionSpeed;

        int score;
        int level;
        int difficulty;
        bool pause;
        bool gameIsOver;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_load_1(object sender, EventArgs e)
        {
            pause = false;
            gameIsOver = false;
            score = 0;
            level = 1;
            difficulty = 9;
            //Enemy stat and images
            enemySpeed = 4;
            Image enemy1 = Image.FromFile("asserts\\E1.png");
            Image enemy2 = Image.FromFile("asserts\\E2.png");
            Image enemy3 = Image.FromFile("asserts\\E3.png");
            Image boss1 = Image.FromFile("asserts\\Boss1.png");
            Image boss2 = Image.FromFile("asserts\\Boss2.png");

            enemies = new PictureBox[10];

            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(40, 40);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].Visible = false;
                this.Controls.Add(enemies[i]);
                enemies[i].Location = new Point((i + 1) * 50, -50);
            }
            enemies[0].Image = boss1;
            enemies[1].Image = enemy2;
            enemies[2].Image = enemy3;
            enemies[3].Image = enemy3;
            enemies[4].Image = enemy1;
            enemies[5].Image = enemy3;
            enemies[6].Image = enemy2;
            enemies[7].Image = enemy3;
            enemies[8].Image = enemy2;
            enemies[9].Image = boss2;
            

            backgroundspeed = 4;
            stars = new PictureBox[15];
            rnd = new Random();
            playerSpeed = 4;

            //Creating the game sound
            gameMedia = new WindowsMediaPlayer();
            shootgMedia = new WindowsMediaPlayer();
            explosion = new WindowsMediaPlayer();

            //Load the songs
            gameMedia.URL = "songs\\GameSong.mp3";
            shootgMedia.URL = "songs\\shoot.mp3";
            explosion.URL = "songs\\boom.mp3";

            //Setup Song Settings
            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            shootgMedia.settings.volume = 1;
            explosion.settings.volume = 3;

            enemyMunitionSpeed = 4;
            MunitionSpeed = 20;
            munitions = new PictureBox[3];

            //Load muntion image
            Image munition = Image.FromFile(@"asserts\munition.png");

            for(int i = 0; i < munitions.Length; i++)
            {
                munitions[i] = new PictureBox();
                munitions[i].Size = new Size(8, 8);
                munitions[i].Image = munition;
                munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                munitions[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(munitions[i]);
            }
            //This is the process for making the stars move in the background

            for(int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 580), rnd.Next(-10, 400));
                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(stars[i]);
            }
            gameMedia.controls.play();

            enemiesMunition = new PictureBox[10];

            for (int i = 0; i <  enemiesMunition.Length; i++)
            {
                enemiesMunition[i] = new PictureBox();
                enemiesMunition[i].Size = new Size(2, 25);
                enemiesMunition[i].Visible = false;
                enemiesMunition[i].BackColor = Color.Yellow;
                int x = rnd.Next(0, 10);
                enemiesMunition[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);
                this.Controls.Add(enemiesMunition[i]);
            }
            gameMedia.controls.play();
        }
        //This is to adjust the speed of the stars in the background
        private void MoveBigTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length /2; i++)
            {
                stars[i].Top += backgroundspeed;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
            for (int i = stars.Length /2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundspeed - 2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void LeftMove_timer_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 10)
            {
                Player.Left -= playerSpeed;
            }
        }

        private void RightMove_timer_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 580)
            {
                Player.Left += playerSpeed;
            }
        }

        private void DownMove_timer_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 400)
            {
                Player.Top += playerSpeed;
            }
        }

        private void UpMove_timer_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10)
            {
                Player.Top -= playerSpeed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.Right)
                {
                    RightMove_timer.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    LeftMove_timer.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    UpMove_timer.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    DownMove_timer.Start();
                }
            }



        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //replaced with key up
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            RightMove_timer.Stop();
            LeftMove_timer.Stop();
            UpMove_timer.Stop();
            DownMove_timer.Stop();
            if (e.KeyCode == Keys.Space)
            {
                if (pause)
                {
                    StartTimers();
                    label1.Visible = false;
                    gameMedia.controls.play();
                    pause = false;
                }
                else
                {
                    label1.Location = new Point(this.Width / 2 - 120, 150);
                    label1.Text = "PAUSED";
                    label1.Visible = true;
                    gameMedia.controls.pause();
                    stopTimers();
                    pause = true;
                }
            }
        }
        // Shooting mech
        private void MoveMuntionsTimer_Tick(object sender, EventArgs e)
        {
            shootgMedia.controls.play();
            for(int i = 0; i < munitions.Length; i++)
            {
                if (munitions[i].Top > 0)
                {
                    munitions[i].Visible = true;
                    munitions[i].Top -= MunitionSpeed;
                    Collision();
                }
                else
                {
                    munitions[i].Visible = false;
                    munitions[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - i * 30);
                }
            }
        }

        private void Move_enemies_Tick(object sender, EventArgs e)
        {
            MoveEnmies(enemies, enemySpeed);
        }
        private void MoveEnmies(PictureBox[] array, int speed)
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }
        private void Collision()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (munitions[0].Bounds.IntersectsWith(enemies[i].Bounds) || munitions[1].Bounds.IntersectsWith(enemies[i].Bounds) || munitions[2].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.controls.play();
                    score += 1;
                    score_label.Text = (score < 10) ? "0" + score.ToString() : score.ToString();

                    if (score%30 ==0)
                    {
                        level += 1;
                        Level_label.Text = (score <10 ) ? "0" + level.ToString() : level.ToString();    
                        if (enemySpeed <= 10 && enemyMunitionSpeed <= 10 && difficulty >= 0)
                         {
                            difficulty--;
                            enemySpeed++;
                            enemyMunitionSpeed++;
                         }
                        if (level == 10)
                        {
                            GameOver("Nicely Done!");
                        }
                    }
                    enemies[i].Location = new Point((i + 1) * 50, -100);
                }
                if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.settings.volume = 30;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("Game Over!");
                }
            }
        }
        private void GameOver(string str)
        {
            gameMedia.controls.stop();
            stopTimers();
            label1.Text = str;
            label1.Location = new Point(120, 120);
            label1.Visible = true;
            Play_button.Visible = true;
            Exit_button.Visible = true;
        }
        private void stopTimers()
        {
            MoveBackground.Stop();
            Move_enemies.Stop();
            MoveMuntionsTimer.Stop();
            EnemiesMunitionTimer.Stop();
        }
        private void StartTimers()
        {
            MoveBackground.Start();
            Move_enemies.Start();
            MoveMuntionsTimer.Start();
        }

        private void EnemiesMunitionTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < (enemiesMunition.Length - difficulty); i++)
            {
                if (enemiesMunition[i].Top < this.Height)
                {
                    enemiesMunition[i].Visible = true;
                    enemiesMunition[i].Top += enemyMunitionSpeed;
                    CollisionWEnemiesMunition();
                }
                else
                {
                    enemiesMunition[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    enemiesMunition[i].Location = new Point(enemies[x].Location.X + 20, enemies[x].Location.Y + 30);
                }
            }
        }
        private void CollisionWEnemiesMunition()
        {
            for(int i = 0; i < enemiesMunition.Length; i++)
            {
                if (enemiesMunition[i].Bounds.IntersectsWith(Player.Bounds))
                {
                    enemiesMunition[i].Visible = false;
                    explosion.settings.volume = 6;
                    explosion.controls.play();
                    Player.Visible = false;
                    GameOver("Game Over!");
                }
            }
        }

        private void Play_button_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_load_1(e, e);
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
    
}
