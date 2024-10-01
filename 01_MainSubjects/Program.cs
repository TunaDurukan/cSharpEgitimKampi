using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");
            //Console.WriteLine("Selam");

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

            //string customerName, customerSurname, customerPhone, customerEmail, district, city;

            //customerName = "Ahmet";
            //customerSurname = "Aksoy";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "aaksoy@gmail.com";
            //district = "Maltepe";
            //city = "İstanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: ");
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------");

            //customerName = "Mehmet";
            //customerSurname = "Aksoy";
            //customerPhone = "+90 500 600 70 80";
            //customerEmail = "maksoy@gmail.com";
            //district = "Kartal";
            //city = "İstanbul";

            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: ");
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------");

            #endregion

            #region Int Değişkenler

            int hamburgerPrice = 300, cokePrice = 35, waterPrice = 10, friesPrice = 50, pizzaPrice = 250, lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatları ****");
            Console.WriteLine();
            Console.WriteLine("- Hamburger: " + hamburgerPrice + " TL");
            Console.WriteLine("- Pizza: " + pizzaPrice + " TL");
            Console.WriteLine("- Kızartma: " + friesPrice + " TL");
            Console.WriteLine("- Kola: " + cokePrice + " TL");
            Console.WriteLine("- Limonata: " + lemonadePrice + " TL");
            Console.WriteLine("- Su: " + waterPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatları ****");

            Console.WriteLine();
            int hamburgerCount = 3;
            int cokeCount = 3;
            int waterCount = 3;
            int friesCount = 1;
            int pizzaCount = 0; 
            int lemonadeCount = 0;

            int hamburgerTotal, cokeTotal, waterTotal, friesTotal, pizzaTotal, lemonadeTotal, totalPrice = 0;

            hamburgerTotal = hamburgerCount * hamburgerPrice;
            cokeTotal = cokeCount * cokePrice;
            waterTotal = waterCount * waterPrice;
            friesTotal = friesCount * friesPrice;
            pizzaTotal = pizzaCount * pizzaPrice;
            lemonadeTotal = lemonadeCount * lemonadePrice;

            Console.WriteLine("---------------------------");
            Console.WriteLine("Hamburger Tutarı: " + hamburgerTotal + " TL");
            Console.WriteLine("Pizza Tutarı: " + pizzaTotal + " TL");
            Console.WriteLine("Kızartma Tutarı: " + friesTotal + " TL");
            Console.WriteLine("Kola Tutarı: " + cokeTotal + " TL");
            Console.WriteLine("Limonata Tutarı: " + lemonadeTotal + " TL");
            Console.WriteLine("Su Tutarı: " + waterTotal + " TL");
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            totalPrice = hamburgerTotal + cokeTotal + waterTotal + friesTotal + pizzaTotal + lemonadeTotal;

            Console.WriteLine("Toplam Tutar: " + totalPrice + " TL");

            #endregion

            Console.Read();

        }
    }
}
