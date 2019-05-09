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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); //abre o formulario 2 quando clicar no botao


            colorDialog1.ShowDialog(); //Abre uma palheta de cor para 
            BackColor = colorDialog1.Color; // escolher o background do formulario
       
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.BackColor = Color.Yellow;
            form2.Show(); //abre o formulario 2 na cor amarela

        }
    }
}
