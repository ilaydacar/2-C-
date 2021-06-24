﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 5 adet sınav notunuzu giriniz");
            int[] sinavlar = new int[5];
            for (int i = 0; i < 5; i++)
            {
                sinavlar[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Değiştirmek istediğiniz sınav varsa, 1'e basınız.\nSilmek istediğiniz sınav varsa 2'e basınız.\n Sınavlarınızı yüksekten düşüğe doğru sıralamak için 3'e basınız.");
            int secim = int.Parse(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Hangi notunuzu değiştirmek istiyorsunuz?");
                    int not = int.Parse(Console.ReadLine());
                    int notunIndexi = Array.IndexOf(sinavlar, not);
                    if (notunIndexi != -1)
                    {
                        //kullanıcının yazdığı notun bulunması durumu
                        Console.WriteLine("Güncel notunuzu yazınız.");
                        int yeniNot = int.Parse(Console.ReadLine());
                        sinavlar[notunIndexi] = yeniNot;
                        Console.WriteLine("Notunuz güncellendi.");
                        foreach (var item in sinavlar)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                        Console.WriteLine("Böyle bir not girilmedi.");
                    break;
                case 2:
                    Console.WriteLine("Hangi notunuzu silmek istiyorsunuz?");
                    not = int.Parse(Console.ReadLine());
                    notunIndexi = Array.IndexOf(sinavlar, not);
                    if (notunIndexi != -1)
                    {
                        //kullanıcının yazdığı notun bulunması durumu
                        Array.Clear(sinavlar, notunIndexi, 1);
                        Console.WriteLine("Notunuz silindi.");
                        foreach (var item in sinavlar)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                        Console.WriteLine("Böyle bir not girilmedi.");
                    break;
                case 3:
                    Array.Sort(sinavlar);
                    Array.Reverse(sinavlar);
                    foreach (var item in sinavlar)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                default:
                    Console.WriteLine("Yanlış seçim yaptınız.");
                    break;
            }
            Console.ReadKey();
        }
    }
}