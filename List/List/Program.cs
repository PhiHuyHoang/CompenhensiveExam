using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            ListImplement L = new ListImplement();
            for (int i = 0; i < 10; i++)
            {
                L.insert2Front(i);
                //L.insert2End(i);
            }
            L.Traversal();
            L.removeNode(7);
            Console.WriteLine();
            L.Traversal();
            Console.ReadLine();
        }
    }
}
