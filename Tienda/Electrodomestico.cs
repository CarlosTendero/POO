

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Tienda
{
    class Electrodomestico
    {
        protected string fabricante;  /*fabricante*/
        protected string modelo;      /*modelo*/
        protected float precio;       /*precio*/
        protected Byte anyos;         /*anyos*/
        protected char clasificacion; /*clasificacion*/
        protected uint capacidad;     /*capacidad*/

        Frigorificos[] frigorificos = new Frigorificos[100];    /*array de frigorificos*/
        Lavadoras[] lavadoras = new Lavadoras[100];             /*array de lavadoras*/
        Lavavajillas[] lavavajillas = new Lavavajillas[100];    /*array de lavavajillas*/
        /*constructor vacio*/
        public Electrodomestico()
        {

        }
        /*constructor parametrizado*/
        public Electrodomestico(string fabricante, string modelo, float precio, Byte anyos, char clasificacion, uint capacidad)
        {

            this.fabricante = fabricante;
            this.modelo = modelo;
            this.precio = precio;
            this.anyos = anyos;
            this.clasificacion = clasificacion;
            this.capacidad = capacidad;

        }

        /*Obtiene el fabricante*/
        public string get_fabricante()
        {
            return this.fabricante;
        }
        /*Actualiza el estado*/
        public void set_fabricante(string fabricante)
        {
            this.fabricante = fabricante;
        }
        /*Obtiene el modelo*/
        public string get_modelo()
        {
            return this.modelo;
        }
        /*actualizo el modelo*/
        public void set_modelo(string modelo)
        {
            this.modelo = modelo;
        }
        /*Obtiene el precio*/
        public float get_precio()
        {
            return this.precio;
        }
        /*Actualizo el precio*/
        public void set_precio(float precio)
        {
            this.precio = precio;
        }
        /*Obtiene los anyos*/
        public Byte get_anyos()
        {
            return this.anyos;
        }
        /*Actualizo el precio*/
        public void set_anyos(Byte anyos)
        {
            this.anyos = anyos;
        }
        /*Obtiene la clasificacion*/
        public char get_clasificacion()
        {
            return this.clasificacion;
        }
        /*Actualizo la clasificacion*/
        public void set_clasificacion(char clasificacion)
        {
            this.clasificacion = clasificacion;
        }
        /*Obitne la capacidad*/
        public uint get_capacidad()
        {
            return this.capacidad;
        }
        /*Actualizo la capacidad*/
        public void set_capacidad(uint capacidad)
        {
            this.capacidad = capacidad;
        }

        /*Mostrar datos*/
        virtual public void mostrardatos()
        {
            Console.WriteLine("\nFabricante:\t{0}\nModelo:\t{1}\nPrecio:\t{2} euros\nGarantia:\t{3} anyos\nClasificacion energetica:\t{4}\nCapacidad:\t{5} litros", this.get_fabricante(), this.get_modelo(), this.get_precio(), this.get_anyos(), this.get_clasificacion(), this.get_capacidad());
        }

        virtual public string escribirdatos()
        {
            return "\nFabricante:\t" + this.get_fabricante() + "\nModelo:\t" + this.get_modelo() + "\nPrecio:\t" + this.get_precio()+ "  euros" + "\nAnyos:\t" + this.get_anyos()+ " garantia" + "\nClasificacion energetica:\t" + this.get_clasificacion() + "\nCapacidad:\t" + this.get_capacidad();
        }

        /*Introducir frigorifico*/
        public byte introducir_frigorifico(Frigorificos frigorifico)
        {          
                int i = 0;
                for (i = 0; i < 100 && !(Equals(frigorificos[i], null)); i++)
                {
                if ((Equals(frigorifico.get_fabricante(), frigorificos[i].get_fabricante())) && (Equals(frigorifico.get_modelo(), frigorificos[i].get_modelo())))
                {
                    Console.WriteLine("\nYa existe un frigorifico con estos datos, no se puede anyadir");
                    return 0;

                }
            }
            if (i == 100)                                  /*esta llenao el array*/
            {
                Console.WriteLine("\nFrigorifico lleno");
                return 0;
            }
            else
            {
                frigorificos[i] = frigorifico;
                return 1;
            }

        }

        /*Introducir lavadora*/
        public byte introducir_lavadora(Lavadoras lavadora)
        {
            int i = 0;
            for (i = 0; i < 100 && !(Equals(lavadoras[i], null)); i++)
            {
                if ((Equals(lavadora.get_fabricante(), lavadoras[i].get_fabricante())) && (Equals(lavadora.get_modelo(), lavadoras[i].get_modelo())))
                {
                    Console.WriteLine("\nYa existe una con estos datos, no se puede anyadir");
                    return 0;

                }
            }
            if (i == 100)                                  /*esta llenao el array*/
            {
                Console.WriteLine("\nFrigorifico lleno");
                return 0;
            }
            else
            {
                lavadoras[i] = lavadora;
                return 1;
            }

        }
        /*Introducir lavavajillas*/
        public byte introducir_lavavajilla(Lavavajillas lavavajilla)
        {
            int i = 0;
            for (i = 0; i < 100 && !(Equals(lavavajillas[i], null)); i++)
            {
                if ((Equals(lavavajilla.get_fabricante(), lavavajillas[i].get_fabricante())) && (Equals(lavavajilla.get_modelo(), lavavajillas[i].get_modelo())) )
                {
                    Console.WriteLine("\nYa existe un lavavajillas con estos datos, no se puede anyadir");
                    return 0;

                }

            }
            if (i == 100)                                  /*esta llenao el array*/
            {
                Console.WriteLine("\nFrigorifico lleno");
                return 0;
            }
            else
            {
                lavavajillas[i] = lavavajilla;
                return 1;
            }

        }

        /*Listar electrodomesticos*/

        public void listar_electrodomesticos()
        {
            /*Frigorificos*/
            if (get_tamanyo_frigorificos() == 0)
                Console.WriteLine("\nNo hay frigorificos");
            else
            {
                Console.WriteLine("\nListado de Frigorificos: ");
                for (int i = 0; i < 100 && !(Equals(frigorificos[i], null)); i++)
                    frigorificos[i].mostrardatos();
            }
            /*lavadoras*/
            if (get_tamanyo_lavadoras() == 0)
                Console.WriteLine("\nNo hay lavadoras");
            else
            {
                Console.WriteLine("\nListado de Lavadoras: ");
                for (int i = 0; i < 100 && !(Equals(lavadoras[i], null)); i++)
                    lavadoras[i].mostrardatos();
            }
            /*lavavajillas*/
            if (get_tamanyo_lavavajillas() == 0)
                Console.WriteLine("\nNo hay lavavajillas");
            else
            {
                Console.WriteLine("\nListado de lavavajillas: ");
                for (int i = 0; i < 100 && !(Equals(lavavajillas[i], null)); i++)
                    lavavajillas[i].mostrardatos();
            }
        }
        /*borrar frigorifico*/
        public byte borrar_frigorifico(Frigorificos frigorifico)
        {
            int i;
            for (i = 0; i < 100 && (!(Equals(frigorificos[i].get_modelo(), frigorifico.get_modelo ())) || !(Equals(frigorificos[i].get_fabricante(), frigorifico.get_fabricante()))); i++) ;

            frigorificos[i] = null;

            for (i = 0; i < 100; i++)
            {
                if (frigorificos[i] == null)
                    for (int j = i; j < 100; j++)
                    {
                        if (!Equals(frigorificos[j], null))
                        {
                            frigorificos[i] = frigorificos[j];
                            frigorificos[j] = null;
                            i++;
                        }

                    }
            }
            return 1;   /*exito*/

        }
        /*borrar lavadora*/
        public byte borrar_lavadora(Lavadoras lavadora)
        {
            int i;
            for (i = 0; i < 100 && (!(Equals(lavadoras[i].get_modelo(), lavadora.get_modelo())) || !(Equals(lavadoras[i].get_fabricante(), lavadora.get_fabricante()))); i++) ;

            lavadoras[i] = null;

            for (i = 0; i < 100; i++)
            {
                if (lavadoras[i] == null)
                    for (int j = i; j < 100; j++)
                    {
                        if (!Equals(lavadoras[j], null))
                        {
                            lavadoras[i] = lavadoras[j];
                            lavadoras[j] = null;
                            i++;
                        }

                    }
            }
            return 1;   /*exito*/
        }

        /*borrar lavadora*/
        public byte borrar_lavavajilla(Lavavajillas lavavajilla)
        {
            int i;

            for (i = 0; i < 100 && (!(Equals(lavavajillas[i].get_modelo(), lavavajilla.get_modelo())) || !(Equals(lavavajillas[i].get_fabricante(), lavavajilla.get_fabricante()))); i++) ;

            lavavajillas[i] = null;

            for (i = 0; i < 100; i++)
            {
                if (lavavajillas[i] == null)
                    for (int j = i; j < 100; j++)
                    {
                        if (!Equals(lavavajillas[j], null))
                        {
                            lavavajillas[i] = lavavajillas[j];
                            lavavajillas[j] = null;
                            i++;
                        }

                    }
            }
            return 1;   /*exito*/
        }

        /*Buscar frigorifico*/
        public byte buscar_frigorifico(Frigorificos frigorifico)
        {
            byte flag = 0;
            for (int i = 0; i < 100 && !(Equals(frigorificos[i], null)); i++)
            {
                if ((Equals(frigorificos[i].get_fabricante(), frigorifico.get_fabricante() ))&& (Equals(frigorificos[i].get_modelo(), frigorifico.get_modelo())))
                {
                    Console.WriteLine("\nEncontrado\n");
                    Console.WriteLine("\nMarca:\t\t{0}\nModelo:\t{1}", frigorificos[i].get_fabricante(), frigorificos[i].get_modelo());
                    flag = 1;
                }
            }

            if (flag == 0)
                Console.WriteLine("\nFrigorifico no encontrado");

            return flag;
        }

        /*Buscar lavadora*/
        public byte buscar_lavadora(Lavadoras lavadora)
        {
            byte flag = 0;
            for (int i = 0; i < 100 && !(Equals(lavadoras[i], null)); i++)
            {
                if ((Equals(lavadoras[i].get_fabricante(),lavadora.get_fabricante())) && (Equals(lavadoras[i].get_modelo(), lavadora.get_modelo())))
                {
                    Console.WriteLine("\nEncontrado\n");
                    Console.WriteLine("\nMarca:\t\t{0}\nModelo:\t{1}", lavadoras[i].get_fabricante(), lavadoras[i].get_modelo());
                    flag = 1;
                }
            }

            if (flag == 0)
                Console.WriteLine("\nLavadora no encontrado");

            return flag;
        }

        /*Buscar lavavajillas*/
        public byte buscar_lavavajillas(Lavavajillas lavavajilla)
        {
            byte flag = 0;
            for (int i = 0; i < 100 && !(Equals(lavavajillas[i], null)); i++)
            {
                if ((Equals(lavavajillas[i].get_fabricante(), lavavajilla.get_fabricante())) && (Equals(lavavajillas[i].get_modelo(), lavavajilla.get_modelo())))
                {
                    Console.WriteLine("\nEncontrado\n");
                    Console.WriteLine("\nMarca:\t\t{0}\nModelo:\t{1}", lavavajillas[i].get_fabricante(), lavavajillas[i].get_modelo());
                    flag = 1;
                }
            }

            if (flag == 0)
                Console.WriteLine("\nLavavajillas no encontrado");

            return flag;
        }

        /*Devuelve el numero de frigorificos*/
        public SByte get_tamanyo_frigorificos()
        {
            int i;
            for (i = 0; i < 100 && !(Equals(frigorificos[i], null)); i++) ;
            return (SByte)i;
        }
        /*Devuelve el numero de lavadoras*/
        public SByte get_tamanyo_lavadoras()
        {
            int i;
            for (i = 0; i < 100 && !(Equals(lavadoras[i], null)); i++) ;
            return (SByte)i;
        }
        /*Devuelve el numero de lavavajillas*/
        public SByte get_tamanyo_lavavajillas()
        {
            int i;
            for (i = 0; i < 100 && !(Equals(lavavajillas[i], null)); i++) ;
            return (SByte)i;
        }

        /*escribir fichero*/
        public void escribir_fichero()
        {
            /*frigorificos*/
            if (get_tamanyo_frigorificos() != 0)
            {
                StreamWriter fichero_aux; /*fichero*/
                fichero_aux = File.CreateText("Frigorficos.txt");
                for (int i = 0; i < 100 && !(Equals(frigorificos[i], null)); i++)
                    fichero_aux.Write(frigorificos[i].escribirdatos());
                fichero_aux.Close();
            }
            /*lavadoras*/
            if (get_tamanyo_lavadoras() != 0)
            {
                StreamWriter fichero_aux; /*fichero*/
                fichero_aux = File.CreateText("Lavadoras.txt");
                for (int i = 0; i < 100 && !(Equals(lavadoras[i], null)); i++)
                    fichero_aux.Write(lavadoras[i].escribirdatos());
                fichero_aux.Close();
            }
            /*lavavajillas*/
            if (get_tamanyo_lavavajillas() != 0)
            {
                StreamWriter fichero_aux; /*fichero*/
                fichero_aux = File.CreateText("Lavavajillas.txt");
                for (int i = 0; i < 100 && !(Equals(lavavajillas[i], null)); i++)
                    fichero_aux.Write(lavavajillas[i].escribirdatos());
                fichero_aux.Close();
            }

            StreamWriter fichero;

            fichero = File.CreateText("Electrodomesticos.txt");

            fichero.Write("Frigorificos\n");
            if (get_tamanyo_frigorificos() != 0)
            {
                for (int i = 0; i < 100 && !(Equals(frigorificos[i], null)); i++)
                    fichero.Write(frigorificos[i].escribirdatos());
            }
            else
                fichero.Write("\nNo hay frigorificos");
            fichero.Write("\nLavadoras\n");
            if (get_tamanyo_lavadoras() != 0)
            {
                for (int i = 0; i < 100 && !(Equals(lavadoras[i], null)); i++)
                    fichero.Write(lavadoras[i].escribirdatos());
            }
            else
                fichero.Write("\nNo hay lavadoras");
            fichero.Write("\nLavavajillas");
            if (get_tamanyo_lavavajillas() != 0)
            {
                for (int i = 0; i < 100 && !(Equals(lavavajillas[i], null)); i++)
                    fichero.Write(lavavajillas[i].escribirdatos());
            }


            fichero.Close();

        }
    }
}


