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
        private string nombreUsuario;
        public Form1()
        {
            InitializeComponent();
            cambiarlabel();
            label2.Visible = false;
            label1.Text = "Ingrese su edad en el siguiente recuadro:";
        }
        public void SetNombre(string nombre)
        {
            label3.Text = "Bienvenido " + nombre;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int edad1;
            VerificadorEdad verificador = new VerificadorEdad();

            while (true)
            {
                if (int.TryParse(textBox1.Text, out edad1))
                {
                    String msj = label2.Text = verificador.Verificar(edad1);
                    MessageBox.Show(msj);
                    label2.Visible = false;
                    break;
                }
                else
                {
                    label2.Text = "Ingrese un número válido";
                    MessageBox.Show(label2.Text);
                    label2.Visible = false;
                    break;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Quieres salir de la aplicación?", "Salir", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
                
            }
        }
        public void cambiarlabel()
        {
            Bienvenida v = new Bienvenida();
        }
    }
}



