using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {
            Electrodomestico mielectrodomesticos = new Electrodomestico();
            SByte menu = 0;
            Frigorificos frigorifico;
            Lavadoras lavadora;
            Lavavajillas lavavajilla;
            while (menu != 6)
            {

                try
                {


                    Console.WriteLine("\n1.-Incluir electrodomestico");
                    Console.WriteLine("\n2.-Eliminar un electrodomestico");
                    Console.WriteLine("\n3.-Buscar electrodomestico");
                    Console.WriteLine("\n4.-Listar electrodomesticos");
                    Console.WriteLine("\n5.-Guardar en un fichero");
                    Console.WriteLine("\n6.-Salir");
                    menu = Convert.ToSByte(Console.ReadLine());
                    switch (menu)
                    {
                        case 1: /*incluir electrodomestico*/
                            Console.WriteLine("\nElija un electrodomestico");
                            Console.WriteLine("\n1.-Frigorifico");
                            Console.WriteLine("\n2.-Lavadoras");
                            Console.WriteLine("\n3.-Lavavajillas");

                            switch (Convert.ToByte(Console.ReadLine()))
                            {


                                case 1:
                                    if (mielectrodomesticos.get_tamanyo_frigorificos() == 100)
                                        Console.WriteLine("\nEsta lleno, no se puede anyadir");
                                    else
                                    {
                                        frigorifico = new Frigorificos();
                                        Console.WriteLine("\nIntroduzca la marca del frigorifico: ");
                                        frigorifico.set_fabricante(Console.ReadLine());
                                        Console.WriteLine("\nIntroduzca el modelo: ");
                                        frigorifico.set_modelo(Console.ReadLine());
                                        Console.WriteLine("\nIntroduzca el precio: ");
                                        frigorifico.set_precio(Convert.ToSingle(Console.ReadLine()));
                                        Console.WriteLine("\nIntroduzca los anyos garantia: ");
                                        frigorifico.set_anyos(Convert.ToByte(Console.ReadLine()));
                                        Console.WriteLine("\nIntroduzca la clasificación energética: ");
                                        frigorifico.set_clasificacion(Convert.ToChar(Console.ReadLine()));
                                        Console.WriteLine("\nIntroduzca la capacidad: ");
                                        frigorifico.set_capacidad(Convert.ToUInt32(Console.ReadLine()));
                                        Console.WriteLine("\nIntroduzca el alto: ");
                                        frigorifico.set_alto(Convert.ToByte(Console.ReadLine()));
                                        Console.WriteLine("\nIntroduzca el ancho: ");
                                        frigorifico.set_ancho(Convert.ToByte(Console.ReadLine()));
                                        Console.WriteLine("\nIntroduzca el fondo: ");
                                        frigorifico.set_fondo(Convert.ToByte(Console.ReadLine()));
                                        /*Introducir frigorifico*/
                                        if (mielectrodomesticos.introducir_frigorifico(frigorifico) == 0)
                                            Console.WriteLine("\nNo se ha podido introducir el frigorifico");
                                        else
                                            Console.WriteLine("\nSe ha introducido correctamente");
                                        frigorifico = null;
                                    }
                                    break;


                                case 2:
                                    if (mielectrodomesticos.get_tamanyo_lavadoras() == 100)
                                        Console.WriteLine("\nEsta lleno, no se puede anyadir");
                                    else
                                    {
                                        lavadora = new Lavadoras();
                                        Console.WriteLine("\nIntroduzca la marca de la lavadora: ");
                                        lavadora.set_fabricante(Console.ReadLine());
                                        Console.WriteLine("\nIntroduzca el modelo: ");
                                        lavadora.set_modelo(Console.ReadLine());
                                        Console.WriteLine("\nIntroduzca el precio: ");
                                        lavadora.set_precio(Convert.ToSingle(Console.ReadLine()));
                                        Console.WriteLine("\nIntroduzca la garantia: ");
                                        lavadora.set_anyos(Convert.ToByte(Console.ReadLine()));
                                        Console.WriteLine("\nIntroduzca la clasificación energética: ");
                                        lavadora.set_clasificacion(Convert.ToChar(Console.ReadLine()));
                                        Console.WriteLine("\nIntroduzca la capacidad: ");
                                        lavadora.set_capacidad(Convert.ToUInt32(Console.ReadLine()));
                                        Console.WriteLine("\nNúmero de programas de lavado: ");
                                        lavadora.set_nprogramas(Convert.ToByte(Console.ReadLine()));
                                        Console.WriteLine("\nNúmero de revoluciones: ");
                                        lavadora.set_nrevoluciones(Convert.ToUInt32(Console.ReadLine()));
                                        /*Introducir lavadora*/
                                        if (mielectrodomesticos.introducir_lavadora(lavadora) == 0)
                                            Console.WriteLine("\nNo se ha podido introducir la lavadora");
                                        else
                                            Console.WriteLine("\nSe ha introducido correctamente");
                                        lavadora = null;
                                    }
                                    break;

                                case 3:
                                    if (mielectrodomesticos.get_tamanyo_lavavajillas() == 100)
                                        Console.WriteLine("\nEsta lleno, no se puede anyadir");
                                    else
                                    {
                                        lavavajilla = new Lavavajillas();
                                        Console.WriteLine("\nIntroduzca la marca del lavavajillas: ");
                                        lavavajilla.set_fabricante(Console.ReadLine());
                                        Console.WriteLine("\nIntroduzca el modelo: ");
                                        lavavajilla.set_modelo(Console.ReadLine());
                                        Console.WriteLine("\nIntroduzca el precio: ");
                                        lavavajilla.set_precio(Convert.ToSingle(Console.ReadLine()));
                                        Console.WriteLine("\nIntroduzca la garantia: ");
                                        lavavajilla.set_anyos(Convert.ToByte(Console.ReadLine()));
                                        Console.WriteLine("\nIntroduzca la clasificación energética: ");
                                        lavavajilla.set_clasificacion(Convert.ToChar(Console.ReadLine()));
                                        Console.WriteLine("\nIntroduzca la capacidad: ");
                                        lavavajilla.set_capacidad(Convert.ToUInt32(Console.ReadLine()));
                                        Console.WriteLine("\nNúmero de programas de lavado: ");
                                        lavavajilla.set_nprogramas(Convert.ToByte(Console.ReadLine()));
                                        Console.WriteLine("\nNúmero de programas de temperaturas: ");
                                        lavavajilla.set_ntemperaturas(Convert.ToByte(Console.ReadLine()));
                                        /*Introducir lavavajilla*/
                                        if (mielectrodomesticos.introducir_lavavajilla(lavavajilla) == 0)
                                            Console.WriteLine("\nNo se ha podido introducir el lavavajillas");
                                        else
                                            Console.WriteLine("\nSe ha introducido correctamente");
                                        lavavajilla = null;
                                    }
                                    break;
                                default:

                                    Console.WriteLine("\nOpcion incorrecta");

                                    break;
                            }
                           
                            break;

                        case 2: /*Eliminar electrodomestico*/
                                /*la eliminación de un electrodoméstico dados su marca y su modelo (debe
                                 devolver si la eliminación ha tenido éxito o no).*/
                            Console.WriteLine("\nQue electrodomestico desea eliminar: ");
                            Console.WriteLine("\n1.-Frigorificos");
                            Console.WriteLine("\n2.-Lavadoras");
                            Console.WriteLine("\n3.-Lavavajillas");

                            switch (Convert.ToByte(Console.ReadLine()))
                            {
                                case 1:/*Frigorificos*/
                                    if (mielectrodomesticos.get_tamanyo_frigorificos() == 0)
                                        Console.WriteLine("\nNo hay frigorificos que eliminar");
                                    else
                                    {
                                        frigorifico = new Frigorificos();
                                        Console.WriteLine("\nIntroduce la marca: ");
                                        frigorifico.set_fabricante(Console.ReadLine());
                                        Console.WriteLine("\nIntroduce su modelo: ");
                                        frigorifico.set_modelo(Console.ReadLine());
                                        /*borrar frigorifico*/
                                        if (mielectrodomesticos.borrar_frigorifico(frigorifico) == 1)
                                            Console.WriteLine("\nSe ha eliminado correctamente");
                                        else
                                            Console.WriteLine("\nNo se ha podido eliminar, es posible que no este");
                                        frigorifico = null;
                                    }
                                    break;

                                case 2:/*Lavavadoras*/
                                    if (mielectrodomesticos.get_tamanyo_lavadoras() == 0)
                                        Console.WriteLine("\nNo hay lavadoras que eliminar");
                                    else
                                    {
                                        lavadora = new Lavadoras();
                                        Console.WriteLine("\nIntroduce la marca: ");
                                        lavadora.set_fabricante(Console.ReadLine());
                                        Console.WriteLine("\nIntroduce su modelo: ");
                                        lavadora.set_modelo(Console.ReadLine());
                                        /*borrar lavadora*/
                                        if (mielectrodomesticos.borrar_lavadora(lavadora) == 1)
                                            Console.WriteLine("\nSe ha eliminado correctamente");
                                        else
                                            Console.WriteLine("\nNo se ha podido eliminar, es posible que no este");
                                        lavadora = null;
                                    }
                                    break;

                                case 3:/*Lavavajillas*/
                                    if (mielectrodomesticos.get_tamanyo_lavavajillas() == 0)
                                        Console.WriteLine("\nNo hay lavavajillas que eliminar");
                                    else
                                    {
                                        lavavajilla = new Lavavajillas();
                                        Console.WriteLine("\nIntroduce la marca: ");
                                        lavavajilla.set_fabricante(Console.ReadLine());
                                        Console.WriteLine("\nIntroduce su modelo: ");
                                        lavavajilla.set_modelo(Console.ReadLine());
                                        /*Eliminar lavavajilla*/
                                        if (mielectrodomesticos.borrar_lavavajilla(lavavajilla) == 1)
                                            Console.WriteLine("\nSe ha eliminado correctamente");
                                        else
                                            Console.WriteLine("nNo se ha podido eliminar, es posible que no este");
                                        lavavajilla = null;
                                    }
                                        break;
                                    
                                default:

                                    Console.WriteLine("\nOpcion incorrecta");
                                    break;
                            }

                            break;

                        case 3: /*buscar electrodomestico*/
                                /*la búsqueda de un electrodoméstico dados su marca y su modelo (debe devolver
                                    si la operación tiene éxito o no y, en caso afirmativo, el electrodoméstico).*/
                            Console.WriteLine("\nQue electrodomestico desea buscar: ");
                            Console.WriteLine("\n1.-Frigorificos");
                            Console.WriteLine("\n2.-Lavadoras");
                            Console.WriteLine("\n3.-Lavavajillas");

                            switch (Convert.ToByte(Console.ReadLine()))
                            {
                                case 1:/*Frigorificos*/
                                    if (mielectrodomesticos.get_tamanyo_frigorificos() == 0)
                                        Console.WriteLine("\nNo hay frigorificos que buscar");
                                    else
                                    {
                                        frigorifico = new Frigorificos();
                                        Console.WriteLine("\nIntroduce la marca: ");
                                        frigorifico.set_fabricante(Console.ReadLine());
                                        Console.WriteLine("\nIntroduce su modelo: ");
                                        frigorifico.set_modelo(Console.ReadLine());
                                        /*BUSCAR FRIGORIFICO*/
                                        mielectrodomesticos.buscar_frigorifico(frigorifico);
                                        frigorifico = null;
                                    }
                                    break;

                                case 2:/*Lavavadoras*/
                                    if (mielectrodomesticos.get_tamanyo_lavadoras() == 0)
                                        Console.WriteLine("\nNo hay lavadoras que buscar");
                                    else
                                    {
                                        lavadora = new Lavadoras();
                                        Console.WriteLine("\nIntroduce la marca: ");
                                        lavadora.set_fabricante(Console.ReadLine());
                                        Console.WriteLine("\nIntroduce su modelo: ");
                                        lavadora.set_modelo(Console.ReadLine());
                                        /*BUSCAR LAVADORA*/
                                        mielectrodomesticos.borrar_lavadora(lavadora);
                                        lavadora = null;
                                    }
                                    break;

                                case 3:/*Lavavajillas*/
                                    if (mielectrodomesticos.get_tamanyo_lavavajillas() == 0)
                                        Console.WriteLine("\nNo hay lavavajillas que buscar");
                                    else
                                    {
                                        lavavajilla = new Lavavajillas();
                                        Console.WriteLine("\nIntroduce la marca: ");
                                        lavavajilla.set_fabricante(Console.ReadLine());
                                        Console.WriteLine("\nIntroduce su modelo: ");
                                        lavavajilla.set_modelo(Console.ReadLine());
                                        /*BUSCAR LAVAVAJILLA*/
                                        mielectrodomesticos.borrar_lavavajilla(lavavajilla);
                                        lavavajilla = null;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("\nOpcion incorrecta");
                                    break;
                            }

                            break;
                        case 4: /*Listar electrodomesticos*/
                                /*la visualización por pantalla de la información de todos los electrodomésticos
                                existentes en una lista de electrodomésticos*/

                            mielectrodomesticos.listar_electrodomesticos();

                            break;

                        case 5: /*Guardar en fichero*/

                            /*guarda ficheros*/
                            mielectrodomesticos.escribir_fichero();

                            break;

                        default:    /*Opcion no valida*/
                            Console.WriteLine("\nOpcion no valida");
                            break;

                    }

                }/*try*/
                catch (FormatException)
                {
                    Console.WriteLine("\nno valido");
                    Console.ReadKey();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nFuera de rango");
                    Console.ReadKey();
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("\nArgumento no valido");
                    Console.ReadKey();
                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine("\nno hay memoria");
                    Console.ReadKey();
                }

            }/*while*/

        }
    }
}

