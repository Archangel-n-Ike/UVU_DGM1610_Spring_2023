using System;

namespace Challenge1b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the current month? (1-12)");
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("The current month is January");
                    break;
                case 2:
                    Console.WriteLine("The current month is February");
                    break;
                case 3:
                    Console.WriteLine("The current month is March");
                    break;
                case 4:
                    Console.WriteLine("The current month is April");
                    break;
                case 5:
                    Console.WriteLine("The current month is May");
                    break;
                case 6:
                    Console.WriteLine("The current month is June");
                    break;
                case 7:
                    Console.WriteLine("The current month is July");
                    break;
                case 8:
                    Console.WriteLine("The current month is August");
                    break;
                case 9:
                    Console.WriteLine("The current month is September");
                    break;
                case 10:
                    Console.WriteLine("The current month is October");
                    break;
                case 11:
                    Console.WriteLine("The current month is November");
                    break;
                case 12:
                    Console.WriteLine("The current month is December");
                    break;
                default:
                    Console.WriteLine("Is there a month I don't know about?");
                    break;
            }
        }
    }
}
