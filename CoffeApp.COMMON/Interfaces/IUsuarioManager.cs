using CoffeApp.COMMON.Entidades;
using CoffeApp.COMMON.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeApp.COMMON.Interfaces
{
   public interface IUsuarioManager : IGenericManager<Usuario>
    {
        Usuario Login(string nombreDeUsuario, string password);

        IEnumerable<Usuario> ListarUsuariosPorTipo(string idTipoUsuario);
        Usuario Login(LoginModel model);
    }
}
