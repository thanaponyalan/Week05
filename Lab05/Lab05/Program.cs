using System;

namespace Lab05
{
    class Program
    {
        public static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i < 9)
                {
                    continue;
                }
                Console.WriteLine(i);

            }
        }
    }
}
