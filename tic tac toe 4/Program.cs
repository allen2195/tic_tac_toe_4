using System;
namespace ConsoleApp22
{
    class Program
    {

        static int choice;
        static int turns = 9;
        static char player = 'X';


        static void Main(string[] args)
        {
            char[,] board = new char[3, 3];


            GameBoard(board);

            while (true)
            {
                Gamemenu();

                choice = char.Parse(Console.ReadLine());
                switch (choice)
                {
                    case '1':
                        while (true)
                        {
                            Console.Clear();
                            Print(board);
                            Console.WriteLine("Player '" + player + "' is playing!");
                            Console.WriteLine("Select the row");
                            int row = Convert.ToInt32(Console.ReadLine()) - 1;
                            Console.WriteLine("Select column");
                            int col = Convert.ToInt32(Console.ReadLine()) - 1;
                            board[row, col] = player;
                            turns--;
                            if (turns == 0)
                            {

                                Console.Clear();
                                Print(board);
                                Console.WriteLine(" DRAW!");
                                break;
                            }
                            if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
                            {
                                Console.Clear();
                                Print(board);
                                Console.WriteLine(" Player '" + player + "' won!");
                                break;
                            }
                            else if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
                            {
                                Console.Clear();
                                Print(board);
                                Console.WriteLine(" Player '" + player + "' won!");
                                break;
                            }
                            else if (player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
                            {
                                Console.Clear();
                                Print(board);
                                Console.WriteLine("Player '" + player + "' won!");
                                break;
                            }
                            else if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])
                            {
                                Console.Clear();
                                Print(board);
                                Console.WriteLine(" Player '" + player + "' won!");
                                break;
                            }
                            else if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
                            {
                                Console.Clear();
                                Print(board);
                                Console.WriteLine(" Player '" + player + "' won!");
                                break;
                            }
                            else if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
                            {
                                Console.Clear();
                                Print(board);
                                Console.WriteLine(" Player '" + player + "' won!");
                                break;
                            }
                            else if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
                            {
                                Console.Clear();
                                Print(board);
                                Console.WriteLine(" Player '" + player + "' won!");
                                break;
                            }
                            else if (player == board[0, 2] && player == board[1, 1] && player == board[2, 0])
                            {
                                Console.Clear();
                                Print(board);
                                Console.WriteLine(" Player '" + player + "' won!");
                                break;
                            }
                            if (player == 'X')
                            {
                                player = 'O';
                            }
                            else
                            {
                                player = 'X';
                            }



                        }
                        Console.WriteLine("Press any botton to exit the game ");
                        Console.ReadKey();
                        break;
                    case '2':
                        Console.WriteLine("Author of this is Allen Nyombayire, a student at WSB University of Poznan");
                        Console.WriteLine("Press any button");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case '3':

                        {

                        }
                        Console.WriteLine("Do you really want to exit? (y/n)");
                        choice = Convert.ToChar(Console.ReadLine());
                        switch (choice)
                        {
                            case 'Y':
                                Console.WriteLine("Thanks for attention");
                                System.Environment.Exit(-1);
                                break;

                            case 'N':
                                Console.Clear();
                                break;
                        }
                        break;
                }
            }




        }
        static void GameBoard(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                    board[row, col] = ' ';
            }
        }
        static void Print(char[,] board)
        {
            for (int row = 0; row < 3; row++)
            {



                Console.Write(row + 1 + "| ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("   1   2   3   ");
        }

        private static void Gamemenu()
        {
            Console.WriteLine("WELCOME TO TIC TAC TOE");
            Console.WriteLine("Press any key to get to the menu");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2.About the Author");
            Console.WriteLine("3. Exit");
        }


    }
}















