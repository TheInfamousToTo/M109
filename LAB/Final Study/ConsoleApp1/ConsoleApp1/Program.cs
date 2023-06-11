class Program
{
    public static void Main(string[] args)
    {
        int[] AB = new int[] { 1, 2, 3, 4, 5 };
        test(ref AB);
        Console.ReadLine();
        int i = 1;
        while (i < 6)
        {
            if (i == 3)
            {
                break;
                i += 1;
            }
            else
            {
                i += 1;
                continue;
            }
            Console.WriteLine(i);

        }
        static void test(ref int[] PQ)
        {
            for (int i = 0; i < PQ.Length; i++)
            {
                PQ[i] = PQ[i] + i;
                Console.Write(PQ[i] + " ");

            }
        }

    }
}