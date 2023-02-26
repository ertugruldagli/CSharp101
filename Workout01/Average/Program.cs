using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int girilenSayi=1,toplam=0,adet=0; //girilenSayi değişkenine 1 atması yaptık. çünkü döngüde 0 ataması olduğunda döngü sona erecek.
        float ort;
        
        while (girilenSayi!=0)   //girilen değer  sıfıra eşit olana kadar  döngü  çalışacak
        {
            Console.Write("bir sayi giriniz: ");
            girilenSayi = Convert.ToInt32(Console.ReadLine());

            adet++;

            toplam += girilenSayi;

        }
        ort = toplam / adet;

        Console.WriteLine("toplamı: " + toplam);
        Console.WriteLine("ortalamasi: " + ort);

        Console.ReadKey();

    }
}
