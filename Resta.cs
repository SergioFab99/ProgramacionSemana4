using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Interfaces;

namespace Calculadora.Clases
{
    class Resta : Operacion
    {
        internal Resta(float op1, float op2) : base(op1, op2)
        {
        }

        protected override float Calcular(float operando1, float operando2)
        {
            return operando1 - operando2;
        }

        protected override string GetSimbolo()
        {
            return "-";
        }
    }
}