using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace LibrariesOfBaseClasses.NET
{
    class Program
    {
       static void PrintTime(object state)
       {
            Console.WriteLine($"Time is {DateTime.Now.ToLongDateString()}");
       }
        static void Main(string[] args)
        {
            TimerCallback tb = PrintTime;
            Timer t = new Timer(tb, null, 0, 1000);
            Console.ReadLine();
            Console.WriteLine();
            

        }
       


    }
}
