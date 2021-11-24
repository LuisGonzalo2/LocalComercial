using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class OperarNuevo
    {
        public OperarNuevo()
        {
        }
        //metodo para calcular el porcentaje y el descuento
        public double calcular(double valor, double porcentaje)
        {
            double descuento = porcentaje / 100 ;
            double multiplicacion = valor * descuento;
            double resultado = valor - multiplicacion;
            return resultado;
        }
    }
}
