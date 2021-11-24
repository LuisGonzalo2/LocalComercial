using System;
using CapaLogica;

namespace LocalComercial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo el objeto mostrar para mostrar mensajes
            Mensajes mostrar = new Mensajes();
            mostrar.bienvenida();
            //creo el objeto pedir para pedir mensajes
            PedirDatos pedir = new PedirDatos();
            //creo el objeto operar para operar el valor de la factura
            OperarNuevo operar = new OperarNuevo();
            //creo el objeto escoger para escoger las opciones
            Opciones escoger = new Opciones();
            //creo el objeto de calcular para calcular el descuento junto con el valor de la factura
            OperarPromocion calcular = new OperarPromocion();
            //creo el objeto ubi para mostrar y sumar el valor total de las ubicaciones
            OperarPosicionado ubi = new OperarPosicionado();
            mostrar.mensajepedir1();
            string nombLocal = pedir.NombreLocal();
            mostrar.mensajepedir2();
            string direccionnomb = pedir.DireccionLocal();
            mostrar.mensajepedir3();
            string nombreduenio = pedir.NombreDuenio();
            mostrar.mensajepedir4();
            string fechacreacion = pedir.FechaCreacion();
            mostrar.opcionesMensajes();
            int opcion = escoger.elejir(pedir.pedirOpcion());
            //Ejecuta local comercial nuevo
            if(opcion == 1)
            {
                Console.Clear();
                //pedir el valor total
                mostrar.mensaje1();
                double valorNuevo = pedir.pedirValor();
                //pedir el descuento a sacar
                mostrar.mensaje2();
                double porcentajeNuevo = pedir.pedirPorcentaje();
                Console.Clear();
                //operar el descuento y guardar en una variable
                double descuento = operar.calcular(valorNuevo, porcentajeNuevo);
                //mostrar en consola el resultado
                Console.WriteLine(mostrar.factura1(valorNuevo, porcentajeNuevo, descuento));
            }
            //Ejecuta Local comercial en promocion
            else if(opcion == 2)
            {
                Console.Clear();
                //precio del local
                calcular.LocalComercial = 5000;
                //valor absoluto del descuento
                calcular.Descuento = 10;
                mostrar.mensaje3();
                //Se pide el valor y se guarda en una variable
                double valorPromocion = pedir.pedirValor();
                Console.Clear();
                //Aqui se calcula para saber si necesita descuento o no
                string total = (calcular.calcular(valorPromocion, calcular.LocalComercial, calcular.Descuento));
                //Manda un mensaje a consola
                Console.WriteLine(mostrar.factura2(valorPromocion,total));
            }
            //Ejecuta Local comercial posicionado
            else if(opcion == 3)
            {
                Console.Clear();
                //pide un valor
                mostrar.mensaje4();
                double num = pedir.pedirValor();
                //se pide que selecciones una ubicacion y retorna una respuesta que se guarda en una variable
                Console.Clear();
                string ubicacion = ubi.ubicacion(num);
                //Aqui se almacena el costo de cada ubicacion
                double valor1 = ubi.ubiCosto(num);
                //aqui se guarda el precio de los locales
                double valor2 = ubi.LocalComercial = 5000;
                //Aqui se suma los valores y se guarda en la variable
                string valortotal = ubi.operarSuma(valor1, valor2);
                //muestra un mensaje de la factura en consola
                mostrar.factura3(ubicacion, valor1, valortotal, valor2);
            }
            Console.WriteLine("Aplaste cualquier tecla para continuar");
            Console.ReadLine();
            Console.Clear();
            mostrar.mostrarLista(nombLocal,direccionnomb,nombreduenio,fechacreacion);
            Console.ReadLine();
        }
    }
}
