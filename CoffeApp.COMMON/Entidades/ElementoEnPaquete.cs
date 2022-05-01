using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeApp.COMMON.Entidades
{
   public class ElementoEnPaquete : BaseDTO
    {
        public string idPaquete { get; set; }

        public string Foto { get; set; }

        public int Cantidad { get; set; }

        public string idProducto { get; set; }

        public string idMenuComidaCorrida { get; set; }

        public string Descripcion { get; set; }
    }
}
