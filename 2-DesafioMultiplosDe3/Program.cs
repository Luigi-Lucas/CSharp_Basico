﻿class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Múltiplos de 3 entre 1 e 100: ");
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
 }