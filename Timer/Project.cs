using System;

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = 0;
            Console.WriteLine("|                      Welcome to the Timer App v1.1                 |");
            Console.WriteLine("|                      Please input how long to run the timer        |");
            Console.WriteLine("|                      Note: Time is in seconds                      |");
            Console.WriteLine("|                                                                    |");

            try
            {
                time = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("ERROR: not a number!!");
            };
            if(time < 0)
            {
                Console.WriteLine("ERROR: You cant use a negative number in a timer");
            }
            Console.Clear();
            while (time > 0)
            {
                Console.WriteLine("--- " + time + " ---");
                System.Threading.Thread.Sleep(1000);
                time--;
            }

            Console.Clear();
            Console.WriteLine("---Time's Up!!!!---");
            System.Threading.Thread.Sleep(200);
        }
    }
}