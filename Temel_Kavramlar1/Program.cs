using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temel_Kavramlar1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Double_Değişkenleri
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //double number;
            //number = 45.75;
            //Console.WriteLine(number);
            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 13.45;
            //orangePrice = 7.85;
            //strawberryPrice = 22.65;
            //potatoPrice = 9.98;
            //tomatoPrice = 11.27;
            //Console.WriteLine("Elma Birim Fiyatı " + applePrice + " ₺");
            //Console.WriteLine("Portakal Birim Fiyatı " + orangePrice + " ₺");
            //Console.WriteLine("Çilek Birim Fiyatı " + strawberryPrice + " ₺");
            //Console.WriteLine("Patates Birim Fiyatı " + potatoPrice + " ₺");
            //Console.WriteLine("Domates Birim Fiyatı " + tomatoPrice + " ₺");
            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.765;
            //orangeGram = 1.215;
            //strawberryGram = 2.645;
            //potatoGram = 5.125;
            //tomatoGram = 8.255;
            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar:" + appleTotalPrice + " ₺");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar:" + orangeTotalPrice + " ₺");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar:" + strawberryTotalPrice + " ₺");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar:" + potatoTotalPrice + " ₺");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar:" + tomatoTotalPrice + " ₺");
            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödenecek Tutar: " + shoppingTotalPrice + "₺");





            #endregion

            #region Char_Değişkenleri
            //ABCDEFGH
            //DEF..
            //TOPLANTI SAAT 20:00'DE
            //" '
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden_Veri_Girişleri_String_Değişkenler
            //Console.WriteLine("***** Alemdar Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();
            //string passengerName, passengerSurName, passengerDistrict, passengerCity, passengerAge,passengerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı: ");
            //passengerSurName = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yaşınız: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("T.C Numaranız: ");
            //passengerIdentityNumber = Console.ReadLine();


            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("Yolcu Adı: " + passengerName + " Yolcu Soyadı " + passengerSurName + " Yolcu İl " + passengerDistrict + "Yolcu Şehir " + 
            //passengerCity+ " Yolcu Yaşı " + passengerAge+ " Yolcu T.C " + passengerIdentityNumber);





            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1500;
            //computerPrice = 7300;
            //chairPrice = 3800;
            //tvPrice = 15000;
            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Girin: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Girin: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Girin: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen Aldığınız Televizyon Sayısını Girin: ");
            //tvCount = int.Parse(Console.ReadLine());
            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine("--------------------------------------------------");
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice + "₺");


            #endregion

            #region Klavyeden Ondalık Sayı İşlemleri
            //double exam1, exam2, exam3, result;
            //Console.WriteLine("Vize Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Final Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Proje Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ortalamaınz: " + result);
            #endregion

            #region Klavyeden Karakter Girişleri
            //char gender;
            //Console.WriteLine("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            #endregion
            Console.Read();
        }
    }
}
