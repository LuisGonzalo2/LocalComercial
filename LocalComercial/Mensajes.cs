using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalComercial
{
    class Mensajes
    {
        //mensaje de bienvenida
        public void bienvenida()
        {
            Console.WriteLine("BIENVENIDO");
        }

        //lista donde muestra el nombre del local etc etc
        public void mostrarLista(string nombrelocal, string direccionlocal, string nombreduenio, string fechacreacion)
        {
            List<string> listacrear = new List<string>();
            listacrear.Add("El nombre del local es: "+nombrelocal);
            listacrear.Add("La direccion del local es: "+direccionlocal);
            listacrear.Add("El Nombre del duenio es: "+nombreduenio);
            listacrear.Add("La fecha de creacion del local es: "+fechacreacion);
            
            foreach (var item in listacrear)
            {
                Console.WriteLine(item);
            }
        }
        //metodo donde imprime la factura numero 1
        public string factura1(double valor, double descuento, double resultado)
        {
            return "El valor SubTotal es: "+valor+ "\nEl valor del Descuento es: "+descuento+ "\nEl valor Total es: "+resultado;
        }
        //metodo donde imprime la factura numero 2
        public string factura2(double cantidadProductos, string descuento)
        {
            return "La cantidad de Locales comercial son: "+cantidadProductos +"\n"+descuento;
        }
        //metodo donde imprime las opciones
        public void opcionesMensajes()
        {
            Console.WriteLine("A continuacion escoge");
            Console.WriteLine("1. Adquirir un Local Comercial Nuevo");
            Console.WriteLine("2. Adquirir un Local comercial por promocion");
            Console.WriteLine("3. Adquirir un Local comercial por posicionado");
        }
        //metodo donde imprime la factura numero 3
        public void factura3(string ubi,double valorubi, string valortotal, double valorLocal)
        {
            Console.WriteLine("La ubicacion escogida fue "+ubi);
            Console.WriteLine("Esta ubicacion tiene el precio de: " + valorubi);
            Console.WriteLine("El local tiene el valor de: " + valorLocal);
            Console.WriteLine(valortotal);
        }
        //aqui en estos metodos son generales, solo para decirle al usuario que hacer
        public void mensaje1()
        {
            Console.WriteLine("Ingresa el Valor del Local");
        }
        public void mensaje2()
        {
            Console.WriteLine("Ingrese el valor del descuento");
        }
        public void mensaje3()
        {
            Console.WriteLine("Ingrese Cuantos locales va a comprar");
        }
        public void mensaje4()
        {
            Console.WriteLine("Escoja un lugar donde quiera adquirir su local: ");
            Console.WriteLine("1. Centro --> 560 ");
            Console.WriteLine("2. Al Frente --> 700");
            Console.WriteLine("3. Al Fondo --> 360");
        }

        public void mensajepedir1()
        {
            Console.WriteLine("Ingresa el nombre de tu Local");
        }

        public void mensajepedir2()
        {
            Console.WriteLine("Ingresa la ubicacion del local");
        }

        public void mensajepedir3()
        {
            Console.WriteLine("Ingresa Tu Nombre");
        }
        public void mensajepedir4()
        {
            Console.WriteLine("Ingresa la fecha de creacion");
        }
    }
}
