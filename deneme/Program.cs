using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double değişken
            //double number= 8.25;
            //Console.WriteLine(number);
            //double applePrice =14.85,
            //    orangePrice=20.95,
            //    strawberryPrice=45,
            //    potatoPrice=9.74, 
            //    tomatoPrice=6.88;
            //Console.WriteLine("----- Elma birim fiyatı:" + applePrice+"TL");
            //Console.WriteLine("----- Portakal birim fiyatı:" + orangePrice+"TL");
            //Console.WriteLine("----- Çilek birim fiyatı:" + strawberryPrice+"TL");
            //Console.WriteLine("----- Patates birim fiyatı:" + potatoPrice+"TL");
            //Console.WriteLine("----- Domates birim fiyatı:" + tomatoPrice+"TL");
            //double appleGram = 1.2,
            //    orangeGram = 2.65,
            //    strawberryGram = 0.75,
            //    pototoGram = 4.859,
            //    tomatoGram = 3.857;
            //double appleTotalPrice = applePrice * appleGram,
            //    strowberryTotalPrice = strawberryPrice * strawberryGram,
            //    orangeTotalPrice = orangePrice * orangeGram,
            //    pototoTotalPrice = potatoPrice * pototoGram,
            //    tomatoTotalPrice = tomatoPrice * tomatoGram;

            //double totalPrice = appleTotalPrice + orangeTotalPrice + strowberryTotalPrice + pototoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine(totalPrice);
            //Console.ReadLine();
            #endregion
            //int k=0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0) 
            //    { 
            //        Console.WriteLine( i);
            //        k++;
            //    }

            //}
            //Console.WriteLine(k);

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;

            //    Console.WriteLine(i+" Saatin sonunda: "+ bacterium);
            //}

            #region while döngüsü

            //int i = 1;
            //while (i<=100)
            //{
            //    if (i % 5 == 0) 
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            #endregion

            Console.WriteLine( "Sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hundreds = number / 100;
            sum=ones+tens+hundreds;
            Console.WriteLine(ones);
            Console.WriteLine(tens);
            Console.WriteLine(hundreds);
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
