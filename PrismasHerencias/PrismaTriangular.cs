using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismasHerencias
{
    class PrismaTriangular:Prisma
    {

        public PrismaTriangular(byte ladosBase, double lado, double altura):base(ladosBase, lado, altura)
        {

        }
        /*areaBase Devuelve el área de la base de un prisma cuadrangular.
          volumen Devuelve el volumen del prisma cuadrangular.
          mostrarDatos Devuelve un string con los datos del prisma cuadrangular*/

        public float areaBase() /*area de la base de un prisma triangular*/
        {
            return (float)((Math.Sqrt(3)/4)*(this.lado*this.lado));
        }
        public double volumen() /*volumen del prisma triangular*/
        {
            return (areaBase() * this.altura);
        }

        /*mostrarDatos*/
        public override string mostrarDatos()
        {
            return base.mostrarDatos() + "\nAreaBase:\t\t"+ areaBase() + "\nVolumen:\t\t"  + volumen();
        }
    }
        
}
