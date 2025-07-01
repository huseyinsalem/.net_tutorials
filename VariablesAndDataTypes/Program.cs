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

            #endregion



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
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            #endregion



            // DECISION STRUCTURES 

            #region if  else


            string capital, country;
            Console.Write("enter the capital: ");
            capital = Console.ReadLine();

            Console.Write("enter the country: ");
            country = Console.ReadLine();

            if(capital=="Türkiye" & country=="Ankara" )
            {
                Console.WriteLine("data verified");
            }
            else
            {
                Console.WriteLine("incorrect information");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---------------------------------");




            int exam1, exam2, exam3, average;
            string result="";

            Console.Write("note1: ");
            exam1=int.Parse(Console.ReadLine());
            Console.Write("note2: ");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("note3: ");
            exam3 = int.Parse(Console.ReadLine());



            average = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("average of exams: " + average);

            if (average > 0 & average < 50)
            {
                Console.WriteLine(" result is mediocre");
            }
            if (average > 50 & average < 80)
            {
                Console.WriteLine("result is medium");
            }

            if (average > 80)
            {
                Console.WriteLine("result is good");
            }
            Console.WriteLine(result) ;

            Console.WriteLine("---------------------------------");


            #endregion



            #region switch case

            Console.WriteLine("Please log in to the lessons");
            int numberLessons=int.Parse(Console.ReadLine());


            switch(numberLessons)
            {
                case 1: Console.WriteLine("maths"); break;
                case 2: Console.WriteLine("Turkish"); break;
                case 3: Console.WriteLine("biology"); break;
                case 4: Console.WriteLine("English"); break;
                case 5: Console.WriteLine("chemical"); break;
                case 6: Console.WriteLine("physical"); break;
                default: Console.WriteLine("incorrect entry");break;
          
            }

            #endregion



            //LOOPS


            #region For loop


            Console.WriteLine("---------------------------------");




            Console.Write("please enter a value on the screen: ");
            int finishValue = int.Parse(Console.ReadLine());

            for (int i = 1; i <= finishValue; i++)
            {
                Console.WriteLine("I love you");
            }


            Console.WriteLine("---------------------------------");
            #endregion


            

            #region decision structures with for loop



            for (int i =1; i<=30; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine();


            int totalValue = 1;
            for(int i =1;i<=10;i++)
            {
                totalValue += i;
            }
            Console.WriteLine(totalValue);


            Console.WriteLine("---------------------------------");




            int totalValue2 = 0;
             for(int i = 1;i<=20; i++)
            {
                if(i % 2 == 0)
                {
                    totalValue2 += i;
                    Console.WriteLine(i);
                }

                
                
            }
            Console.WriteLine("-----");
            Console.WriteLine(totalValue2);



            Console.WriteLine("---------------------------------");
            #endregion



            #region while


            int number = 1;
            while (number <= 10)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
                number++;
            }
            #endregion



            //ARRAYS


            #region Arrays


            Console.WriteLine("---------------------------------");

            string[] colors = { "Yellow", "Red", "Black", "Orange", "Green", "Blue" };

            for(int i=0;i<colors.Length;i++)
            {
                Console.WriteLine(colors[i]);
            }

            Console.WriteLine("---------------------------------");


            int[] numbers = { 6, 20, 100, 522, 400, 888, 456 };

            for(int i=0;i<numbers.Length;i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("---------------------------------");


            int[] numbers2 = { 56, 12, 48, 65, 321, 35, 487 };
            Array.Sort(numbers2);
            for(int i=0;i<numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i]);
            }


            #endregion



            #region foreachLoop

            Console.WriteLine("---------------------------------");




            int[] numbers1 = { 45, 86, 15, 28, 456, 89, 159 };
            foreach(int x in numbers1)
            {
                Console.WriteLine(x);
            }

            #endregion



            #region exam system application



            Console.WriteLine("----------------------------------");


            Console.WriteLine("***** EXAM APPLICATION *****");
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("------------------------------");

            Console.Write("How many students are there in your class: ");
            int studentcount=int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------------");





            string[] studentNames= new string[studentcount];
            double[] studentExamAvg=new double[studentcount];

            for (int i=0; i< studentcount;i++)
            {
                Console.Write($"{i+1} Enter the student's name: ");
                studentNames[i] = Console.ReadLine();



                double totalExamResult = 0;




                for(int j=0; j<3; j++)
                {
                    Console.Write($"{studentNames[i]}The student named {j+1} Enter the exam score: ");
                    double value =double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }

                studentExamAvg[i] = totalExamResult / 3;

            }

            for (int i=0;i<studentcount;i++)
            {
                Console.WriteLine($"{studentNames[i]}The average of the student named: {studentExamAvg[i]}");
            }



            #endregion





            //METHODS


            #region methods
            Console.WriteLine("----------------------------------");

            void customercard(string name,string surName)
            {
                Console.WriteLine("Customer: "+name+" "+surName); 
            }
            customercard("Hüseyin","Salem");
            customercard("Zeliş", "Öztürk");

            Console.WriteLine("----------------------------------");


            void sum(int number1, int number2,int number3)
            {
                int result1 = number1 + number2 + number3;
                Console.WriteLine(result1);
            }
            sum(4, 6, 7);

            Console.WriteLine("----------------------------------");

            #endregion

            Console.Read();
        }

    }
}
