using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Threading;

namespace DoublyLinkedListProject
{
    class DoublyLinkedList
    {
       private Node start;

        public DoublyLinkedList()
        {
            start = null;
        }

        public void DisplayList()
        {
            Node p=start;
            if (start == null)
                return;
            while(p!=null)
            {
                Console.Write(p.info + " ");
                p = p.next;
            }
            Console.WriteLine("");
        }

        public void InsertInBeginning(int data)
        {
            Node temp = new Node(data);
            temp.next = start;
            start.prev = temp;
            start = temp;
        }

        public void InsertInEmptyList(int data)
        {
            Node temp = new Node(data);
            start = temp;
        }

        public void InsertInEnd(int data)
        {
            Node temp = new Node(data);
            Node p = start;
            while(p.next!=null)
            {
               p = p.next;
            }
            p.next = temp;
            temp.prev = p;
        }

        public void CreateList()
        {
            int i, n, data;
            Console.Write("Enter the number of nodes:");
            n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
                return;

            Console.Write("Enter the first element to be inserted:");
            data = Convert.ToInt32(Console.ReadLine());
            InsertInBeginning(data);

            for (i =2;i<=n;i++)
            {
                Console.Write("Enter the next element to be inserted:");
                data = Convert.ToInt32(Console.ReadLine());
                InsertInEnd(data);
            }
        }

        public void InsertAfter(int data,int x)
        {
            Node temp = new Node(data);
            Node p = start;
            if (start == null)
                return;
            while(p!=null)
            {
                if (p.info == x)
                    break;
                p = p.next;
            }
            if (p == null)
                Console.WriteLine(x + " is not found");
            else
            {
                temp.prev = p;
                temp.next = p.next;
                if (p.next != null)
                    p.next.prev = temp; /*should not be done when p refers to last node*/
                p.next = temp;
            }
        }

        public void InsertBefore(int data,int x)
        {
            Node temp = new Node(data);
            Node p = start;
            if (start == null)
                Console.WriteLine("List is Empty");
            if(start.info==x)
            {
                temp.next = start;
                temp.prev = start.prev;
                start = temp;
                return;
            }
            while(p!=null)
            {
                if (p.info == x)
                    break;
                p = p.next;
            }
            if (p == null)
                Console.WriteLine(x + " is not found");
            else
            {
                temp.prev = p.prev;
                temp.next = p;
                p.prev.next = temp;
                p.prev = temp;
            }
        }

        public void DeleteFirstNode()
        {
            if (start == null)
                Console.WriteLine("EMPTY");

            /*DeleteOnlyNode()*/
            if (start.next==null)
            {
                start = null;
                return;
            }
            start = start.next;
            start.prev = null;
        }

        public void DeleteOnlyNode()
        {
            if (start.next == null)
            {
                start = null;
                return;
            }
        }

        public void ReverseList()
        {
            if (start == null)
                return;
            Node p1 = start;
            Node p2 = p1.next;
            p1.next = null;
            p1.prev = p2;
            while(p2!=null)
            {
                p2.prev = p2.next;
                p2.next = p1;
                p1 = p2;
                p2 = p2.prev;
            }
            start = p1;
        }
    }
}
