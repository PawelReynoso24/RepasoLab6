using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoLab6
{
    internal class Pago
    {
        public string Nombre { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public int Modelo { get; set; }
        public string Color { get; set; }
        public decimal Precio { get; set; }
        public DateTime Devolución { get; set; }
        public decimal Total_Pagar { get; set; }
    }
}
