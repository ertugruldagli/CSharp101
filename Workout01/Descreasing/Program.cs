internal class Program
{
    private static void Main(string[] args)
    {
        int girilenSayi,i; 

        Console.Write("Bir sayi giriniz: ");
        girilenSayi = Convert.ToInt32(Console.ReadLine());

        if (girilenSayi > 0) //girilen sayinin pozitif olup olmadığını kontrol ediyoruz.
        {
            for (i = girilenSayi; i > 1; i -= 5) //döngüyü  klavyeden alınan sayıyla başlatıyoruz. 1'e kadar 5er azaltıyoruz.
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("pozitif deger giriniz!");
        }
        
        Console.ReadKey();  
    }
}