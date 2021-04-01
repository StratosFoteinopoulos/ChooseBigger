using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTCS_9_Exercises_Foteinopoulos
{
    class Program
    {
        enum colours
        {
            red, // 1
            blue, // 2
            yellow, //3
            green,//4
            black,//5
            grey,//6
        }
        static void Main(string[] args)
        {

            //EXERCISE 1

            Console.WriteLine("Please insert your Age");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine($"Your age is: {age} and your are a kid");

            }
            else
            {
                Console.WriteLine($"Your age is: {age} and you are an adult");
            }

            //EXERCISE 2

            Console.WriteLine("Please insert 2 numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            bool A = true;
            bool B = false;
            int result = 0;
            if (A == false && B == false)
            {
                result = a + b;
            }
            else if (A == false || B == false)
            {
                result = a - b;
            }
            else if (A == false && a > 5)
            {
                result = a * b;
            }
            else if (B == true && (a + b) > 45 && (a % b == 0))
            {
                Console.WriteLine("Something");
            }
            Console.WriteLine(result);


            //EXERCISE 3 Χωρίς Να είμαι σίγουρος για το ζητούμενο της Άσκησης

            Console.WriteLine("Please insert 1 number");
            int number = int.Parse(Console.ReadLine());
            int number2 = number;

            Console.WriteLine("While :" + number);
            while (number < 50)
            {

                number++;
            }
            Console.WriteLine("while:" + number + "\n");

            Console.WriteLine("Do While :" + number2);
            do
            {

                number2++;
            }
            while (number2 < 50);
            Console.WriteLine("Do While : " + number2);


            // EXERCISE 4

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            int example = 0;
            while (example < 10)
            {
                example++;
                if (example > 5)
                {
                    break;
                }
                Console.WriteLine(example);
            }

            int example2 = 0;
            while (example2 < 10)
            {

                if (example2 == 5)
                {
                    example2++;
                    continue;
                }
                example2++;
                Console.WriteLine(example2);
            }

            //   EXERCISE 5.1

            for (int i = 0; i < 2000;)
            {
                if (i < 1000)
                {
                    i = i + 100;
                    Console.WriteLine(i);
                }
                else if (i >= 1000)
                {
                    i = i + 50;
                    Console.WriteLine(i);
                }
            }

            //  EXERCISE 5.2

            Console.WriteLine("Please enter a number");
            int number52 = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i} * {number52} = " + (i * number52));
            }

            //  EXERCISE 5.3

            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    Console.Write(j);
                }
                Console.Write(" Row :" + i + "\n");
            }

            //  EXERCISE 5.4

            Console.WriteLine("Please enter a number ");
            int number54 = int.Parse(Console.ReadLine());
            int fbncci = 0;
            int[] pinakas = new int[number54];
            pinakas[0] = 0;
            pinakas[1] = 1;
            for (int i = 2; i < number54; i++)
            {
                pinakas[i] = pinakas[i - 1] + pinakas[i - 2];
                fbncci = pinakas[i];
            }
            Console.WriteLine(fbncci);

            // EXERCISE 6

            Console.WriteLine("please choose a number from 1 to 6");
            int n6 = int.Parse(Console.ReadLine());


            while (n6 < 1 || n6 > 6)
            {
                Console.WriteLine("invalid Value");

                n6 = int.Parse(Console.ReadLine());
            }
            switch (n6)

            {
                case 1:
                    Console.WriteLine("you chose 1");
                    return;

                case 2:
                    Console.WriteLine("you chose 2");
                    return;
                case 3:
                    Console.WriteLine("you chose 3");
                    return;

                case 4:
                    Console.WriteLine("you chose 4");
                    return;
                case 5:
                    Console.WriteLine("you chose 5");
                    return;
                case 6:
                    Console.WriteLine("you chose 6");
                    return;

                   
            }
        }
    }
}
