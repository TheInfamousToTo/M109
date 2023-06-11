// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class HellowWorld
{
    static void Main()
    {
        //int i = 0, sum = 0;
        /*while (i <= 99999999)
        {
            Console.WriteLine("Hello, World! : "+ i);
            i=i+876;
        }*/
        /*        while ( i<= 5)
                {
                    sum = sum + i;
                    i++;
                    Console.WriteLine("Hello, World! : " + sum);*/
        /*        for (int i = 1; i < 100; i++)
                {
                    Console.WriteLine(" ");
                    if (i >= 10)
                        break;
                    for (int j = 1; j < 100; j++)
                    {
                        Console.Write("#");
                        Console.Write("$");
                        Console.Write("%");
                        Console.Write("^");
                        if (j == i)
                             goto loop1;
                    }

                    loop1 : continue;
                }
                Console.WriteLine("Termination by BREAK");
                }*/
        int i, j;
        for (i = 5; i >= 1; i--)
        {
            for (j = 1; j <= i; j++)
            {
                Console.Write(i + "");
            }
            Console.WriteLine();
        }
    }
}
