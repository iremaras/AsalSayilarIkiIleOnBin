using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayilarİkiİleOnBin
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] asalSayilar = new int[10000];
            //int sayici = 0;
            for (int i = 3; i <= 10000; i++)
            {
                bool asalMi = true;
                for (int bolen = 2; bolen < i; bolen++)
                {
                    if (i % bolen == 0)
                    {
                        asalMi = false;
                        break;
                    }    
                }
                if (asalMi)
                {
                    Console.WriteLine(i);
                    //asalSayilar[sayici] = i;
                    //sayici++;
                }
               
            }
            //foreach (int sayi in asalSayilar)
            //{
            //    Console.WriteLine(sayi);
            //}
            Console.ReadLine();
        }
    }
}
