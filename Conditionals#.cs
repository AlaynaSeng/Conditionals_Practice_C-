using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Conditionals
    {
        static void Main(string[] args)
        {
            float np;
            Console.WriteLine("Number 1");
            Console.WriteLine("Enter a positve or negative number: ");
            np = float.Parse(Console.ReadLine());
            if(np >= 0)
            {
                Console.WriteLine($"\n {np} is a positve number!");
            }
            else
            {
                Console.WriteLine($"\n {np} is a negative number!");
            }


            float in1;
            float in2;
            float in3;
            Console.WriteLine($"\n Number 2");
            Console.Write("Enter Your First Number: ");
            in1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Your Second Number: ");
            in2 = float.Parse(Console.ReadLine());
            Console.Write("Enter Your Third Number: ");
            in3 = float.Parse(Console.ReadLine());
            if(in1 <= in2)
            {
                if(in1 < in3)
                {
                    if(in2 <= in3)
                    {
                        Console.WriteLine($"\n Your numbers have been inputed in increasing order.");
                    }

                }
                else
                {
                    Console.WriteLine($"\n Your numbers have not been entered in increasing order.");
                }

            }



            float evod;
            Console.WriteLine($"\n Number 3");
            Console.WriteLine("Enter a number: ");
            evod = float.Parse(Console.ReadLine());
            if(evod % 2 == 0)
            {
                Console.WriteLine($"\n This number is even");
            }
            else
            {
                Console.WriteLine($"\n This number is odd");
            }


            int day;
            Console.WriteLine($"\n Number 4");
            Console.Write("Enter a Number 1-7: ");
            day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1 : Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                default: Console.WriteLine("This is not an aplicable number"); break;
            }


            char voc;
            Console.WriteLine($"\n Number 5");
            Console.WriteLine("Enter a single letter");
            voc = Convert.ToChar(Console.ReadLine());
            if(voc == 'a' || voc == 'A' || voc == 'e' || voc == 'E' || voc == 'i' || voc == 'I' || voc == 'o' || voc == 'O' || voc == 'u' || voc == 'U')
            {
                Console.WriteLine($"{voc} is a vowel");
            } else if(voc == 'y' || voc == 'Y')
            {
                Console.WriteLine($"{voc} is sometimes a vowel");
            }
            else
            {
                Console.WriteLine($"{voc} is a consonant");
            }


            float exn1;
            float exn2;
            Console.WriteLine($"\n Number 6");
            Console.WriteLine("Enter a number");
            exn1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            exn2 = float.Parse(Console.ReadLine());
            if(exn1 > exn2)
            {
                Console.WriteLine($"\n {exn2} , {exn1}");
            }
            else
            {
                Console.WriteLine($"\n {exn1} , {exn2}");
            }


            float invoice;
            Console.WriteLine($"\n Number 7");
            Console.WriteLine("Enter your gross amount of an invoice");
            invoice = float.Parse(Console.ReadLine());
            if(invoice >= 20000)
            {
                Console.WriteLine($"\n you get 15% off! your total is now {invoice - (invoice * 0.15)} ");
            }
            else
            {
                Console.WriteLine($"\n Your total is {invoice}");
            }


            float p1;
            float p2;
            float p3;
            Console.WriteLine($"\n Number 8");
            Console.Write("Enter Your First Number: ");
            p1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Your Second Number: ");
            p2 = float.Parse(Console.ReadLine());
            Console.Write("Enter Your Third Number: ");
            p3 = float.Parse(Console.ReadLine());
            float res = p1 * p2 * p3;
            if(res >= 0)
            {
                Console.WriteLine($"\n + (Positve)");
            }
            else
            {
                Console.WriteLine($"\n - (Negative)");
            }


            float i1;
            float i2;
            float i3;
            Console.WriteLine($"\n Number 9");
            Console.Write("Enter Your First Number: ");
            i1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Your Second Number: ");
            i2 = float.Parse(Console.ReadLine());
            Console.Write("Enter Your Third Number: ");
            i3 = float.Parse(Console.ReadLine());
            if (i1 > i2)
            {
                if (i1 > i3)
                {
                    Console.WriteLine($"\n {i1} is the greatest number");
                }
            }
            else if (i2 > i3)
            {
                if (i2 > i1)
                {
                    Console.WriteLine($"\n {i2} is the greatest number");
                }
            }
            else
            {
                Console.WriteLine($"\n {i3} is the greatest number");
            }


            int nanu;
            Console.WriteLine($"\n Number 10");
            Console.WriteLine($"\n Enter a number between 0 and 9");
            nanu = int.Parse(Console.ReadLine());
            switch (nanu)
            {
                case 0 : Console.WriteLine("Zero"); break;
                case 1 : Console.WriteLine("One"); break;
                case 2 : Console.WriteLine("Two"); break;
                case 3 : Console.WriteLine("Three"); break;
                case 4 : Console.WriteLine("Four"); break;
                case 5 : Console.WriteLine("Five"); break;
                case 6 : Console.WriteLine("Six"); break;
                case 7 : Console.WriteLine("Seven"); break;
                case 8 : Console.WriteLine("Eight"); break;
                case 9 : Console.WriteLine("Nine"); break;
                default : Console.WriteLine("This is not an aplicable number"); break;
            }


            int inte = 0;
            double dub = 0;
            string stri;
            Console.WriteLine($"\n Number 11");
            Console.Write("\n Choose an input type(integer = 0, double = 1, string = 2)");
            inte = int.Parse(Console.ReadLine());
            switch (inte)
            {
                case 0 : Console.WriteLine("Enter an integer"); 
                inte = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\n {inte + 1}");
                    break;
                case 1 : Console.WriteLine("Enter a double");
                    dub = double.Parse(Console.ReadLine());
                    Console.WriteLine($"\n {dub + 1}");
                    break;
                case 2 : Console.WriteLine("Enter a string");
                    stri = Console.ReadLine();
                    stri += '*';
                    Console.WriteLine($"\n {stri}");
                    break;
            }


            int score;
            Console.WriteLine($"\n Number 12");
            Console.WriteLine("Enter a number between 1 and 9");
            score = int.Parse(Console.ReadLine());
            switch (score)
            {
                case 1 : Console.WriteLine(score * 10); break;
                case 2: Console.WriteLine(score * 10); break;
                case 3: Console.WriteLine(score * 10); break;
                case 4: Console.WriteLine(score * 100); break;
                case 5: Console.WriteLine(score * 100); break;
                case 6: Console.WriteLine(score * 100); break;
                case 7: Console.WriteLine(score * 1000); break;
                case 8: Console.WriteLine(score * 1000); break;
                case 9: Console.WriteLine(score * 1000); break;
                default: Console.WriteLine("This is not an aplicable number"); break;
            }





            Console.ReadKey();
        }
    }
}
