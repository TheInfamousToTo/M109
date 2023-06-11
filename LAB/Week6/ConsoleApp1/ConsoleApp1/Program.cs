/*// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
*/


class HelloWorld
{
/*    public void helloWorld()
    {
        Console.WriteLine("test");
    }
    public static void Main()
    {
        Console.WriteLine("Hello, World!");
        HelloWorld obj1 = new HelloWorld();
        obj1.helloWorld();

    }*/

    public static void big ( int n1,int n2)
    {
        if (n1 > n2)
            Console.WriteLine("Num1 is Greater");
        else if (n2 > n1)
            Console.WriteLine("Num2 is Greater");
        else
            Console.WriteLine("Both = ");

    }
    public static void change(int m)
    { m = m + 20;
        Console.WriteLine("M= " + m);
    }

    static void Main()
    {
        int n = 20;
        big(100, 50);
        change(n);
        Console.WriteLine("N= " + n);


    }

}

