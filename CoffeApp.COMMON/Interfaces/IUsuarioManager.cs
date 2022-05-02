using CoffeApp.COMMON.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeApp.COMMON.Interfaces
{
   public interface IUsuarioManager : IGenericManager<Usuario>
    {
        Usuario Login(string nombreDeUsuario, string password);
    }
}
