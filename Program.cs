using System;

namespace InClassWeek5
{
    class Program
    {
        static void Main(string[] args)
        {
          MyMath mathobject1 = new MyMath();

            Console.WriteLine("The difference is " + mathobject1.subtractNumbers(33, 21));
            Console.WriteLine("The sum is " + mathobject1.addNumbers(9, 10));
            Console.WriteLine("The product is " + mathobject1.multiplyNumbers(33, 21));
            Console.WriteLine("The quotient is " + mathobject1.dividenumbers(33, 21));

            mathobject1.operand1 = 10;
            mathobject1.operand2 = 11;
            

            int sum;
            sum = mathobject1.addNumbers(22,45);
            Console.WriteLine("The sum is " + sum);
            Console.WriteLine("The sum is " + mathobject1.addNumbers(9,12,15));

        }



      
    }


}
