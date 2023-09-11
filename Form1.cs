using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_U1_3_Arbol
{
    public partial class Form1 : Form
    {
        //Variables para leer el archivo y organizar el arbol
        string[] txt; //Para guardar el archivo
        int i, j, k, lin; //Como indices
        public Form1()
        {
            InitializeComponent();
        }

        private void botonAbrir_Click(object sender, EventArgs e)
        {
            //Limpieza de arbol
            i = j = k = lin = 0;
            arbolDatos.Nodes.Clear();

            //Usuario da un archivo
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo de texto|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK) //Si lee algo
            {
                txt = File.ReadAllLines(openFileDialog.FileName); //Guarda el archivo por lineas
                
                while (lin < txt.Length) //Empieza a acomodar el arbol
                {
                    MessageBox.Show(txt[lin]);
                    if (txt[lin][0] == '.' && txt[lin][1] == '.') //Si es nieto
                    {
                        arbolDatos.Nodes[i - 1].Nodes[j - 1].Nodes.Add(txt[lin].Substring(2));
                        k++;
                    }
                    else if (txt[lin][0] == '.') //Si es hijo
                    {
                        arbolDatos.Nodes[i - 1].Nodes.Add(txt[lin].Substring(1));
                        j++;
                        k = 0;
                    }
                    else //Si es padre
                    {
                        arbolDatos.Nodes.Add(txt[lin]);
                        i++;
                        j = k = 0;
                    }
                    lin++;
                }
            }

        }
    }
}
