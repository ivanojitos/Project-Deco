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
    public partial class Proyecto4 : Form
    {
        public Proyecto4()
        {
            InitializeComponent();
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (e.KeyValue == (char)Keys.Enter)
                {
                    int numero;
                    int resultado;
                    string valor = textBox1.Text;
                    switch (valor)
                    {
                        case "Amarillo":
                            listBox1.Items.Clear();
                            label2.Text = "La tabla del 2";
                            numero = 2;
                            for (int i = 1; i <= 10; i++)
                            {
                                resultado = numero * i;
                                listBox1.Items.Add(numero + " x " + i + " = " + resultado);

                            }
                            break;
                        case "Morado":
                            listBox1.Items.Clear();
                            label2.Text = "La tabla del 7";
                            numero = 7;
                            for (int i = 1; i <= 10; i++)
                            {
                                resultado = numero * i;
                                listBox1.Items.Add(numero + " x " + i + " = " + resultado);

                            }
                            break;
                        case "Rosa":
                            listBox1.Items.Clear();
                            label2.Text = "La tabla del 9";
                            numero = 2;
                            for (int i = 1; i <= 10; i++)
                            {
                                resultado = numero * i;
                                listBox1.Items.Add(numero + " x " + i + " = " + resultado);

                            }
                            break;
                        case "Azul":
                            listBox1.Items.Clear();
                            label2.Text = "La tabla del 6";
                            numero = 6;
                            for (int i = 1; i <= 10; i++)
                            {
                                resultado = numero * i;
                                listBox1.Items.Add(numero + " x " + i + " = " + resultado);

                            }
                            break;
                        case "Blanco":
                            listBox1.Items.Clear();
                            label2.Text = "La tabla del 12";
                            numero = 12;
                            for (int i = 1; i <= 10; i++)
                            {
                                resultado = numero * i;
                                listBox1.Items.Add(numero + " x " + i + " = " + resultado);

                            }
                            break;
                        
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
