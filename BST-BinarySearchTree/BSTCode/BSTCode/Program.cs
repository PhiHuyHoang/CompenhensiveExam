using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTCode
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeImp bt = new BinaryTreeImp();
            bt.insertNode(bt.root, bt.addNode(5));
            bt.insertNode(bt.root, bt.addNode(3));
            bt.insertNode(bt.root, bt.addNode(7));
            bt.insertNode(bt.root, bt.addNode(2));
            bt.insertNode(bt.root, bt.addNode(4));
            bt.insertNode(bt.root, bt.addNode(6));
            bt.insertNode(bt.root, bt.addNode(1));
            bt.displayTree(bt.root);

            Console.WriteLine();
            Console.WriteLine("Pre Order");
            // 5 3 2 1 4 7 6
            bt.PreOrder(bt.root);
            Console.WriteLine("In Order");
            // 1 2 3 4 5 6 7
            bt.InOrder(bt.root);
            Console.WriteLine("Post Order");
            // 1 2 4 3 6 7 5
            bt.PostOrder(bt.root);

            Console.WriteLine("lookup");
            Console.WriteLine(bt.Lookup(bt.root,7));
            Console.ReadLine();
        }
    }
}
