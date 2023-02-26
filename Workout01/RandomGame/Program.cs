using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int randomSayi, tahminSayi;

        Random rnd= new Random(); // random sınıfından random nesnesi üretilir
        randomSayi=rnd.Next(1,200);  //1 ve 200 arasında bir random sayısı değişkene atılır

        
        for (int i = 0; i <= 10; i++)         // 10 defa da tahmin etmek için for döngüsünün limiti 10 ile sınırlandırılır.
        {
            Console.WriteLine("Bir sayi tahmin ediniz: ");
            tahminSayi = Convert.ToInt32(Console.ReadLine()); // kullanıcıdan tahmin edilmesi istenilen sayı değişkene girilir.

            if (randomSayi!=tahminSayi)     // girilen sayi random sayiya eşite değilse +++
            {
        
                if (randomSayi > tahminSayi)  //++ if ile yönlendirmeler yapılarak tahmin etmesi kolaylaştırılır.
                {
                    Console.WriteLine("küçük değer girdiniz!");
                }
                else
                {
                    Console.WriteLine("büyük değer girdiniz!");
                }
            }
            else 
            {
                Console.BackgroundColor = ConsoleColor.Green;  //arka plan rengini yeşil yapar
                Console.WriteLine("Tebrikler tahmin ettiniz!!");
                break;                                              // tahmin doğru olduğu zaman döngü burada kırılır ve çıkış yapılır.
            }
            
        }
        Console.BackgroundColor = ConsoleColor.Red; //arkad plan rengini kırmızı yapar
        Console.WriteLine("HAK DOLDU!");

       

        Console.ReadKey();
    }
}