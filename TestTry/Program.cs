using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class TestTry
    {
        static void Main(string[] args)
        {
            /*
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
            */
            // answer 3
            int num, num1, num2 , num3, num4;
            Console.WriteLine("Enter a number three digit: ");
            num = int.Parse(Console.ReadLine());

            num1 = num%10;
            num2 = num/100;
            num3 = num % 100 / 10;
            num4 = num1 + num2;

            if (num4 > num3)
                Console.WriteLine("The combination of these three numbers can ba a sides of triangle");
            else
                Console.WriteLine("Ops those ");


            Console.ReadLine();
        }
    }
}

