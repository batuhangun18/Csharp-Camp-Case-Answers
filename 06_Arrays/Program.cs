using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            //2,4,6,8
            //sarı kırmızı mavi turuncu

            //   DeğişkenTürü[] DiziAdı = new DeğişkenTürü[Eleman sayısı]
            //string[] colors = new string[4];
            //colors[0] = "Sarı";
            //colors[1] = "Kırmızı";
            //colors[2] = "Mavi";
            //colors[3] = "Turuncu";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milan";
            //cities[1] = "Paris";
            //cities[2] = "London";
            //cities[3] = "New York";
            //cities[4] = "Tokyo";

            //Console.WriteLine(cities[3]);

            //int[] numbers = new int[10];

            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 30;
            //numbers[3] = 4;
            //numbers[7] = 50;
            //Console.WriteLine(numbers[7]);

            //string[] city = { "Ankara", "İstanbul", "İzmir" };
            //Console.WriteLine(city[1]);



            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Mavi", "Turuncu" };

            ////for (int i = 0; i < colors.Length; i++)
            ////{
            ////    Console.WriteLine(colors[i]);
            ////}
            //Console.WriteLine(colors);

            //int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 520, 7456, 2365,1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 96, 74, 125, 635, 488, 520, 7456, 2365, 1120 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}

            //Console.WriteLine(maxNumber);

            //string[] persons = { "Ali", "Veli", "Deli", "Mehmet", "Ahmet", "Ayşe", "Fatma" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 520, 7456, 2365, 1120 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 520, 7456, 2365, 1120 };
            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }




            #endregion

            #region Dizi Metotları

            //string[] customers = { "Ali", "Veli", "Deli", "Mehmet", "Ahmet", "Ayşe", "Fatma" };
            //int index = Array.IndexOf(customers, "Mehmet");
            //Console.WriteLine(index);

            //int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 520, 7456, 2365, 1120 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max());
            //Console.WriteLine("Dizinin en küçük elemanı: " + numbers.Min());



            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write("Şehir adı giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}


            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}

            //Console.WriteLine(sum);

            int[] numberss = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            Console.WriteLine("Çift Sayılar");
                for (int i = 0; i < numberss.Length; i++)
            {
                if (numberss[i] % 2 == 0)
                {
                    Console.WriteLine(numberss[i]);
                }
            }

            Console.WriteLine("Tek Sayılar");
            for (int i = 0; i < numberss.Length; i++)
            {
                if (numberss[i] % 2 != 0)
                {
                    Console.WriteLine(numberss[i]);
                }
            }

            #endregion


            Console.Read();
        }
    }
}
