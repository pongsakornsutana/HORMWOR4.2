using System;

namespace home_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int layer;
            Console.Write("Please in put your Triangle's leyer :");
            layer = int.Parse(Console.ReadLine());
            int layer2 = layer + 1;
            Pascaltriangle(ref layer2);
        }
        static void Pascaltriangle(ref int layer2)
        {
            int row = 1, blank, j;
            for (int i = 0; i < layer2; i = i + 1)
            {
                for (blank = 10; blank <= layer2 - i; blank++)
                    Console.Write(" ");
                for (j = 0; j <= i; j = j + 1)
                {
                    if (j == 0 || i == 0)
                        row = 1;
                    else
                        row = row * (i - j + 1) / j;
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
