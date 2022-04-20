using System;

namespace Exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("£20 total after discount is £" + CalculateDiscount(20));
            Console.WriteLine("£50 total after discount is £" + CalculateDiscount(50));
            Console.WriteLine("£100 total after discount is £" + CalculateDiscount(100));
            Console.WriteLine("£101 total after discount is £" + CalculateDiscount(101));
        }


        public static double CalculateDiscount(double totalBeforeDiscount)
        {
            double totalAfterDiscount = totalBeforeDiscount;

            if (totalBeforeDiscount >= 100)
            {
                totalAfterDiscount =  totalBeforeDiscount * 0.8;
            }
            else if (totalBeforeDiscount >= 50)
            {
                totalAfterDiscount = totalBeforeDiscount * 0.88;
            }
            else if (totalBeforeDiscount >= 20)
            {
                totalAfterDiscount = totalBeforeDiscount * 0.95;
            }

            return Math.Round(totalAfterDiscount, 2);
        }
    }
}
