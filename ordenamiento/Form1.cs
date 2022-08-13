using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ordenamiento
{
    public partial class Form1 : Form
    {
        Entero listInt;
        String listStr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listInfo.Items.Clear();
            if (inputInt.Text != "")
            {
                string tipo = checkTipe();
                listInfo.Items.Add(tipo);
                switch (tipo)
                {
                    case "STRING 8":
                        generarString(8);
                        break;
                    case "STRING 32":
                        generarString(32);
                        break;
                    default:
                        break;
                }
            }
        }

        private void generarString(int caracter=32)
        {
            var timer = new Stopwatch();
            timer.Start();
            listBox1.Items.Clear();
            int count = int.Parse(inputInt.Text);
            listStr = new String(count, caracter);
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;
            string foo = "Vector generado: " + timeTaken.ToString(@"m\:ss\.fff");
            listInfo.Items.Add(foo);
            listBox1.Items.AddRange(listStr.Lista);
        }

        private void generarInt64()
        {
            listInt = new Entero(Convert.ToInt32(inputInt.Text), 32);
            for (int i = 0; i < listInt.Cant; i++)
            {
                listBox1.Items.Add(listInt.obtenerValor(i, 64).ToString());
            }
        }

        private void generarInt()
        {
            listInt = new Entero(Convert.ToInt32(inputInt.Text), 16);
            for (int i = 0; i < listInt.Cant; i++)
            {
                listBox1.Items.Add(listInt.obtenerValor(i, 16).ToString());
            }
        }


        private void ordenarInt64()
        {
            if (radioSeleccion.Checked)
            {
                listInt.ordenarShell(64);
            }else if (radioQuick.Checked)
            {
                listInt.ordenarQuick(64);
            }
            else if (radioBurbuja.Checked)
            {
                listInt.ordenarBurbuja(64);
            }
            listBox1.Items.Clear();
            for (int i = 0; i < listInt.Cant; i++)
            {
                listBox1.Items.Add(listInt.obtenerValor(i, 64).ToString());
            }
        }

        private void ordenarInt()
        {
            if (radioSeleccion.Checked)
            {
                listInt.ordenarShell(16);
            }
            else if (radioQuick.Checked)
            {
                listInt.ordenarQuick(16);
            }else if (radioBurbuja.Checked)
            {
                listInt.ordenarBurbuja(16);
            }
            listBox1.Items.Clear();
            for (int i = 0; i < listInt.Cant; i++)
            {
                listBox1.Items.Add(listInt.obtenerValor(i, 16).ToString());
            }
        }


        private void ordenarString()
        {
            string[] list = listStr.Lista;
            string metod = checkMetod();
            switch (metod)
            {
                case "Burbuja":
                    listInfo.Items.Add("ORDENAMIENTO BURBUJA");
                    listStr.OrdenarBurbuja(list);
                    break;
                case "Seleccion":
                    listInfo.Items.Add("ORDENAMIENTO SELECCION");
                    listStr.Seleccion(list);
                    break;
                case "Merge":
                    listInfo.Items.Add("ORDENAMIENTO MERGE");
                    listStr.MergeSort(list);
                    break;
                case "Quick":
                    listInfo.Items.Add("ORDENAMIENTO Quick");
                    listStr.QuickSort(list);
                    break;
                case "Quick iterativo":
                    listInfo.Items.Add("ORDENAMIENTO Quick iterativo");
                    listStr.quickiterativo(list);
                    break;
                default:
                    break;
            }
            listInfo.Items.Add("=====================");
            listBox3.Items.Clear();
            for (int i = 0; i < list.Length; i++)
            {
                listBox3.Items.Add(list[i].ToString());
            }
            string foo = "intercambios: " + listStr.Intercambios.ToString();
            listInfo.Items.Add(foo);
            foo = "Comparaciones: " + listStr.Comparaciones.ToString();
            listInfo.Items.Add(foo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tipo = checkTipe();
            switch (tipo)
            {
                case "STRING 8":
                case "STRING 32":
                    ordenarString();
                    break;
                default:
                    break;
            }
        }

        private string checkTipe()
        {
            string result = "";
            foreach (Control ctrl in groupBox2.Controls)
            {
                if (ctrl is RadioButton)
                    if (((RadioButton)ctrl).Checked) result = ((RadioButton)ctrl).Text;
            }
            return result;
        }

        private string checkMetod()
        {
            string result = "";
            foreach (Control ctrl in groupBox3.Controls)
            {
                if (ctrl is RadioButton)
                    if (((RadioButton)ctrl).Checked) result = ((RadioButton)ctrl).Text;
            }
            return result;
        }
    }
}
