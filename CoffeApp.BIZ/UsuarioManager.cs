using CoffeApp.COMMON.Entidades;
using CoffeApp.COMMON.Interfaces;
using CoffeApp.COMMON.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeApp.BIZ
{
    public class UsuarioManager : GenericManager<Usuario>, IUsuarioManager
    {
        public UsuarioManager(IGenericRepository<Usuario> repository ): base(repository)
        {

        }

        public IEnumerable<Usuario> ListarUsuariosPorTipo(string idTipoUsuario)
        {
            try
            {
                var tu = repository.Query($"Select * from TipoUsuario where id='{idTipoUsuario}';");
                Error = tu != null ? "" : repository.Error;
                return tu;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public Usuario Login(string nombreDeUsuario, string password)
        {
            try
            {
                Usuario u = repository
                 .Query($"Select * from Usuario where NombreUsuario = " +
                 $"'{nombreDeUsuario}' and Password = '{password}';").SingleOrDefault();
                Error = u != null ? "" : repository.Error;
                return u;
            }
            catch (Exception ex)
            {

                Error = ex.Message;
                return null;
            }
        }

        public Usuario Login(LoginModel model)
        {
            try
            {
                Usuario u = repository
                 .Query($"Select * from Usuario where NombreUsuario = " +
                 $"'{model.NombreUsuario}' and Password = '{model.Password}';").SingleOrDefault();
                Error = u != null ? "" : repository.Error;
                return u;
            }
            catch (Exception ex)
            {

                Error = ex.Message;
                return null;
            }
        }
    }
}
