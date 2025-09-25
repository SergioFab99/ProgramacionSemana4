using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la Calculadora App");

            Clases.Calculadora calculadora = new Clases.Calculadora();

            calculadora.AgregarOperacion(new Clases.Suma(0, 0));
            calculadora.AgregarOperacion(new Clases.Resta(0, 0));
            calculadora.AgregarOperacion(new Clases.Multiplicacion(0, 0));
            calculadora.AgregarOperacion(new Clases.Division(0, 0));
            calculadora.AgregarOperacion(new Clases.Modulo(0, 0));

            calculadora.Ejecutar();
        }
    }
}