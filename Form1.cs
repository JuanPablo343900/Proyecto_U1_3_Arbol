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
        int i, j, k, l, lin; //Como indices
        public Form1()
        {
            InitializeComponent();
            arbolDatos.ImageList = new ImageList();
            arbolDatos.ImageList.Images.Add(Image.FromFile("C:/Users/JPRZ1/source/repos/Cid-Lufaine/Proyecto_U1_3_Arbol/circle-icon.png"));
            arbolDatos.ImageList.Images.Add(Image.FromFile("C:/Users/JPRZ1/source/repos/Cid-Lufaine/Proyecto_U1_3_Arbol/circle-line-icon.png"));
            arbolDatos.ImageList.Images.Add(Image.FromFile("C:/Users/JPRZ1/source/repos/Cid-Lufaine/Proyecto_U1_3_Arbol/circle-center-icon.png"));
            arbolDatos.ImageList.Images.Add(Image.FromFile("C:/Users/JPRZ1/source/repos/Cid-Lufaine/Proyecto_U1_3_Arbol/circle-center-line-icon.png"));
            arbolDatos.ImageList.Images.Add(Image.FromFile("C:/Users/JPRZ1/source/repos/Cid-Lufaine/Proyecto_U1_3_Arbol/color-adjust-icon.png"));
        }

        private void botonAbrir_Click(object sender, EventArgs e)
        {
            //Limpieza de arbol
            i = j = k = l = lin = 0;
            arbolDatos.Nodes.Clear();

            //Usuario da un archivo
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivo de texto|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK) //Si lee algo
            {
                txt = File.ReadAllLines(openFileDialog.FileName); //Guarda el archivo por lineas

                while (lin < txt.Length) //Empieza a acomodar el arbol
                {
                    if (txt[lin][0] == '.' && txt[lin][1] == '.' && txt[lin][2] == '.') //Si es bisnieto
                    {
                        arbolDatos.Nodes[i - 1].Nodes[j - 1].Nodes[k - 1].Nodes.Add(txt[lin].Substring(3));
                        arbolDatos.Nodes[i - 1].Nodes[j - 1].Nodes[k - 1].Nodes[l].ImageIndex = 4;
                        l++;
                    }
                    else if (txt[lin][0] == '.' && txt[lin][1] == '.') //Si es nieto
                    {
                        arbolDatos.Nodes[i - 1].Nodes[j - 1].Nodes.Add(txt[lin].Substring(2));
                        arbolDatos.Nodes[i - 1].Nodes[j - 1].Nodes[k].ImageIndex = 3;
                        k++;
                        l = 0;
                    }
                    else if (txt[lin][0] == '.') //Si es hijo
                    {
                        arbolDatos.Nodes[i - 1].Nodes.Add(txt[lin].Substring(1));
                        arbolDatos.Nodes[i - 1].Nodes[j].ImageIndex = 2;
                        j++;
                        k = l = 0;
                    }
                    else //Si es padre
                    {
                        arbolDatos.Nodes.Add(txt[lin]);
                        arbolDatos.Nodes[i].ImageIndex = 1;
                        i++;
                        j = k = l = 0;
                    }
                    lin++;
                }
            }

        }
    }
}
