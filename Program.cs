using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите х: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            double result = 0;
            for(int i = 0; i < n; i++) 
            {
                int upline = (int)(Math.Pow(x, 2 * i) * Math.Pow(-1, i));
                double underline = 2 * i + 1;
                result = upline / factorial(underline) + result;
            }
            Console.WriteLine(result);
        }
        public static double factorial(double arg)
        {
            if (arg == 1) {  return 1; }
            else { return arg * factorial(arg - 1); }
        }
    }
}
