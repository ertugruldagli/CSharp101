internal class Program
{
    private static void Main(string[] args)
    {
        double maas = 8.500d, hesaplananMaas; //sabit aldigi maas, degiskene atandı.  ikinci değişken ise zam oranını gösterecek

        int calistigiYil; //calistigi yıl sayısı istendi

        Console.Write("Kac yildir calisiyor? : ");
        calistigiYil = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < calistigiYil; i++)// calışstığı yil sayisi kadar döngüye alıp maasa ekleme yapacak
        {
            hesaplananMaas = maas * 0.15;// maaş ile zam oranı hesaplandı
            maas += hesaplananMaas; // yapılan zam oranı maasa eklendi.
        }

        Console.WriteLine("Hesaplanan Maasi: " + maas);

        Console.ReadKey();
    }
}