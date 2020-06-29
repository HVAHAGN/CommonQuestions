using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldKeyword
{
    class Program
    {
         static List<int> MyList = new List<int>();
        static void FillValues()
        {
            MyList.Add(1);
            MyList.Add(2);
            MyList.Add(3);
            MyList.Add(4);
            MyList.Add(5);
            MyList.Add(6);

        }
        static IEnumerable<int> Filter()
        {
            List<int> temp = new List<int>();
            foreach (var item in MyList)
            {
                if (item>3)
                {
                    temp.Add(item);
                }
            }
            return temp;
        }
        //Filtering without of a temp collection
        static IEnumerable<int> FilterWithYield()
        {
         
            foreach (var item in MyList)
            {
                if (item > 3)
                {
                    yield return item;
                }
            }
         
        }
        static IEnumerable<int> RunningTotal()
        {
            int runningTotal = 0;
            foreach (var item in MyList)
            {
                runningTotal += item;
                yield return (runningTotal);
            }
        }
        static void Main(string[] args)
        {

            //Yield helps to do custom stateful iteration over a collection 
            FillValues();
            foreach (var item in FilterWithYield())
            {
                //If condition is true he remember that has to start from which number
                Console.WriteLine(item);
            }
            Console.WriteLine("Running Total");
            foreach (var item in RunningTotal())
            {
                //If condition is true he remember that has to start from which number
                Console.WriteLine(item);
            }




            Console.ReadLine();
        }
    }
}
