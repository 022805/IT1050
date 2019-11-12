using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int speedlimit = 35;
            int speed = 42;

            if (speed > speedlimit)
            {
                Console.WriteLine("SLOW NOW");
            }

            bool isTrue;
            isTrue = true;

            int num1 = 14;
            int num2 = 19;

            if (num1 < num2)
            {
                Console.WriteLine("It is True!");
            }

            else

            {
                Console.WriteLine("It is False!");
            }

            Console.WriteLine("Input temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double Celsius = (fahrenheit - 32d) * 5d / 9d;
            Console.WriteLine("Temperature in Celsius is {0}: ",
                Celsius); Console.ReadLine();

            if (fahrenheit >= 90)
                Console.WriteLine("It is hot");

            if (fahrenheit <= 40)
                Console.WriteLine("It is cold");

            int counter = 1;
            while (counter < 11)

            {
                Console.WriteLine(counter);
                counter = counter + 1;
            }

            int counter = 60;
            while (counter > 19)

            {
                Console.WriteLine(counter);
                counter = counter - 1;
            }

            int counter = 10;
            while (counter <= 20)
            {
                Console.WriteLine(counter);
                counter = counter + 1;
            }












        }
        }
}
