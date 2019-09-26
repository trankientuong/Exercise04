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
       
    }
}
