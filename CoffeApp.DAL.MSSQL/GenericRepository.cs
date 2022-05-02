using CoffeApp.COMMON.Entidades;
using CoffeApp.COMMON.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeApp.DAL.MSSQL
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseDTO
    {
        public string Error => throw new NotImplementedException();

        public IEnumerable<T> Read => throw new NotImplementedException();

        public T Create(T entidad)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Query(string querySql)
        {
            throw new NotImplementedException();
        }

        public T Update(T entidad)
        {
            throw new NotImplementedException();
        }
    }
}
