﻿using System;
using System.Reflection.Emit;

namespace switch_case
{

    class Program
    {
        static void Main(string[] args)
        {
            /*  //Ekrandan girilen sayıya kadar olan sayıları ekrana yazdır
              Console.WriteLine("Lütfen sayi giriniz: ");
              int sayac = int.Parse(Console.ReadLine());
              for (int i = 1; i <= sayac ; i++)
              {
                 if(i%2 == 1)
                   Console.WriteLine(i);   
              }*/

            // 1 ile 1000 arası tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır
            int tekToplam = 0;
            int ciftToplam = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 0)
                    ciftToplam += i; //ciftToplam = ciftToplam + i;

                else
                    tekToplam += i; //tekToplam = tekToplam + i;

            }
            Console.WriteLine("çift toplam = " + ciftToplam);
            Console.WriteLine("Tek toplam: " + tekToplam);

        // break, continue
        for (int i = 1; i < 10; i++)
        {
            if(i==4)
               break;
            Console.WriteLine(i);
            
        }

        for (int i = 1; i < 10; i++)
        {
            if(i==4)
               continue;
            Console.WriteLine(i);
            
        }

        }
    }
}