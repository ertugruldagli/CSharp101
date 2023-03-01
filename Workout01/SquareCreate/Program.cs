internal class Program
{
    private static void Main(string[] args)
    {
        // Kullanıcıdan 1 ile 10 arasında deger alınacak. Bu degere göre kenarları * olacak şekilde, ortası boş olacak.

        Console.WriteLine("1 ile 10 arasında bir değer giriniz: ");
        int edgeLength = int.Parse(Console.ReadLine()); //convert.toInt32  karşılığıdır.

        if (edgeLength >= 1 && edgeLength <= 10)
        {
            for (int i = 0; i < edgeLength; i++) //satırlar
            {
                for (int j = 0; j < edgeLength; j++) //sütünlar
                {
                    if (i == 0 || i == edgeLength - 1 || j == 0 || j == edgeLength - 1) //hem satırda hem sütunda  en son olanın önündemiyim
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }


                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("hatalı deger girildi!");
        }
        Console.ReadKey();
    }
        
}