using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for Döngüsü

            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
            }

            for(int i = 3; i<= 50; i += 3)
            {
                Console.WriteLine(i);
            }
            Console.Write("Ekrana yazılmasını istediğiniz adedi girin:");
                int finishValue = int.Parse(Console.ReadLine());

            for (int i = 1; i <= finishValue; i++)
            {
                Console.WriteLine("Yaşasın Cumhuriyet");
            }




            #endregion


            #region For döngüsü  ile karar yapıları 
                for(int i = 0; i <= 100; i++)
            {
                if(i % 5 == 0 )
                {
                    Console.WriteLine(i);
                }
            }

            //int totalValue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);


            int totalValue = 0;
            for (int i = 1; i < 20; i++)
            {
                if (i % 2 == 0 )
                {
                    totalValue += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("--------");
            Console.WriteLine(totalValue);


            int count = 0;
                for (int i = 1; i <= 50; i++)
            {
                if(i % 7 == 0)
                {
                    count++;
                }
            }
                Console.WriteLine(count);

            #endregion

            #region While Döngüsü

            //int i = 1;

            //while (i <= 10) {
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10) {
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);


            #endregion


            #region Örnek Sınav Sorusu 

            // Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yaz

            Console.Write("Sayıyı giriniz : ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hunders;
            int sum;

            ones = number % 10;
            tens = (number % 100) / 10;
            hunders = number / 100;

            Console.WriteLine(ones + "-" + tens + "-" + hunders);
            sum = ones + tens + hunders;

            Console.WriteLine(sum);


            #endregion

            Console.Read();
        }
    }
}
