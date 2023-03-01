internal class Program
{
    private static void Main(string[] args)
    {
        int[,] sayilar = { {1,2,3 }, { 4,5,6} };


        foreach(int i in sayilar)
        {
            int ikiKat = i * 2;
            Console.WriteLine(ikiKat);
        }

        //for (int i = 0;i < sayilar.GetLength(0);i++)
        //{
        //    for (int j = 0; j < sayilar.GetLength(1); j++)
        //    {
        //        Console.Write(sayilar[i, j]);
        //    }
        //}

       

        Console.ReadKey();
    }
}