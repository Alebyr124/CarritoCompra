using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarritoCompras;

namespace CarritoCompras
{
    public class Tienda
    {
        public List<Producto> Productos { get; set; } = new List<Producto>();
        public List<Categoria> Categorias { get; set; } = new List<Categoria>();

        public Tienda{
            Categorias.Add(new Categoria { Nombre = "Electrónica", Descripcion = "Dispositivos electrónicos y gadgets" });
            Categorias.Add(new Categoria { Nombre = "Ropa", Descripcion = "Vestimenta y accesorios" });
            Categorias.Add(new Categoria { Nombre = "Hogar", Descripcion = "Artículos para el hogar y decoración" });
            Categorias.Add(new Categoria { Nombre = "Juguetes", Descripcion = "Juguetes y juegos para niños" });
            Categorias.Add(new Categoria { Nombre = "Libros", Descripcion = "Literatura y libros de texto" });

            Productos.Add(new Producto { Codigo = 1, Nombre = "Celular", Precio = 299.99, Stock = 50, Categoria = Categorias[0] });
            Productos.Add(new Producto { Codigo = 2, Nombre = "Notebook", Precio = 799.99, Stock = 30, Categoria = Categorias[0] });
            Productos.Add(new Producto { Codigo = 3, Nombre = "Camisa", Precio = 29.99, Stock = 100, Categoria = Categorias[1] });
            Productos.Add(new Producto { Codigo = 4, Nombre = "Pantalones", Precio = 49.99, Stock = 80, Categoria = Categorias[1] });
            Productos.Add(new Producto { Codigo = 5, Nombre = "Sofá", Precio = 499.99, Stock = 20, Categoria = Categorias[2] });
            Productos.Add(new Producto { Codigo = 6, Nombre = "Lámpara", Precio = 39.99, Stock = 60, Categoria = Categorias[2] });
            Productos.Add(new Producto { Codigo = 7, Nombre = "Auto de juguete", Precio = 19.99, Stock = 150, Categoria = Categorias[3] });
            Productos.Add(new Producto { Codigo = 8, Nombre = "Juego de mesa", Precio = 34.99, Stock = 70, Categoria = Categorias[3] });
            Productos.Add(new Producto { Codigo = 9, Nombre = "Comic", Precio = 14.99, Stock = 200, Categoria = Categorias[4] });
            Productos.Add(new Producto { Codigo = 10, Nombre = "Manual de matematicas", Precio = 59.99, Stock = 120, Categoria = Categorias[4] });
        }

        public void CategoriasDisponibles()
        {
            Console.WriteLine("Categorías disponibles:");
            foreach (var categoria in Categorias)
            {
                Console.WriteLine($"- {categoria.Nombre}: {categoria.Descripcion}");
            }
        }
    }
}
