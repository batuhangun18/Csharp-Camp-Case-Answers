using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar 

            //()
            //Geriye değer döndürmeyen metotlar
            //Customer--> Listele, ekle, sil,güncelle
            //void

            void CustomerList()
            {
                Console.WriteLine("Ali Yıldız");
                Console.WriteLine("Ahmet Yıldız");
                Console.WriteLine("Hakan Öztürk");
                Console.WriteLine("Merve Çınar");

            }

            CustomerList();
            CustomerList();
            CustomerList();
            CustomerList();

            void Sum()
            {
                int a = 5;
                int b = 10;
                int c = a + b;
                Console.WriteLine("Toplam: " + c);
            }

            Sum();

            #endregion


            #region GeriyeDeğer Döndürmeyen parametreli Metotlar

            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}

            //WriteMethod("Ali Yıldız");

            void CustomerCard(string name, string surName)

            {
                Console.WriteLine("Müşteri :" + name + " " + surName);
            }

            CustomerCard("Ali", "Yıldız");
            CustomerCard("Ahmet", "Yıldız");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            void SumWithParams(int number1, int number2, int number3)
            {
                int result = number1 + number2 + number3;
                Console.WriteLine("Toplam: " + result);
            }

            SumWithParams(5, 10, 15);

            #endregion

            #region Geriye Değer Döndüren Metotlar


            //string CustomerName()
            //{
            //    return "Ali Yıldız";
            //}
            //CustomerName();


            string StudentCard()
            {
                string name = "Ali";
                string surName = "Yıldız";

                return name + " " + surName;
            }

            Console.WriteLine(StudentCard());



            #endregion

            #region Geriye Değer Döndüren Parametreli Metotlar

            string CountryCard(string countryName, string capital, string flagColor)
            {

                string cardInfo = "Ülke: " + countryName + " Başkent: " + capital + " Bayrak Rengi: " + flagColor;
                return cardInfo;


            }

            string x , y, z;
            Console.WriteLine("Ülke Adı: ");
            x = Console.ReadLine();

            Console.WriteLine("Başkent: ");
            y = Console.ReadLine();

            Console.WriteLine("Bayrak Rengi: ");
            z = Console.ReadLine();

            Console.WriteLine(CountryCard(x, y, z));



            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            int Sums(int number1, int number2)
            {
                int result = number1 + number2;
                return result;

            }

            Console.WriteLine(Sums(5, 10));
            Console.WriteLine(Sums(15, 20));
            Console.WriteLine(Sums(30, 40));




            #endregion

            #region Örnek Uygulama 

            string ExamResults(string student, int exam1, int exam2, int exam3)
            {
                int average = (exam1 + exam2 + exam3) / 3;

                if (average >= 50)
                {
                    return student + " Geçti" + "ortalama: " + average;
                }
                else
                {
                    return student + " Kaldı" + "ortalama " + average;
                }
            }

            Console.WriteLine(ExamResults("Ali", 50, 60, 70));
            Console.WriteLine(ExamResults("Ahmet", 30, 40, 50));
            Console.WriteLine(ExamResults("Mehmet", 70, 80, 90));

            #endregion

            Console.Read();
        }
    }
}
