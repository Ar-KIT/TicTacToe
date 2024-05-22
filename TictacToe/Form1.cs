using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TictacToe
{
    public partial class Form1 : Form
    {


        private Image x = Properties.Resources.x;
        private Image o = Properties.Resources.o;
        private Image blank = null;
        private Board gameBoard;

        public Form1()
        {
            InitializeComponent();
            gameBoard = new Board();

            //Event Listener for PictureBox
            foreach (PictureBox pb in TIcTacToe_Board.Controls)
            {
                pb.Image = blank;
                pb.Click += PictureBox_Click;
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedBox = sender as PictureBox;
            if (clickedBox != null) {
                string[] coordinates = clickedBox.Name.Split('_')[1].ToCharArray().Select(c => c.ToString()).ToArray();
                int row = int.Parse(coordinates[0]);
                int col = int.Parse(coordinates[1]);

                try
                {
                    gameBoard.PlayMove(row, col);
                    UpdateBoard();
                    if (Process.isGameOver)
                    {
                        if (Process.result == "win")
                        {
                            MessageBox.Show($"Player {gameBoard.GetCurrentPlayer()} wins!");
                            if(gameBoard.GetCurrentPlayer() == "X")
                            {
                                X_Score.Text = (int.Parse(X_Score.Text.ToString()) + 1).ToString();
                            }
                            else if (gameBoard.GetCurrentPlayer() == "O")
                            {
                                O_Score.Text = (int.Parse(O_Score.Text.ToString()) + 1 ).ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Its a Draw!");
                        }
                        Process.result = null;
                        Process.isGameOver = false;
                        ResetBoard();
                    }
                    else
                    {
                        PlayerTurns.Text = $"Player {gameBoard.GetCurrentPlayer()}'s Turn";
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void UpdateBoard()
        {
            string[,] board = gameBoard.GetBoard();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    PictureBox pb = (PictureBox)this.Controls.Find($"cell_{i}{j}", true)[0];
                    pb.Image = board[i, j] == "X" ? x : board[i, j] == "O" ? o : blank;
                }
            }
        }
        private void ResetBoard()
        {
            gameBoard.InitializeBoard();
            UpdateBoard();
        }
    }
}
