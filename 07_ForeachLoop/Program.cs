using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Loop

            //1: Değişken Türü
            //2: Değişken Adı
            //3: In
            //4:Liste, Koleksiyon, Dizi

            //string[] cities = {"Ankara", "İstanbul","İzmir", "Adana", "Bursa" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //int[] numberss = {45, 78, 985,635,321,566,21234,2342 };
            //foreach (int number in numberss) {
            //    if(number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach (char letter in word)
            //{
            //    Console.WriteLine(letter);
            //}






            #endregion

            #region Örnek Sınav sistemi uygulaması

            Console.WriteLine("*****C# Eğitim Kampı Sınav Uygulaması ******");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //öğrenci sayısını alma

            Console.WriteLine("-----------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-----------------------");

            //öğrenci isimlerini ve not ortalamalarını saklayacak diziler

            string[] studentNames = new string[studentCount];
            double[] studentAverages = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini girin ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;

                // Her öğrenci için 3 sınav notu alınacak

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu girin: ");
                    totalExamResult += double.Parse(Console.ReadLine());
                }
                studentAverages[i] = totalExamResult / 3;
            }
            //Öğrencilerin ortalaması ve geçip geçmediği kontrol edilecek

            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin ortalaması: {studentAverages[i]} ve durumu: {(studentAverages[i] >= 50 ? "Geçti" : "Kaldı")}");
            }


            #endregion

        }
    }
}
