using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
   public class Pedido
    {
        #region agregaciones
        //agregacion CLIENTE
        private Cliente cliente;
        // agregacion MESA
        private Mesa mesa;
        //agregacion ALIMENTO
        private List<Alimento> alimentos;
        //agregacion GARZON
        private Garzon garzon;
        //agregacion MENU
        private List<Menu> menu;

#endregion
        private DateTime fecha;
        private DateTime hora;
        private Boolean estado;
 

        //CONSTRUCTOR 
        public Pedido(
            DateTime fecha,
            DateTime hora,
            Boolean estado
            
            ) {
            this.fecha = fecha;
            this.hora = hora;
            this.estado = estado;

        }

        public bool registrarse(string[] param) {
            return true;
        }


    }
}
