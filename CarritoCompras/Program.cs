using System;
using System.Security.Cryptography.X509Certificates;

namespace CarritoCompras
{
    class Program
    {
        static void MostrarArteAscii()
        {
            string arte = @"
                 ██████  █████  ██████  ██████  ██ ████████  ██████      ██████  ███████      ██████  ██████  ███    ███ ██████  ██████   █████  ███████                     
                ██      ██   ██ ██   ██ ██   ██ ██    ██    ██    ██     ██   ██ ██          ██      ██    ██ ████  ████ ██   ██ ██   ██ ██   ██ ██             
                ██      ███████ ██████  ██████  ██    ██    ██    ██     ██   ██ █████       ██      ██    ██ ██ ████ ██ ██████  ██████  ███████ ███████        
                ██      ██   ██ ██   ██ ██   ██ ██    ██    ██    ██     ██   ██ ██          ██      ██    ██ ██  ██  ██ ██      ██   ██ ██   ██      ██        
                 ██████ ██   ██ ██   ██ ██   ██ ██    ██     ██████      ██████  ███████      ██████  ██████  ██      ██ ██      ██   ██ ██   ██ ███████       
                                                                                                                                       
            ";
            Console.WriteLine(arte);
        }

        static void Main(string[] args)
        {
            Tienda tienda = new Tienda();

            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                MostrarArteAscii();
                Console.WriteLine("1. Categorías disponibles");
                Console.WriteLine("2. Productos disponibles");
                Console.WriteLine("3. Productos filtrados por categoría");
                Console.WriteLine("4. Agregar un producto al carrito");
                Console.WriteLine("5. Eliminar un producto del carrito");
                Console.WriteLine("6. Contenido del carrito");
                Console.WriteLine("7. Ver total a pagar");
                Console.WriteLine("8. Finalizar compra");
                Console.WriteLine("9. Salir");
                Console.Write("\n\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        tienda.CategoriasDisponibles();
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        tienda.ProductosDisponibles();
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        tienda.ProductosPorCategoria();
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        tienda.CategoriasDisponibles();
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        tienda.CategoriasDisponibles();
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        tienda.CategoriasDisponibles();
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.Clear();
                        tienda.CategoriasDisponibles();
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.Clear();
                        tienda.CategoriasDisponibles();
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "9":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        Console.WriteLine("\n\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}