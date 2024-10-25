using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region IF

            //Console.Write("Lütfen Şifreyi giriniz ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.WriteLine("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");

            //}


            //int number;
            //Console.WriteLine("Sayı Giriniz:");
            //number = int.Parse(Console.ReadLine());
            //if (number == 0)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}


            //int exam1, exam2, exam3, avarage;
            //string result = "Hata";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //avarage = (exam1 + exam2 + exam3) / 3;
            //Console.Write("Sınavların ortalaması :" + avarage);

            //if (avarage > 0 & avarage <= 50) {

            //    result = "Sonuç Vasat";
            //        }
            //if (avarage > 50 & avarage <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if(avarage >70 & avarage <= 84 )
            //{
            //    result = "Sonuç İyi";
            //}
            //if(avarage > 84)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.Write(result);


            string city;
            Console.Write("Lütfen şehir girişi yapınız:");
            city = Console.ReadLine();

            if(city =="adana" | city == "ankara" | city=="bursa" | city=="trabzon")
            {
                Console.WriteLine("Şehir Mevcut");
            }
            else
            {
                Console.WriteLine("Şehir mevcut değil");
            }

            Console.WriteLine("Lütfen kullanıcı adını girin");
            string  username = Console.ReadLine();
            if ( username != "admin")
            {
                Console.WriteLine("Bu kullanıcı adı kabul edilemez");

            }

            else
            {
                Console.WriteLine("Hoş geldiniz");
            }





            #endregion


            #region Mod İşlemleri
            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. sayıyı girin");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("lütfen 2. sayıyı girin");
            //int number2 = int.Parse(Console.ReadLine());

            //int result1 = number1 % number2;

            //Console.Write("1. sayının 2. sayıya bölümünden kalan : " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çift");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tek");
            //}


            //char team;
            //Console.Write("takım sembolünü gir:");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' | team =='F' )
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b'| team == 'B') 
            //{
            //    Console.WriteLine("Beşiktaş");
            //}






            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("********* C# Eğitim Kampı Restoranı *********");
            //Console.WriteLine();
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Ana Yemekler---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Körili Tavuk");
            //    Console.WriteLine("2- Kızartma Tabağı");
            //    Console.WriteLine("3- Fasulye Pilav");
            //    Console.WriteLine("4- Fırında Somon");
            //    Console.WriteLine("5- Patlıcan Musakka");
            //    Console.WriteLine("--------Ana Yemekler---------");

            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------Çorbalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-  Mercimek   ");
            //    Console.WriteLine("2- Ezogelin ");
            //    Console.WriteLine("--------Çorbalar-----");

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("--------pizzalar----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margarita");
            //    Console.WriteLine("2-Karışık");

            //    Console.WriteLine("--------pizzalar ---------");

            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------İçecekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("Su");
            //    Console.WriteLine("Ayran");
            //    Console.WriteLine("Kola");

            //    Console.WriteLine("--------İçecekler----------");

            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------Tatlılar---------");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Künefe");
            //    Console.WriteLine("2- Sütlü Nuriye");
            //    Console.WriteLine("3- Fırında Sütlaç");
            //    Console.WriteLine("--------Tatlılar---------");

            //}



            #endregion



            #region switch case

            Console.WriteLine("Lütfen Ay girin");
            int monthNumber = int.Parse(Console.ReadLine());

            
            switch(monthNumber)
            {
                case 1: Console.Write("Ocak");
                    break;
                case 2:
                    Console.Write("Şubat");
                    break;
                case 3:
                    Console.Write("Mart");
                    break;
                case 4:
                    Console.Write("Nisan");
                    break;
                case 5:
                    Console.Write("Mayıs");
                    break;
                case 6:
                    Console.Write("Haziran");
                    break;
                case 7:
                    Console.Write("Temmuz");
                    break;
                case 8:
                    Console.Write("Ağustos");
                    break;
                case 9:
                    Console.Write("Eylül");
                    break;
                case 10:
                    Console.Write("Ekim");
                    break;
                case 11:
                    Console.Write("Kasım");
                    break;
                case 12:
                    Console.Write("Aralık");
                    break;
                    default: Console.WriteLine("Hatalı veri"); break;   


            }




            #endregion


            #region Hesap Makinesi Switch Case

            int number1, number2, result;
            char symbol;
            Console.WriteLine("1. Sayıyı girin:");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Sayıyı girin");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi girin: ");
            symbol = char.Parse(Console.ReadLine());

            switch(symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;
            }

            #endregion



            Console.Read();
        }
    }
}
