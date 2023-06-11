int nopersons = 0;
int table = 0;
int total = 0;
int[] tables = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
s: Console.Write("\n Enter the required table number (-1 to exit) "); // 1 mark
table = Convert.ToInt32(Console.ReadLine());
while (table != -1)
{
    if (tables[table] == 1)
    {
        Console.WriteLine("Reservation cancelled due to unavailable table number"); 
     goto s;
    }
    else if (tables[table] == 0)
    {
        tables[table] = 1;
        Console.Write("Enter the number of persons ");
        nopersons = Convert.ToInt32(Console.ReadLine());
        if (nopersons > 5)
        {
            Console.WriteLine("Reservation cancelled due to unallowed number of persons"); 
           
            tables[table] = 0;
            goto s;
        }
        total = nopersons * 10;
        Console.WriteLine("\n Reservation is confirmed for table no " +
       table);
        Console.WriteLine("Total fees " + total);
        goto s;
    }
}
Console.ReadKey();
