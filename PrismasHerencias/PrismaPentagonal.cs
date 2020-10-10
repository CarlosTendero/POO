using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismasHerencias
{
    class PrismaPentagonal:Prisma
    {
        public PrismaPentagonal(byte ladosBase, double lado, double altura):base(ladosBase, lado, altura)
        {
   
        }
        /*areaBase Devuelve el área de la base de un prisma pentagonal.
        volumen Devuelve el volumen del prisma pentagonal.
        mostrarDatos Devuelve un string con los datos del prisma pentagonal .*/

        public float areaBase() /*area de la base de un prisma pentagonal*/
        {
            return (float)((this.ladosBase* this.lado * apotema())/2);
        }
        public double volumen() /*volumen del prisma pentagonal*/
        {
            return (areaBase() * this.altura);
        }
        /*mostrarDatos*/
        public override string mostrarDatos()
        {
            return base.mostrarDatos() + "\nAreaBase:\t\t" + areaBase() + "\nVolumen:\t\t" + volumen();
        }
        private float apotema() /*apotema del prisma pentagonal*/
        {
            return (float)(this.lado/1.45);
        }
 
    }
}
