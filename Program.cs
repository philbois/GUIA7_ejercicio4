using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*ENUNCIADO
 Modele una clase llamada Muestra que permita procesar una serie de datos ingresados informando:
Cantidad de muestras, Máximo Valor, Mínimo Valor, promedio.
Utilice esta clase en una aplicación que permita cargar un número N de valores numéricos determinado al inicio por el usuario.
*/
namespace GUIA7_ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Muestra muestra = new Muestra();
            int num1, num;
            Console.WriteLine("ingrese cantidad de numeros");
            num1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <num1 ; i++)
            {
                num=random.Next(10,150);
                muestra.Ingreso(num, num1);

            }
        }
    }
}
