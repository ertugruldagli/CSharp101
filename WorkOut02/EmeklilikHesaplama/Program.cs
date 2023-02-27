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

            }
        }
        else if  (cinsiyet=="E"|| cinsiyet =="e"){
            if (prim>=9000)
            {
                Console.WriteLine("Prim gününüz doldu, emeklisiniz!");
            }

        }
       
    }
}