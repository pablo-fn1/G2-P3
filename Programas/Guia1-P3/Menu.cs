using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia1_P3
{
    public class Menu
    {
        public void interfaz()
        {
            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(8, 4); Console.WriteLine("--------------------------------------");
                Console.SetCursorPosition(13, 6); Console.WriteLine("P3 M E N U");
                Console.SetCursorPosition(10, 8); Console.WriteLine("1.  Calcular Promedio");
                Console.SetCursorPosition(10, 10); Console.WriteLine("2.  Calcular Pulsaciones");
                Console.SetCursorPosition(10, 12); Console.WriteLine("3.  Información Financiera");
                Console.SetCursorPosition(10, 14); Console.WriteLine("4. Salir");
                Console.SetCursorPosition(8, 16); Console.WriteLine("--------------------------------------");
                Console.SetCursorPosition(12, 18); Console.WriteLine("Seleccione una opcion [   ]");
                Console.SetCursorPosition(36, 18); op = int.Parse(Console.ReadLine());


                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Promedio prom = new Promedio();
                        prom.CapturarNotas();
                        prom.ImprimirResultados();
                        break;

                    case 2:
                        Console.Clear();
                        Pulsaciones pul = new Pulsaciones();
                        pul.CapturarDatos();
                        pul.ImprimirResultados();

                        break;

                    case 3:
                        Console.Clear();
                        GestorCuentaBancaria banc = new GestorCuentaBancaria();
                        banc.Ejecutar();

                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Hasta la proxima!");
                        Console.ReadKey();
                        break;
                }
            } while (op != 5);
        }
    }
}

