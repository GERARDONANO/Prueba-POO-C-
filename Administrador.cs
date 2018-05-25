using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Administrador : Trabajador
    {

        public void agregarEmpleado(Empleado empleado) { }
        public void quitarEmpleado(Empleado empleado) { }
        public void agregarBonificacion(Empleado empleado, int monto) { }


        // DEPENDENCIA ADMINISTRADOR - PEDIDO
        public List<Pedido> visualizaVentas(DateTime inicio, DateTime termino)
        {
            List<Pedido> pedido = new List<Pedido>();
            return pedido;
        }

        // DEPENDENCIA ADMINISTRADOR - PEDIDO
        public List<Pedido> visualizaVentas()
        {
            List<Pedido> pedido = new List<Pedido>();
            return pedido;
        }

        public void pagarEmpleados(Empleado empleado, int mes, int anio) { }


    }

}
