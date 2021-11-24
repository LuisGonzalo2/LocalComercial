using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class OperarPromocion
    {
        public double LocalComercial { get; set; }
        public double Descuento { get; set; }
        public OperarPromocion() { }
        //metodo para calcular el pocentaje y el descuento
        public string calcular(double num, double localComercial, double porcentaje) 
        {
            double valor = 0;
            
            if(num >= 11)
            {

                double opera = porcentaje / 100;
                valor = num * localComercial;
                double descuento = valor * opera;
                double total = valor - descuento;
                return "Aplica para el descuento el total es: "+total;
            }
            else 
            {
                valor = num * localComercial;
                
                return "No aplica para el descuento el total es: "+valor;
            }


        }
    }
}
