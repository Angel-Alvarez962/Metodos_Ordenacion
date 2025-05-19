using System;
using System.Diagnostics;
using System.Linq;

namespace ProyectoOrdenacionConsola
{
    public static class OrdenamientoSacudida
    {
        public static void Ordenar(int[] arreglo)
        {
            int izquierda = 0, derecha = arreglo.Length - 1;
            while (izquierda < derecha)
            {
                for (int i = izquierda; i < derecha; i++)
                    if (arreglo[i] > arreglo[i + 1])
                        (arreglo[i], arreglo[i + 1]) = (arreglo[i + 1], arreglo[i]);

                derecha--;

                for (int i = derecha; i > izquierda; i--)
                    if (arreglo[i - 1] > arreglo[i])
                        (arreglo[i - 1], arreglo[i]) = (arreglo[i], arreglo[i - 1]);

                izquierda++;
            }
        }
    }
}
