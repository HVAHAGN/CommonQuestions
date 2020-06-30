using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpActionFuncPredicate
{
    class Program
    {
       delegate double CalArepointer(int r);
       static CalArepointer cpointer = CalculateArea;

        static void Main(string[] args)
        {

            double area = cpointer.Invoke(20);
             


            Console.ReadLine();
        }

        static double CalculateArea(int r)
        {
            return 3.14 * r * r;
        }
    }
}
