using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponentComputation
{
    class Program
    {
        public static int Exponent { get { return 2; } set { } }
        public static int BaseNumber { get { return 10; } set { } }
        public static int StartingBase { get { return 2; } set { } }
        public static int ComputeQuadratics(int baseNumber, int exponent)
        {
            var result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }

            return result;
        }

        static void Main(string[] args)
        {
            for (int i = StartingBase; i < BaseNumber; i++)
            {
                var result = ComputeQuadratics(i, Exponent);
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
