using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[5] ;
            int[] ksayilar = new int[3] ;
            int[] bsayilar = new int[3] ;

            Console.WriteLine("20 tane sayı giriniz.") ;

            for (int i = 0; i < 5; i++)
            {
                sayilar[i] = int.Parse(Console.ReadLine()) ;                
            }

             Array.Sort(sayilar) ;

             for (int i = 0; i < 3; i++)
             {
                 ksayilar[i] =sayilar[i] ;
             }
             
            Console.WriteLine("Girdiğiniz sayılardan en küçük 3 tanesi:") ;
             foreach (int m in ksayilar)
            {
                Console.WriteLine(m) ;
            }

            Console.WriteLine("En küçük 3 tanesinin ortalaması:") ;
            int toplam1 = 0;
          foreach (int m in ksayilar)
            {
              toplam1 +=  m ;   
            }
            int ort1 = (toplam1)/3 ;
            Console.WriteLine(ort1) ;
             
             Array.Reverse(sayilar) ;
            for (int i = 0; i < 3; i++)
             {
                 bsayilar[i] =sayilar[i] ;
             }
            
            Console.WriteLine("Girdiğiniz sayılardan en büyük 3 tanesi:") ;

             foreach (int m in bsayilar)
            {
                Console.WriteLine(m) ;
            }

            Console.WriteLine("En büyük 3 tanesinin ortalaması:") ;
            int toplam2 = 0;
          foreach (int m in bsayilar)
            {
              toplam2 +=  m ;   
            }
            int ort2 = (toplam2)/3 ;
            Console.WriteLine(ort2) ;

            Console.WriteLine("En büyük 3 ve en küçük 3 sayının ortalama toplamları: " +(ort1+ort2)) ;
        }
    }
}
