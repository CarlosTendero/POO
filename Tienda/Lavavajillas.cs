using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda
{
    class Lavavajillas : Electrodomestico
    {
        private Byte nprogramas;        /*numero de programas*/
        private uint ntemperaturas;     /*numero de temperaturas*/

        
        /*constructor vacio*/
        public Lavavajillas()
        {

        }
        /*Constructor parametrizado*/
        public Lavavajillas(string fabricante, string modelo, float precio, Byte anyos, char clasificacion, uint capacidad, Byte nprogramas, uint ntemperaturas) : base(fabricante, modelo, precio, anyos, clasificacion, capacidad)
        {
            this.nprogramas = nprogramas;
            this.ntemperaturas = ntemperaturas;

        }

        /*Obtengo el numero de programas*/
        public Byte get_nprogramas()
        {
            return this.nprogramas;
        }
        /*Actualizo el numero de progrmas*/
        public void set_nprogramas(Byte nprogramas)
        {
            this.nprogramas = nprogramas;
        }
        /*Obtengo el numero de temperaturas*/
        public uint get_ntemperaturas()
        {
            return this.ntemperaturas;
        }
        /*Actualizo el numero de temperaturas*/
        public void set_ntemperaturas(Byte ntemperaturas)
        {
            this.ntemperaturas = ntemperaturas;
        }

        public override void mostrardatos()
        {
            Console.WriteLine("\nLavavajillas");
            base.mostrardatos();
            Console.WriteLine("\nNumero de Programas:\t{0}\nNumero de programas de Temperaturas:\t{1}", this.get_nprogramas(), this.get_ntemperaturas());
        }

        public override string escribirdatos()
        {
            return base.escribirdatos() + "\nNumero de Programas:\t" + this.get_nprogramas() + "\nNumero de programas de Temperaturas:\t" + this.get_ntemperaturas();
        }


    }
}
