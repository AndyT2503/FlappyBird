using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FlappyBird
{
    public partial class Form1 : Form
    {
        string username; // giu username cua nguoi choi
        SqlConnection sqlCon;// giu database ket noi voi tro choi

        Random size = new Random(); //random kich thuoc pipe 
      
        int speed = new int();
        int gravity = 2;
        int score = 0;
        public Form1()
        {
            InitializeComponent();

        }

        public void GetValue(string name, SqlConnection sql)
        {
            username = name;
            sqlCon = sql;
        }

        void SaveScore() //luu highscore vao database
        {
            int highscore = new int();
            string getscore = "select score from [Table] where username = '" + username + "'";
            SqlCommand command = new SqlCommand(getscore, sqlCon);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                highscore = Int32.Parse(dr["score"].ToString());
             
            }
            dr.Close();
            if(score > highscore)
            {
                string query = "Update [Table] set score = " + score + " where username = '" + username + "'";
                SqlCommand cmd = new SqlCommand(query, sqlCon);

                cmd.ExecuteNonQuery();
            }
            
        }
        int[] InitSpeed()//tao mang gia tri toc do
        {
            int[] Speed = { 5, 6, 7, 8, 9, 10, 11, 12 };
            return Speed;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.mydata = new LoginForm.GetData(GetValue);
            sqlCon.Open();
            LoadGame();
        }

        void EndGame()
        {
            gameTimer.Stop();
            SaveScore();
            btn_Exit.Enabled = true;
            btn_start.Enabled = true;
            btn_highscore.Enabled = true;
        }

        void CheckEnd()
        {
            if (Bird.Bounds.IntersectsWith(pipeBotom1.Bounds))
                EndGame();
            else if (Bird.Bounds.IntersectsWith(pipeBotom2.Bounds))
                EndGame();
            else if (Bird.Bounds.IntersectsWith(pipeTop1.Bounds))
                EndGame();
            else if (Bird.Bounds.IntersectsWith(pipeTop2.Bounds))
                EndGame();
            else if (Bird.Bounds.IntersectsWith(ground.Bounds))
                EndGame();
        }

        void GetScore()
        {
            Scoretxt.Text = score.ToString();
        }

        void ControlSpeed()//dieu khien toc do
        {
            int[] Speed = InitSpeed();
            int i = score / 10;
            speed = Speed[i];
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            GetScore();
            ControlSpeed();
            Bird.Top += gravity;
            pipeBotom1.Left -= speed;
            pipeBotom2.Left -= speed;
            pipeTop1.Left -= speed;
            pipeTop2.Left -= speed;

            if(pipeBotom1.Left<=-30)
            {
                score++;
                int h = size.Next(120, 150);
                pipeBotom1.Height = h;
                int t = 306 - h;
                pipeBotom1.Location = new Point(505, t);
            }
            if(pipeBotom2.Left <= -30)
            {
                score++;
                int h = size.Next(120, 150);
                pipeBotom2.Height = h;
                int t = 306 - h;
                pipeBotom2.Location = new Point(490, t);
            }
            if(pipeTop1.Left <= -30)
            {
                score++;
                int h = size.Next(103, 135);
                pipeTop1.Height = h;
                pipeTop1.Location = new Point(505, 0);
            }
            if (pipeTop2.Left <= -30)
            {
                score++;
                int h = size.Next(103, 135);
                pipeTop2.Height = h;
                pipeTop2.Location = new Point(490, 0);
            }

            CheckEnd();
        }

        void LoadGame()
        {
            //speed
            score = 0;
            Scoretxt.Text = "0";
            pipeBotom1.Left = 228;
            pipeBotom2.Left = 368;
            pipeTop1.Left = 257;
            pipeTop2.Left = 438;
            Bird.Location = new Point(12, 189);
        }

        private void Btn_start_Click(object sender, EventArgs e)
        {
            if (btn_start.Text == "Bắt đầu")
            {
                gameTimer.Start();
                btn_start.Enabled = false;
                btn_Exit.Enabled = false;
                btn_highscore.Enabled = false;
                btn_start.Text = "Chơi lại";
            }
            else
            {
                LoadGame();
                btn_start.Text = "Bắt đầu";
            }
        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode==Keys.Space)
            {
                e.SuppressKeyPress = true;
                gravity = -2;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Space)
            {
                gravity = 2;
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            
            sqlCon.Close();
            Application.Exit();
            
        }

        private void Btn_highscore_Click(object sender, EventArgs e)
        {
            HighScore highScore = new HighScore(sqlCon);
            highScore.ShowDialog();
        }
    }
}
