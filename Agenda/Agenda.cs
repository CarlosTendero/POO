using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda
{

    class Agenda
    {
        Contacto[] contactos = new Contacto[100];   /*cadena de contactos*/

        public Agenda()     /*inicializo la agenda*/
        {
            
        }

        public SByte get_tamanyo()
        {
            int i;
            for ( i = 0; i < 100 && !(Equals(contactos[i], null)); i++) ;
            return (SByte) i;
        }
        public void anyadircontacto(Contacto Ncontacto)     /*anyado el contacto*/
        {
            int i = 0;
            for (i = 0; i < 100 && !(Equals(contactos[i], null)); i++)
            {
                if (Equals(Ncontacto.get_telefono(), contactos[i].get_telefono()))  /*si coinciden los telefonos*/
                {
                    Console.WriteLine("\nNo se puede anyadir el contacto porque ya hay uno que tiene el mismo numero");
                    return;
                }
            }
            if (i == 100)                                   /*esta llena la agenda*/
                Console.WriteLine("\nAgenda llena");
            else
                contactos[i] = Ncontacto;

            
        }

        public void verAgenda()     /*Mostrar agenda*/
        {
            for (int i = 0; i < 100 && !(Equals(contactos[i], null)); i++)
                  Console.WriteLine("\nContacto\t{0}\nNombre:\t\t{1}\nTelefono:\t{2}", i + 1, contactos[i].get_nombre(), contactos[i].get_telefono());
        }

        public SByte buscarcontacto(string nom)
        {
            SByte flag = 0;
            for (int i = 0; i < 100 && !(Equals(contactos[i], null)); i++)
            {
                if (Equals(contactos[i].get_nombre(), nom))
                {
                    Console.WriteLine("\nNombre:\t\t{0}\nTelefono\t{1}", contactos[i].get_nombre(), contactos[i].get_telefono());
                    flag = 1;
                }
            }

            if (flag == 0)
                Console.WriteLine("\nContacto no encontrado");

            return flag;
        }
            
            /*modificar contacto*/

        public void modificarcontacto(Contacto c)
        {
            int i;
          
            {
                for ( i = 0; i < 100 && !(Equals(contactos[i].get_nombre(), c.get_nombre())) || !(Equals(contactos[i].get_telefono(), c.get_telefono())); i++);


                    Console.WriteLine("Desea cambiar nombre: s/n");
                if (Equals(Console.ReadLine(), "s"))
                {
                    Console.WriteLine("Introduzca el nombre a cambiar:");
                    c.set_nombre(Console.ReadLine());
                }
                else //if (Equals(Console.ReadLine(), "n"))
                    c.set_nombre(contactos[i].get_nombre());
               // else
               //     Console.WriteLine("Opcion no valida");
               
               
                Console.WriteLine("Desea cambiar el telefono: s/n");
                if (Equals(Console.ReadLine(), "s"))
                {
                    Console.WriteLine("Introduzca el telefono a cambiar: ");
                    c.set_telefono(Convert.ToUInt32(Console.ReadLine()));
                }
                else// if (Equals(Console.ReadLine(), "n"))
                    c.set_telefono(contactos[i].get_telefono());
              //  else
              //      Console.WriteLine("Opcion no valida");

                contactos[i] = null;
                anyadircontacto(c);
            }

        }

            /*borrar contacto*/
        public void borrarcontacto(Contacto c)
        {
            int i;
               for (i = 0; i < 100 && (!(Equals(contactos[i].get_nombre(), c.get_nombre())) || !(Equals(contactos[i].get_telefono(), c.get_telefono()))); i++);
     
            contactos[i] = null;

            for (i = 0; i < 100; i++)
            {
                if(contactos[i]==null)
                for(int j = i; j < 100; j++)
                    {
                        if (!Equals(contactos[j], null))
                        {
                            contactos[i] = contactos[j];
                            contactos[j] = null;
                            i++;
                        }

                    }
            }
            
        }

    }
}
