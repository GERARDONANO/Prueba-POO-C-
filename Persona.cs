using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Persona
    {
        private int run;
        private string nombre;
        private int celular;
        private string email;
        private string clave;


        protected void reiniciarClave(Persona personna) { }

        public bool iniciarSesion(string[] param) {
            return true;
        }


    }
}
