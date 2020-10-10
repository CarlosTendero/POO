using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrismasRegulares
{
    class Program
    {
        static void Main(string[] args)
        {
            Prisma triangular, cuadrangular, pentagonal, hexagonal;
            /*prisma triangular*/
            triangular = new Prisma(3, 10, 30);
            /*prisma cuadrangular*/
            cuadrangular = new Prisma(4, 10, 30);
            /*prisma pentagonal*/
            pentagonal = new Prisma();
            double aux = 0;

            pentagonal.set_ladosBase(5);
            
            while (aux <= 0)
            {
                try
                {
                    Console.WriteLine("Introduzca la longitud del lado (pentagonal)");
                    aux = Convert.ToDouble(Console.ReadLine());
                    if (aux <= 0)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception) /*control de errores*/
                {
                    Console.WriteLine("El valor introducido es menor o igual que 0.");
                }
                finally
                {
                    pentagonal.set_lado(aux);
                }
            }

            aux = 0;

            while (aux <= 0)
            {
                try
                {
                    Console.WriteLine("Introduzca la altura (pentagonal)");
                    aux = Convert.ToDouble(Console.ReadLine());
                    if (aux <= 0)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception) /*control de errores*/
                {
                    Console.WriteLine("El valor introducido es menor o igual que 0.");
                }
                finally
                {
                    pentagonal.set_altura(aux);
                }
            }


            /*prisma hexagonal*/
            hexagonal = new Prisma();

            hexagonal.set_ladosBase(6);

            aux = 0;

            while (aux <= 0)
            {
                try
                {
                    Console.WriteLine("Introduzca la longitud del lado (hexagonal)");
                    aux = Convert.ToDouble(Console.ReadLine());
                    if (aux <= 0)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception) /*control de errores*/
                {
                    Console.WriteLine("El valor introducido es menor o igual que 0.");
                }
                finally
                {
                    hexagonal.set_lado(aux);
                }
            }

            aux = 0;
           
            while (aux <= 0)
            {
                try
                {
                    Console.WriteLine("Introduzca la altura (hexagonal)");
                    aux = Convert.ToDouble(Console.ReadLine());
                    if (aux <= 0)
                    {
                        throw new Exception();
                    }
                }
                catch (Exception) /*control de errores*/
                {
                    Console.WriteLine("El valor introducido es menor o igual que 0.");
                }
                finally
                {
                    hexagonal.set_altura(aux);
                }
            }


            /*Prisma triangular*/

            Console.WriteLine("\nNúmero de vertices prisma triangular: {0}",triangular.numeroVertices());
            Console.WriteLine("\nNúmero de aristas prisma triangular: {0}", triangular.numeroAristas());
            Console.WriteLine("\nArea lateral del prisma triangular: {0}", triangular.areaLateral());
            Console.WriteLine("\nPerímetro del prisma triangular: {0}", triangular.perimetro());
            
            /*Prisma cuadrangular*/

            Console.WriteLine("\nNúmero de vertices prisma cuadrangular: {0}", cuadrangular.numeroVertices());
            Console.WriteLine("\nNúmero de aristas prisma cuadrangular: {0}", cuadrangular.numeroAristas());
            Console.WriteLine("\nArea lateral del prisma cuadrangular: {0}", cuadrangular.areaLateral());
            Console.WriteLine("\nPerímetro del prisma cuadrangular: {0}", cuadrangular.perimetro());
            /*Prisma pentagonal*/

            Console.WriteLine("\nNúmero de vertices prisma pentagonal: {0}", pentagonal.numeroVertices());
            Console.WriteLine("\nNúmero de aristas prisma pentagonal: {0}", pentagonal.numeroAristas());
            Console.WriteLine("\nArea lateral del prisma pentagonal: {0}", pentagonal.areaLateral());
            Console.WriteLine("\nPerímetro del prisma pentagonal: {0}", pentagonal.perimetro());
            /*Prisma hexagonal*/

            Console.WriteLine("\nNúmero de vertices prisma hexagonal: {0}", hexagonal.numeroVertices());
            Console.WriteLine("\nNúmero de aristas prisma hexagonal: {0}", hexagonal.numeroAristas());
            Console.WriteLine("\nArea lateral del prisma hexagonal: {0}", hexagonal.areaLateral());
            Console.WriteLine("\nPerímetro del prisma hexagonal: {0}", hexagonal.perimetro());


            Console.ReadKey();

            
        }
    }
}
