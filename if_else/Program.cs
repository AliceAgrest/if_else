using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class TestTry
    {
        static void Main(string[] args)
        {
            
            // answer 1
            int training;
            Console.WriteLine("Enter a number of bascket player's hour training: ");
            training = int.Parse(Console.ReadLine());

            if (training < 30) ;
            {
                Console.WriteLine("Warrning - you can't stay at the team cause you don't have enough hours \n " +
                    "you need more : " + (30 - training ));
                
            }
            
            // answer 2
            int num , ahadot , meot;
            Console.WriteLine("Enter a number three digit: ");
            num = int.Parse(Console.ReadLine());

            ahadot = num%10;
            meot = num/100;

            if (meot > ahadot)
                Console.WriteLine("{0} > {1}", meot, ahadot);
            else
                Console.WriteLine("Ops the ahadot is bigger then the meot");
            
            // answer 3
            int num4, num1, num2, num3;
            Console.WriteLine("Enter a number three digit: ");
            num4 = int.Parse(Console.ReadLine());

            num1 = num4%10;
            num2 = num4/100;
            num3 = num4 % 100 / 10;

            if ((num1 + num2) > num3 && (num2 + num3) > num1 && (num3 + num1) > num2)
                Console.WriteLine("The combination of these three numbers can be a sides of triangle");
            else
                Console.WriteLine("Ops those numbers can't be sides of triangle");
            
            // answer 4
            int kwh, v1 , v2, v3 ;
            Console.WriteLine("Enter your kWh ");
            kwh = int.Parse(Console.ReadLine());

            if (kwh == 180)
            {
                v1 = (kwh + 70)/ 17 + kwh;
                Console.WriteLine("Your value is " + v1);
            }
            else if (kwh > 180 && kwh < 1000)
            {
                v2 = (kwh + 90)/17 + kwh;
                Console.WriteLine("Your value is " + v2);
            }
            else
            {
                v3 = kwh / 17 + kwh;
                Console.WriteLine("our value is " + v3);
            } 
            
            // answer 5
            char a, b;
            Console.WriteLine("Enter a letter ");
            a = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter another letter ");
            b = char.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("{0} {1}", a, b);
                Console.WriteLine("{0} {1}", b, a);
            }
            else if(b > a)
            {
                Console.WriteLine("{0} {1}", b , a);
                Console.WriteLine("{0} {1}", a , b);
            }
            

            Console.ReadLine();
        }
    }
}

