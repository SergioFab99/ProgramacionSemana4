using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Interfaces
{
    interface ICalculadora
    {
        float Calcular(float operando1, float operando2);
        string GetSimbolo();
    }
}