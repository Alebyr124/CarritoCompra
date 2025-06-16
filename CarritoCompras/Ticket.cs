using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarritoCompras
{
    public class Ticket
    {
        public string Id { get; set; }
        public DateTime Fecha { get; set; }
        public List<ItemCarrito> Items { get; set; } = new List<ItemCarrito>();
        public double Total { get; set; }
    }
}
