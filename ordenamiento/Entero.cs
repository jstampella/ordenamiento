using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenamiento
{
    internal class Entero
    {
        private long[] vector;
        private int[] vector16;
        private int cant;
        static Random rnd = new Random();

        public int Cant { get => cant; }

        public Entero(int cant, int tipo = 16)
        {
            this.cant = cant;
            Cargar(cant,tipo);
        }

        public long obtenerValor(int pos,int tipo)
        {
            long valor;
            if (tipo == 16)
                valor  = vector16[pos];
            else 
                valor = vector[pos];
            return valor;
        }
        public void Cargar(int cant,int tipo)
        {
            if(tipo == 16)
            {
                vector16 = new int[cant];
                for (int f = 0; f < vector16.Length; f++)
                {
                    vector16[f] = rnd.Next(-32768, 32767);
                }
            }
            else
            {
                vector = new long[cant];
                for (int f = 0; f < vector.Length; f++)
                {
                    vector[f] = randomLong();
                }
            }
            
        }

        public void ordenarShell(int tipo)
        {
            if (tipo == 16) Shell();
            else Shell32();
        }

        public void ordenarQuick(int tipo)
        {
            if (tipo == 16)
                quicksort(vector16,0, vector16.Length-1);
            else
                quicksort64(vector, 0, vector.Length-1);
        }

        public void ordenarBurbuja(int tipo)
        {
            if (tipo == 16)
                metodoBurbuja();
            else
                metodoBurbuja64();
        }


        private long randomLong()
        {
            byte[] bytes = new byte[8];
            rnd.NextBytes(bytes);
            return BitConverter.ToInt64(bytes, 0);
        }

        private void Shell()
        {
            int salto;
            int sw;
            int auxi;
            int e;
            salto = vector16.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (vector16.Length - salto))
                    {
                        if (vector16[e - 1] > vector16[(e - 1) + salto])
                        {
                            auxi = vector16[(e - 1) + salto];
                            vector16[(e - 1) + salto] = vector16[e - 1];
                            vector16[(e - 1)] = auxi;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }
        }

        private void quicksort(int[] vector, int primero, int ultimo)
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

        private void quicksort64(long[] vector, int primero, int ultimo)
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
                    long temp;
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                quicksort64(vector, primero, j);
            }
            if (i < ultimo)
            {
                quicksort64(vector, i, ultimo);
            }
        }

        private void Shell32()
        {
            int salto;
            int sw;
            long auxi;
            int e;
            salto = vector.Length / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (vector.Length - salto))
                    {
                        if (vector[e - 1] > vector[(e - 1) + salto])
                        {
                            auxi = vector[(e - 1) + salto];
                            vector[(e - 1) + salto] = vector[e - 1];
                            vector[(e - 1)] = auxi;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }
        }

        private void metodoBurbuja()
        {
            int t;
            for (int a = 1; a < vector16.Length; a++)
                for (int b = vector16.Length - 1; b >= a; b--)
                {
                    if (vector16[b - 1] > vector16[b])
                    {
                        t = vector16[b - 1];
                        vector16[b - 1] = vector16[b];
                        vector16[b] = t;
                    }
                }
        }

        private void metodoBurbuja64()
        {
            long t;
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
    }
}
