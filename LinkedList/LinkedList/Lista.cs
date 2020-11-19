using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Lista
    {
        LinkedList<int> List = new LinkedList<int>();
        LinkedListNode<int> num;

        int op;
        //poner constructor como lista

        public void Agregar()
        {
            Console.WriteLine(" 1.- Agregar al inicio ");
            Console.WriteLine(" 2.- Agregar al final ");
            Console.WriteLine("");
            Console.Write(" Opcion: ");
            Console.ReadKey();

            do
            {

                op = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                Lista seleccion = new Lista();
                Console.WriteLine("Inserte un numero");
                num = new LinkedListNode<int>(int.Parse(Console.ReadLine()));

                switch (op)
                {
                    case 1:                        
                        List.AddFirst(num);
                        break;
                    case 2:
                        List.AddLast(num);
                        break;

                }
            } while (op != 3);
        }

        public void Eliminar()
        {
            Console.WriteLine(" 1.- Elimminar al inicio ");
            Console.WriteLine(" 2.- Eliminar al final ");
            Console.WriteLine("");
            Console.Write(" Opcion: ");
            Console.ReadKey();

            do
            {

                op = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                Lista seleccion = new Lista();

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Se borro el primer nodo");
                        List.RemoveFirst();
                        break;
                    case 2:
                        Console.WriteLine("Se borro el ultimo nodo");
                        List.RemoveLast();
                        break;

                }
            } while (op != 3);

        }

        public void EliminarL()
        {
            Console.WriteLine("Se borraron todos lo elementos de la lista");
            List.Clear();
        }

        public void Mostrar()
        {
            //foreach(Nodo a in List)
            //{
            //    Console.WriteLine("" + a.Dato);
            //}
        }

        public void Buscar()
        {
            LinkedListNode<int> dato;
            int result = List.Find(delegate (int dato));
            //foreach (Nodo b in List)
            //{
            //    if (n.Dato == b)
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }

        public void Contar()
        {
            Console.WriteLine("La lista tiene: " + List.Count() + " nodos");
            Console.ReadKey();
        }

        public void Guardar()
        {
            string ruta = @"C:\Users\DanyG\source\repos\LinkedList\LinkedList\Lista.txt";
            using (StreamWriter save = new StreamWriter(ruta))
            {
                foreach (int item in List)
                {
                    save.WriteLine(item + ""); //Corregir el orden
                }
            }
        }

        public void Cargar()
        {

        }
    }
}
