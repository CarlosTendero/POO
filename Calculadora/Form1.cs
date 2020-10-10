using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {

        private enum Entrada
        {
            NINGUN,                     /*ninguna entrada*/
            DIGITO,                     /*se ha introducido un digito*/
            OPERADOR,                   /*se ha introducido un operador*/
            CE
        }

        private Entrada UltimaEntrada;  /*variable Entrada*/
        private bool ComaDec;           /*variable coma decimal*/
        private char Operador;          /*variable operador*/
        private double Operando1;       /*variable para guardar el primer operador*/
        private double Operando2;       /*variable para guardar el segundo operando*/
        private byte NumOperandos;      /*variable para guardar el numero de operandos*/



       
        public Calculadora()        
        {
            InitializeComponent();          /*inicializar la calculadora*/
            UltimaEntrada = Entrada.NINGUN;
            ComaDec = false;
            Operador = '\0';
            Operando1 = 0;
            Operando2 = 0;
            NumOperandos = 0;
        }

        private void botondigito(object sender, EventArgs e) /*Evento para los digitos*/
        {
            Button objboton = (Button)sender;                /*variable objeto auxiliar*/

            if (UltimaEntrada != Entrada.DIGITO)
            {
                if ((objboton.Text == "0") && (NumOperandos == 0))
                    return;

                Pantalla.Text = " ";
                UltimaEntrada = Entrada.DIGITO;
                ComaDec = false;

            }
            Pantalla.Text += objboton.Text;

        }

        private void btBorrarEnt(object sender, EventArgs e)    /*evento para borrar lo ultimo introducido*/
        {
            
                Button objeto = (Button)sender;
                string text = objeto.Text;

                if (text[0] == '+' && text[0] == '-' && text[0] == '*' && text[0] == '/' && text[0] == '%') /*lo ultimo introducido es un operador */
                    Pantalla.Text = "0";

                else
                    Pantalla.Text = Convert.ToString(Operando1);
            if (UltimaEntrada != Entrada.CE)
            {
                UltimaEntrada = Entrada.CE;
                ComaDec = false;
            }
            
        }

        private void btClear(object sender, EventArgs e)
        {

            Pantalla.Text = "0";
            UltimaEntrada = Entrada.NINGUN;
            ComaDec = false;
            Operador = '\0';
            Operando1 = 0;
            Operando2 = 0;
            NumOperandos = 0;
        }

        private void btComa(object sender, EventArgs e)
        {
            if (UltimaEntrada != Entrada.DIGITO)          /*control de errores*/          
            {
                Pantalla.Text = "0,";
                UltimaEntrada = Entrada.DIGITO;
            }
            else if (ComaDec == false)                    /*control de errores*/
                Pantalla.Text = Pantalla.Text + ",";
            ComaDec = true;

        }

        private void btOperacion(object sender, EventArgs e)
        {
            if(UltimaEntrada!= Entrada.OPERADOR){       /*control de errores*/
            Button objeto = (Button)sender;
            string text = objeto.Text;
            Operando1 = Convert.ToDouble(Pantalla.Text);
            switch (text[0])
            {
                case '+':   /*suma*/
                    Operando2 += Operando1;
                    Pantalla.Text = Convert.ToString(Operando1) + '+';

                        Operador = '+';
                        NumOperandos++;
                    break;


                case '-':   /*resta*/
                        if(Operando2 != 0.00)
                            Operando2 -= Operando1;                        
                        else
                            Operando2 += Operando1;
                        Pantalla.Text = Convert.ToString(Operando1) + '-';

                        Operador = '-';
                        NumOperandos++;
                    break;


                case 'X':   /*multiplicar*/
                        if(Operando2 != 0.00)
                            Operando2 *= Operando1;
                        else
                            Operando2 += Operando1;                   
                        Pantalla.Text = Convert.ToString(Operando1) + '*';

                        Operador = '*';
                        NumOperandos++;
                    break;


                case '/':   /*dividir*/
                        if(Operando2 != 0.00)
                            Operando2 /= Operando1;
                        else
                            Operando2 += Operando1;
                        Pantalla.Text = Convert.ToString(Operando1) + '/';

                        Operador = '/';
                        NumOperandos++;
                    break;


                case '%':   /*porcentaje*/

                        switch (Operador)
                        {
                            case '+':               /*porcentaje-suma*/
                                Operando2 = (Operando1 * Operando2) / 100;
                                Pantalla.Text = Convert.ToString(Operando2);
                                Operando2 += Operando1;
                                break;

                            case '-':               /*porcentaje-resta*/
                                Operando2 = (Operando1 * Operando2) / 100;
                                Pantalla.Text = Convert.ToString(Operando2);
                                Operando2 -= Operando1;
                                break;

                            case '*':               /*porcentaje-multiplicar*/
                                Operando2 = (Operando1 * Operando2) / 100;
                                Pantalla.Text = Convert.ToString(Operando2);
                                Operando2 *= Operando1;
                                break;

                            default:
                                Pantalla.Text = "3RR0R";
                                break;
                        }

                        Operador = '%';
              
                    break;


                case '=':   /*igual*/
                        if (NumOperandos != 0)
                        {
                            switch (Operador)
                            {
                                case '+':       /*resultado de la suma*/

                                    Operando2 += Operando1;
                                    Pantalla.Text = Convert.ToString(Operando2);
                                    break;

                                case '-':       /*resultado de la resta*/

                                    Operando2 -= Operando1;
                                    Pantalla.Text = Convert.ToString(Operando2);
                                    break;

                                case '*':       /*resultado de la multiplicacion*/

                                    Operando2 *= Operando1;
                                    Pantalla.Text = Convert.ToString(Operando2);
                                    break;

                                case '/':       /*resultado de dividir*/
                                    if (Operando1 == 0.00)
                                        Pantalla.Text = "3RR0R";
                                    else
                                    {
                                        Operando2 /= Operando1;
                                        Pantalla.Text = Convert.ToString(Operando2);
                                    }
                                    break;

                                case '%':
                                    break;

                                default:
                                    Pantalla.Text = "3RR0R";
                                    break;

                            }
                            Operando2 = 0.00;
                            NumOperandos = 0;
                            Operador = '=';
                        }
                    
                    break;
               

            }
                if (Operador != '=' && Operador != '%')        
                    UltimaEntrada = Entrada.OPERADOR;
                else
                    UltimaEntrada = Entrada.NINGUN;             /*casos especiales*/
            }
        }
    }
}