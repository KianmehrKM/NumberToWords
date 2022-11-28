using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            int n, a, b, c;

            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());

            c = n % 10;

            n = n / 10;
            b = n % 10;

            n = n / 10;
            a = n % 10;

            if (a == 1)
                Console.Write("One hundred ");

            if (a == 2)
                Console.Write("Two hundred ");

            if (a == 3)
                Console.Write("Three hundred");

            if (a == 4)
                Console.Write("Four hundred ");

            if (a == 5)
                Console.Write("Five hundred ");

            if (a == 6)
                Console.Write("Six hundred ");

            if (a == 7)
                Console.Write("Seven hundred ");

            if (a == 8)
                Console.Write("Eight hundred ");

            if (a == 9)
                Console.Write("Nine hundred ");

            if (c == 0)
            {
                if (b == 1)
                    Console.Write("Ten ");
            }

            if (b == 2)
                Console.Write("Twenty ");

            if (b == 3)
                Console.Write("Thirty ");

            if (b == 4)
                Console.Write("Fourty ");

            if (b == 5)
                Console.Write("Fifty ");

            if (b == 6)
                Console.Write("Sixty ");

            if (b == 7)
                Console.Write("Seventy ");

            if (b == 8)
                Console.Write("Eighty ");

            if (b == 9)
                Console.Write("Ninety ");


            if (b == 1)
            {
                if (c == 1)
                    Console.Write("Eleven ");

                if (c == 2)
                    Console.Write("Twelve ");

                if (c == 3)
                    Console.Write("Thirteen ");

                if (c == 4)
                    Console.Write("Fourteen ");

                if (c == 5)
                    Console.Write("Fifteen ");

                if (c == 6)
                    Console.Write("Sixteen ");

                if (c == 7)
                    Console.Write("Seventeen ");

                if (c == 8)
                    Console.Write("Eighteen ");

                if (c == 9)
                    Console.Write("Nineteen ");
            }

            else
            {
                if (c == 1)
                    Console.Write("One ");

                if (c == 2)
                    Console.Write("Two ");

                if (c == 3)
                    Console.Write("Three ");

                if (c == 4)
                    Console.Write("Four ");

                if (c == 5)
                    Console.Write("Five ");

                if (c == 6)
                    Console.Write("Six ");

                if (c == 7)
                    Console.Write("Seven ");

                if (c == 8)
                    Console.Write("Eight ");

                if (c == 9)
                    Console.Write("Nine ");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("End of program.");

            Console.ReadKey();
        }
    }
}
