internal class Program
{
    private static void Main(string[] args)
    {
        int girilenSayi,toplam=0,adet=0;
        double ort;

        Console.Write("bir sayi giriniz: ");
        girilenSayi = Convert.ToInt32(Console.ReadLine());

        for ( int i = 1; i < girilenSayi ; i++)
        {
            toplam += i;
            adet++;
        }
        ort = toplam / adet;
        Console.WriteLine(ort);

        Console.ReadKey();

    }
}
