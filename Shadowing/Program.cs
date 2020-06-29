using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shadowing
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            Sales obj3 = new Sales();
            obj3.InvoiceNumber = 123;
            SalesVersion2 obj4 = new SalesVersion2();
            obj4.InvoiceNumber = "Hello";

            //overriding change the implementation
            Class1 obj1 = new Class1();
            Class2 obj2 = new Class2();
            // i is a variable
            obj1.i = 123;

            // i has been converted to a method
            // parent class element is compeletly replaced by the child class //shadowing
            obj2.i();

            Console.ReadLine();
        }
    }
    public class Sales
    {
        public int InvoiceNumber { get; set; }
    }
    public class SalesVersion2 : Sales
    {
        public object InvoiceNumber { get; set; }
    }
    public class Class1
    {
        public int i = 0;
    }
    public class Class2 : Class1
    {
        public void i()
        {

        }
    }
}
