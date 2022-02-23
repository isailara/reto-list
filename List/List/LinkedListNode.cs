using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.DbLinkedList
{
    class LinkedListNode
    {
        public string data;
        public LinkedListNode next;
        public LinkedListNode previous;

        public LinkedListNode(string data)
        {
            this.data = data;
        }
    }
}