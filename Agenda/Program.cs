using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda miagenda = new Agenda();
            SByte menu = 0;
            Contacto contacto;

            while (menu != 6)
            {

                try
                {


                    Console.WriteLine("\n1.-Mostrar agenda");
                    Console.WriteLine("\n2.-Mostrar contacto");
                    Console.WriteLine("\n3.-Introducir contacto");
                    Console.WriteLine("\n4.-Modificar contacto");
                    Console.WriteLine("\n5.-Borrar contacto");
                    Console.WriteLine("\n6.-Salir");
                    menu = Convert.ToSByte(Console.ReadLine());
                    switch (menu)
                    {
                        case 1: /*Mostrar agenda*/
                            if (miagenda.get_tamanyo() == 0)
                                Console.WriteLine("Agenda vacia");
                            else
                                miagenda.verAgenda();
                            break;

                        case 2: /*Mostrar contacto*/
                            if (miagenda.get_tamanyo() == 0)
                                Console.WriteLine("Agenda vacia");
                            else
                            {
                                Console.WriteLine("\nIntroduzca el nombre del contacto(s) a buscar");
                                miagenda.buscarcontacto(Console.ReadLine());
                            }

                            break;

                        case 3: /*Introducir contacto*/
                            if (miagenda.get_tamanyo() == 100)
                                Console.WriteLine("Agenda llena");
                            else
                            {
                                contacto = new Contacto();
                                Console.WriteLine("\nIntroduzca un nombre: ");                  /*introduce nombre*/
                                contacto.set_nombre(Console.ReadLine());
                                Console.WriteLine("\nIntroduzca un telefono: ");                /*introduce telefono*/
                                contacto.set_telefono(Convert.ToUInt32(Console.ReadLine()));
                                miagenda.anyadircontacto(contacto);                             /*introducir contacto en la agenda*/
                                contacto = null;                                                /*libero el puntero*/
                            }


                            break;

                        case 4: /*Modificar contacto*/
                            if (miagenda.get_tamanyo() == 0)
                                Console.WriteLine("Agenda vacia");
                            else
                            {
                                contacto = new Contacto();
                                Console.WriteLine("\nIntroduzca el nombre del contacto a modificar: ");         /*nombre*/
                                contacto.set_nombre(Console.ReadLine());
                                if (miagenda.buscarcontacto(contacto.get_nombre()) == 1)
                                {
                                    Console.WriteLine("\nIntroduzca el telefono del contacto a modificar: ");       /*telefono*/
                                    contacto.set_telefono(Convert.ToUInt32(Console.ReadLine()));
                                    miagenda.modificarcontacto(contacto);
                                }
                                contacto = null;
                            }


                            break;

                        case 5: /*Borrar contacto*/

                            if (miagenda.get_tamanyo() == 0)
                                Console.WriteLine("No hay contactos que borrar");
                            else
                            {
                                contacto = new Contacto();
                                Console.WriteLine("\nIntroduzca el nombre del contacto a borrar: ");         /*nombre*/
                                contacto.set_nombre(Console.ReadLine());
                                if (miagenda.buscarcontacto(contacto.get_nombre()) == 1)
                                {
                                    Console.WriteLine("\nIntroduzca el telefono del contacto a borrar: ");       /*telefono*/
                                    contacto.set_telefono(Convert.ToUInt32(Console.ReadLine()));
                                    miagenda.borrarcontacto(contacto);
                                }
                                contacto = null;
                            }
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
