using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Github");
            Console.WriteLine(isPrime(6));

        }
        public static bool isOdd(int n)
        {
            if (n % 2 == 1)
                return true;
            return false;
        }
        public static bool isEven(int n)
        {
            if (n % 2 == 0)
                return true;
            return false;
        }
        public static bool isPrime(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    count++;
            }
            if (count == 2)
                return true;
            return false;
        }
        public static int Square(int n)
        {
            return n * n;
        }
        public static int Cube(int n)
        {
            return n * n * n;
        }
        public static int Pow(int x, int y)
        {
            int R = 1;
            for(int i=1;i<=y;i++)
            {
                R = R * x;
            }
            return R;
         }
        public static int Abs(int n)
        {
            if (n > 0)
                n = n;
            else
                n = n * (-1);
            return n;
        }
    }
}
