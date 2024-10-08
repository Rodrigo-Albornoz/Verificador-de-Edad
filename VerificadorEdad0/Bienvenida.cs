using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerificadorEdad0
{
    public partial class Bienvenida : Form
    {
        public string nombreGuardado;
        public Bienvenida()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarNombre();
            Form1 form1 = new Form1();
            form1.SetNombre(nombreGuardado);
            form1.Show();
            this.Hide();
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
        }
        private void GuardarNombre()
        {
            nombreGuardado = textBox1.Text;
        }
    }
}
