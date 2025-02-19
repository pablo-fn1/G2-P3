using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1_P3
{
    public class Promedio
    {
        //constantes
        public const float PORC_NOTA1 = 0.3f;
        public const float PORC_NOTA2 = 0.3f;
        public const float PORC_NOTA3 = 0.4f;

        // variables 
        public string nombre;
        public float nota1;
        public float nota2;
        public float nota3;


        //funciones 
        public void CapturarNotas()
        {
            Console.WriteLine("CAPTURA DE NOTAS");
            Console.Write("Nombre: "); nombre = Console.ReadLine();
            Console.Write("notas 1: "); nota1 = float.Parse(Console.ReadLine());
            Console.Write("notas 2: "); nota2 = float.Parse(Console.ReadLine());
            Console.Write("notas 3: "); nota3 = float.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("datos capturados satisfactoriamente ... ");
            Console.ReadKey();
            Console.Clear();
        }
        private float CalcularDefinitiva()
        {
            float definitiva;
            definitiva = nota1 * PORC_NOTA1 + nota2 * PORC_NOTA2 + nota3 * PORC_NOTA3;

            return definitiva;
        }
        private string Estado()
        {
            if (CalcularDefinitiva() >= 3)
            {
                return "Eres una persona feliz ...";
            }
            return "siga intentando ...";
        }

        public void ImprimirResultados()
        {
            Console.SetCursorPosition(8, 6); Console.WriteLine("Reporte de Notas");

            Console.SetCursorPosition(8, 8); Console.Write("Nombre");
            Console.SetCursorPosition(18, 8); Console.Write("Primer Parcial");
            Console.SetCursorPosition(33, 8); Console.Write("Segundo Parcial");
            Console.SetCursorPosition(50, 8); Console.Write("Examen Final");
            Console.SetCursorPosition(67, 8); Console.Write("Definitiva");

            Console.SetCursorPosition(8, 9); Console.Write("-------------------------------------------------------------------------");

            Console.SetCursorPosition(8, 10); Console.Write(nombre);
            Console.SetCursorPosition(25, 10); Console.Write(nota1);
            Console.SetCursorPosition(40, 10); Console.Write(nota2);
            Console.SetCursorPosition(55, 10); Console.Write(nota3);
            Console.SetCursorPosition(69, 10); Console.Write(CalcularDefinitiva());
            Console.SetCursorPosition(8, 11); Console.Write("-------------------------------------------------------------------------");

            Console.SetCursorPosition(37, 12); Console.WriteLine("Estado : " + Estado());

            Console.ReadKey();
        }
    }
}
