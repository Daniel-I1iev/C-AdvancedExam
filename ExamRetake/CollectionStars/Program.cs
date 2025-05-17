using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[,] field = new char[n, n];
        int playerRow = 0, playerCol = 0, stars = 2;

       
        for (int i = 0; i < n; i++)
        {
            string[] row = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                field[i, j] = row[j][0];
                if (field[i, j] == 'P')
                {
                    playerRow = i;
                    playerCol = j;
                }
            }
        }

       
        string command;
        while ((command = Console.ReadLine()) != null)
        {
            int newRow = playerRow, newCol = playerCol;

            switch (command)
            {
                case "up": newRow--; break;
                case "down": newRow++; break;
                case "left": newCol--; break;
                case "right": newCol++; break;
            }

            if (newRow < 0 || newRow >= n || newCol < 0 || newCol >= n)
            {
                newRow = 0;
                newCol = 0;
            }

            if (field[newRow, newCol] == '#')
            {
                stars--;
                if (stars == 0)
                {
                    Console.WriteLine("Game over! You are out of any stars.");
                    PrintFinalState(field, playerRow, playerCol);
                    return;
                }
            }
            else
            {
                if (field[newRow, newCol] == '*')
                {
                    stars++;
                }
                field[playerRow, playerCol] = '.';
                playerRow = newRow;
                playerCol = newCol;
                field[playerRow, playerCol] = 'P';

                if (stars >= 10)
                {
                    Console.WriteLine("You won! You have collected 10 stars."); 
                    PrintFinalState(field, playerRow, playerCol);
                    return;
                }
            }
        }
    }

    static void PrintFinalState(char[,] field, int playerRow, int playerCol)
    {
        Console.WriteLine($"Your final position is [{playerRow}, {playerCol}]");
        for (int i = 0; i < field.GetLength(0); i++)
        {
            for (int j = 0; j < field.GetLength(1); j++)
            {
                Console.Write(field[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
