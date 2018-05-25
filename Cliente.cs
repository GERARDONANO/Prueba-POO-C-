using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
   public class Cliente: Persona
    {
      
        // agregacion PEDIDO
        private Pedido pedido;


        //CONSTRUCTOR con PEDIDO
        public Cliente(
            Pedido pedido
            )
        { }

        //CONSTRUCTOR sin PEDIDO
        public Cliente() { }




        public bool Registrarse(string[] param) {
            return true;
        }


        public void reservarMesa() {
            Mesa mesa = new Mesa(1,1,true);
            mesa.registrar(true);
        }
        public void quitarMesa() {
            Mesa mesa = new Mesa(2,2,false);
            mesa.registrar(false);
        }


    }
}
