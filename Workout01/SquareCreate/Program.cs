internal class Program
{
    private static void Main(string[] args)
    {
        int k, i;
        
        Console.WriteLine("Bir deger giriniz: ");
        int deger=Convert.ToInt32(Console.ReadLine());

        for ( i = 1; i < deger; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
        for (k = 0; k < deger - 2; k++)
        {
            Console.Write("* ");
            for (int j = 0; j < deger; j++)
            {
                Console.Write("  ");
            }
            // sağ kenarı oluşturma
            Console.Write("*");
            Console.WriteLine();
        }

        for (int n = 0; n < deger; n++)
            Console.Write("*");

        Console.ReadKey();
    }
        
}