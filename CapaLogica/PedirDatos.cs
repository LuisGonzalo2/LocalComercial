using System;
using CapaDatos;

namespace CapaLogica
{
    public class PedirDatos
    {
        Duenio pedir = new Duenio();
        public PedirDatos() { }


        //metodo para pedir el nombre del local
        public string NombreLocal()
        {  
            return pedir.NOMBRELOCAL = Console.ReadLine();
        }
        //metodo para pedir la direccion del local
        public string DireccionLocal()
        {       
            return pedir.DIRECCIONLOCAL = Console.ReadLine();
        }
        //metodo para pedir el nombre del duenio
        public string NombreDuenio()
        {  
            return pedir.NOMBREDUENIO = Console.ReadLine();
        }
        //metodo para pedir la fecha de creacion
        public string FechaCreacion()
        {
            return pedir.FECHACREACION = Console.ReadLine();
        }
        //metodo para pedir valores
        public double pedirValor()
        {
            String Valor = Console.ReadLine();
            double num = double.Parse(Valor);
            return num;
        }
        //metodo para pedir porcentajes
        public double pedirPorcentaje()
        {
            String valor = Console.ReadLine();
            double num = double.Parse(valor);
            return num;
        }
        //metodo para pedir opciones
        public int pedirOpcion()
        {
            string num = Console.ReadLine();
            int valor = int.Parse(num);
            return valor;
        }


    }
}
