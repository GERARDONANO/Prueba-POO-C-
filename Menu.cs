using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Menu
    {
        private List<Alimento> alimentos;
        private int precio;
        private string nombre;


        // COMPOSICION  DE ALIMENTO
        private Alimento alimento = new Alimento(12122,"");

        //AGREGACION PEDIDO
        private Pedido pedido;

        //Constructor CON List ALIMENTO
        public Menu(
            List<Alimento> alimentos,
            int precio,
            string nombre)
        {
            this.alimentos = alimentos;
            this.precio = precio;
            this.nombre = nombre;
        }

        //Constructor SIN List ALIMENTO
        public Menu(
            int precio,
            string nombre)
        {
            this.precio = precio;
            this.nombre = nombre;
        }




        public void agregarAlimento(Alimento alimento) { }
        public void quitarAlimento(Alimento alimento) { } 

        public int  obtienePrecio() {
            int precio = 0;
            return precio;
        } 
        public int cambiarPrecio(int precio) {
            return precio;
                }



    }
}
