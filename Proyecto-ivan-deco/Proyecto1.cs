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
    public partial class Proyecto1 : Form
    {
        public Proyecto1()
        {
            InitializeComponent();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            string text = textBox2.Text;
            if (text != "")    
            {
                if (e.KeyValue == (char)Keys.Enter)
                {
                   var cadena =  Invertir(text);
                    textBox1.Text = cadena;
                }
                
            }
        }
        public static string Invertir(string cadena)
        {
            // Convertir a arreglo
            char[] cadenaComoCaracteres = cadena.ToCharArray();
            // Invertir el arreglo usando métodos incorporados
            Array.Reverse(cadenaComoCaracteres);
            // Convertir de nuevo el arreglo a cadena
            return new string(cadenaComoCaracteres);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
