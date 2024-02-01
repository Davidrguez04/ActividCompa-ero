using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadCompañero.Servicios
{
    /// <summary>
    /// Clase que contiene los metodos del programa
    /// David R- 01/02/24
    /// </summary>
    /// <returns></returns>
    internal class ImplMetodo : InterfazMetodo
    {
        /// <summary>
        /// Método para pedir numeros y añadirlos a la lista
        /// David R- 01/02/24
        /// </summary>
        /// <returns></returns>
        public List<int> pedirNumeros()
        {
            List<int> listaNumeros = new List<int>();

            Console.WriteLine("Ingresa números (ingresa 'fin' para terminar):");

            while (true)
            {
                string input = Console.ReadLine();

                if (input.ToLower() == "fin")
                    break;

                if (int.TryParse(input, out int numero))
                {
                    listaNumeros.Add(numero);
                }
                else
                {
                    Console.WriteLine("Ingresa un número válido: ");
                }
            }

            return listaNumeros;

        }
        /// <summary>
        /// Método para mostrar la lista por consola
        /// David R- 01/02/24
        /// </summary>
        /// <returns></returns>
        public void mostrarLista(List<int> listaNumeros)
        {
            
            foreach (var numeros in listaNumeros)
            {
                Console.Write(numeros + " ");
            }
            Console.WriteLine();

        }
        /// <summary>
        /// Método para crear un array de 7 posiciones y llenarla con numeros enteros
        /// David R- 01/02/24
        /// </summary>
        /// <returns></returns>
        public int[] crearArray()
        {
            Random random = new Random();
            int[] listaArray = new int[7];

            for (int i = 0; i < listaArray.Length; i++)
            {
                listaArray[i] = random.Next(1, 101);
            }

            foreach (var numero in listaArray)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\n\tPrimera posicion array: " + listaArray[0]);
            Console.WriteLine("\n\tCuarta posicion array: " + listaArray[3]);
            Console.WriteLine("\n\tUltima posicion array: " + listaArray[6]);

            return listaArray;
        }
        /// <summary>
        /// Método que recibe un array y muestra los numeros mayores de 40
        /// David R- 01/02/24
        /// </summary>
        /// <returns></returns>
        public void mayores40(int[] listaArray)
        {
            var mayoresDe40 = listaArray.Where(num => num > 40);
            Console.Write("\n\tNúmeros mayores de 40:  ");
            mostrarLista(mayoresDe40.ToList());
        }
        /// <summary>
        /// Método para ordenar el array de forma descendente
        /// David R- 01/02/24
        /// </summary>
        /// <returns></returns>
        public void ordenarArrayDescendente(int[] listaArray)
        {
            for (int i = 0; i < listaArray.Length - 1; i++)
            {
                for (int j = 0; j < listaArray.Length - 1 - i; j++)
                {
                    if (listaArray[j] < listaArray[j + 1])
                    {
                        // Intercambia los elementos si están en el orden incorrecto
                        int aux = listaArray[j];
                        listaArray[j] = listaArray[j + 1];
                        listaArray[j + 1] = aux;
                    }
                }
            }
            Console.Write("\n\tArray descendente:  ");
            foreach (var numeros in listaArray)
            {
                Console.Write(numeros + " ");
            }
            Console.WriteLine();

        }
        /// <summary>
        /// Método para agregar en la antepenultima posicion del array el número 23
        /// y muestra el array de nuevo finalmente en el programa
        /// David R- 01/02/24
        /// </summary>
        /// <returns></returns>
        public void agregarEnAntepenultimaPosicion(int[] listaArray, int numero)
        {
            if (listaArray.Length >= 3)
            {
                listaArray[listaArray.Length - 3] = numero;
            }

            Console.Write("\n\tArray con 23:  ");
            foreach (var numeros in listaArray)
            {
                Console.Write(numeros + " ");
            }
            Console.WriteLine();
        }
    }
}
