using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ArrayList
{
    class Array
    {
        static void Main(string[] args)
        {
            UArrayList team1 = new UArrayList();
            UArrayList team2 = new UArrayList();
            ArrayListIterator iterator;
            //Help
            team1.addAtTail("Jesús");
            team1.addAtTail("Salomón");
            team1.addAtTail("Yael");
            team1.addAtTail("Hugo");
            team1.addAtTail("Paco");
            team1.addAtTail("Luis");
            team1.addAtTail("Annie");
            //team1.PrintArray(); //Debe de imprimir Luis, Salomón, Yael, Hugo, Paco y Luis
            iterator = team1.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);    //Debe de imprimir Luis, Salomón, Yael, Hugo, Paco y Luis
            }
            Console.WriteLine("El team 1 tiene: " + team1.getSize() + " integrantes"); //Debe de tener 7 integrantes
            Console.WriteLine();
            team1.remove(0);
            team1.remove(2);
            team1.remove(4);
            if (team1.getAt(0).Equals("Salomón"))
            {
                team1.setAt(0, "Pachito"); //Sustituye a Salomón por Pachito
            }
            team1.PrintArray(); //Debe de imprimir Pachito, Yael, Paco y Luis
            Console.WriteLine("El team 1 tiene: " + team1.getSize() + " integrantes"); //Debe de tener 4 integrantes
            //Console.WriteLine();
            team2.addAtFront("Cristian");
            team2.addAtFront("Daniel");
            team2.addAtFront("Diego");
            team2.addAtFront("Francisco");
            team2.addAtFront("Eduardo");
            team2.addAtFront("Quenira");
            Console.WriteLine();
            //team2.PrintArray(); //Debe de imprimir Cristian, Daniel, Diego, Francisco, Eduardo y Quenira
            iterator = team2.getIterator();

            while (iterator.hasNext())
            {
                String name = iterator.next();
                Console.WriteLine(name);    //Debe de imprimir Cristian, Daniel, Diego, Francisco, Eduardo y Quenira
            }
            Console.WriteLine("El team 2 tiene: " + team2.getSize() + " integrantes"); //Debe de tener 6 integrantes
            Console.WriteLine();
            team2.remove(0);
            team2.remove(2);
            team2.remove(3);
            if (team2.getAt(1).Equals("Francisco"))
            {
                team2.setAt(1, "Pedro"); //Sustituye a Francisco por Pedro
            }
            team2.PrintArray(); //Debe de imprimir Eduardo, Pedro y Daniel
            Console.WriteLine("El team 2 tiene: " + team2.getSize() + " integrantes"); //Debe de tener 3 integrantes

        }
    }
}