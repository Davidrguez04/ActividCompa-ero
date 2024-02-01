using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadCompañero.Servicios
{
    /// <summary>
    /// Interfaz que recibe los metodos
    /// David R- 01/02/24
    /// </summary>
    /// <returns></returns>
    internal interface InterfazMetodo
    {
        public List<int> pedirNumeros();
        public void mostrarLista(List<int> listaNumeros);

        public int[] crearArray();

        public void mayores40(int[] listaArray);

        public  void ordenarArrayDescendente(int[] listaArray);

        public  void agregarEnAntepenultimaPosicion(int[] listaArray, int numero);

    }
}
