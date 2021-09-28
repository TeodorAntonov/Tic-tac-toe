using System;
using System.Linq;
using System.Collections.Generic;

namespace Tic_tac_toe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] table = new string[3, 3];

            Players firstPlayer = new Players();
            Players secondPlayer = new Players();

            Console.WriteLine("Welcome Pleayers! You Ready for a game");
            Console.WriteLine("1st player Enter your name:");

            firstPlayer.Name = Console.ReadLine();

            Console.WriteLine("2st player Enter your name:");

            secondPlayer.Name = Console.ReadLine();

            Console.WriteLine($"{firstPlayer.Name} is playing with X{Environment.NewLine}" +
                             $"{secondPlayer.Name} is playing with O");


            for (int row = 0; row < table.GetLength(0); row++)
            {
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    table[row, col] = "_";
                }
            }

            Table(table);
            int count = 1;
            
            while (count < 18 )
            {
                if (count % 2 == 1)
                {
                    Console.WriteLine($"{firstPlayer.Name} selecting:");
                    string firstPlayerSelecting = Console.ReadLine();

                    if (firstPlayerSelecting == "A1")
                    {
                        table[0, 0] = "X";
                    }
                    if (firstPlayerSelecting == "A2")
                    {
                        table[0, 1] = "X";
                    }
                    if (firstPlayerSelecting == "A3")
                    {
                        table[0, 2] = "X";
                    }
                    if (firstPlayerSelecting == "B1")
                    {
                        table[1, 0] = "X";
                    }
                    if (firstPlayerSelecting == "B2")
                    {
                        table[1, 1] = "X";
                    }
                    if (firstPlayerSelecting == "B3")
                    {
                        table[1, 2] = "X";
                    }
                    if (firstPlayerSelecting == "C1")
                    {
                        table[2, 0] = "X";
                    }
                    if (firstPlayerSelecting == "C2")
                    {
                        table[2, 1] = "X";
                    }
                    if (firstPlayerSelecting == "C3")
                    {
                        table[2, 2] = "X";
                    }
                }
                if (count % 2 == 0)
                {
                    Console.WriteLine($"{secondPlayer.Name} selecting:");

                    string secondPlayerSelecting = Console.ReadLine();

                    if (secondPlayerSelecting == "A1")
                    {
                        table[0, 0] = "O";
                    }
                    if (secondPlayerSelecting == "A2")
                    {
                        table[0, 1] = "O";
                    }
                    if (secondPlayerSelecting == "A3")
                    {
                        table[0, 2] = "O";
                    }
                    if (secondPlayerSelecting == "B1")
                    {
                        table[1, 0] = "O";
                    }
                    if (secondPlayerSelecting == "B2")
                    {
                        table[1, 1] = "O";
                    }
                    if (secondPlayerSelecting == "B3")
                    {
                        table[1, 2] = "O";
                    }
                    if (secondPlayerSelecting == "C1")
                    {
                        table[2, 0] = "O";
                    }
                    if (secondPlayerSelecting == "C2")
                    {
                        table[2, 1] = "O";
                    }
                    if (secondPlayerSelecting == "C3")
                    {
                        table[2, 2] = "O";
                    }
                }

                Table(table);

                int countXo = 0;
                foreach (var item in table)
                {
                    if (item == "X" || item == "O")
                    {
                        countXo++;
                        if (countXo == 9)
                        {
                            return;
                        }
                    }
                }

                int LeftDiagonal_X = 0;
                int LeftDiagonal_O = 0;

                int RightDiagonal_X = 0;
                int RightDiagonal_O = 0;

                for (int row = 0; row < table.GetLength(0); row++)
                {
                    if (table[row,row] == "X")
                    {
                        LeftDiagonal_X++;
                        if (LeftDiagonal_X == 3)
                        {
                            Console.WriteLine($"{secondPlayer.Name} Wins");
                            return;
                        }
                    }
                    if (table[row, row] == "O")
                    {
                        LeftDiagonal_O++;
                        if (LeftDiagonal_O == 3)
                        {
                            Console.WriteLine($"{firstPlayer.Name} Wins");
                            return;
                        }
                    }
                    //
                    if (table[table.GetLength(0) - 1 - row, row] == "X")
                    {
                        RightDiagonal_X++;
                        if (RightDiagonal_X == 3)
                        {
                            Console.WriteLine($"{secondPlayer.Name} Wins");
                            return;
                        }
                    }
                    if (table[table.GetLength(0) - 1 - row, row] == "O")
                    {
                        RightDiagonal_O++;
                        if (RightDiagonal_O == 3)
                        {
                            Console.WriteLine($"{firstPlayer.Name} Wins");
                            return;
                        }
                    }
                } // Diagonal checks for a Win

                // Col Wins
                int FirstCol_X = 0;
                int FirstCol_O = 0;

                for (int col = 0; col < table.GetLength(1)-1; col++)
                {
                    if (table[col, col] == "X")
                    {
                        FirstCol_X++;
                        if (FirstCol_X == 3)
                        {
                            Console.WriteLine($"{secondPlayer.Name} Wins");
                            return;
                        }
                    }
                    if (table[col, col + 1] == "X")
                    {
                        FirstCol_X++;
                        if (FirstCol_X == 3)
                        {
                            Console.WriteLine($"{secondPlayer.Name} Wins");
                            return;
                        }
                    }
                    if (table[col, table.GetLength(1)-1] == "X")
                    {
                        FirstCol_X++;
                        if (FirstCol_X == 3)
                        {
                            Console.WriteLine($"{secondPlayer.Name} Wins");
                            return;
                        }
                    }
                    //
                    if (table[col, col] == "O")
                    {
                        FirstCol_O++;
                        if (FirstCol_O == 3)
                        {
                            Console.WriteLine($"{firstPlayer.Name} Wins");
                            return;
                        }
                    }
                    if (table[col, col + 1] == "O")
                    {
                        FirstCol_O++;
                        if (FirstCol_O == 3)
                        {
                            Console.WriteLine($"{firstPlayer.Name} Wins");
                            return;
                        }
                    }
                    if (table[col, table.GetLength(1) - 1] == "O")
                    {
                        FirstCol_O++;
                        if (FirstCol_O == 3)
                        {
                            Console.WriteLine($"{firstPlayer.Name} Wins");
                            return;
                        }
                    }
                } // Collumns Wins

                // Row Wins // 
                int FirstRow_X = 0;
                int FirstRow_O = 0;

                for (int row = 0; row < table.GetLength(0)-1; row++) // Rows Wins
                {
                    if (table[row, row] == "X")
                    {
                        FirstRow_X++;
                        if (FirstRow_X == 3)
                        {
                            Console.WriteLine($"{secondPlayer.Name} Wins");
                            return;
                        }
                    }
                    if (table[row, row + 1] == "X")
                    {
                        FirstRow_X++;
                        if (FirstRow_X == 3)
                        {
                            Console.WriteLine($"{secondPlayer.Name} Wins");
                            return;
                        }
                    }
                    if (table[row, table.GetLength(0) - 1] == "X")
                    {
                        FirstRow_X++;
                        if (FirstRow_X == 3)
                        {
                            Console.WriteLine($"{secondPlayer.Name} Wins");
                            return;
                        }
                    }
                    //
                    if (table[row, row] == "O")
                    {
                        FirstRow_O++;
                        if (FirstRow_O == 3)
                        {
                            Console.WriteLine($"{firstPlayer.Name} Wins");
                            return;
                        }
                    }
                    if (table[row, row + 1] == "O")
                    {
                        FirstRow_O++;
                        if (FirstRow_O == 3)
                        {
                            Console.WriteLine($"{firstPlayer.Name} Wins");
                            return;
                        }
                    }
                    if (table[row, table.GetLength(0) - 1] == "O")
                    {
                        FirstRow_O++;
                        if (FirstRow_O == 3)
                        {
                            Console.WriteLine($"{firstPlayer.Name} Wins");
                            return;
                        }
                    }
                }

                count++;
            }
        }

        public static void Table(string[,] table)  
        {
            Console.WriteLine("    _1____2____3_");
            Console.WriteLine($"A  |_{table[0,0]}_|__{table[0, 1]}__|_{table[0, 2]}_|");
            Console.WriteLine($"B  |_{table[1,0]}_|__{table[1, 1]}__|_{table[1, 2]}_|");
            Console.WriteLine($"C  |_{table[2,0]}_|__{table[2, 1]}__|_{table[2, 2]}_|");
        }
    }
}
