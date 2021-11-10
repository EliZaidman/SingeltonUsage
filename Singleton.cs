using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingeltonToRead
{
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object objLock = new object(); // Added new line
        private int _counter = 0;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                lock (objLock)  // Added new block
                {
                    if (_instance == null)
                        _instance = new Singleton();

                    return _instance;
                }
            }
        }

        public int Increament()
        {
            return _counter++;
        }

        public void print()
        {
            Console.WriteLine("Counter Value: " + _counter.ToString());
        }
    }
}
