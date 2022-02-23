using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DbLinkedList
{
    private LinkedListNode head;
    private LinkedListNode tail;
    private int size;

    public void addAtFront(String data)
    {
        LinkedListNode node = new LinkedListNode(data);

        if (size == 0)
        {
            tail = node;
        }
        else
        {
            head.previous = node;
        }
        node.next = head;
        head = node;

        size++;
    }

    public void addAtTail(String data)
    {
        LinkedListNode node = new LinkedListNode(data);

        //node.data=data;

        if (size == 0)
        {
            head = node;
        }
        else
        {
            tail.next = node;
            node.previous = tail;
        }

        tail = node;
        size++;
    }

    public void remove(int index)
    {
        LinkedListNode node = findNode(index);

        if (node == null)
        {
            return;
        }

        if (size == 1)
        {
            head = null;
            tail = null;
        }
        else if (node == head)
        {
            head = node.next;
            if (head != null)
            {
                head.previous = null;
            }
        }
        else if (node == tail)
        {
            tail = node.previous;
            if (tail != null)
            {
                tail.next = null;
            }
        }
        else
        {
            node.previous.next = node.next;
            node.next.previous = node.previous;
        }
        size--;
    }

    private LinkedListNode findNode(int index)
    {
        if (index < 0 || index >= size)
        {
            return null;
        }

        LinkedListNode node = head;
        int currentIndex = 0;

        while (currentIndex != index)
        {
            currentIndex++;
            node = node.next;
        }

        return node;
    }

    public void removeAll()
    {
        head = null;
        tail = null;
        size = 0;
    }

    public void PrintList()
    {
        LinkedListNode runner = head;
        while (runner != null)
        {
            Console.WriteLine(runner.data);
            runner = runner.next;
        }
    }

    public int getSize()
    {
        return size;
    }

    public string getAt(int index)
    {
        LinkedListNode node = findNode(index);

        if (node == null)
        {
            return null;
        }
        else
        {
            return node.data;
        }

    }

    public void setAt(int index, String data)
    {
        LinkedListNode node = findNode(index);

        if (node != null)
        {
            node.data = data;
        }
    }
}
