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
        string[] txt;
        public Form1()
        {
            InitializeComponent();
        }

        private void botonAbrir_Click(object sender, EventArgs e)
        {
            arbolDatos.Nodes.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Archivo de texto|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txt = File.ReadAllLines(openFileDialog.FileName);

                for(int i = 0; i < txt.Length; i++)
                {
                    if (txt[i][0] == '.')
                    {
                        arbolDatos.Nodes[i - 1].Nodes.Add(txt[i].Substring(1));
                    }
                    else if (txt[i][0] == '.' && txt[i][1] == '.')
                    {
                        arbolDatos.Nodes[i - 1].Nodes[i - 1].Nodes.Add(txt[i].Substring(2));
                    }
                    else
                    {
                        arbolDatos.Nodes.Add(txt[i]);
                    }
                }
            }

        }
    }
}
