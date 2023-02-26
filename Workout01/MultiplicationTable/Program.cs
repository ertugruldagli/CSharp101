internal class Program
{
    private static void Main(string[] args)
    {
        int i, k, carp;

        for (k = 1; k<10; k++)                                     // ilk döngü carpilması gerekn sayıyı tutuyor
        {
            Console.Write("\n");                                   //bir satır boşluk bırakması için araya ekledim

            for (i = 1; i <= 10; i++)                              //ikinci döngü ise çarpılan sayısının çarpanlarını tutuyor
            {
                carp = i * k;                                      // çarpma işlemini yeni bir değişkene atıyoruz
                Console.WriteLine("{0} x {1} = {2} ",i,k,carp);     //parametrik çıktı
            }

        }


        Console.ReadKey();
    }
}