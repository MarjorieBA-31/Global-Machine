using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlandoAExamenprogaII
{
    class Program
    {
        static string name = "";
        static int numero = 0;
        static double numero1 = 0;
        static double numero2 = 0;
        static double numero3 = 0;
        static double numero4 = 0;
        static double numero5 = 0;
        static double numero6 = 0;
        static double numero7 = 0;
        static double numero8 = 0;
        static double numero9 = 0;
        static double numero10 = 0;
        static double cantidad = 0;
        static double comprar1;
        static double comprar2;
        static double comprar3;
        static double comprar4;
        static double comprar5;
        static double comprar6;
        static double comprar7;
        static double comprar8;
        static double comprar9;
        static double comprar10;
        static double resultado1;
        static double resultado2;
        static double resultado3;
        static double resultado4;
        static double resultado5;
        static double resultado6;
        static double resultado7;
        static double resultado8;
        static double resultado9;
        static double resultado10;
        static double orden = 0;
        static double descuento1 = 0;
        static double descuento2 = 0;
        static double descuento3 = 0;
        static double descuento4 = 0;
        static double descuento5 = 0;
        static double descuento6 = 0;
        static double descuento7 = 0;
        static double descuento8 = 0;
        static double descuento9 = 0;
        static double descuento10 = 0;
        static double descuentototal = 0;
        static double impuesto = 0.13;
        static double usuario = 0;
        static double total = 0;
        static double totalimpuesto = 0;
        static double neto = 0;
        static double final = 0;







        static int option = 0;
        static int i = 0;
        static int size = 5;
        [Flags]
        enum Nivel
        {
            Bajo = 200,
            MedioBajo = 500,
            Medio = 1000,
            MedioAlto = 3000,
            Alto = 20000,
        };
        struct articulo
        {

            public int ID;
            public string name;
            public string tipo;
            public string fecha;
            public string proveedor;
            public double nivel;


        };
        static articulo[] articulos;


        static void ingreso_productos() {
            int r = 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < articulos.Length)
                {
                    Console.WriteLine("*-* Global Machines *-*");
                    Console.WriteLine("Ingreso de producto.             ");
                    Console.Write("Digite el ID del producto:           ");
                    articulos[i].ID = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del producto:       ");
                    articulos[i].name = Console.ReadLine();
                    Console.Write("Digite la Tipo de producto:          ");
                    articulos[i].tipo = Console.ReadLine();
                    Console.Write("Digite el Fecha  de vencimiento:     ");
                    articulos[i].fecha = Console.ReadLine();
                    Console.Write("Digite el Nombre del Proveedor:      ");
                    articulos[i].proveedor = Console.ReadLine();
                    Console.Write("Seleccione el nivel o pocision :     ");
                    Console.Write("\n" + Nivel.Bajo + ":" + (int)Nivel.Bajo + "\n" +
                                  Nivel.MedioBajo + ":" + (int)Nivel.MedioBajo + "\n" +
                                  Nivel.Medio + ":" + (int)Nivel.Medio + "\n" +
                                  Nivel.MedioAlto + ":" + (int)Nivel.MedioAlto + "\n" +
                                  Nivel.Alto + ":" + (int)Nivel.Alto + "\n");
                    articulos[i].nivel = double.Parse(Console.ReadLine());


                    Console.WriteLine("Desea agregar otro libro 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de productos  lleno..");
                    r = 1;
                    Console.ReadKey();
                }
            }

        }

        static void lista_Articulos()
        {
            int reg = 0;
            Console.Clear();
            Console.WriteLine("                        *-* Global Machine  *-*");

            Console.WriteLine("============================================================================");
            Console.WriteLine("Listado de libros.             ");
            Console.WriteLine("============================================================================");

            Console.WriteLine("Registro " + "codigo  " + "Nombre   " + "Tipo   " + "Vencimiento   " + "Proveedor   " + "Posicion    " + "Precio     ");
            for (i = 0; i < articulos.Length; i++)
            {
                reg = i + 1;


                Console.WriteLine(+reg + "         " + articulos[i].ID + "          " + articulos[i].name + "     " + articulos[i].tipo + "         " + articulos[i].fecha + "         " + articulos[i].proveedor + "          " + articulos[i].nivel);


            }
            Console.WriteLine("===========================================================================");
            Console.ReadKey();
        }



        static void modificar_articulos()
        {
            int reg = 0;
            int option = 0;
            int user = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("*-* Global Machine *-*");
                Console.WriteLine("Modificación de Productos");
                Console.WriteLine("Digite el ID del producto que desea buscar");
                user = int.Parse(Console.ReadLine());
                for (i = 0; i < articulos.Length; i++)
                {
                    if (user == articulos[i].ID)
                    {
                        reg = i + 1;


                        Console.WriteLine("Registro:          " + reg);
                        Console.WriteLine("ID o Codigo:       " + articulos[i].ID);
                        Console.WriteLine("Nombre:            " + articulos[i].name);
                        Console.WriteLine("Tipo:              " + articulos[i].tipo);
                        Console.WriteLine("fecha:             " + articulos[i].fecha);
                        Console.WriteLine("Proveedor:         " + articulos[i].proveedor);
                        Console.WriteLine("Nivel:             " + articulos[i].nivel);
                        found = true;



                        {
                            while (option != 7)
                            {
                                Console.Clear();


                                Console.WriteLine("Ingrese la opcion que desea cambiar");
                                Console.WriteLine("1.Nombre");
                                Console.WriteLine("2.Tipo");
                                Console.WriteLine("3.fecha");
                                Console.WriteLine("4.proveedor");
                                Console.WriteLine("5.nivel");
                                Console.WriteLine("6.Ver cambios");
                                Console.WriteLine("7.Salir");

                                option = int.Parse(Console.ReadLine());
                                switch (option)
                                {
                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("Digite el nuevo nombre del producto");
                                        articulos[i].name = Console.ReadLine();

                                        break;
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("Digite la nueva fecha de vencimiento del producto");
                                        articulos[i].name = Console.ReadLine();
                                        break;
                                    case 3:
                                        Console.Clear();
                                        Console.WriteLine("Digite la nueva TIPO del producto");
                                        articulos[i].tipo = Console.ReadLine();
                                        break;
                                    case 4:
                                        Console.Clear();
                                        Console.WriteLine("Digite el nuevo proveedor del producto");
                                        articulos[i].proveedor = Console.ReadLine();
                                        break;
                                    case 5:
                                        Console.Clear();
                                        Console.Write("Digite el nivel o pocision :        ");
                                        Console.Write(Nivel.Bajo + ":" + (int)Nivel.Bajo + "\n" +
                                                      Nivel.MedioBajo + ":" + (int)Nivel.MedioBajo + "\n" +
                                                      Nivel.Medio + ":" + (int)Nivel.Medio + "\n" +
                                                      Nivel.MedioAlto + ":" + (int)Nivel.MedioAlto + "\n" +
                                                      Nivel.Alto + ":" + (int)Nivel.Alto + "\n");
                                        articulos[i].nivel = double.Parse(Console.ReadLine());
                                        break;
                                    case 6:
                                        {
                                            lista_Articulos();
                                            if (user.Equals(articulos[i].name))
                                            {
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                Console.WriteLine("Modificaciones Actuales");


                                                Console.WriteLine("Digite Nombre del producto:   " + articulos[i].name.Length);
                                                Console.WriteLine("Digite Nombre del tipo de producto:   " + articulos[i].tipo.Length);
                                                Console.WriteLine("Digite la nueba fecha de vencimiento del producto:     " + articulos[i].fecha.Length);
                                                Console.WriteLine("Digite el nuevo Proveedor:         " + articulos[i].proveedor);
                                                Console.WriteLine("Digite el nuevo Nivel:             " + articulos[i].nivel);
                                                found = true;
                                            }
                                            lista_Articulos();
                                        }
                                        break;
                                    case 7:


                                        break;
                                }







                            }
                            if (!found)
                            {
                                Console.WriteLine("No se encontro ese ID");
                                found = false;
                            }
                            Console.WriteLine("Desea buscar otro producto 0-Sí 1-No");
                            r = int.Parse(Console.ReadLine());
                        }
                    }
                }
            }
        }


        static void Buscar_Producto()
        {
            //Buscar por registro
            int ID = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Global Machine *-*");
                Console.WriteLine("Búsquedad de Productos.           ");
                Console.WriteLine("Digite el ID del productos a buscar");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < articulos.Length; i++)
                {
                    if (ID == articulos[i].ID)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro:          " + reg);
                        Console.WriteLine("ID o Codigo:       " + articulos[i].ID);
                        Console.WriteLine("Nombre:            " + articulos[i].name);
                        Console.WriteLine("Tipo:              " + articulos[i].tipo);
                        Console.WriteLine("fecha:             " + articulos[i].fecha);
                        Console.WriteLine("Proveedor:         " + articulos[i].proveedor);
                        Console.WriteLine("Nivel:             " + articulos[i].nivel);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro Producto 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }


        static void Eliminar_Producto()
        {

            int ID = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* Global Machine *-*");
                Console.WriteLine("Búsquedad de Productosque desea Eliminar.           ");
                Console.WriteLine("Digite el ID del productos ");
                ID = int.Parse(Console.ReadLine());
                for (i = 0; i < articulos.Length; i++)
                {
                    if (ID == articulos[i].ID)
                    {
                        articulos[i].ID = 0;
                        articulos[i].name = "";
                        articulos[i].tipo = "";
                        articulos[i].fecha = "";
                        articulos[i].proveedor = "";
                        articulos[i].nivel = 0;


                        reg = i + 1;
                        Console.WriteLine("Registro:          " + reg);
                        Console.WriteLine("ID o Codigo:       " + articulos[i].ID);
                        Console.WriteLine("Nombre:            " + articulos[i].name.Length);
                        Console.WriteLine("Tipo:              " + articulos[i].tipo.Length);
                        Console.WriteLine("fecha:             " + articulos[i].fecha.Length);
                        Console.WriteLine("Proveedor:         " + articulos[i].proveedor.Length);
                        Console.WriteLine("Nivel:             " + articulos[i].nivel);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea Eliminar otro Producto 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void Main()
        {
            articulos = new articulo[size];
            do
            {
                Console.Clear();
                Console.WriteLine("-* Global Machines  *-*");
                Console.WriteLine("1. Ingreso de productos.");
                Console.WriteLine("2. Modificación de productos.");
                Console.WriteLine("3. Eliminación de productos.");
                Console.WriteLine("4. Búsquedad de productos.");
                Console.WriteLine("5. Listado de productos.");
                Console.WriteLine("6. Venta de productos.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Selecciones una opción");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            ingreso_productos();

                            break;
                        }
                    case 2:
                        {
                            modificar_articulos();
                            break;
                        }
                    case 3:
                        {
                            Eliminar_Producto();
                            break;
                        }
                    case 4:
                        {
                            Buscar_Producto();

                            break;
                        }
                    case 5:
                        {
                            lista_Articulos();




                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Ingrese la cantidad de productos");
                            Console.WriteLine("Fritura");
                            comprar1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("respoteria");
                            comprar2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("resfrescos gaseosos");
                            comprar3 = int.Parse(Console.ReadLine());
                            Console.WriteLine("refrescos naturales");
                            comprar4 = int.Parse(Console.ReadLine());
                            Console.WriteLine("confiteria");
                            comprar5 = int.Parse(Console.ReadLine());
                            

                            if (comprar1 >= 1)
                            {
                                numero1 = 2000;
                                Console.WriteLine(" ");
                                resultado1 = comprar1 * numero1;
                                descuento1 = (resultado1 * 0.15);
                            }
                            else
                            {
                                Console.WriteLine("");
                            }
                            if (comprar2 >= 1)
                            {

                                numero2 = 1000;
                                Console.WriteLine(" ");
                                resultado2 = comprar2 * numero2;
                                descuento2 = (resultado2 * 0.2);
                            }
                            else
                            {
                                Console.WriteLine("");
                            }
                            if (comprar3 >= 1)
                            {

                                numero3 = 1500;
                                Console.WriteLine(" ");
                                resultado3 = comprar3 * numero3;
                                descuento3 = (resultado3 * 0.05);
                            }
                            else
                            {
                                Console.WriteLine("");
                            }
                            if (comprar4 >= 1)
                            {

                                numero4 = 4000;
                                Console.WriteLine(" ");
                                resultado4 = comprar4 * numero4;
                                descuento4 = (resultado4 * 0.25);
                            }
                            else
                            {
                                Console.WriteLine("");
                            }
                            if (comprar5 >= 1)
                            {
                                numero5 = 3200;
                                Console.WriteLine(" ");
                                resultado5 = comprar5 * numero5;
                                descuento5 = (resultado5 * 0.1);
                            }
                            else
                            {
                                Console.WriteLine("");
                            }
                           

                            orden = comprar1 + comprar2 + comprar3 + comprar4 + comprar5 + comprar6 + comprar7 + comprar8 + comprar9 + comprar10;
                            descuentototal = descuento1 + descuento2 + descuento3 + descuento4 + descuento5 + descuento6 + descuento7 + descuento8 + descuento9 + descuento10;
                            total = (resultado1 + resultado2 + resultado3 + resultado4 + resultado5 + resultado6 + resultado7 + resultado8 + resultado9 + resultado10) - descuentototal;
                            totalimpuesto = total * 0.13;
                            neto = total + totalimpuesto;
                            final = usuario - neto;

                            Console.WriteLine(" *.*                 Global Machine                      *.*");

                            Console.WriteLine(" =======================================================================");
                            Console.WriteLine("Factura Proforma                                                 Nº 0001");

                            Console.Write("Cliente:  " + name);
                            name = Console.ReadLine();
                            Console.Write("Telefono: ");
                            numero = int.Parse(Console.ReadLine());
                            Console.WriteLine("------------------------------------------------------------------------");
                            Console.WriteLine("                Item                       Ctd      Precio    Sub Total ");
                            Console.WriteLine("Frutas                                      " + comprar1 + "       " + numero1 + "           " + resultado1);

                            Console.WriteLine("reposteria                                  " + comprar2 + "       " + numero2 + "           " + resultado2);

                            Console.WriteLine("refrescos gaseosos                          " + comprar3 + "       " + numero3 + "           " + resultado3);

                            Console.WriteLine("refrescos naturales                         " + comprar4 + "       " + numero4 + "           " + resultado4);

                            Console.WriteLine("Confiteria                                  " + comprar5 + "       " + numero5 + "           " + resultado5);

                            

                           
                            Console.WriteLine("------------------------------------------------------------------------");
                            Console.WriteLine("Total Orden                                                        " + orden);
                            Console.WriteLine("Descuento                                                          " + descuentototal);
                            Console.WriteLine("Impuesto Venta                                                     13% ");
                            Console.WriteLine("Impuesto Total                                                     " + totalimpuesto);
                            Console.WriteLine("Precio Neto                                                        " + neto);
                            Console.WriteLine("------------------------------------------------------------------------");
                            Console.WriteLine("Monto Recibido                                                     " + usuario);
                            Console.WriteLine("Monto Cambio                                                       " + final);
                            Console.WriteLine(" =======================================================================");
                            Console.WriteLine("Gracias por su compra....                                                          ");

                            Console.ReadKey();

                        

                
            


                        break;
                
                        }
                    case 7:
                       
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccion inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (option != 7);
        }
    }
}


