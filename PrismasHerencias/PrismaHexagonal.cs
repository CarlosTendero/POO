using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismasHerencias
{
    class PrismaHexagonal:Prisma
    {
        public PrismaHexagonal(byte ladosBase, double lado, double altura):base(ladosBase, lado, altura)
        {

        }
        /*areaBase Devuelve el área de la base de un prisma hexagonal.
            volumen Devuelve el volumen del prisma hexagonal.
            mostrarDatos Devuelve un string con los datos del prisma hexagonal.*/
        
        public float areaBase() /*area de la base de un prisma hexagonal*/
        {
            return (float)(3 * this.lado * apotema());
        }

        public double volumen() /*volumen del prisma hexagonal*/
        {
            return (areaBase()*this.altura);
        }
        /*mostrarDatos*/

        public override string mostrarDatos()
        {
            return base.mostrarDatos() + "\nAreaBase:\t\t" + areaBase() + "\nVolumen:\t\t" + volumen();
        }

        private float apotema() /*apotema del prisma hexagonal*/
        {
            return (float)((Math.Sqrt(3) * this.lado) / 2);
        }
    }
}
