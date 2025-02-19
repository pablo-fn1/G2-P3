using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1_P3
{
    public class Pulsaciones
    {
        // Variables
        public string nombre;
        public int edad;
        public char sexo;

        // Función para capturar datos
        public void CapturarDatos()
        {
            Console.WriteLine("CAPTURA DE DATOS");
            Console.Write("Nombre: "); nombre = Console.ReadLine();
            Console.Write("Edad: "); edad = int.Parse(Console.ReadLine());
            Console.Write("Sexo (M/F): "); sexo = char.Parse(Console.ReadLine().ToUpper());
            Console.Clear();
            Console.WriteLine("Datos capturados satisfactoriamente ... ");
            Console.ReadKey();
            Console.Clear();
        }

        // Función para calcular pulsaciones
        private float CalcularPulsaciones()
        {
            if (sexo == 'F')
            {
                return (220 - edad) / 10.0f;
            }
            return (210 - edad) / 10.0f;
        }

        // Función para imprimir los resultados
        public void ImprimirResultados()
        {
            Console.SetCursorPosition(8, 6); Console.WriteLine("Reporte de Pulsaciones");

            Console.SetCursorPosition(8, 8); Console.Write("Nombre");
            Console.SetCursorPosition(18, 8); Console.Write("Edad");
            Console.SetCursorPosition(28, 8); Console.Write("Sexo");
            Console.SetCursorPosition(38, 8); Console.Write("Pulsaciones");

            Console.SetCursorPosition(8, 9); Console.Write("------------------------------------------------------");

            Console.SetCursorPosition(8, 10); Console.Write(nombre);
            Console.SetCursorPosition(20, 10); Console.Write(edad);
            Console.SetCursorPosition(30, 10); Console.Write(sexo);
            Console.SetCursorPosition(42, 10); Console.Write(CalcularPulsaciones());

            Console.SetCursorPosition(8, 11); Console.Write("------------------------------------------------------");

            Console.ReadKey();
        }
    }
}

