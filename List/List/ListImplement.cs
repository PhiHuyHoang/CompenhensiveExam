using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class ListImplement
    {
        Node head;
        public ListImplement()
        {
            head = null;
        }

        public void Traversal()
        {
            Node p = head;
            while(p != null)
            {
                Console.WriteLine(p.data);
                p = p.Next;
            }
        }

        public void insert2Front(object newValue)
        {
            Node p = new Node();
            p.data = newValue;
            p.Next = head;
            head = p;
        }

        public void insert2End(object newValue)
        {
            Node p = new Node();
            p.data = newValue;
            if(head == null)
            {
                head = p;
            }
            else
            {
                Node temp = head;
                while(temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = p;
            }
        }

        public bool removeNode(object toBeDeleted)
        {
            Node p = head;
            Node e = null;
            while(p != null && !p.data.Equals(toBeDeleted))
            {
                e = p;
                p = p.Next;
            }
            if(p != null)
            {
                if(e == null)
                {
                    head = p.Next;
                }
                else
                {
                    e.Next = p.Next;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
