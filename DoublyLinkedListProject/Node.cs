using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedListProject
{
    class Node
    {
        public Node prev;
        public int info;
        public Node next;

        public Node(int i)
        {
            info = i;
            prev = null;
            next = null;
        }
    }
}
