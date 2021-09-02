using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
       static void Main(string[] args)
        {
            ArrayList sayilar1 = new ArrayList() ;
            ArrayList sayilar2 = new ArrayList() ;

            Console.WriteLine("4 adet pozitif tam sayı giriniz: ") ;
        

            for (int i = 0; i < 4; i++)
                {
                   int n = Convert.ToInt32(Console.ReadLine()) ;
                   
                   bool sonuc1 = IsNumeric1(n) ;
                   
                   int kontrol =0 ;

                    if (sonuc1 == true )
                    {
                          for (int j = 2; j < n; j++)
                        {
                            if( n%j ==0)
                            {   
                               kontrol++ ;
                            }
                        }
                               if(kontrol!=0)
                                sayilar2.Add(n) ; 
                                 else
                                {  sayilar1.Add(n) ; }
                                
                    
                    }

                    else
                    {
                        Console.WriteLine("Negatif veya nümerik olmayan bir değer girdiniz.") ;
                        Console.WriteLine("Yeni bir değer giriniz.") ;
                        i-- ;
                    }
                }
            
            

            Console.WriteLine("---Girdiğiniz Asal Sayıların Büyükten Küçüğe Sıralanmış Hali---") ;
                sayilar1.Sort() ;
                sayilar1.Reverse() ;
                
                foreach (int sayi in sayilar1)
                {
                 Console.WriteLine(sayi) ;
                }
             

            Console.WriteLine("---Girdiğiniz Asal Sayıların Sayısı---") ;
                int k = sayilar1.Count;
                Console.WriteLine(k) ;

            Console.WriteLine("---Girdiğiniz Asal Sayıların Ortalaması---") ;
            int sayi1=0 ;
             foreach (int sayi in sayilar1)
             {
                 sayi1 += sayi ;
             }
             Console.WriteLine(sayi1/k) ;
            
            
            Console.WriteLine("---Girdiğiniz Asal Olmayan Sayıların Büyükten Küçüğe Sıralanmış Hali---") ;
                sayilar2.Sort() ;
                sayilar2.Reverse() ;

                foreach (int sayi in sayilar2)
                {
                 Console.WriteLine(sayi) ;
                }

              Console.WriteLine("---Girdiğiniz Asal Olmayan Sayıların Sayısı---") ;
                int m = sayilar2.Count;
                Console.WriteLine(m) ;

            Console.WriteLine("---Girdiğiniz Asal Sayıların Ortalaması---") ;
            int sayi2=0 ;
             foreach (int sayi in sayilar2)
             {
                 sayi2 += sayi ;
             }
             Console.WriteLine(sayi2/m) ;
            
            
    }

        // static bool IsNumeric (string input)
        // {
        //     int test ;
        //     return int.TryParse(input, out test) ;
        // }

        static bool IsNumeric1 (int input1)
        {
            if(input1<0)
            return (false) ;

            return (true) ;
        }
    }
}
