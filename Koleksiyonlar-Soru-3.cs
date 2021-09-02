using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList sesliharfler = new ArrayList() ;
            string sesli = "aeıioöuü" ;

            Console.WriteLine("Bir cümle giriniz.") ;
            string c = Console.ReadLine() ;

            for (int i = 0; i < c.Length; i++)
            {
                if(sesli.Contains(c[i]))
                {
                    sesliharfler.Add(c[i]) ;
                }
            }

            Console.WriteLine("---Cümleniz içerisindeki sesli harfler--- ") ;
            foreach (var harf in sesliharfler)
            {
                Console.WriteLine(harf) ;
            }

        }
    }
}
