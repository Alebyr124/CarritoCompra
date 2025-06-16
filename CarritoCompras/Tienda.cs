using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using CarritoCompras;

namespace CarritoCompras
{
    public class Tienda
    {
        public List<Producto> Productos { get; set; } = new List<Producto>();
        public List<Categoria> Categorias { get; set; } = new List<Categoria>();

        public Tienda()
        {
            // Base de datos de ejemplo
            Categorias.Add(new Categoria { Nombre = "Electrónica", Descripcion = "Dispositivos electrónicos y gadgets." });
            Categorias.Add(new Categoria { Nombre = "Ropa", Descripcion = "Vestimenta y accesorios de moda." });
            Categorias.Add(new Categoria { Nombre = "Hogar", Descripcion = "Artículos para el hogar y decoración." });
            
            Productos.Add(new Producto { Codigo = 1, Nombre = "Smartphone", Precio = 299.99, Stock = 50, Categoria = Categorias[0] });
            Productos.Add(new Producto { Codigo = 2, Nombre = "Laptop", Precio = 799.99, Stock = 30, Categoria = Categorias[0] });
            Productos.Add(new Producto { Codigo = 3, Nombre = "Camisa", Precio = 29.99, Stock = 100, Categoria = Categorias[1] });
            Productos.Add(new Producto { Codigo = 4, Nombre = "Sofá", Precio = 499.99, Stock = 20, Categoria = Categorias[2] });
        }

        public void CategoriasDisponibles(Tienda tienda)
        {
            int codigoCategoria = 1;
            Console.WriteLine("Categorías disponibles:");
            foreach (var categoria in tienda.Categorias)
            {
                Console.WriteLine($"\n {codigoCategoria} - {categoria.Nombre}: {categoria.Descripcion}");
                codigoCategoria++;
            }
        }
        public void ProductosDisponibles(Tienda tienda)
        {

            Console.WriteLine("Productos disponibles:");
            foreach (var producto in tienda.Productos)
            {
                Console.WriteLine($"\n * {producto.Nombre} - Precio: ${producto.Precio} - Stock: {producto.Stock} - Codigo: {producto.Codigo}");
            }
        }

        public void ProductosPorCategoria(Tienda tienda)
        {
            CategoriasDisponibles(tienda);
            Console.Write("\nIngrese el numero de la categoría para filtrar los productos: ");
            int idCategoria = int.Parse(Console.ReadLine());

            if (tienda.Categorias[idCategoria-1] != null)
            {
                Console.WriteLine($"\nProductos en la categoría {tienda.Categorias[idCategoria - 1].Nombre}:");
                foreach (var producto in Productos.Where(p => p.Categoria.Nombre == tienda.Categorias[idCategoria - 1].Nombre))
                {
                    Console.WriteLine($"\n * {producto.Nombre} - Precio: ${producto.Precio} - Stock: {producto.Stock} - Codigo: {producto.Codigo}");
                }
            }
            else
            {
                Console.WriteLine($"No se encontró la categoría");
            }
        }
    }
}
