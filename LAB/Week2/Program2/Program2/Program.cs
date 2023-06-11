// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args) {
        int A = 15, B = 30;
        String S1 = (A > B) ? "A is the King" : "B is the Boss";
        Console.WriteLine(S1);
        int grade = 75;
        if (grade >= 50 && grade<=100)
        {
            Console.WriteLine("PASS");
        }
        else if (grade < 50 && grade > 0)
        {
            Console.WriteLine("FAIL");
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Welcome to AOU");
        Console.WriteLine("==========================================");
        Console.Write("Your Grade is : ");
        if (grade >= 90)
            Console.WriteLine("A");
        else if (grade < 89 && grade >= 82)
            Console.WriteLine("B+");
        else if (grade < 81 && grade >= 75)
            Console.WriteLine("B");
        else if (grade < 74 && grade >= 70)
            Console.WriteLine("C+");
        else if (grade < 69 && grade >= 60)
            Console.WriteLine("C");
        else if (grade > 50)
            Console.WriteLine("F");
        else
            Console.WriteLine("Wrong input");
        Console.WriteLine("==========================================");


    }
}