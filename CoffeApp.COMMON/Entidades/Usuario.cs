using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeApp.COMMON.Entidades
{
   public class Usuario : BaseDTO
    {
        public string NombreUsuario { get; set; }

        public string Password { get; set; }

        public string Nombre { get; set; }

        public string Apelliido { get; set; }

        public string Foto { get; set; }

        public string Correo { get; set; }

        public string Telefono { get; set; }

        public string idTipoUsuario { get; set; }

        public decimal Credito { get; set; }

        public string Nota { get; set; }
    }
}
