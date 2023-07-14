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
    public partial class Proyecto2 : Form
    {
        public Proyecto2()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(textBox1.Text != "")
            {
                if (e.KeyValue == (char)Keys.Enter)
                {
                    int numero = Convert.ToInt16(textBox1.Text);
                    string valor = "El numero (Valor del número) es impar";
                    if (numero % 2 == 0)
                    {
                        valor = "El numero (Valor del número) es par";
                    }
                    textBox2.Text = valor;
                    
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
