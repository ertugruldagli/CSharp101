using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int randomSayi, tahminSayi;

        Random rnd= new Random();
        randomSayi=rnd.Next(5);

        

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Bir sayi tahmin ediniz: ");
            tahminSayi = Convert.ToInt32(Console.ReadLine());

            if (randomSayi==tahminSayi)
            {
                Console.WriteLine("Tebrikler tahmin ettiniz!!");
                break;
            }
            else 
            {
                Console.WriteLine(" YANLIS!! Tekrar deneyin");
            }
 
        }
        










        Console.ReadKey();
    }
}