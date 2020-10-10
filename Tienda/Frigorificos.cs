using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Frigorificos: Electrodomestico
    {
        private Byte alto;              /*alto*/
        private Byte ancho;             /*ancho*/
        private Byte fondo;             /*fondo*/

        /*constructor vacio*/
        public Frigorificos()
        {

        }
        /*constructor parametrizado*/
        public Frigorificos(string fabricante, string modelo, float precio, Byte anyos, char clasificacion, uint capacidad, Byte alto, Byte ancho, Byte fondo) : base(fabricante,modelo,precio,anyos,clasificacion,capacidad)
        {
            this.alto = alto;
            this.ancho = ancho;
            this.fondo = fondo;
        }

        /*Obtengo el alto*/
        public Byte get_alto()
        {
            return this.alto;
        }
        /*Actualizo el alto*/
        public void set_alto(Byte alto)
        {
            this.alto = alto;
        }
        /*Obtengo el ancho*/
        public Byte get_ancho()
        {
            return this.ancho;
        }
        /*Actualizo el ancho*/
        public void set_ancho(Byte ancho)
        {
            this.ancho = ancho;
        }
        /*Obtengo el fondo*/
        public Byte get_fondo()
        {
            return this.fondo;
        }
        /*Actualizo el fondo*/
        public void set_fondo(Byte fondo)
        {
            this.fondo = fondo;
        }

        public override void mostrardatos()
        {
            Console.WriteLine("\nFrigorifico");
            base.mostrardatos();
            Console.WriteLine("\nAlto:\t{0}\nAncho:\t{1}\nFondo:\t{2}", this.get_alto(), this.get_ancho(), this.get_fondo());
        }
        public override string escribirdatos()
        {
            return base.escribirdatos() + "\nAlto:\t" + this.get_alto() + "\nAncho:\t" + this.get_ancho() + "\nFondo:\t" + this.get_fondo();
        }
    }
}
