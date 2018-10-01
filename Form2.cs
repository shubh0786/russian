using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace russian
{
    public partial class Form2 : Form
    {
        public static string Player;
        public Form2(string Player)
        {
            InitializeComponent();
            label1_player.Text = " Player :" + Player;

        }
        int Chamber = 0;
        int chamber_count = 0;
        Random ran = new Random();
        int[] playerGun = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
        int round = 0;
        int total_score = 0;
    

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.Restart();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void LoadBullet()
        {    sound load = new sound();
            load.load_sound();
            Chamber = ran.Next(1, 7);
           

        }
        public void SpinBullet()
        {
            sound spin = new sound();
            spin.spin_sound();
            playerGun[Chamber] = 1;

        }


        public void Restart()
        {
            Application.Exit();
            Application.Restart();
        }
        void round_count()
        {
            round++;
            label_round.Text = "Round" + round;
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Show();
            LoadBullet();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            SpinBullet();
            if (Chamber == 0)
            {
                MessageBox.Show("there is no bullet it automatically restart the game");
                Restart();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {



            MessageBox.Show("***How To Play***\n\n1. Load The Bullet.\n2. Spin The Chamber.\n3. Press  Shoot Me." +
                "\n\n There are 1 in 2 Chances The Bullet is in the Chamber.\n You Can Shoot Two Times during the Game to Avoid the bullet." +
                "The maximum points is 200.");
                
            }

        private void btnshoot_Click(object sender, EventArgs e)
        {
            sound shootMe = new sound();
            shootMe.shoot();
            pictureBox3.Show();
            round_count();
            chamber_count++;


            if (Chamber == 0)
            
                
                {

                    MessageBox.Show("there is no bullet it automatically restart the game");
                    Restart();
                }
            
            if (playerGun[chamber_count] == 1)
            {
                MessageBox.Show("Bang - You are dead\nBetter Lucks Next Time...\n\n***Restart game * **");
                Restart();
            }
            else
            {
                MessageBox.Show("Bang - You survived");
                total_score += 100; //User get 100 points each time they survived
                label_score.Text = " Total Score: " + total_score;
            }
            if (round == 2)
                
            {
                MessageBox.Show("game over \nYou won \n you shot more than 2 times and the bullet has not been fired...\n\n*** Restart Game * **");
                Restart();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox2.Hide();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox3.Hide();
        }
    }
    }

