using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathodApp
{
    class Program
    {
        static void Main(string[] args)
        {

            double i = 10;
            int a = 100;
            long b = a;

            long c = 30;

            int d = (int)c;


            double result = GetSquare(i);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static double GetSquare(double aValue)
        {
            double squareValue = aValue * aValue;
            return squareValue;

        }
    }
}
