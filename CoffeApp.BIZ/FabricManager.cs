using CoffeApp.COMMON.Interfaces;
using CoffeApp.DAL.MSSQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeApp.BIZ
{
   public static class FabricManager
    {
        public static IUsuarioManager
               usuarioManager() => new UsuarioManager(FabricRepository.Usuario());
    }
}
