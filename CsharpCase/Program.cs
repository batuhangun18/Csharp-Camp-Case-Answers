using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("SELAM");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemekler");
            //Console.WriteLine("3- Soğuk Başlangıçlar");
            //Console.WriteLine("4- Salatalar");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("6- İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region Değişkenler 

            //string değişkenler
            // değişken_türü değişken_adı = değer;

            // string ad = "Mehmet";
            //  Console.WriteLine(ad);
            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, districk, city;

            customerName = "Mehmet";
            customerSurname = "Yılmaz";
            customerPhone = "0532 123 45 67";
            customerEmail = "deneme@gmail.com";
            districk = "Çankaya";
            city = "Ankara";

            Console.WriteLine("****Rezervasyon Bilgileri****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("Telefon: " + customerPhone);
            Console.WriteLine("Email: " + customerEmail);
            Console.WriteLine("Adres: " + districk + " / " + city);
            Console.WriteLine("-------------------------------");

            customerName = "Ayşe";
            customerSurname = "Yılmaz";
            customerPhone = "0532 123 45 67";
            customerEmail = "test@gmail.com";
            districk = "Çatalca";
            city = "İstanbul";

            Console.WriteLine("****Rezervasyon Bilgileri****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("Telefon: " + customerPhone);
            Console.WriteLine("Email: " + customerEmail);
            Console.WriteLine("Adres: " + districk + " / " + city);
            Console.WriteLine("-------------------------------");





            #endregion

            #region INT DEĞİŞKENLER

            //int
            // int number = 5;
            //Console.WriteLine(number);

            int hamburgerPrice = 20;
            int colaPrice = 5;
            int frenchFriesPrice = 8;
            int pizzaPrice = 25;
            int lemonadePrice = 4;
            int waterPrice = 2;

            Console.WriteLine("****Menü Fiyatları****");
            Console.WriteLine();
            Console.WriteLine("------Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("------Kola: " + colaPrice + " TL");
            Console.WriteLine("------Patates Kızartması: " + frenchFriesPrice + " TL");
            Console.WriteLine("------Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("------Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("------Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("****Menü Fiyatları****");

            int hamburgerCount = 2;
            int colaCount = 3;
            int frenchFriesCount = 1;
            int pizzaCount = 4;
            int lemonadeCount = 2;
            int waterCount = 3;

            int totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            int totalColaPrice = colaPrice * colaCount;
            int totalFrenchFriesPrice = frenchFriesPrice * frenchFriesCount;
            int totalPizzaPrice = pizzaPrice * pizzaCount;
            int totalLemonadePrice = lemonadePrice * lemonadeCount;
            int totalWaterPrice = waterPrice * waterCount;

            Console.WriteLine("****Sipariş Detayları****");
            Console.WriteLine();
            Console.WriteLine("------Hamburger: " + hamburgerCount + " Adet " + totalHamburgerPrice + " TL");
            Console.WriteLine("------Kola: " + colaCount + " Adet " + totalColaPrice + " TL");
            Console.WriteLine("------Patates Kızartması: " + frenchFriesCount + " Adet " + totalFrenchFriesPrice + " TL");
            Console.WriteLine("------Pizza: " + pizzaCount + " Adet " + totalPizzaPrice + " TL");
            Console.WriteLine("------Limonata: " + lemonadeCount + " Adet " + totalLemonadePrice + " TL");
            Console.WriteLine("------Su: " + waterCount + " Adet " + totalWaterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("****Sipariş Detayları****");
            int totalPrice = totalHamburgerPrice + totalColaPrice + totalFrenchFriesPrice + totalPizzaPrice + totalLemonadePrice + totalWaterPrice;

            Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");
            Console.WriteLine();





            #endregion

            //Batuhan Gün

            Console.Read();
        }
    }
}




