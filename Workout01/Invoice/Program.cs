internal class Program
{
    private static void Main(string[] args)
    {
        double tutar, indirimFiyati;        //double değişkeni kullanmamızın sebebi ondaklıklı sayılarla işlem yapmamızdır. int değişkeni yeterli ve doğru bir kullanım olmaz

        Console.WriteLine("Alisveris tutari giriniz: ");
        tutar = Convert.ToInt32(Console.ReadLine());

        if (tutar<=200)
        {
            indirimFiyati = tutar * 0.10; // alışveriş tutarından uygulanacak miktari çarpıp indirim hesaplandı
            tutar-=indirimFiyati;   // tutardan hesaplnan indirim çıkarıldı.

            Console.WriteLine("Uygulanna indirim : " + indirimFiyati);
            Console.WriteLine("İndirimli tutar: " + tutar);
        }
        else if (tutar>200 && tutar<=400)
        {
            indirimFiyati = tutar * 0.15;
            tutar -= indirimFiyati;

            Console.WriteLine("Uygulanna indirim : " + indirimFiyati);
            Console.WriteLine("İndirimli tutar: " + tutar);
        }
        else 
        {
            indirimFiyati = tutar * 0.20;
            tutar -= indirimFiyati;

            Console.WriteLine("Uygulanan indirim : " + indirimFiyati);
            Console.WriteLine("İndirimli tutar: " + tutar);
        }
    }
}