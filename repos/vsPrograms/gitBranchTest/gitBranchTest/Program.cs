using System;

namespace gitBranchTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Give two numbers to multiply together. If their product is greater than or equal to 15, " +
                $"result will be true.");
             Console.WriteLine($"If their product is less than 15, the result will be false.");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int num3 = num1 * num2;
            Console.WriteLine(Test(num3));
        }
        public static bool Test(int num3)
        {
            if (num3 >= 15)
                return true;

            return false;
        }

    }
}
