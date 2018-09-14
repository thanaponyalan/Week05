﻿using System;

namespace Lab05
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 200, y = 4;
            int count = 0;
            string[,] array = new string[x, y];

            // Initialize the array:
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    array[i, j] = (++count).ToString();

            // Read input:
            Console.Write("Enter the number to search for: ");

            // Input a string:
            string myNumber = Console.ReadLine();

            // Search:
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (array[i, j].Equals(myNumber))
                    {
                        goto Found;
                    }
                }
            }

            Console.WriteLine("The number {0} was not found.", myNumber);
            goto Finish;

        Found:
            Console.WriteLine("The number {0} is found.", myNumber);

        Finish:
            Console.WriteLine("End of search.");

            // Keep the console open in debug mode.
            Console.WriteLine("Press any key to exit.\n");
            Console.ReadKey();
            Main(args);
        }
    }
}
