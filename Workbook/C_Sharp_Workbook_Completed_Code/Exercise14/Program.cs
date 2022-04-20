using System;

namespace Exercise14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5,8 should be 40: " + Multiply(5, 8) );
            Console.WriteLine("-7,-2 should be 14: " + Multiply(-7, -2));
            Console.WriteLine("-10,8 should be -80: " + Multiply(-10, 8));
            Console.WriteLine("3,-11 should be -33: " + Multiply(3, -11));
            Console.WriteLine("14,0 should be 0: " + Multiply(14, 0));
        }

        public static int Multiply(int num1, int num2)
        {
            // Need to check if either number is negative for later
            bool isNum1Negative = num1 < 0;
            bool isNum2Negative = num2 < 0;

            // Math.Abs() will give the positive value of any number, e.g. Math.Abs(4) is 4, Math.Abs(-4) is 4.
            num1 = Math.Abs(num1);
            num2 = Math.Abs(num2);

            int answer = 0;
            // Add num1 to itself num2 number of times
            for(int i=0; i<num2; i++)
            {
                answer += num1;
            }

            // If num1 was negative to start with, we need to convert it back to being negative
            if (isNum1Negative)
            {
                answer = 0 - answer;
            }
            // If num 2 was negative to start with, we need to convert it back to being negative
            if (isNum2Negative)
            {
                answer = 0 - answer;
            }

            return answer;
        }
    }
}
