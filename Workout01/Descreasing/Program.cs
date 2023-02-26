internal class Program
{
    private static void Main(string[] args)
    {
        int girilenSayi,i;

        Console.Write("Bir sayi giriniz: ");
        girilenSayi = Convert.ToInt32(Console.ReadLine());

        for ( i = 1; i < girilenSayi;) 
        {
            i = i - 5;
            Console.WriteLine(i);
        }
        //Console.WriteLine(i);
        Console.ReadKey();  
    }
}