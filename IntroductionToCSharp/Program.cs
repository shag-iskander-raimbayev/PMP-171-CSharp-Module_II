using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToCSharp
{
    class A
    {
        private int B;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World");
            Console.Write("This is one line");
            Console.Write("\n");
            Console.WriteLine("This message comes with audio \a");
            */

            /*
            int someInteger = 10;
            int aInteger = 20, bInteger = 30, cInteger = 40;
            double pi = 3.14, exp = 2.7;

            double piMultExp = pi * exp;

            Console.WriteLine(someInteger);
            Console.WriteLine(aInteger.ToString() + " " + bInteger + " " + cInteger);
            Console.WriteLine(piMultExp);
            */

            /*
            double a, b, c;
            string myInput = Console.ReadLine();
            string myInputTwo = Console.ReadLine();

            a = double.Parse(myInput);
            b = double.Parse(myInputTwo);

            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine(c);
            */

            /*
            double x1, x2, y1, y2, result;
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());

            result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1,2));

            // Next lesson: string formatting operators
            Console.WriteLine(result);
            Console.WriteLine(result.ToString("0"));
            */

            /*Console.WriteLine(100M);

            Console.WriteLine("Enter CM");
            int cm = int.Parse(Console.ReadLine());
            float meters = cm / 100F;
            Console.WriteLine(meters);*/
            /*
            double p, r, n, c , a1;
            p = double.Parse(Console.ReadLine());
            r = double.Parse(Console.ReadLine());
            n = double.Parse(Console.ReadLine());
            a1 = Math.Pow(1 + r / 12, 12 * n);
            double a2 = 12 * n;

            c = ((p * (r / 12) * a1) / (a1 - 1)) * a2  - p;
            Console.WriteLine(c);
            */

            /*
            double x = double.Parse(Console.ReadLine());
            double factorial_3 = 1, factorial_5 = 1, factorial_7 = 1;
            double x_3, x_5, x_7;

            for (int i = 1; i <= 3; i++)
            {
                factorial_3 = factorial_3 * i;
            }
            for (int i = 1; i <= 5; i++)
            {
                factorial_5 = factorial_5 * i;
            }
            for (int i = 1; i <= 7; i++)
            {
                factorial_7 = factorial_7 * i;
            }

            double result = x - (Math.Pow(x, 3) / factorial_3) 
                + (Math.Pow(x, 5) / factorial_5) 
                - (Math.Pow(x, 7) / factorial_7);

            Console.WriteLine(Math.Sin(x));
            Console.WriteLine(result);
            */
            // Switch-case complex version - see later
            /*
            int n = 10;
            switch (n)
            {
                case 3:
                    Console.WriteLine("LOL");
                    break;
                case 20:
                    Console.WriteLine("LOL2");
                    break;
                default:
                    Console.WriteLine("LOL3");
                    break;
            }
            */

            int [] arr = { 1, 2, 3, 4, 5 };

            int [] arr2 = new int[10];

            int[] arr3 = new int[5] { 1, 2, 3, 4, 6 };

            double[] d = new double[10];

            Program p = new Program();

            object[] objects = { 1, true, 1D, "Oll", p };

            foreach (var item in objects)
            {
                Console.WriteLine(item);
            }

            A a = new A();

            Console.ReadLine();
        }
    }
}
