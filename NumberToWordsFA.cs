using System;

namespace NumToWord1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            int n, a, b, c;

            Console.Write("Adade se raghami vared kon: ");
            n = int.Parse(Console.ReadLine());

            c = n % 10;

            n = n / 10;
            b = n % 10;

            n = n / 10;
            a = n % 10;
                            
            if (a == 1)
                Console.Write("Saado ");

            if (a == 2)
                Console.Write("Divisto ");

            if (a == 3)
                Console.Write("Sisado ");

            if (a == 4)
                Console.Write("Chaharsado ");

            if (a == 5)
                Console.Write("Poonsado ");

            if (a == 6)
                Console.Write("Shishsado ");

            if (a == 7)
                Console.Write("Haftsado ");

            if (a == 8)
                Console.Write("Hashtsado ");

            if (a == 9)
                Console.Write("Nohsado ");

            if (c == 0)
            {
                if (b == 1)
                    Console.Write("Daho ");
            }

            if (b == 2)
                Console.Write("Bisto ");

            if (b == 3)
                Console.Write("Siyo ");

            if (b == 4)
                Console.Write("Chehelo ");

            if (b == 5)
                Console.Write("Panjaho ");

            if (b == 6)
                Console.Write("Shasto ");

            if (b == 7)
                Console.Write("Haftado ");

            if (b == 8)
                Console.Write("Hashtado ");

            if (b == 9)
                Console.Write("Navado ");


            if (b == 1)
            {
                if (c == 1)
                    Console.Write("Yazdah ");

                if (c == 2)
                    Console.Write("Davazdah ");

                if (c == 3)
                    Console.Write("Sizdah ");

                if (c == 4)
                    Console.Write("Chahardah ");

                if (c == 5)
                    Console.Write("Poonzdah ");

                if (c == 6)
                    Console.Write("Shoonzdah ");

                if (c == 7)
                    Console.Write("Hifdah ");

                if (c == 8)
                    Console.Write("Hizhdah ");

                if (c == 9)
                    Console.Write("Noozdah ");
            }

            else
            {
                if (c == 1)
                    Console.Write("Yek ");

                if (c == 2)
                    Console.Write("Do ");

                if (c == 3)
                    Console.Write("Se ");

                if (c == 4)
                    Console.Write("Chahar ");

                if (c == 5)
                    Console.Write("Panj ");

                if (c == 6)
                    Console.Write("Shish ");

                if (c == 7)
                    Console.Write("Haft ");

                if (c == 8)
                    Console.Write("Hasht ");

                if (c == 9)
                    Console.Write("Noh ");
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Payane barnameh.");

            Console.ReadKey();
        }
    }
}
