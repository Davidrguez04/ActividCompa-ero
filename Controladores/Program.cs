/*Enunciado
LISTAS Y ARRAY
Listas:
Crea un programa que pida tantos números como quiera el usuario
Muestre por pantalla la lista 
Ordena la lista de forma ascendente y descendente

Array:
Luego crea una lista de tipo Array (de enteros) de 7 posiciones, con números aleatorios del 1 hasta 100 y muestralo
Ordene la lista de forma descendente (con burbuja), muestra por pantalla
Muestra la primera, cuarta y última posición del array
Luego debes mostrar todo aquellos números que sean mayores de “ 40“ (pista: Where)
Añade en la antepenúltima posición el número “ 23 ” 
Muestra por pantalla el array entero

Requisitos mínimos:
Clases, métodos e interfaces, debe estar comentando, incluyendo autor
Debe contener la aplicación como mínimo un servicio
*/

using ActividadCompañero.Servicios;

namespace ActividadCompañero.Controladores
{
    /// <summary>
    /// Clase que controla el flujo de la app
    /// David Rodriguez-- 01/02/2024
    /// </summary>
    class Program
    {
        /// <summary>
        /// Método Main que controla la ejecucion del programa
        /// David R- 01/02/24
        /// </summary>
        /// <returns></returns>
        static void Main(string[] args)
        {
            InterfazMetodo metodo = new ImplMetodo();
            //Lista de enteros
            List<int>listaNumeros= new List<int>();
            //Array de 7 posiciones
            int[] listaArray = new int[7];

            //Métodos
            listaNumeros=metodo.pedirNumeros();

            Console.Write("\n\tLista ordenada de forma ascendente:  ");
            //Método Sort para ordenar la lista de forma ascendente
            listaNumeros.Sort();
            metodo.mostrarLista(listaNumeros);

            Console.Write("\n\tLista ordenada de forma descendente:  ");
            listaNumeros.Sort((a, b) => b.CompareTo(a));
            metodo.mostrarLista(listaNumeros);

            Console.Write("\n\tLista de Array con numeros aleatorios: ");
            listaArray=metodo.crearArray();

            metodo.ordenarArrayDescendente(listaArray);
           
            metodo.mayores40(listaArray);

            metodo.agregarEnAntepenultimaPosicion(listaArray, 23);

            Console.WriteLine();

        }
    }
}
