using CoffeApp.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeApp.COMMON.Modelos
{
    public class TokenModel
    {
        public string Token { get; set; }
        public Usuario Usuario { get; set; }
    }
}
