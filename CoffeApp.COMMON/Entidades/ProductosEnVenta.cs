using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeApp.COMMON.Entidades
{
    public  class ProductosEnVenta : BaseDTO
    {
        public string idVenta { get; set; }

        public string idProducto { get; set; }

        public string idMenu { get; set; }

        public string idPaquete { get; set; }

        public int  Cantidad { get; set; }

        public double Costo { get; set; }

        public bool Preparando { get; set; }

        public bool Preparado { get; set; }

        public bool Entregado { get; set; }
    }
}
