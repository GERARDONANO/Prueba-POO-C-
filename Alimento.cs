using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Alimento
    {
        private string nombre;
        private int precio;

        //AGREGACION CON PEDIDO
        private Pedido pedido;

        //Constructor CON Pedido
        public Alimento(
            Pedido pedido,
            int precio,
            string nombre)
        {
            this.nombre = nombre;
            this.pedido = pedido;
            this.precio = precio;
        }

        //Constructor SIN Pedido
        public Alimento(
            int precio,
            string nombre)
        {
            this.nombre = nombre;
            this.precio = precio;
        }


        class Plato { }
        class Bebida { }
        class Postre { }
        class Ensalada { }
        class Agregado { }




    }
}
