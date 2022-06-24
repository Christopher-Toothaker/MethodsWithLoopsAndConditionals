using System;

namespace MethodsWithLoopsAndConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DecendingDigits();
            OddWayUp();
            Console.WriteLine(EqualCheck());
            Console.WriteLine(EvenOrOdd());
            PosOrNeg();
            VotingAge();
            TensRange();
            TimesTables();

        }

        public static void DecendingDigits()
        {
            Console.WriteLine("This part counts from 1000 to -1000. Press any key to start.");

            Console.ReadKey();
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }

        }

        public static void OddWayUp()
        {
            Console.WriteLine("This part counts to 999 by 3 starting from 3. Press any key to continue.");
            Console.ReadKey();

            int oddCount = 3;
            do
            {
                Console.WriteLine(oddCount);
                oddCount += 3;
            }
            while (oddCount <= 999);


        }

        public static bool EqualCheck()
        {

            Console.WriteLine(" This part determines if two numbers are equal or not. " +
                "Enter a number and press Return, then enter another number and press Return.");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            return a == b;



        }

        public static bool EvenOrOdd()
        {

            Console.WriteLine("This part determines if a number is even or odd. " +
                "Enter a number and press Return to see if it is even or odd.");

            var div = int.Parse(Console.ReadLine());
            var isEven = div % 2 == 0;
            var evenOrOdd = isEven ? "even" : "odd";
            Console.WriteLine($"{div} is {evenOrOdd}");
            return isEven;
        }

        public static void PosOrNeg()
        {
            Console.WriteLine("This part determines if a number is positive or negative. " +
                "Enter a number and press Return to see if it is positive or negative.");

            var num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is negative");
            }
            else
            {
                Console.WriteLine($"{num} is 0");
            }
        }

        public static void VotingAge()
        {
            Console.WriteLine("This part determines if you are old enough to vote. Enter a number to find out.");

            var ableToVote = Convert.ToInt32(Console.ReadLine());

            if (ableToVote >= 18)
                Console.WriteLine("You are old enough to vote.");
            else
                Console.WriteLine("You are not old enough to vote yet.");

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        public static void TensRange()
        {
            Console.WriteLine("This part determines if a number falls between -10 and 10. " +
                "Type a number between -10 and 10 and press Return.");

            var inRange = Convert.ToInt32(Console.ReadLine());

            if (inRange >= -10 && inRange <= 10)
            {
                Console.WriteLine($"{inRange} is between -10 and 10.");
            }

            else if (inRange < -10)
                Console.WriteLine(inRange + " is less than -10 and does not fall in set range.");

            else
                Console.WriteLine(inRange + " is greater than 10 and does not fall in set range.");

        }

        public static void TimesTables()
        {

            int[] table = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            Console.WriteLine("This part shows the multiplication table of a given number. " +
                "Input a number to see its multiplication table from 1 to 12");

            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < table.Length; i++)

                Console.WriteLine(input * table[i]);

            Console.WriteLine("Press any key to end program");
            Console.ReadKey();

        }

    }
}
