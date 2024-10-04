using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varaibles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            // double number;
            // number = 10.5;
            // Console.WriteLine(number);
            Console.WriteLine("**** Fiyat Listesi ****");
            Console.WriteLine();

            double applePrice , orangePrice , strawberryPrice , patatoPrice , tomatoPrice ;

            applePrice = 2.5;
            orangePrice = 3.5;
            strawberryPrice = 4.5;
            patatoPrice = 5.5;
            tomatoPrice = 6.5;

            Console.WriteLine("----- Elma birim fiyatı : " + applePrice + " TL");
            Console.WriteLine("----- Portakal birim fiyatı : " + orangePrice + " TL");
            Console.WriteLine("----- Çilek birim fiyatı : " + strawberryPrice + " TL");
            Console.WriteLine("----- Patates birim fiyatı : " + patatoPrice + " TL");
            Console.WriteLine("----- Domates birim fiyatı : " + tomatoPrice + " TL");

            double appleGram, orangeGram, strawberryGram, patatoGram, tomatoGram;
            
            appleGram = 1.245;
            orangeGram = 1.345;
            strawberryGram = 1.445;
            patatoGram = 1.545;
            tomatoGram = 1.645;

            double appleTotalPrice = applePrice * appleGram;
            double orangeTotalPrice = orangePrice * orangeGram;
            double strawberryTotalPrice = strawberryPrice * strawberryGram;
            double patatoTotalPrice = patatoPrice * patatoGram;
            double tomatoTotalPrice = tomatoPrice * tomatoGram;

            Console.WriteLine("Alınan Ürün : Elma - " + "Birim Fiyatı : " + applePrice + " TL - " + "Alınan Gram : " + appleGram + " - " + "Toplam Fiyat : " + appleTotalPrice + " TL");
            Console.WriteLine("Alınan Ürün : Portakal - " + "Birim Fiyatı : " + orangePrice + " TL - " + "Alınan Gram : " + orangeGram + " - " + "Toplam Fiyat : " + orangeTotalPrice + " TL");
            Console.WriteLine("Alınan Ürün : Çilek - " + "Birim Fiyatı : " + strawberryPrice + " TL - " + "Alınan Gram : " + strawberryGram + " - " + "Toplam Fiyat : " + strawberryTotalPrice + " TL");
            Console.WriteLine("Alınan Ürün : Patates - " + "Birim Fiyatı : " + patatoPrice + " TL - " + "Alınan Gram : " + patatoGram + " - " + "Toplam Fiyat : " + patatoTotalPrice + " TL");
            Console.WriteLine("Alınan Ürün : Domates - " + "Birim Fiyatı : " + tomatoPrice + " TL - " + "Alınan Gram : " + tomatoGram + " - " + "Toplam Fiyat : " + tomatoTotalPrice + " TL");

            double totalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + patatoTotalPrice + tomatoTotalPrice;
            Console.WriteLine("Toplam Fiyat : " + totalPrice + " TL");


            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            // DEF...
            //Toplantı Saat 20:00'de

            char symbol;
            symbol = 'A';

            Console.WriteLine("Karakter : " + symbol);

            #endregion

            #region Klavyeden Veri Girişi String Değişkenler
                
            
            Console.WriteLine("*** Csharp Hava Yolları Yolcu Bilgisi ***");
            Console.WriteLine();

            string passangerName, passangerSurname, passangerDistrick, passangerCity, passangerAge, passangerıdentificationNumber;

            Console.Write("Yolcu Adı : ");
            passangerName = Console.ReadLine();
            Console.Write("Yolcu Soyadı : ");
            passangerSurname = Console.ReadLine();
            Console.Write("İlçe  : ");
            passangerDistrick = Console.ReadLine();
            Console.Write("Şehir : ");
            passangerCity = Console.ReadLine();
            Console.Write("Yaş : ");
            passangerAge = Console.ReadLine();
            Console.Write("TC Kimlik Numarası : ");
            passangerıdentificationNumber = Console.ReadLine();

            Console.WriteLine("---------------------");
            Console.WriteLine("Yolcu Tc Kimlik Numarası : " + passangerıdentificationNumber + " -Yolcu Adı : " + passangerName + " -Yolcu Soyadı : " + passangerSurname + " -Yaş : " + passangerAge + " -İlçe : " + passangerDistrick + " -Şehir : " + passangerCity);


            #endregion


            #region Klavyeden tam Sayı girişi ve dönüşümler

            int shoesPrice, computerPrice, chairPrice, tvPrice;

            shoesPrice = 100;
            computerPrice = 200;
            chairPrice = 300;
            tvPrice = 400;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.WriteLine("Lütfen Ayakkabı Adetini Giriniz : ");
            shoesCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Bilgisayar Adetini Giriniz : ");
            computerCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Sandalye Adetini Giriniz : ");
            chairCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Televizyon Adetini Giriniz : ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrices = (shoesPrice * shoesCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tvPrice * tvCount);

            Console.WriteLine("Ayakkabı Adet : " + shoesCount + " - Fiyat : " + shoesPrice + " TL - Toplam Fiyat : " + (shoesPrice * shoesCount) + " TL");
            Console.WriteLine("Bilgisayar Adet : " + computerCount + " - Fiyat : " + computerPrice + " TL - Toplam Fiyat : " + (computerPrice * computerCount) + " TL");
            Console.WriteLine("Sandalye Adet : " + chairCount + " - Fiyat : " + chairPrice + " TL - Toplam Fiyat : " + (chairPrice * chairCount) + " TL");
            Console.WriteLine("Televizyon Adet : " + tvCount + " - Fiyat : " + tvPrice + " TL - Toplam Fiyat : " + (tvPrice * tvCount) + " TL");
            Console.WriteLine("Toplam Fiyat : " + totalPrices + " TL");




            #endregion


            #region Klavyeden Ondalıklı Sayı İşlemleri
                    
            double exam1 , exam2, exam3, result;
            Console.WriteLine("Lütfen 1. Sınav Notunu Giriniz : ");
            exam1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2. Sınav Notunu Giriniz : ");
            exam2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 3. Sınav Notunu Giriniz : ");
            exam3 = double.Parse(Console.ReadLine());

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine();
            Console.WriteLine("Sınav Ortalaması : " + result);

            #endregion



            #region Klavyeden Karakter Girişi

            char gender;
            Console.WriteLine("Lütfen Cinsiyetinizi Giriniz (E/K) : ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet :" + gender);




            #endregion

            Console.Read();
        }
    }
}
