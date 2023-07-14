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
    public partial class Proyecto3 : Form
    {
        public Proyecto3()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(textBox1.Text != "")
            {
                int numero;
                int resultado;
                if (e.KeyValue == (char)Keys.Enter)
                {
                    listBox1.Items.Clear();
                    if (textBox1.Text == "Amarillo")
                    {
                        label2.Text = "La tabla del 2";
                        numero = 2;
                        for (int i = 1; i <= 10; i++)
                        {
                            resultado = numero * i;
                            listBox1.Items.Add(numero + " x " + i + " = " + resultado);

                        }
                        
                    }
                    else if(textBox1.Text == "Morado")
                    {
                        label2.Text = "La tabla del 7";
                        numero = 7;
                        for (int i = 1; i <= 10; i++)
                        {
                            resultado = numero * i;
                            listBox1.Items.Add(numero + " x " + i + " = " + resultado);

                        }
                    }
                    else if(textBox1.Text == "Rosa")
                    {
                        label2.Text = "La tabla del 9";
                        numero = 9;
                        for (int i = 1; i <= 10; i++)
                        {
                            resultado = numero * i;
                            listBox1.Items.Add(numero + " x " + i + " = " + resultado);

                        }
                    }
                    else if(textBox1.Text == "Azul")
                    {
                        label2.Text = "La tabla del 6";
                        numero = 6;
                        for (int i = 1; i <= 10; i++)
                        {
                            resultado = numero * i;
                            listBox1.Items.Add(numero + " x " + i + " = " + resultado);

                        }

                    }
                    else if(textBox1.Text == "Blanco")
                    {
                        label2.Text = "La tabla del 12";
                        numero = 12;
                        for (int i = 1; i <= 10; i++)
                        {
                            resultado = numero * i;
                            listBox1.Items.Add(numero + " x " + i + " = " + resultado);

                        }

                    }

                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
