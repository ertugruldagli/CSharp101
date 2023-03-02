using Calculations;

NewMethod();

static void NewMethod()
{
    Console.WriteLine("Birinci sayiyi giriniz: ");
    int sayi1=Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("İkinvi sayiyi giriniz: ");
    int sayi2=Convert.ToInt32(Console.ReadLine());  


    clsCalculatorMethods test1=  new clsCalculatorMethods();

    test1.Dortislem(sayi1,sayi2);
}
