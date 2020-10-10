using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tienda
{
    class Lavadoras : Electrodomestico
    {
        private Byte nprogramas;        /*numero de programas*/
        private uint nrevoluciones;     /*numero de revoluciones*/

        /*constructor vacio*/
        public Lavadoras()
        {
        }
        /*constructor parametrizado*/
        public Lavadoras(string fabricante, string modelo, float precio, Byte anyos, char clasificacion, uint capacidad, Byte nprogramas, uint nrevoluciones) : base(fabricante, modelo, precio, anyos, clasificacion, capacidad)
        {
            this.nprogramas = nprogramas;
            this.nrevoluciones = nrevoluciones;
        }
        /*Obtiene el numero de programas*/
        public Byte get_nprogramas()
        {
            return this.nprogramas;
        }
        /*Actualizo el numero de programas*/
        public void set_nprogramas(Byte nprogramas)
        {
            this.nprogramas = nprogramas;
        }
        /*Obtiene el numero de revoluciones*/
        public uint get_nrevoluciones()
        {
            return this.nrevoluciones;
        }
        /*Actualizo el numero de revoluciones*/
        public void set_nrevoluciones(uint nrevoluciones)
        {
            this.nrevoluciones = nrevoluciones;
        }

        public override void mostrardatos()
        {
            Console.WriteLine("\nLavadora");
            base.mostrardatos();
            Console.WriteLine("\nNumero de Programas:\t{0}\nNumero de Revoluciones:\t{1}", this.get_nprogramas(), this.get_nrevoluciones());
        }

        public override string escribirdatos()
        {
            return base.escribirdatos() + "\nNumero de Programas:\t" + this.get_nprogramas() + "\nNumero de Revoluciones:\t" + this.get_nrevoluciones();
        }
    }
}


