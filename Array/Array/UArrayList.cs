using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UArrayList
{
    private static int tam = 10;
    private string[] array;
    private int size;

    public UArrayList(int size)
    {
        array = new string[size];
    }

    public UArrayList()
    {
        array = new string[tam];
    }

    public void addAtTail(string data)
    {
        if (size == array.Length)
        {
            increaseArrayList();
        }

        array[size] = data;
        size++;
    }

    private void increaseArrayList()
    {
        string[] newArray = new string[array.Length * 2];

        for (int i = 0; i < size; i++)
        {
            newArray[i] = array[i];
        }

        array = newArray;
    }

    public void addAtFront(string data)
    {
        if (size == array.Length)
        {
            increaseArrayList();
        }

        if (size >= 0) Array.Copy(array, 0, array, 1, size);
        array[0] = data;
        size++;
    }

    public void remove(int index)
    {
        if (index < 0 || index >= size)
        {
            return;
        }

        if (size - 1 - index >= 0) Array.Copy(array, index + 1, array, index, size - 1 - index);
        array[size - 1] = null;
        size--;
    }

    public void removeAll()
    {
        for (int i = 0; i < size; i++)
        {
            array[i] = null;
        }
        size = 0;
    }

    public String getAt(int index)
    {
        if (index >= 0 && index < size)
        {
            return array[index];
        }
        else
        {
            return null;
        }
    }

    public void setAt(int index, String data)
    {
        if (index >= 0 && index < size)
        {
            array[index] = data;
        }
    }

    public int getSize()
    {
        return size;
    }

    public void PrintArray()
    {
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

}