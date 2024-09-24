using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificadorEdad0
{
    public class VerificadorEdad
    {
        public string Verificar(int edad)
        {
            if (edad >= 18)
            {
                return "Acceso concedido";
            }
            else
            {
                return "Acceso no concedido";
            }
        }
    }
}