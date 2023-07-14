using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_ivan_deco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Proyecto1 invertir = new Proyecto1();
            invertir.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Proyecto2 numero = new Proyecto2();
            numero.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Proyecto3 tabla = new Proyecto3();
            tabla.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Proyecto4 tablas = new Proyecto4();
            tablas.ShowDialog();
        }
    }
}
