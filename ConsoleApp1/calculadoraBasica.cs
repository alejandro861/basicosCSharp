using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   /* Public */ class CalculadoraBasica
    {
        private double ultimoResultado;
        public double Sumar(double primerValor, double segundoValor)
        {
            return primerValor+segundoValor;
        }
        public double Dividir(double primerValor, double segundoValor)
        {
            return primerValor/segundoValor;
        }
    }

}
