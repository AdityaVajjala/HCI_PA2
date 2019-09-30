using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static double op;
        static char cancellerInput;
        private static int inputInt = -1;
        private static string input;
        private static Task canceller;

        static void Main(string[] args)
        {
            var tasks = new List<Task>();
            tasks.Add(new Task(() => compute()));
            tasks.Add(new Task(() => Canceller()));
            tasks[0].Start();
            tasks[1].Start();
            Task.WaitAny(tasks.ToArray());
            Console.WriteLine("Exiting.........");
        }

        public static void compute()
        {
            Console.WriteLine("Please enter an integer or ‘q’ to quit.");
            input = Console.ReadLine();
            while (input.ToLower() != "q")
            {
                if (int.TryParse(input, out inputInt))
                {
                    Console.WriteLine("You have asked to compute the square root of PI " + inputInt + " times");
                    Printernrooter(inputInt);
                    Console.WriteLine("The square root of PI is " + op + ".");
                }
                Console.WriteLine("Please enter an integer or ‘q’ to quit.");
                input = Console.ReadLine();
            }
        }

        public static void Printernrooter(int inputInt)
        {
            for (int i = 1; i <= inputInt; i++)
            {
                if(cancellerInput != 'q')
                Console.WriteLine(i);
                Sqrtpi();
            }
        }

        public static void Canceller()
        {
            for (; input != "q"; )
            {
                if (Console.ReadKey().KeyChar == 'q')
                    return;
            }
        }

        public static void Sqrtpi()
        {
            op = Math.Sqrt(Math.PI);
        }
    }
}
