using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontFamily[] lista = FontFamily.Families;
            for(int i=0;i<lista.Length;i++) //abre uma lista de fontfamily
            {
                comboBox1.Items.Add(lista[i].Name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FontFamily[] lista = FontFamily.Families;
            progressBar1.Maximum = lista.Length;
            for(int i=0;i<lista.Length;i++)
            {
                comboBox1.Items.Add(lista[i].Name);
                progressBar1.Value = i + 1; //Progress bar começa na posição 1
            }
        }
    }
}
