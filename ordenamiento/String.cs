using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenamiento
{
    internal class String
    {
        private string[] lista;
        private int cantidad;
        private int intercambios;
        private int comparaciones;

        public String(int cantidad, int caract)
        {
            this.cantidad = cantidad;
            this.lista = new string[cantidad];
            Generar(caract);
        }

        public int Intercambios
        {
            get { return intercambios; }    
        }

        public int Comparaciones
        {
            get { return comparaciones; }
        }


        public string[] Lista   // property
        {
            get
            {
                string[] copy = new string[lista.Length];
                lista.CopyTo(copy, 0);
                return copy;
            }   // get method
        }

        private void Generar(int caract)
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] Charsarr = new char[caract];
            var random = new Random();

            for (int j = 0; j < cantidad; j++)
            {
                for (int i = 0; i < Charsarr.Length; i++)
                {
                    Charsarr[i] = characters[random.Next(characters.Length)];
                }
                lista[j] = new string(Charsarr);
            }
        }

        public void OrdenarBurbuja(string[] arreglo)
        {
            intercambios = 0;
            comparaciones = 0;
            for (int x = 0; x < arreglo.Length; x++)
            {
                // Recuerda que el -1 es porque no queremos llegar al final ya que hacemos
                // un indiceActual + 1 y si fuéramos hasta el final, intentaríamos acceder a un valor fuera de los límites
                // del arreglo
                for (int indiceActual = 0; indiceActual < arreglo.Length - 1;
                     indiceActual++)
                {
                    int indiceSiguienteElemento = indiceActual + 1;
                    comparaciones++;
                    // Si el actual es mayor que el que le sigue a la derecha...
                    if (arreglo[indiceActual].CompareTo(arreglo[indiceSiguienteElemento]) > 0)
                    {
                        intercambios++;
                        string temporal = arreglo[indiceActual];
                        arreglo[indiceActual] = arreglo[indiceSiguienteElemento];
                        arreglo[indiceSiguienteElemento] = temporal;
                    }
                }
            }
        }

        public void Seleccion(string[] arreglo)
        {
            intercambios = 0;
            comparaciones = 0;
            int minimo = 0;
            string temp;
            for (int i = 0; i < arreglo.Length - 1; i++)
            {
                minimo = i;
                for (int j = i + 1; j < arreglo.Length; j++)
                {
                    comparaciones++;
                    if (arreglo[minimo].CompareTo(arreglo[j]) > 0)
                    {
                        minimo = j;
                    }
                }
                intercambios++;
                temp = arreglo[minimo];
                arreglo[minimo] = arreglo[i];
                arreglo[i] = temp;
            }
        }

        public void QuickSort(string[] arreglo)
        {
            intercambios = 0;
            comparaciones = 0;
            QuickSort(arreglo, 0, arreglo.Length-1);
        }

        private void QuickSort(string[] arreglo,int lowerIndex, int higherIndex)
        {
            int i = lowerIndex;
            int j = higherIndex;
            string pivot = arreglo[lowerIndex + (higherIndex - lowerIndex) / 2];

            while (i <= j)
            {
                while (arreglo[i].CompareTo(pivot) < 0)
                {
                    comparaciones++;
                    i++;
                }
                
                while (arreglo[j].CompareTo(pivot) > 0)
                {
                    comparaciones++;
                    j--;
                }

                if (i <= j)
                {
                    intercambios++;
                    string temp = arreglo[i];
                    arreglo[i] = arreglo[j];
                    arreglo[j] = temp;
                    i++;
                    j--;
                }
            }
            //call quickSort recursively
            if (lowerIndex < j)
            {
                QuickSort(arreglo,lowerIndex, j);
            }
            if (i < higherIndex)
            {
                QuickSort(arreglo,i, higherIndex);
            }
        }

        public void MergeSort(string[] arreglo)
        {
            intercambios = 0;
            comparaciones = 0;
            MergeSort(arreglo,0, arreglo.Length - 1);
        }
        private void MergeSort(string[] arreglo,int desde, int hasta)
        {
            //Condicion de parada
            if (desde == hasta)
                return;
            //Calculo la mitad del vector
            int mitad = (desde + hasta) / 2;
            //Voy a ordenar recursivamente la primera mitad
            //y luego la segunda
            MergeSort(arreglo,desde, mitad);
            MergeSort(arreglo, mitad + 1, hasta);
            //Mezclo las dos mitades ordenadas
            string[] aux = Merge(arreglo,desde, mitad, mitad + 1, hasta);
            Array.Copy(aux, 0, arreglo, desde, aux.Length);
        }

        //Método que mezcla las dos mitades ordenadas
        private string[] Merge(string[] arreglo,int desde1, int hasta1, int desde2, int hasta2)
        {
            int a = desde1;
            int b = desde2;
            string[] result = new string[hasta1 - desde1 + hasta2 - desde2 + 2];

            for (int i = 0; i < result.Length; i++)
            {

                if (b != arreglo.Length)
                {
                    if (a > hasta1 && b <= hasta2)
                    {
                        result[i] = arreglo[b];
                        b++;
                    }
                    if (b > hasta2 && a <= hasta1)
                    {
                        result[i] = arreglo[a];
                        a++;
                    }
                    if (a <= hasta1 && b <= hasta2)
                    {
                        comparaciones++;
                        if (arreglo[b].CompareTo(arreglo[a]) >0)
                        {
                            intercambios++;
                            result[i] = arreglo[b];
                            b++;
                        }
                        else
                        {
                            intercambios++;
                            result[i] = arreglo[a];
                            a++;
                        }
                    }
                }
                else
                {
                    comparaciones++;
                    if (a <= hasta1)
                    {
                        intercambios++;
                        result[i] = arreglo[a];
                        a++;
                    }
                }
            }
            return result;

        }

        public void quickiterativo(string[] arreglo)
        {
            intercambios = 0;
            comparaciones = 0;
            quickSortiterativo(arreglo);
        }

        private void quickSortiterativo(string[] a)
        {
            int[] stk = new int[a.Length];            // stack
            int sti = 0;                        // stack index
            stk[sti++] = a.Length - 1;
            stk[sti++] = 0;
            while (sti != 0)
            {
                int lo = stk[--sti];
                int hi = stk[--sti];
                while (lo < hi)
                {
                    comparaciones++;
                    // Hoare partition
                    int md = lo + (hi - lo) / 2;
                    int ll = lo - 1;
                    int hh = hi + 1;
                    string p = a[md];
                    string t;
                    while (true)
                    {
                        while (a[++ll].CompareTo(p) < 0) ;
                        while (a[--hh].CompareTo(p) > 0) ;

                        if (ll >= hh)
                        {
                            comparaciones++;
                            break;
                        }
                        intercambios++;
                        t = a[ll];
                        a[ll] = a[hh];
                        a[hh] = t;
                    }
                    ll = hh++;
                    // ll = last left index, hh = first right index
                    // push larger partition indexes onto stack
                    // loop back for smaller partition
                    if ((ll - lo) > (hi - hh))
                    {
                        stk[sti++] = ll;
                        stk[sti++] = lo;
                        lo = hh;
                    }
                    else
                    {
                        stk[sti++] = hi;
                        stk[sti++] = hh;
                        hi = ll;
                    }
                }
            }
        }
    }
}
