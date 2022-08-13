using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenamiento
{
    internal class Ordenamiento
    {
        private int intercambios;
        private int comparaciones;
        // metodo burbuja
        public void MetodoBurbuja(int[] vector)
        {
            int t;
            for (int a = 1; a < vector.Length; a++)
                for (int b = vector.Length - 1; b >= a; b--)
                {
                    if (vector[b - 1] > vector[b])
                    {
                        t = vector[b - 1];
                        vector[b - 1] = vector[b];
                        vector[b] = t;
                    }
                }
        }

        public static void ordenarBurbujaCadenas(string[] arreglo)
        {
            for (int x = 0; x < arreglo.Length; x++)
            {
                // Recuerda que el -1 es porque no queremos llegar al final ya que hacemos
                // un indiceActual + 1 y si fuéramos hasta el final, intentaríamos acceder a un valor fuera de los límites
                // del arreglo
                for (int indiceActual = 0; indiceActual < arreglo.Length - 1;
                     indiceActual++)
                {
                    int indiceSiguienteElemento = indiceActual + 1;
                    // Si el actual es mayor que el que le sigue a la derecha...
                    if (arreglo[indiceActual].CompareTo(arreglo[indiceSiguienteElemento]) > 0)
                    {
                        string temporal = arreglo[indiceActual];
                        arreglo[indiceActual] = arreglo[indiceSiguienteElemento];
                        arreglo[indiceSiguienteElemento] = temporal;
                    }
                }
            }
        }

        public void Seleccion(int[] vector)
        {
            intercambios = 0;
            comparaciones = 0;
            int minimo = 0;
            int temp;
            for (int i = 0; i < vector.Length - 1; i++)
            {
                minimo = i;
                for (int j = i + 1; j < vector.Length; j++)
                {
                    comparaciones++;
                    if (vector[minimo] > vector[j])
                    {
                        minimo = j;
                    }
                }
                intercambios++;
                temp = vector[minimo];
                vector[minimo] = vector[i];
                vector[i] = temp;
            }
        }

        public void quicksort(int[] vector, int primero, int ultimo)
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    int temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksort(vector, primero, j);
            }
            if (i < ultimo)
            {
                quicksort(vector, i, ultimo);
            }
        }

        //ordenamiento por seleccion
        public static void SeleccionSort(int[] lista)
        {
            int menor;
            int pos;
            int tem;
            for (int i = 0; i < lista.Length - 1; i++)
            {
                menor = lista[i];
                pos = i;
                for (int j = i + 1; j < lista.Length; j++)
                {
                    if (lista[j] < menor)
                    {
                        menor = lista[j];
                        pos = j;
                    }
                }
                if (pos != i)
                {
                    tem = lista[i];
                    lista[i] = lista[pos];
                    lista[pos] = tem;
                }
            }
        }

        //  quicksort iterative
        public static void QuickSortIterative(ref int[] data)
        {
            int startIndex = 0;
            int endIndex = data.Length - 1;
            int top = -1;
            int[] stack = new int[data.Length];

            stack[++top] = startIndex;
            stack[++top] = endIndex;

            while (top >= 0)
            {
                endIndex = stack[top--];
                startIndex = stack[top--];

                int p = Partition(ref data, startIndex, endIndex);

                if (p - 1 > startIndex)
                {
                    stack[++top] = startIndex;
                    stack[++top] = p - 1;
                }

                if (p + 1 < endIndex)
                {
                    stack[++top] = p + 1;
                    stack[++top] = endIndex;
                }
            }
        }

        private static int Partition(ref int[] data, int left, int right)
        {
            int x = data[right];
            int i = (left - 1);

            for (int j = left; j <= right - 1; ++j)
            {
                if (data[j] <= x)
                {
                    ++i;
                    Swap(ref data[i], ref data[j]);
                }
            }

            Swap(ref data[i + 1], ref data[right]);

            return (i + 1);
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }




        //Método portal que llama al método recursivo inicial
        public static void MergeSort(int[] x)
        {
            MergeSort(x, 0, x.Length - 1);
        }

        static private void MergeSort(int[] x, int desde, int hasta)
        {
            //Condicion de parada
            if (desde == hasta)
                return;

            //Calculo la mitad del array
            int mitad = (desde + hasta) / 2;

            //Voy a ordenar recursivamente la primera mitad
            //y luego la segunda
            MergeSort(x, desde, mitad);
            MergeSort(x, mitad + 1, hasta);

            //Mezclo las dos mitades ordenadas
            int[] aux = Merge(x, desde, mitad, mitad + 1, hasta);
            Array.Copy(aux, 0, x, desde, aux.Length);
        }

        //Método que mezcla las dos mitades ordenadas
        static private int[] Merge(int[] x, int desde1, int hasta1, int desde2, int hasta2)
        {
            int a = desde1;
            int b = desde2;
            int[] result = new int[hasta1 - desde1 + hasta2 - desde2 + 2];

            for (int i = 0; i < result.Length; i++)
            {
                if (b != x.Length)
                {
                    if (a > hasta1 && b <= hasta2)
                    {
                        result[i] = x[b];
                        b++;
                    }
                    if (b > hasta2 && a <= hasta1)
                    {
                        result[i] = x[a];
                        a++;
                    }
                    if (a <= hasta1 && b <= hasta2)
                    {
                        if (x[b] <= x[a])
                        {
                            result[i] = x[b];
                            b++;
                        }
                        else
                        {
                            result[i] = x[a];
                            a++;
                        }
                    }
                }
                else
                {
                    if (a <= hasta1)
                    {
                        result[i] = x[a];
                        a++;
                    }
                }
            }
            return result;
        }
    }
}
