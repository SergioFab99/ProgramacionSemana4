using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Interfaces;

namespace Calculadora.Clases
{
    public abstract class Operacion : ICalculadora
    {
        protected float operando1;
        protected float operando2;

        public Operacion(float op1, float op2)
        {
            operando1 = op1;
            operando2 = op2;
        }

        public abstract float Calcular(float operando1, float operando2);
        public abstract string GetSimbolo();

        // Implementación explícita de la interfaz
        float ICalculadora.Calcular(float op1, float op2)
        {
            return Calcular(op1, op2);
        }

        string ICalculadora.GetSimbolo()
        {
            return GetSimbolo();
        }
    }
}