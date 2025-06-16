using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    public class Carrito
    {
        public List<ItemCarrito> Items { get; set; } = new List<ItemCarrito>();


        public void AgregarProducto(Tienda tienda, Carrito carrito)
        {
            Console.Write("Ingrese el código del producto que desea agregar al carrito: ");
            int codigoProducto = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese la cantidad que desea agregar: ");
            int cantidad = int.Parse(Console.ReadLine());

            foreach (ItemCarrito itemCarrito in carrito.Items)
            {
                if (itemCarrito.Producto.Codigo == codigoProducto)
                {
                    if (itemCarrito.Producto.Stock >= itemCarrito.Cantidad+cantidad)
                    {
                        itemCarrito.Cantidad += cantidad;
                        Console.WriteLine($"\nProducto ha sido correctamente agregado al carrito.");
                    }
                    else
                    {
                        Console.WriteLine($"\nNo hay suficiente stock para el producto.");
                    }
                    return;
                }
            }

            foreach (Producto producto in tienda.Productos)
            {
                if (producto.Codigo == codigoProducto)
                {
                    if (producto.Stock >= cantidad)
                    {
                        carrito.Items.Add(new ItemCarrito { Producto = producto, Cantidad = cantidad });
                        Console.WriteLine($"\nProducto ha sido correctamente agregado al carrito.");
                    }
                    else
                    {
                        Console.WriteLine($"\nNo hay suficiente stock para el producto.");
                    }
                    return;
                }
            }
            Console.WriteLine($"\nNo se encontró el producto con el código {codigoProducto}.");
        }
        public void EliminarProducto(Carrito carrito)
        {
            Console.Write("Ingrese el código del producto que desea eliminar del carrito: ");
            int codigoProducto = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese la cantidad que desea eliminar: ");
            int cantidad = int.Parse(Console.ReadLine());

            if (cantidad <= 0)
            {
                Console.WriteLine("\nLa cantidad a eliminar debe ser mayor que cero.");
                return;
            }

            var item = carrito.Items.FirstOrDefault(i => i.Producto.Codigo == codigoProducto);
            if (item != null)
            {
                if (item.Cantidad >= cantidad)
                {
                    item.Cantidad -= cantidad;
                    if (item.Cantidad == 0)
                    {
                        carrito.Items.Remove(item);
                    }
                    Console.WriteLine($"\nProducto ha sido correctamente eliminado del carrito.");
                }
                else
                {
                    Console.WriteLine("\nNo se puede eliminar más cantidad de la que hay en el carrito.");
                }
                return;
            }
            Console.WriteLine($"\nNo se encontró el producto con el código {codigoProducto}.");
        }

        public void MostrarCarrito(Carrito carrito)
        {
            if (carrito.Items.Count == 0)
            {
                Console.WriteLine("El carrito está vacío.");
                return;
            }
            Console.WriteLine("Contenido del carrito:\n");
            foreach (ItemCarrito item in carrito.Items)
            {
                Console.WriteLine($"\n* {item.Producto.Nombre}, Cantidad: {item.Cantidad}, Precio unitario: ${item.Producto.Precio}");
            }

        }
        public void CalcularTotal(Carrito carrito)
        {
            double total = 0;
            double subtotal;

            if (carrito.Items.Count == 0)
            {
                Console.WriteLine("El carrito está vacío.");
                return;
            }

            Console.WriteLine("Total a pagar por los productos del carrito:\n");
            foreach (ItemCarrito item in carrito.Items)
            {
                subtotal = item.Producto.Precio * item.Cantidad;
                if (item.Cantidad >= 5)
                {
                    subtotal -= subtotal * 0.15;
                }
                subtotal += subtotal * 0.21;
                Console.WriteLine($"\n* {item.Producto.Nombre}, Cantidad: {item.Cantidad}, Precio unitario: ${item.Producto.Precio}, SUBTOTAL ------ ${subtotal:F2}");
                total += subtotal;
            }

            Console.WriteLine($"\n\nEl total del carrito es: ${total:F2}");
        }
    }
}