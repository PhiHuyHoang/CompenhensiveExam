using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTCode
{
    class BinaryTreeImp
    {
        public Node root;
        static int count = 0;
        public BinaryTreeImp()
        {
            root = null;
        }
        //Create Node
        public Node addNode(int data)
        {
            Node newNode = new Node(data);
            if (root == null)
            {
                root = newNode;
            }
            count++;
            return newNode;
        }
        public void displayTree(Node t)
        {
            if (t == null) return;
            if (t.left != null)
            {
                Console.Write("\n" + t.data + "'s lc is is " + t.left.data + " ");
            }
            if (t.right != null)
            {
                Console.Write("\n" + t.data + "'s rc is is " + t.right.data + " ");
            }
            displayTree(t.left);
            displayTree(t.right);
        }
        //Lookup - determine value inside tree or not
        public bool Lookup(Node t, int data)
        {
            if (t == null)
            {
                return false;
            }
            if (t.data == data)
            {
                return true;
            }
            if (t.data < data)
            {
                t = t.right;
            }
            else
            {
                t = t.left;
            }
            return Lookup(t, data);
        }
        //Insert new Node
        public void insertNode(Node root, Node newNode)
        {
            Node t = root;
            if (t == null) return;
            if (newNode.data <= t.data)
            {
                if (t.left == null)
                {
                    t.left = newNode;
                }
                else
                {
                    t = t.left;
                    insertNode(t, newNode);
                }
            }
            else if (newNode.data > t.data)
            {
                if (t.right == null)
                {
                    t.right = newNode;
                }
                else
                {
                    t = t.right;
                    insertNode(t, newNode);
                }
            }
        }

        //Traversal
        //There are 3 type of Travesal: PreOrder - InOrder - PostOrder
        /*
         PreOrder: content - left - right
         InOrder: left - content - right
         PostOrder: left - right - content
         */
        public void PreOrder(Node p)
        {
            if (p != null)
            {
                Console.WriteLine(p.data);
                PreOrder(p.left);
                PreOrder(p.right);
            }
        }
        public void InOrder(Node p)
        {
            if(p != null)
            {
                InOrder(p.left);
                Console.WriteLine(p.data);
                InOrder(p.right);
            }
        }
        public void PostOrder(Node p)
        {
            if(p!= null)
            {
                PostOrder(p.left);
                PostOrder(p.right);
                Console.WriteLine(p.data);
            }
        }
    }
}
