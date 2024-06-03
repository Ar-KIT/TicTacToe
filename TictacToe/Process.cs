using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TictacToe
{
    public abstract class Process
    {
        protected string[,] board = new string[3, 3];
        protected string currentPlayer = "X";
        public static bool isGameOver = false;
        public static string result;

        public Process()
        {
            InitializeBoard();
        }

        public void InitializeBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = null;
                }
            }
        }

        public bool IsValidMove(int row, int col)
        {
            return board[row, col] == null;
        }

        public void MakeMove(int row, int col)
        {
            board[row, col] = currentPlayer;
            result = CheckResult();

            if (result == "win" || result == "draw")
            {
                isGameOver = true;
            }
            else
            {
                SwitchPlayer();
            }
        }

        public void SwitchPlayer()
        {
            currentPlayer = (currentPlayer == "X") ? "O" : "X";
        }

        protected string CheckResult()
        {
            // Horizontals and Verticals
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer) ||
                    (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer))
                {
                    return "win";
                }
            }
            // Diagonals
            if ((board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
                (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer))
            {
                return "win";
            }

            bool isDraw = true;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == null)
                    {
                        isDraw = false;
                        break;
                    }
                }
                if (!isDraw) break;
            }
            if (isDraw) return "draw";
            return "continue";
        }

        public abstract void PlayMove(int row, int col);
        public string[,] GetBoard()
        {
            return board;
        }
        public string GetCurrentPlayer()
        {
            return currentPlayer;
        }
    }

    public class Board : Process
    {
        public override void PlayMove(int row, int col)
        {
            if (IsValidMove(row, col))
            {
                MakeMove(row, col);
            }
        }
    }
}
