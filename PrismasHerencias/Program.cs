using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismasHerencias
{
    class Program
    {
        static void Main(string[] args)
        {

            /*El programa principal deberá crear un prisma regular de cada una de las clases, 
             * una vez creados los cuatro objetos e insertados en ellos sus datos mediante el constructor o pidiento
             * los datos por teclado, listar por pantalla todos la información posible de cada prisma.
             *  
                A continuación, el programa deberá crear otro prisma regular de cada una de las clases insertándolas 
                en un vector de objetos de la clase Prisma con 4 elementos.
                na vez creados los cuatro objetos e insertados en el vector con sus datos,
                mostrar toda la información de los prismas recorriendo dicho vector en un bucle.*/

            PrismaTriangular triangular;
            PrismaCuadrangular cuadrangular;
            PrismaPentagonal pentagonal;
            PrismaHexagonal hexagonal;

            /*prisma triangular*/
            triangular = new PrismaTriangular(3, 10, 30);
            /*prisma cuadrangular*/
            cuadrangular = new PrismaCuadrangular(4, 10, 30);
            /*prisma pentagonal*/
            pentagonal = new PrismaPentagonal(5,10,30);
            /*prisma hexagonal*/
            hexagonal = new PrismaHexagonal(6, 10, 30);

            /*Primera parte*/

            /*Prisma triangular*/
            Console.WriteLine(triangular.mostrarDatos());
            /*Prisma cuadrangular*/
            Console.WriteLine(cuadrangular.mostrarDatos());
            /*Prisma pentagonal*/
            Console.WriteLine(pentagonal.mostrarDatos());
            /*Prisma hexagonal*/
            Console.WriteLine(hexagonal.mostrarDatos());

            Console.ReadKey();

            /*Segunda parte*/

            /*A continuación, el programa deberá crear otro prisma regular de cada una de las clases insertándolas en un vector de objetos 
             * de la clase Prisma con 4 elementos*/

            Prisma[] prismitis = new Prisma[4];
            int i = 0;

            Console.WriteLine("\nSegunda parte: ");
            /*Prisma triangular*/
            prismitis[0] = new PrismaTriangular(3,10,30);
            /*Prisma cuadrangular*/
            prismitis[1] = new PrismaCuadrangular(4, 10, 30);
            /*Prisma pentagonal*/
            prismitis[2] = new PrismaPentagonal(5, 10, 30);
            /*'Prisma hexagonal*/
            prismitis[3] = new PrismaHexagonal(6, 10, 30);

            for (i=0; i < 4; i++)
            {
                Console.WriteLine(prismitis[i].mostrarDatos());
            }

            Console.ReadKey();


        }
    }
}
