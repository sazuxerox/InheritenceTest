using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Rectangle(4, 3);
            r.Display();
            Console.ReadKey();
        }
    }
}
