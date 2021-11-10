using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonToRead
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.Increament();
            Singleton.Instance.Increament();
            Singleton.Instance.print();
            Console.ReadLine();
        }
        //if it will create a new object then counter will be set to 1 again otherwise to 2.
        //if new object will be created then it will print 0, otherwise it will print 2
    }
}
