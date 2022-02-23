using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LinkedList
{
    class List
    {
        static void Main(string[] args)
        {
            DbLinkedList linkedList = new DbLinkedList();
            DbLinkedList linkedList1 = new DbLinkedList();

            linkedList.addAtFront("Isai");
            linkedList.addAtFront("Deni");
            linkedList.addAtFront("Romina");
            linkedList.addAtFront("Angel");
            linkedList.addAtFront("Salvador");
            linkedList.PrintList(); //Debe imprimir Isai, Deni, Romina, Angel, Salvador
            Console.WriteLine("El team 1 tiene: " + linkedList.getSize() + " integrantes"); //Debe tener 5 integrantes
            Console.WriteLine();
            linkedList.remove(0);
            linkedList.remove(3);

            if (linkedList.getAt(0).Equals("Angel"))
            {
                linkedList.setAt(0,"Luis"); //Cambia Angel por Luis
            }

            linkedList.PrintList(); //Debe imprimir Deni, Romina, Luis
            Console.WriteLine("El team 1 tiene: " + linkedList.getSize() + " integrantes"); //Debe tener 3 integrantes
            linkedList.removeAll(); //Elimina todos los integrantes del Team 1
            linkedList.PrintList(); //No imprime nada porque ya no hay integrantes en el Team 1
            Console.WriteLine("El team 1 tiene: " + linkedList.getSize() + " integrantes"); //Debe tener 0 integrantes
            Console.WriteLine();
            linkedList1.addAtTail("Sofia");
            linkedList1.addAtTail("Rita");
            linkedList1.addAtTail("Andrea");
            linkedList1.addAtTail("Neftali");
            linkedList1.addAtTail("Paulina");
            linkedList1.addAtTail("Erik");
            linkedList1.addAtTail("Miguel");
            linkedList1.PrintList(); //Debe imprimir Sofia, Rita, Andrea, Neftali, Paulina
            Console.WriteLine("El team 2 tiene: " + linkedList1.getSize() + " integrantes"); //Debe tener 7 integrantes
            Console.WriteLine();
            linkedList1.remove(2);
            linkedList1.remove(4);
            linkedList1.PrintList(); //Debe Sofia, Rita, Neftali, Paulina, Miguel
            Console.WriteLine("El team 2 tiene: " + linkedList1.getSize() + " integrantes"); //Debe tener 5 integrantes
        }
    }
}