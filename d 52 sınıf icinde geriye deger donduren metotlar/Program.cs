using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d_52_sınıf_icinde_geriye_deger_donduren_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            islemler isl = new islemler();
            int s1, s2;
       
            {
                // toplama
                Console.Write("sayi 1:");
                s1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("sayi 2:");
                s2 = Convert.ToInt16(Console.ReadLine());
                isl.topla(s1, s2);

                // fark
                Console.Write("sayi 1:");
                s1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("sayi 2");
                s2 = Convert.ToInt16(Console.ReadLine());
                isl.cikarma(s1, s2);

                //carpma
                Console.Write("Sayi 1:");
                s1 = Convert.ToInt16(Console.ReadLine());
                Console.Write("sayi 2:");
                s2 = Convert.ToInt32(Console.ReadLine());
                isl.carpma(s1, s2);


                //Bolme
                Console.Write("Sayi 1:");
                s1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Sayi 2:");
                s2 = Convert.ToInt32(Console.ReadLine());
                isl.bolme(s1, s2);



            }
        }


    }
}
