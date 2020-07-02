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
        //  static CalArepointer cpointer = CalculateArea;

        static void Main(string[] args)
        {

            //CalArepointer cpointer = new CalArepointer(delegate (int r)
            //{
            //    return 3.14 * r * r;
            //});

            //double Area = cpointer(20);

            //more short and sweeter by using Lambda + Func
            CalArepointer Cpointer = r => 3.12 * r * r;
            var Area = Cpointer(20);
            Func<double, double> cpoiner = r => 3.13 * r * r;
            var Area2 = cpoiner(20);

            Action<string> MyPrinter = y => Console.WriteLine(y);
            MyPrinter("Hello");



            Console.ReadLine();
        }

        static double CalculateArea(int r)
        {
            return 3.14 * r * r;
        }
    }
}
