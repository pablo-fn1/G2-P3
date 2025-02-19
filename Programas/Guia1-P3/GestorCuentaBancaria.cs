using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Guia1_P3
{
    public class GestorCuentaBancaria
    {
        private string[] nombres;
        private int[] cuentas;
        private float[] saldos;
        private int totalClientes;

        public GestorCuentaBancaria(int capacidad = 10)
        {
            nombres = new string[capacidad];
            cuentas = new int[capacidad];
            saldos = new float[capacidad];
            totalClientes = 0;
        }

        public void Ejecutar()
        {
            int opcion;
            do
            {
                MostrarMenu();
                Console.SetCursorPosition(7, 12); Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        RegistrarCliente();
                        break;
                    case 2:
                        Consignar();
                        break;
                    case 3:
                        Retirar();
                        break;
                    case 4:
                        ConsultarSaldo();
                        break;
                    case 5:
                        Console.SetCursorPosition(7, 14); Console.Write("Saliendo del sistema...");
                        break;
                    default:
                        Console.SetCursorPosition(7, 14); Console.Write("Opción inválida.");
                        break;
                }
                Console.ReadKey();
            } while (opcion != 5);
        }

        private void MostrarMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(8, 6); Console.Write("SISTEMA DE GESTIÓN BANCARIA");
            Console.SetCursorPosition(7, 7); Console.Write("1. Registrar Cliente");
            Console.SetCursorPosition(7, 8); Console.Write("2. Realizar Consignación");
            Console.SetCursorPosition(7, 9); Console.Write("3. Realizar Retiro");
            Console.SetCursorPosition(7, 10); Console.Write("4. Consultar Saldo");
            Console.SetCursorPosition(7, 11); Console.Write("5. Salir");
        }

        private void RegistrarCliente()
        {
            Console.Clear();
            Console.SetCursorPosition(8, 6); Console.Write("REGISTRAR NUEVO CLIENTE");

            Console.SetCursorPosition(7, 7); Console.Write("Nombre: ");
            string nombre = Console.ReadLine();

            Console.SetCursorPosition(7, 8); Console.Write("Número de Cuenta: ");
            int cuenta = int.Parse(Console.ReadLine());

            Console.SetCursorPosition(7, 9); Console.Write("Saldo Inicial: ");
            float saldo = float.Parse(Console.ReadLine());

            nombres[totalClientes] = nombre;
            cuentas[totalClientes] = cuenta;
            saldos[totalClientes] = saldo;
            totalClientes++;

            Console.SetCursorPosition(7, 11); Console.Write("Cliente registrado correctamente.");
        }

        private void Consignar()
        {
            Console.Clear();
            Console.SetCursorPosition(8, 6); Console.Write("REALIZAR CONSIGNACIÓN");

            Console.SetCursorPosition(7, 7); Console.Write("Número de Cuenta: ");
            int cuenta = int.Parse(Console.ReadLine());

            int indice = BuscarCuenta(cuenta);
            if (indice == -1)
            {
                Console.SetCursorPosition(7, 9); Console.Write("Cuenta no encontrada.");
            }
            else
            {
                Console.SetCursorPosition(7, 9); Console.Write("Monto a Consignar: ");
                float monto = float.Parse(Console.ReadLine());

                saldos[indice] += monto;

                Console.SetCursorPosition(7, 11); Console.Write("Consignación exitosa.");
            }
        }

        private void Retirar()
        {
            Console.Clear();
            Console.SetCursorPosition(8, 6); Console.Write("REALIZAR RETIRO");

            Console.SetCursorPosition(7, 7); Console.Write("Número de Cuenta: ");
            int cuenta = int.Parse(Console.ReadLine());

            int indice = BuscarCuenta(cuenta);
            if (indice == -1)
            {
                Console.SetCursorPosition(7, 9); Console.Write("Cuenta no encontrada.");
            }
            else
            {
                Console.SetCursorPosition(7, 9); Console.Write("Monto a Retirar: ");
                float monto = float.Parse(Console.ReadLine());

                if (monto > saldos[indice])
                {
                    Console.SetCursorPosition(7, 11); Console.Write("Fondos insuficientes.");
                }
                else
                {
                    saldos[indice] -= monto;
                    Console.SetCursorPosition(7, 11); Console.Write("Retiro exitoso.");
                }
            }
        }

        private void ConsultarSaldo()
        {
            Console.Clear();
            Console.SetCursorPosition(8, 6); Console.Write("CONSULTAR SALDO");

            Console.SetCursorPosition(7, 7); Console.Write("Número de Cuenta: ");
            int cuenta = int.Parse(Console.ReadLine());

            int indice = BuscarCuenta(cuenta);
            if (indice == -1)
            {
                Console.SetCursorPosition(7, 9); Console.Write("Cuenta no encontrada.");
            }
            else
            {
                Console.SetCursorPosition(7, 9); Console.Write($"Saldo actual: {saldos[indice]}");
            }
        }

        private int BuscarCuenta(int cuenta)
        {
            for (int i = 0; i < totalClientes; i++)
            {
                if (cuentas[i] == cuenta)
                    return i;
            }
            return -1;
        }
    }
}
