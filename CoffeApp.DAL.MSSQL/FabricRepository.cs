using CoffeApp.COMMON.Entidades;
using CoffeApp.COMMON.Interfaces;
using CoffeApp.COMMON.Validadores;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeApp.DAL.MSSQL
{
   public static class FabricRepository
    {
        public static IGenericRepository<CategoriaProducto>
           CategoriaProducto()
        {
            return new GenericRepository<CategoriaProducto>(new CategoriaProductoValidator());

        }
    }
}
