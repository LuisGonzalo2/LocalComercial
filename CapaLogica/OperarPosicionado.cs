using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class OperarPosicionado:OperarPromocion
    {
        public string Posicion { get; set; }
        public OperarPosicionado() { }

        //metodo para escoger y devolver una ubicacion
        public string ubicacion(double num)
        {
            OperarPosicionado lugar = new OperarPosicionado();
            if (num == 1)
            {
                return lugar.Posicion = "Centro";
            }
            if (num == 2)
            {
                return lugar.Posicion = "Al Frente";
            }
            if (num == 3)
            {
                return lugar.Posicion = "Al Fondo";
            }
            return "";
        }

        //metodo para devolver el costo de la ubicacion
        public double ubiCosto(double num)
        {
            if (num == 1)
            {
                return 560;
            }
            if (num == 2)
            {
                return 700;
            }
            if (num == 3)
            {
                return 360;
            }
            return 0;
        }

        //metodo sencillo para sumar
        public string operarSuma(double valor1, double valor2)
        {
            double suma = valor1 + valor2;

            return "El valor Total es: " + suma;
        }
    }
}
