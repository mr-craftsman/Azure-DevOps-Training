using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX09ticTacToe
{
    internal class Program
    {
        // basic variables
        static char[,] board;
        static char currentPlayer;
        static bool gameOver;
        static void Main(string[] args)
        {
            StartGame();

            // main game loop
            while (!gameOver)
            {
                DisplayBoard(); // first step of loop
                GetPlayerInput(); // second step of loop
                CheckForWin(); // third step of loop
                SwitchPlayer(); // fourth step of loop
                CheckForDraw(); // fifth step of loop
            }

            DisplayBoard();  // refresh board view
            EndGame();  // finish game
        }
        static void StartGame()
        {
            board = new char[3, 3];
            currentPlayer = 'X';
            gameOver = false;

            Console.WriteLine("this is a tic-tac-toe game");
            Console.WriteLine("player 1: X");
            Console.WriteLine("player 2: O");
            Console.WriteLine("start the game");
            Console.WriteLine();
        }

        // displaying board
        static void DisplayBoard()
        {
            Console.WriteLine("  1   2   3");
            Console.WriteLine("1 " + board[0, 0] + " | " + board[0, 1] + " | " + board[0, 2]);
            Console.WriteLine(" ---+---+---");
            Console.WriteLine("2 " + board[1, 0] + " | " + board[1, 1] + " | " + board[1, 2]);
            Console.WriteLine(" ---+---+---");
            Console.WriteLine("3 " + board[2, 0] + " | " + board[2, 1] + " | " + board[2, 2]);
            Console.WriteLine();
        }

        // getting input
        static void GetPlayerInput()
        {
            Console.WriteLine("player: " + currentPlayer + ", it's your turn.");
            Console.Write("enter the row (1-3): ");
            int row = int.Parse(Console.ReadLine()) - 1;

            Console.Write("enter the column (1-3): ");
            int column = int.Parse(Console.ReadLine()) - 1;

            if (row < 0 || row >= 3 || column < 0 || column >= 3 || board[row, column] != '\0')
            {
                Console.WriteLine("invalid move. please try again.");
                GetPlayerInput();
            }
            else
            {
                board[row, column] = currentPlayer;
            }
        }

        // switching between players
        static void SwitchPlayer()
        {
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }

        // checks if a win occurs
        static void CheckForWin()
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                {
                    Console.WriteLine("player: " + currentPlayer + " wins");
                    gameOver = true;
                    return;
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                {
                    Console.WriteLine("player: " + currentPlayer + " wins");
                    gameOver = true;
                    return;
                }
            }

            // Check diagonals
            if ((board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
                (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer))
            {
                Console.WriteLine("player: " + currentPlayer + " wins");
                gameOver = true;
                return;
            }
        }

        // checking for a draw
        static void CheckForDraw()
        {
            bool isBoardFull = true;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == '\0')
                    {
                        isBoardFull = false;
                        break;
                    }
                }

                if (!isBoardFull)
                    break;
            }

            if (isBoardFull)
            {
                Console.WriteLine("it's a draw");
                gameOver = true;
            }
        }
        // end game message
        static void EndGame()
        {
            Console.WriteLine("game over. press any key to exit.");
            Console.ReadKey();
        }
    }
}
