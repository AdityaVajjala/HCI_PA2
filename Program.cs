using System;
using System.Threading;

namespace HCI_PA2
{
    public class Class1
    {
        static double op;
        static void Main()
        {
            // Creating and initializing threads 
            Thread thr1 = new Thread(compute);
            Thread thr2 = new Thread(Sqrtpi);
            thr1.Start();
            thr2.Start();
        }

        public static void compute()
        {
            Class1 c = new Class1();
            System.Console.WriteLine("Please enter an integer or ‘q’ to quit.");
            string input;
            int inputInt = 0;
            input = System.Console.ReadLine();

            while (input.ToLower() != "q")
            {
                if (int.TryParse(input, out inputInt))
                {
                    System.Console.WriteLine("You have asked to compute the square root of PI " + inputInt + " times");
                    c.Printernrooter(inputInt);
                    System.Console.WriteLine("The square root of PI is " + op + ".");
                }
                System.Console.WriteLine("Please enter an integer or ‘q’ to quit.");
                input = System.Console.ReadLine();
            }
        }

        public void Printernrooter(int inputInt)
        {
            Class1 c1 = new Class1();
            for (int i = 1; i <= inputInt; i++)
            {
                //if (GetAsyncKeyState(0x53) < 0)
                //    break;
                System.Console.WriteLine(i);
            }
        }

        public static void Sqrtpi()
        {
            op = Math.Sqrt(Math.PI);
        }
    }
}
