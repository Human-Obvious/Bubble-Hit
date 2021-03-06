using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDCourseProject;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MinimumSize = new Size(500, 500);
        }

        private void courseProject1_MouseMove(object sender, MouseEventArgs e)
        {
            int xBall = e.X;
            courseProject1.MouseHandlerPlayBall(xBall);
        }

        private void courseProject1_KeyDown(object sender, KeyEventArgs e)
        {
            if (courseProject1.IsStartGame && !courseProject1.isBallFlying && e.KeyCode == Keys.Space)
            {
                courseProject1.LaunchPlayBall();
            }
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            courseProject1.StartGame();
        }

        private void courseProject1_OnStartGame(object sender, EventArgs e)
        {
            if (courseProject1.IsNotifyToGameComplete)
            {
                MessageBox.Show("Игра началась");
            }
        }

        private void courseProject1_OnScoreChanged(object sender, EventArgs e)
        {
            ScoreLabel.Text = courseProject1.Score.ToString();
        }

        private void EndGameButton_Click(object sender, EventArgs e)
        {
            courseProject1.EndGame();
        }

        private void courseProject1_OnEndGame(object sender, EventArgs e)
        {
            if (courseProject1.IsNotifyToGameComplete)
            {
                MessageBox.Show("Игра закончилась");
            }
        }


    }
}
