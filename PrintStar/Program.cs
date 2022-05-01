using System;

namespace PrintStar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Q1();
            Q2();
            Q3();
            Q4();
            Q5();
            Q6();
        }
        static void Q1()
        {
            DisplayHeader("Q1.三角形");
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Q2()
        {
            DisplayHeader("Q2.倒三角形");
            int rows = 5;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 0; j <= rows - i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Q3()
        {
            DisplayHeader("Q3.靠右三角形");
            int rows = 5;

            string star = "";
            for (int i = rows; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(star += "*");
                Console.Write(Environment.NewLine);
            }
        }
        static void Q4()
        {
            DisplayHeader("Q4.靠右倒三角");
            int rows = 5;
            string space = "";
            for (int i = rows; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write(Environment.NewLine);
                Console.Write(space += " ");
            }
        }
        static void Q5()
        {
            DisplayHeader("Q5");
            int rows = 4;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 0; j < rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int z = 0; z < i * 2- 1; z++)
                {
                    Console.Write("*");
                }
                Console.Write(Environment.NewLine);
            }
        }
        static void Q6()
        {
            DisplayHeader("Q6");
            int rows = 4;
            string space = "";
            for (int i = rows; i >0; i--)
            {
                for (int j = 0; j < i*2-1; j++)
                {
                    Console.Write("*");
                }
                Console.Write(Environment.NewLine);
                Console.Write(space += " ");
            }

        }

        static void DisplayHeader(string title)
        {
            Console.WriteLine("\r\n");
            Console.WriteLine(title);
            Console.WriteLine(new string('=', 40));
        }
    }
}