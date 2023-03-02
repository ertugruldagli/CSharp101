using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations 
{
    internal class clsCalculatorMethods
    {
       public static int topla=0,carp;
       public static  double avarage, bolme;

        public  void Dortislem(int s1,int s2)
        {
            
            topla = s1 + s2;
            carp= s1 * s2;
            bolme= s1 / s2;
            avarage = topla / 2;

           Console.WriteLine($"Toplami: {topla}\n Caprma: {carp}\n bolme: {bolme}\n ortalamasi: {avarage}");

            
        }
        

     

    }
}
