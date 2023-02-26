internal class Program
{
    private static void Main(string[] args)
    {
        int girilenSayi,i=1;

        Console.Write("Bir sayi giriniz: ");
        girilenSayi = Convert.ToInt32(Console.ReadLine());

        while (i<girilenSayi)
        {
            i--5;
        }
        //Console.WriteLine(i);
        Console.ReadKey();  
    }
}