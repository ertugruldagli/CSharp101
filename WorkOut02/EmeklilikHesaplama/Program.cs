internal class Program
{
    private static void Main(string[] args)
    {
        string cinsiyet;
        int prim;

        Console.WriteLine("Cinsiyet belirtiniz; K / E....: ");
        cinsiyet= Console.ReadLine();

        Console.WriteLine("calisma prim günü  sayisini giriniz: ");
        prim = Convert.ToInt32(Console.ReadLine());

        if (cinsiyet=="K" || cinsiyet=="k")
        {
            if (prim>=7200)
            {
                Console.WriteLine("Prim gününüz doldu, emeklisiniz!");
            }
            else
            {
                int Gun = 7200 - prim;
                int kalanYil = Gun / 360;
                Console.WriteLine("Kalan yıl: " + kalanYil);
                int kalanAy = kalanYil / 12;
                Console.WriteLine("Kalan ay: " + kalanAy);
                int kalanGun = kalanAy / 30;
                Console.WriteLine("Kalan gun: " + kalanGun);

            }
        }
        else if  (cinsiyet=="E"|| cinsiyet =="e"){
            if (prim>=9000)
            {
                Console.WriteLine("Prim gününüz doldu, emeklisiniz!");
            }
            else
            {
                int Gun = 9000 - prim;
                int kalanYil = (Gun / 360);
                int yilHesapla = Gun - (kalanYil * 360);
                int kalanAy = ((Gun - (kalanYil * 360)) / 30);
                int kalanGun = yilHesapla - (kalanAy * 30);

                Console.WriteLine(Gun);
                Console.WriteLine(kalanYil);
                Console.WriteLine(kalanAy);
                Console.WriteLine(kalanGun);
               

            }

        }
       
    }
}