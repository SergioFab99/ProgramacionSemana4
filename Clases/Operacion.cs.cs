using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Interfaces;

namespace Calculadora.Clases
{
    // Clase interna por defecto (sin 'public')
    public abstract class Operacion : ICalculadora
    {
        // ...existing code...
        protected float operando1;
        protected float operando2;

        // Constructor protegido (solo heredado)
        protected Operacion(float op1, float op2)
        {
            operando1 = op1;
            operando2 = op2;
        }

        // Métodos abstractos ahora protegidos
        protected abstract float Calcular(float operando1, float operando2);
        protected abstract string GetSimbolo();

        // Implementación explícita de la interfaz (no es pública)
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