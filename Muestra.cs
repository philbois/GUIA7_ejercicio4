using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIA7_ejercicio4
{
    internal class Muestra
    {
        int maximo, minimo, cont, acum;
        double promedio;
        //Cantidad de muestras, Máximo Valor, Mínimo Valor, promedio.
        public void Ingreso(int num, int cont)
        {
            this.cont = cont;
            if (acum == 0) minimo = num;
            acum += num;
            if (num<minimo) minimo = num;
            if (num>maximo) maximo = num;
           
        }
        public double Promedio()
        {
            promedio = acum * 1.0 / cont * 1.0;
            return promedio;
        }
        public int Maximo()
        {
            return maximo;
        }
        public int Minimo()
        {
            return minimo;
        }
    }
}
