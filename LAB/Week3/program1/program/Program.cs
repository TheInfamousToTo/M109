// See https://aka.ms/new-console-template for more information
using System;
class Hellow
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        /*int day;
        Console.WriteLine("enter Day Number From 1-7");
        day = Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Thuesday");
                break;
            case 4:
                Console.WriteLine("Whensday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("unvalid Input");
                break;
        }
        Console.WriteLine("============================================================");
        */

        /*int i = 1;
        while (i <= 5)
        {
            Console.WriteLine(" i = "+ i);
            i++;

        }*/

        int i = 0, number;
        double sum = 0;
        double breakTheSystem;
        Console.WriteLine("Enter a number :");
        number = Convert.ToInt32(Console.ReadLine());
        while (i < number)
        {
            sum = sum + i;
            i++;
            breakTheSystem=(sum/number+i)/i*2/4*9*4*5/3;
            Console.WriteLine("Count = "+i+" Sum : "+sum);
            Console.WriteLine("Count = " + i + " breakTheSystem : " + breakTheSystem);
        }
        Console.WriteLine("Sum : "+ sum);
    }
}