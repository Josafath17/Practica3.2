using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int producto, cantidad,precio,descuento,fprecio ,prueba;
            double iva = 0.13;
            bool salir = false;
            int camisas = 10000;
            int tenis = 15000;
            int abrigosh = 25000;
            int abrigosm = 300000;
            int abrigosn = 15000;
        
            

            while (!salir)
            {
                try
                {
                    Console.WriteLine("Bienvenido A Tienda El Descuento ");
                    Console.WriteLine("1. Camisas a 10000");
                    Console.WriteLine("2. Tenis a 15000 ");
                    Console.WriteLine("3. Abrigos para hombre a 25000");
                    Console.WriteLine("4. Abigos para mujer 30000");
                    Console.WriteLine("5. Abrigos para niños 15000");
                    Console.WriteLine("6. Salir");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Todas las Casisas tienen un descueto de un 10%");

                            Console.WriteLine("Ingrese La cantidad de camisas que desea: ");
                            cantidad = int.Parse(Console.ReadLine());

                            precio = camisas * cantidad;
                            Console.WriteLine("El precio de las camisas es: " + precio);
                            producto = (int)(precio * iva);
                            Console.WriteLine("El costo del IVA es: " + producto);
                            prueba = precio + producto;
                            descuento = prueba * 10 / 100;
                            Console.WriteLine("El descueto del 10%: " + descuento);
                            fprecio = precio + producto - descuento;
                            Console.WriteLine("Precio Final a pagar : " + fprecio);

                            break;

                        case 2:
                            Console.WriteLine("Todas las Casisas tienen un descueto de un 20%");

                            Console.WriteLine("Ingrese La cantidad de Tenis que desea: ");
                            cantidad = int.Parse(Console.ReadLine());
                            precio = tenis * cantidad;
                            Console.WriteLine("El precio de las Tenis es: " + precio);
                            producto = (int)(precio * iva);
                            Console.WriteLine("El costo del IVA es: " + producto);
                            prueba = precio + producto;
                            descuento = prueba * 20 / 100;
                            Console.WriteLine("El descueto del 10%: " + descuento);
                            fprecio = precio + producto - descuento;
                            Console.WriteLine("Precio Final a pagar : " + fprecio);

                            break;
                        case 3:
                            Console.WriteLine("Todas las Abrigos de hombre tienen un descueto de un 25%");

                            Console.WriteLine("Ingrese La cantidad de Abrigos de hombre que desea: ");
                            cantidad = int.Parse(Console.ReadLine());
                            precio = abrigosh * cantidad;
                            Console.WriteLine("El precio de las Tenis es: " + precio);
                            producto = (int)(precio * iva);
                            Console.WriteLine("El costo del IVA es: " + producto);
                            prueba = precio + producto;
                            descuento = prueba * 25 / 100;
                            Console.WriteLine("El descueto del 10%: " + descuento);
                            fprecio = precio + producto - descuento;
                            Console.WriteLine("Precio Final a pagar : " + fprecio);


                            break;

                        case 4:
                            Console.WriteLine("Todas las Abrigos de Mujer tienen un descueto de un 30%");

                            Console.WriteLine("Ingrese La cantidad de Abrigos de mujer que desea: ");
                            cantidad = int.Parse(Console.ReadLine());
                            precio = abrigosm * cantidad;
                            Console.WriteLine("El precio de las Tenis es: " + precio);
                            producto = (int)(precio * iva);
                            Console.WriteLine("El costo del IVA es: " + producto);
                            prueba = precio + producto;
                            descuento = prueba * 30 / 100;
                            Console.WriteLine("El descueto del 10%: " + descuento);
                            fprecio = precio + producto - descuento;
                            Console.WriteLine("Precio Final a pagar : " + fprecio);


                            break;

                        case 5:
                            Console.WriteLine("Todas las Abrigos de Niños tienen un descueto de un 20%");

                            Console.WriteLine("Ingrese La cantidad de Abrigos de niños que desea: ");
                            cantidad = int.Parse(Console.ReadLine());
                            precio = abrigosn * cantidad;
                            Console.WriteLine("El precio de las Tenis es: " + precio);
                            producto = (int)(precio * iva);
                            Console.WriteLine("El costo del IVA es: " + producto);
                            prueba = precio + producto;
                            descuento = prueba * 20 / 100;
                            Console.WriteLine("El descueto del 10%: " + descuento);
                            fprecio = precio + producto - descuento;
                            Console.WriteLine("Precio Final a pagar : " + fprecio);

                            break;




                        case 6:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 6");
                            break;

                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
