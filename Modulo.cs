using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Interfaces;

namespace Calculadora.Clases
{
    public class Modulo : Operacion
    {
        public Modulo(float op1, float op2) : base(op1, op2)
        {
        }

        public override float Calcular(float operando1, float operando2)
        {
            if (operando2 == 0)
            {
                throw new DivideByZeroException("No se puede calcular el módulo con divisor cero");
            }
            return operando1 % operando2;
        }

        public override string GetSimbolo()
        {
            return "%";
        }
    }
}