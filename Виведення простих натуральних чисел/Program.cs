using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void natural_namb(string max)
        {
            int x = Convert.ToInt32(max);
            int sum = 0;
            while (sum != x)
            {
                for (int i=1; ; i++)
                {
                    if (i % 2 == 0 || i % 3 == 0 || i % 5 == 0)
                    {
                        if (i==2 || i==3 || i == 5)
                        {
                            Console.WriteLine("Your number: " + i);
                            sum++;
                        }
                        else
                        {
                            continue;
                        }                       
                    }
                    else
                    {
                        Console.WriteLine("Your number: " + i);
                        sum++;
                    }
                    if (sum == x)
                    {
                        break;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter hove much natural number you wan't to see: ");
            string a = Console.ReadLine();
            natural_namb(a);
            Console.ReadKey();
        }
    }
}
