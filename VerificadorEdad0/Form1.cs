using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificadorEdad0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Ingrese su edad en el siguiente recuadro:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad1;
            VerificadorEdad verificador = new VerificadorEdad();

            while (true)
            {
                if (int.TryParse(textBox1.Text, out edad1))
                {
                    label2.Text = verificador.Verificar(edad1);
                    break;
                }
                else
                {
                    label2.Text = "Ingrese un número válido";
                    break;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

