internal class Program
{
    private static void Main(string[] args)
    {
        int sayi1, sayi2, toplama, cikarma, carp;
        float bolme;
        string kontrol;

        Console.WriteLine("birinci sayiyi giriniz: ");
        sayi1= Convert.ToInt32(Console.ReadLine()); // kullanıcıdan 1. sayıyı istedik

        Console.WriteLine("ikinci sayiyi giriniz: "); //kullanıcıdan 2. sayıyı istedik
        sayi2= Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("lütfen işlem seçiniz: \n Toplam için: T/t \n Cikarma için: E/e \n Carpma için: Ç/ç \n Bolme için: B/b");
        kontrol = Console.ReadLine();  //hesaplama yapması için seçim yapması istendi 

        if(kontrol=="T" || kontrol == "t") { // if bloklarıyla klavyeden girilen seçime göre işlemler yapılır.
                toplama=sayi1+sayi2;
                Console.WriteLine("Toplami: "+ toplama);

        }else if(kontrol=="E" || kontrol == "e") {
                cikarma=sayi1-sayi2;
                Console.WriteLine("Cikarma: " + cikarma);

        }
        else if (kontrol=="Ç" || kontrol=="ç"){
                carp = sayi1 * sayi2;
                Console.WriteLine("Carpma: " + carp);

        }
        else if (kontrol=="B" || kontrol=="b"){
                bolme = sayi1 / sayi2;
                Console.WriteLine("Bolme: " + bolme);
        }else{
                Console.WriteLine("Yanlis karakter girdiniz!"); // if blokları içerisinde istenen veri dışında bir veri girilirse uyarı mesajı verilecek
        }
        
    }
}