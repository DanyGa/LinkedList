﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Menu
    {        
        public void Inicio()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" ");
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("");
            Console.WriteLine("                                        Lista Doblemente Enlazada ");
            Console.WriteLine("");
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine(" Elige una de las opciones ");
            Console.WriteLine("");
            Console.WriteLine(" 1.- Agregar ");
            Console.WriteLine(" 2.- Eliminar ");
            Console.WriteLine(" 3.- Eliminar Lista ");
            Console.WriteLine(" 4.- Mostrar Lista ");
            Console.WriteLine(" 5.- Buscar ");
            Console.WriteLine(" 6.- Contar ");
            Console.WriteLine(" 7.- Guardar ");
            Console.WriteLine(" 8.- Cargar ");
            Console.WriteLine(" 9.- Salir ");
            Console.WriteLine("");
            Console.Write(" Opcion: ");
            Console.ReadKey();

            int Opcion;
            do
            {
                
                Opcion = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
                Lista seleccion = new Lista();

                switch (Opcion)
                {
                    case 1:
                        seleccion.Agregar();
                        break;
                    case 2:
                        seleccion.Eliminar();
                        break;
                    case 3:
                        seleccion.EliminarL();
                        break;
                    case 4:
                        seleccion.Mostrar();
                        break;
                    case 5:
                        seleccion.Buscar();
                        break;
                    case 6:
                        seleccion.Contar();
                        break;
                    case 7:
                        seleccion.Guardar();
                        break;
                    case 8:
                        seleccion.Cargar();
                        break;
                    case 9:
                        Environment.Exit(-1);
                        break;
                }

            } while (Opcion != 10);
            
        }
    }
}
