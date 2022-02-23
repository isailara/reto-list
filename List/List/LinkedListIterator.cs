using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List.DbLinkedList
{
    internal class LinkedListIterator
    {

        private LinkedListNode currentNode;

        public LinkedListIterator(LinkedListNode startNode)
        {
            currentNode = startNode;
        }

        public bool hasNext()
        {
            return currentNode != null;
        }

        public string next()
        {
            string data = currentNode.data;

            currentNode = currentNode.next;

            return data;
            //return currentNode.data;
        }
    }
}
