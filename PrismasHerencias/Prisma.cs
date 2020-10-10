using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismasHerencias
{
    class Prisma
    {
        /*atributos*/
        protected byte ladosBase;
        protected double lado;
        protected double altura;

        /*constructor*/
        public Prisma(byte ladosBase, double lado, double altura)
        {
            this.ladosBase = ladosBase;                 /*lados de la base*/
            this.lado = lado;                           /*longitud del lado*/
            this.altura = altura;                       /*longitud de la altura*/

        }
        /*constructor vacio*/
        public Prisma()
        {
            
        }

        public double get_lado()                        /*devuelve el lado del prisma*/
        {
            return lado;
        }
        public double get_altura()                      /*devuelve la altura del prisma*/
        {
            return altura;
        }
        public byte get_ladosBase()                     /*devuelve el num de lados de la base*/
        {
            return ladosBase;
        }

        public void set_lado(double lado)               /*actualiza el lado*/
        {
            this.lado = lado;          
        }
        public void set_altura(double altura)           /*actualiza la altura*/
        {
            this.altura = altura;
        }
        public void set_ladosBase(byte ladosBase)       /*actualiza el num de lados de la base*/
        {
            this.ladosBase = ladosBase;
        }
        public int numeroVertices()
        {
            return (2 * get_ladosBase());               /*el numero de vertices es 2 veces los lados de la base*/
        }
        public int numeroAristas ()
        {
            return (3 * get_ladosBase());               /*el numero de aristas es 3 veces los lados de la base*/
        }
        public float areaLateral()
        {
            return (float)((get_altura() * get_ladosBase() * get_lado()));        /*el area lateral es la altura por el perimetro*/
        }
        public  double perimetro()                                                /*devuelve la suma de todos los lados del prisma*/
        {
            return (2 * get_lado() * get_ladosBase() + get_ladosBase() * get_altura());
        }

        virtual public string mostrarDatos()
        {
            string nombre = "";
            if (get_ladosBase() == 3)
                nombre = "Prisma triangular";
            else if (get_ladosBase() == 4)
                nombre = "Prisma cuadrangular";
            else if (get_ladosBase() == 5)
                nombre = "Prisma pentagonal";
            else if (get_ladosBase() == 6)
                nombre = "Prisma hexagonal";

            return nombre + "\n\nLados base:\t\t" + get_ladosBase() + "\nLongitud lado:\t\t" + get_lado() + "\nLongitud altura:\t" + get_altura();
        }

    }





}

    
    