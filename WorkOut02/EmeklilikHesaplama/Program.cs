using System.Reflection;

internal class Program
{

    private static void Emekli(string gender, int prim)
    {
        int Gun, kalanYil, kalanAy, kalanGun, yilHesapla;
       
        if (gender == "K" || gender  == "k")
        {
            if (prim >= 7200)
            {
                Console.WriteLine("Prim gününüz doldu, emekli işlemlerinize başlayabilirsiniz!");
            }
            else
            {
                 Gun = 7200 - prim;
                 kalanYil = (Gun / 360);
                 yilHesapla = Gun - (kalanYil * 360);
                 kalanAy = ((Gun - (kalanYil * 360)) / 30);
                 kalanGun = yilHesapla - (kalanAy * 30);

                Console.WriteLine("Kalan prim gün sayınız: {0}", Gun + "\n");
                Console.WriteLine("Emekliliğine {0} yıl {1} ay {2} gün kaldı", kalanYil, kalanAy, kalanGun);


            }
        }
        else if (gender == "E" || gender == "e")
        {
            if (prim >= 9000)
            {
                Console.WriteLine("Prim gününüz doldu,emekli işlemlerinize başlayabilirsiniz!");
            }
            else
            {
                 Gun = 9000 - prim;
                 kalanYil = (Gun / 360);
                 yilHesapla = Gun - (kalanYil * 360);
                 kalanAy = ((Gun - (kalanYil * 360)) / 30);
                 kalanGun = yilHesapla - (kalanAy * 30);
            
                Console.WriteLine("Kalan prim gün sayınız: {0}", Gun + "\n");
                Console.WriteLine("Emekliliğine {0} yıl {1} ay {2} gün kaldı", kalanYil, kalanAy, kalanGun);


            }

        }

    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Cinsiyet belirtiniz; K / E....: ");
        string gender = Console.ReadLine();

        Console.WriteLine("calisma prim günü  sayisini giriniz: ");
        int prim = Convert.ToInt32(Console.ReadLine());

        Emekli(gender,prim);
    }
}