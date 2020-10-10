using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda
{
    class Contacto
    {
        private String nombre;          /*nombre*/
        private uint telefono;          /*telefono*/


        public Contacto(String n, uint t)
        {
            nombre = n;         /*nombre*/
            telefono = t;       /*telefono*/
        }

        public Contacto()
        {
     
        }


        public String get_nombre()  /*Obtengo el nombre*/
        {
            return nombre;
        }
        public uint get_telefono()  /*Obtengo el telefono*/
        {
            return telefono;
        }
        public void set_nombre(String n)    /*actualizo el nombre*/
        {
            nombre = n;
        }
        public void set_telefono(uint t)    /*actualizo el telefono*/
        {
            telefono = t;
        }

    }
}
