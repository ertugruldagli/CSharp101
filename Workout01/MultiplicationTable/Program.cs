internal class Program
{
    private static void Main(string[] args)
    {
        int i, k;

        for (k = 1; k<10; k++)
        {
            for (i = 1; i <= 10; i++)
            {
                int carp = i * k;
                Console.Write(carp);
            }

        }


        Console.ReadKey();
    }
}