using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismasHerencias
{
    class PrismaCuadrangular:Prisma {

        public PrismaCuadrangular(byte ladosBase, double lado, double altura):base(ladosBase, lado, altura)
        {

        }   

        /*  areaBase Devuelve el área de la base de un prisma cuadrangular.
            volumen Devuelve el volumen del prisma cuadrangular.
            mostrarDatos Devuelve un string con los datos del prisma cuadrangular*/

        public float areaBase() /*area de la base de un prisma cuadrangular*/
        {
            return  (float)(this.lado*this.lado);
        }
        public double volumen() /*volumen de un prisma cuadrangular*/
        {
            return (areaBase()*this.altura);
        }
        /*mostrarDatos*/
        public override string mostrarDatos()
        {
            return base.mostrarDatos() + "\nAreaBase:\t\t" + areaBase() + "\nVolumen:\t\t" + volumen();
        }
    }
}