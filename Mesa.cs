using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
   public class Mesa
    {
        private int numero;
        private int cantidadPersonas;
        private bool estado;

        private Pedido pedido;

        //CONSTRUCTOR con PEDIDO
        public Mesa(
            Pedido pedido,
            int numero,
            int cantidad,
            bool estado)
        {
            this.pedido = pedido;
            this.numero = numero;
            this.cantidadPersonas = cantidad;
            this.estado = estado;
        }


        //CONSTRUCTOR sin PEDIDO
        public Mesa(
           
            int numero,
            int cantidad,
            bool estado)
        {
            this.numero = numero;
            this.cantidadPersonas = cantidad;
            this.estado = estado;
        }


        public void registrar(bool tipo) { }

        public bool consultaEstado()
        {
            return false;
        }

        public List<Mesa> disponibles() {
            return new List<Mesa>();
                }


    }
}
