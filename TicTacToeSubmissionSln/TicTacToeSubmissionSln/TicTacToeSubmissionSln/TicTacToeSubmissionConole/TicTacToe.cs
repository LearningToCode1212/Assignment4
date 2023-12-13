using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10,6);
            _boardRenderer.Render();
        }

        public static string[,] gameBoard = { 
            { "", "", ""}, 
            { "", "", ""},
            { "", "", ""}
        };
        public void Run()
        {

            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE
            int player1moves = 0;
            int player2moves = 0;
            bool onOff = true;
            bool xturn = true;
            bool yturn = true;
            while (onOff)
            {
                while (true)
                {
                    player1moves++;
                    Console.SetCursorPosition(2, 19);

                    Console.Write("Player X");

                    Console.SetCursorPosition(2, 20);

                    Console.Write("Please Enter Row: ");
                    var row = Console.ReadLine();

                    Console.SetCursorPosition(2, 22);

                    Console.Write("Please Enter Column: ");
                    var column = Console.ReadLine();

                    if (gameBoard[int.Parse(row), int.Parse(column)] == "")
                    {
                        _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);
                        gameBoard[int.Parse(row), int.Parse(column)] = "X";
                        Console.Clear();
                        _boardRenderer.Render();
                        break;
                    }
                    CheckWinner();
                }
                if (CheckWinner().Length > 5 | player1moves == 5)
                {
                    break;
                }
                
                while (yturn)
                {
                    player2moves++;
                    Console.SetCursorPosition(2, 19);

                    Console.Write("Player O");

                    Console.SetCursorPosition(2, 20);

                    Console.Write("Please Enter Row: ");
                    var row = Console.ReadLine();

                    Console.SetCursorPosition(2, 22);

                    Console.Write("Please Enter Column: ");
                    var column = Console.ReadLine();
                    if (gameBoard[int.Parse(row), int.Parse(column)] == "")
                    {
                        _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.O, true);
                        gameBoard[int.Parse(row), int.Parse(column)] = "O";
                        Console.Clear();
                        _boardRenderer.Render();
                        break;
                    }
                    


                }
                if (CheckWinner().Length > 5 | player1moves == 5)
                {
                    break;
                }
            }
            
            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            //_boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);
        }
        public static string CheckWinner()
        {
            string text;
            if (gameBoard[0,0] == "X" & gameBoard[0, 1] == "X" & gameBoard[0, 2] == "X")
            {
                Console.Clear();
                return text = "Player X Wins";
            } 
            else if (gameBoard[1, 0] == "X" & gameBoard[1, 1] == "X" & gameBoard[1, 2] == "X")
            {
                Console.Clear();
                return text = "Player X Wins";
            } else if (gameBoard[2, 0] == "X" & gameBoard[2, 1] == "X" & gameBoard[2, 2] == "X")
            {
                Console.Clear();
                return text = "Player X Wins";   
            } 
            else if (gameBoard[0, 0] == "X" & gameBoard[1, 0] == "X" & gameBoard[2, 0] == "X")
            {
                Console.Clear();
                return text = "Player X Wins";
            } else if (gameBoard[0, 1] == "X" & gameBoard[1, 1] == "X" & gameBoard[2, 1] == "X")
            {
                Console.Clear();
                return text = "Player X Wins";
            } else if (gameBoard[0, 2] == "X" & gameBoard[1, 2] == "X" & gameBoard[2, 2] == "X")
            {
                Console.Clear();
                return text = "Player X Wins";
            }
            else if (gameBoard[0, 0] == "X" & gameBoard[1, 1] == "X" & gameBoard[2, 2] == "X")
            {
                Console.Clear();
                return text = "Player X Wins";
            } else if (gameBoard[0, 2] == "X" & gameBoard[2, 2] == "X" & gameBoard[2, 0] == "X")
            {
                Console.Clear();
                return text = "Player X Wins";
            }
            /////////////////////////////////////////////////////////////////////////////////////
            if (gameBoard[0, 0] == "O" & gameBoard[0, 1] == "O" & gameBoard[0, 2] == "O")
            {
                Console.Clear();
                return text = "Player O Wins";
            }
            else if (gameBoard[1, 0] == "O" & gameBoard[1, 1] == "O" & gameBoard[1, 2] == "O")
            {
                Console.Clear();
                return text = "Player O Wins";
            }
            else if (gameBoard[2, 0] == "O" & gameBoard[2, 1] == "O" & gameBoard[2, 2] == "O")
            {
                Console.Clear();
                return text = "Player O Wins";

            }
            else if (gameBoard[0, 0] == "O" & gameBoard[1, 0] == "O" & gameBoard[2, 0] == "O")
            {
                Console.Clear();
                return text = "Player O Wins";

            }
            else if (gameBoard[0, 1] == "O" & gameBoard[1, 1] == "O" & gameBoard[2, 1] == "O")
            {
                Console.Clear();
                return text = "Player O Wins";

            }
            else if (gameBoard[0, 2] == "O" & gameBoard[1, 2] == "O" & gameBoard[2, 2] == "O")
            {
                Console.Clear();
                return text = "Player O Wins";

            }
            else if (gameBoard[0, 0] == "O" & gameBoard[1, 1] == "O" & gameBoard[2, 2] == "O")
            {
                Console.Clear();
                return text = "Player O Wins";

            }
            else if (gameBoard[0, 2] == "O" & gameBoard[1, 1] == "O" & gameBoard[2, 0] == "O")
            {
                Console.Clear();
                return text = "Player O Wins";

            }
            else 
            {
                return text = "Draw";
            }
            return text = "";
        }
    }
}
