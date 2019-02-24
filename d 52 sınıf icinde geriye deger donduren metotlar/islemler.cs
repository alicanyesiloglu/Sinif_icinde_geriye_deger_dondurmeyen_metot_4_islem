using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d_52_sınıf_icinde_geriye_deger_donduren_metotlar
{
    class islemler
    {

     public int topla(int s1,int s2)
        {
            int s3 = s1 + s2;
            Console.WriteLine("Toplamı" + s3);
            return s3;

        }
      public int cikarma(int s1,int s2)
        {
            int s3 = s1 - s2;
            Console.WriteLine("Cikarma" + s3);
            return s3;
        }
            public int carpma(int s1,int s2)
        {
            int s3 = s1 * s2;
            Console.WriteLine("Carpma" + s3);
            return s3;
        }
        public int bolme (int s1,int s2)
        {
            int s3 = s1 / s2;
            Console.WriteLine("Bolme" + s3);
            return s3;
        }
    }
}
