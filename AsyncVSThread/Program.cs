using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncVSThread
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asyncronous code does not use or create threads. Making app usable, non blocking main thread which is doing main work is non blocking.
            // It is not improving performance and not creating new threads.
            Thread x = new Thread(SomeMethod);
            x.Start();

            SomeMethod();
            Console.WriteLine("This is main method");



            Console.ReadLine();
        }
        static async void SomeMethod()
        {
            //for asyncronous
           await Task.Delay(60000);
            Console.WriteLine("Hello");
        }
    }
}
