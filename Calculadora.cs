using System;
using System.Collections.Generic;
using Calculadora.Interfaces;

namespace Calculadora.Clases
{
    class Calculadora
    {
        private List<ICalculadora> operaciones;

        internal Calculadora()
        {
            operaciones = new List<ICalculadora>();
        }

        internal void AgregarOperacion(ICalculadora operacion)
        {
            operaciones.Add(operacion);
        }

        private void MostrarMenu()
        {
            Console.WriteLine("\n=== CALCULADORA ===");
            Console.WriteLine("Seleccione una operación:");
            for (int i = 0; i < operaciones.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {operaciones[i].GetSimbolo()}");
            }
            Console.WriteLine($"{operaciones.Count + 1}. Salir");
            Console.Write("Opción: ");
        }

        internal void Ejecutar()
        {
            bool continuar = true;

            while (continuar)
            {
                try
                {
                    MostrarMenu();
                    string opcionStr = Console.ReadLine();

                    if (!int.TryParse(opcionStr, out int opcion))
                    {
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        continue;
                    }

                    if (opcion == operaciones.Count + 1)
                    {
                        continuar = false;
                        Console.WriteLine("¡Gracias por usar la calculadora!");
                        break;
                    }

                    if (opcion < 1 || opcion > operaciones.Count)
                    {
                        Console.WriteLine("Opción fuera de rango. Intente nuevamente.");
                        continue;
                    }

                    Console.Write("Ingrese el primer número: ");
                    if (!float.TryParse(Console.ReadLine(), out float num1))
                    {
                        Console.WriteLine("Número inválido. Intente nuevamente.");
                        continue;
                    }

                    Console.Write("Ingrese el segundo número: ");
                    if (!float.TryParse(Console.ReadLine(), out float num2))
                    {
                        Console.WriteLine("Número inválido. Intente nuevamente.");
                        continue;
                    }

                    ICalculadora operacionSeleccionada = operaciones[opcion - 1];
                    float resultado = operacionSeleccionada.Calcular(num1, num2);

                    Console.WriteLine($"Resultado: {num1} {operacionSeleccionada.GetSimbolo()} {num2} = {resultado}");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error inesperado: {ex.Message}");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}