using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string

            #endregion
            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, District, city;


            customerName = "Hüseyin";
            customerSurname = "Şalem";
            customerPhone = "+90 500 400 30 20";
            customerEmail = "Deneme@gmail.com";
            District = "Van";
            city = "İpekyolu";



            Console.WriteLine("******OTEL REZERVASYONU******");
            Console.WriteLine();
            Console.WriteLine("1.");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + District + "/" + city);
            Console.WriteLine("----------------------------------");





            customerName = "Hasan";
            customerSurname = "Demir";
            customerPhone = "+90 800 500 70 10";
            customerEmail = "proje@gmail.com";
            District = "İstanbul";
            city = "Kızılay";

            Console.WriteLine("2.");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + District + "/" + city);
            Console.WriteLine("----------------------------------");

            #region int
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            int hamburgerPrice = 250;
            int waterPrice = 20;
            int lemonedeprice = 80;
            int cokePrice = 100;
            int chipsPrice = 60;

            Console.WriteLine("*****RESTORANT MENÜSÜ*****");
            Console.WriteLine();
            Console.WriteLine("----------------------------------");
            Console.WriteLine("---Hamburger: " + hamburgerPrice);
            Console.WriteLine("---Su: " + waterPrice);
            Console.WriteLine("---Limonata: " + lemonedeprice);
            Console.WriteLine("---Kola: " + cokePrice);
            Console.WriteLine("---Patates Kızartması: " + chipsPrice);
            Console.WriteLine("----------------------------------");
            Console.WriteLine();


            int hamburgercount;
            int watercount;
            int lemonedecount;
            int cokecount;
            int chipscount;


            int totalhamburgerprice;
            int totalwaterprice;
            int totallemonedeprice;
            int totalcokeprice;
            int totalchipsprice;


            hamburgercount = 3;
            watercount = 3;
            lemonedecount = 1;
            cokecount = 2;
            chipscount = 2;


            totalhamburgerprice = hamburgercount * hamburgerPrice;
            totalwaterprice = watercount * waterPrice;
            totallemonedeprice = lemonedecount * lemonedeprice;
            totalcokeprice = cokecount * chipsPrice;
            totalchipsprice = chipscount * chipsPrice;



            Console.WriteLine("---------------------------------------");
            Console.WriteLine();
            Console.WriteLine("-Hamburger Tutarı:" + totalhamburgerprice + "TL");
            Console.WriteLine("-Su Tutarı:" + totalwaterprice + "TL");
            Console.WriteLine("-Limonata Tutarı:" + totallemonedeprice + "TL");
            Console.WriteLine("-Kola Tutarı:" + totalcokeprice + "TL");
            Console.WriteLine("-Patates Kızartması Tutarı:" + totalchipsprice + "TL");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------");

            int totalprice = totalchipsprice + totalwaterprice + totallemonedeprice + totalcokeprice + totalhamburgerprice;
            Console.WriteLine("Toplam Tutar:" + totalprice + "TL");


            int totalprice2 = totalchipsprice + totalwaterprice + totallemonedeprice + totalcokeprice + totalhamburgerprice;
            int avareage = totalprice2 / 5;
            Console.WriteLine("Toplam Tutar:" + totalprice + "TL");
            Console.WriteLine("Avarage : " +avareage);

            #endregion
            Console.Read();
        }
    }
}
